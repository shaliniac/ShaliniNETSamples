using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IEnuExample1;



class Program
{
    static void Main()
    {
        string[] names = new string[] { "Anu", "James", "Sam" };

        Display(names);


    }

    static void Display(IEnumerable<string> namesArg)
    {
	foreach (string value in namesArg)
	    Console.WriteLine(value);
    }
}

