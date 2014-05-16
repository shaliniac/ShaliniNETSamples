using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsClassLibrary
{
    public class FizzBuzzMethods
    {
        //Fizz method returns true if the number is divisible by 3
        public bool Fizz(int number)
        {
            if ((number % 3) == 0)
            {
                return true;
            }
            else
                return false;
        }

        //Buzz method returns true if the number is divisible by 5
        public bool Buzz(int number)
        {
            if ((number % 5) == 0)
            {
                return true;
            }
            else
                return false;
        }

        // Method to get the number from the user
        public int getnumber()
        {
            Console.WriteLine("\nEnter a number\n");
            return (int.Parse(Console.ReadLine()));
        }
    }
}
