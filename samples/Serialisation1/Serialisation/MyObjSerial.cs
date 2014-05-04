using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace MyObjSerial
{
    [Serializable()]	//Set this attribute to all the classes to be serialized
    public class Student : ISerializable
    {
        public int StudentId;
        public string StudentName;
        public int StudentGPA;


        //Default constructor
        public Student()
        {
           StudentId = 0;
           StudentName = null;
           StudentGPA = 0;

        }

        //Deserialization constructor.
        public Student(SerializationInfo info, StreamingContext ctxt)
        {
            //Get the values from info and assign them to the appropriate properties
            StudentId = (int)info.GetValue("StudentId", typeof(int));
            StudentName = (String)info.GetValue("StudentName", typeof(string));
            StudentGPA = (int)info.GetValue("StudentGPA", typeof(int));
        }

        //Serialization function.
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {

            /*You can use any custom name for your name-value pair. But you need to ensure to read the values with the same name. 
              For ex:- If you write StudentId as "StudentId"then you should read the same with "StudentId"*/
              info.AddValue("StudentId", StudentId);
              info.AddValue("StudentName", StudentName);
              info.AddValue("StudentGPA", StudentGPA);
        }
    }


    //Main class
    public class ObjSerial


    {
        public static void Main(String[] args)
        {
            //Create a new Employee object

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
            stream.Close();

            Console.WriteLine("Student Id: {0}", st.StudentId.ToString());
            Console.WriteLine("Student Name: {0}", st.StudentName);
            Console.WriteLine("Student GPA: {0}", st.StudentGPA);
        }
    }
}