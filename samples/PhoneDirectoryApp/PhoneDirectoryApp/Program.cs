using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PhoneDirectoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string number;
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            // My Entity Container is called PhoneDirectoryEntities and FindPhoneNumber is the class which has the method LoookupNumber

            FindPhoneNumber find = new FindPhoneNumber(new PhoneDirectoryEntities());

            // The LookupNumber function returns the number for the given name 
            number = find.LookupNumber(name);
            Console.WriteLine("The Phone number of "+ name + " is " + number);
        }

    }
}
