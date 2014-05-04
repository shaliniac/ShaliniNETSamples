
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;


namespace MyObjSerial
{
    [Serializable()]	//Set this attribute to all the classes to be serialized
        public class Student
        {
            public int StudentId  { get; set; }   
            public string StudentName { get; set; }      
            public int StudentGPA { get; set; }    

            public Student(int StuID, string StuName, int StuGPA)
            {
                StudentId = StuID;
                StudentName = StuName;
                StudentGPA = StuGPA;
            }

            public Student()
            {
                StudentId = 0;
                StudentName = null;
                StudentGPA = 0;
            }
   

        //Deserialization method.
        public void DisplayObjectData()
        {
            //Get the values from info and assign them to the appropriate properties
            try
            {
                using (Stream stream = File.Open("data.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    var lizards2 = (List<Student>)bin.Deserialize(stream);
                    foreach (Student student in lizards2)
                    {
                        Console.WriteLine("{0}, {1}, {2}",
                            student.StudentId,
                            student.StudentName,
                            student.StudentGPA);
                    }
                }
            }
            catch (IOException)
            {
            }
                        
        }

        //Serialization function.
        public void GetObjectData()
        {

            /*You can use any custom name for your name-value pair. But you need to ensure to read the values with the same name. 
              For ex:- If you write StudentId as "StudentId"then you should read the same with "StudentId"*/
                var Students1 = new List<Student>();
                Students1.Add(new Student(1,"Shalini",6));
                Students1.Add(new Student(2, "Rex", 5));

                try
                {
                    using (Stream stream = File.Open("data.bin", FileMode.Create))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        bin.Serialize(stream, Students1);
                    }
                }
                catch (IOException)
                {
                }                              
        }

    }

}