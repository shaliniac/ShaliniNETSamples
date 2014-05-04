using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample3
{


    class Program
    {
        static void Main()
        {
            //
            // Use this input string[] array.
            // ... Convert it to a List with the ToList extension.
            //
            string[] array = new string[]
	        {
	            "James", "Sam", "Anu" 
	        };

            // Use query expression on array.
            //
            var query = from element in array
                        orderby element
                        select element;

            Console.WriteLine(array.Count());

            string[] array2 = query.ToArray();
            //
            // Display array.
            //
            foreach (string value in array2)
            {
                Console.WriteLine(value);
            }

        }
    }

}

