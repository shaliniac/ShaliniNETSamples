
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


[Serializable()]
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
}


class Program
{
    
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("s=serialize, r=read:");
            switch (Console.ReadLine())
            {
                case "s":
                    var student1 = new List<Student>();
                    student1.Add(new Student(1,"Shalini", 6));
                    student1.Add(new Student(2, "Rex", 5));
                    

                    try
                    {
                        using (Stream stream = File.Open("data.bin", FileMode.Create))
                        {
                            BinaryFormatter bin = new BinaryFormatter();
                            bin.Serialize(stream, student1);
                        }
                    }
                    catch (IOException)
                    {
                    }
                    break;

                case "r":
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
                    break;
            }
        }
    }
}
