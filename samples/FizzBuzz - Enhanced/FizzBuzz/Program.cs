using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionsClassLibrary;


namespace FizzBuzz
{
    class Program
    {

        static void Main(string[] args)
        {
            //create an instance of Class Choice in the Class Library
           Choice call = new Choice();

            //call the menu which diaplays the list of operations that can be performed
           call.menu();

         }

    }
}
