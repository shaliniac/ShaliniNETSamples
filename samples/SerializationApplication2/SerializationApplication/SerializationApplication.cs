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
            Console.WriteLine("Writing Students Information");
            st.GetObjectData();
            Console.WriteLine("Reading and displaying Students Information");
            st.DisplayObjectData();                    

            //Clear st for further usage.
            st = null;

            
        }
    }
}

