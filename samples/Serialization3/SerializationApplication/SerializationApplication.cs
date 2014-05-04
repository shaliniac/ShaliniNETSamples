using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyObjSerial;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace SerializationApplication
{
     public class ObjSerial
    {
        static void Main(string[] args)
        {
//Create two Student object

            Student st = new Student();
            st.StudentId = 1;
            st.StudentName = "Shalini";
            st.StudentGPA = 6;           
         

            // Open a file and serialize the object into it in binary format.
            // StudentInfo.osl is the file that we create. 
            // Note:- you can give any extension you want for your file which is associated with your program
            Stream stream = File.Open("StudentInfo.osl", FileMode.Create);
            BinaryFormatter bformatter = new BinaryFormatter();

            Console.WriteLine("Writing Student Information");
            bformatter.Serialize(stream, st);
                       stream.Close();

            //Clear mp for further usage.
            st = null;

            //Open the file written above and read values from it.
            stream = File.Open("StudentInfo.osl", FileMode.Open);
            bformatter = new BinaryFormatter();

            Console.WriteLine("Reading Student Information");
                st = (Student)bformatter.Deserialize(stream);
          
                Console.WriteLine("Student Id: {0}", st.StudentId.ToString());
                Console.WriteLine("Student Name: {0}", st.StudentName);
                Console.WriteLine("Student GPA: {0}", st.StudentGPA);            
            

            stream.Close();
        }
    }
}

