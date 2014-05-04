
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

}