using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {

        static void Main(string[] args)
        {
            int i=0;
            int number;                   

            do
            {
                    Console.WriteLine("1.Print 1 to 100");
                    Console.WriteLine("2.If divisible by 3 print Fizz");
                    Console.WriteLine("3.If divisible by 5 print Buzz");
                    Console.WriteLine("4.If divisible by 3 and 5 print FizzBuzz");
                    Console.WriteLine("5.Exit");
                    Console.WriteLine("\n");
                    Console.WriteLine(" Please enter your choice\n");
                    try

                    {
                        i = int.Parse(Console.ReadLine());

                        switch (i)
                        {
                            case 1:
                                for (int j = 1; j <= 100; j++)
                                    Console.WriteLine(j);
                                Console.WriteLine("\n");
                                continue;

                            case 2:
                                Console.WriteLine("Enter a number");
                                number = int.Parse(Console.ReadLine());
                                if ((number % 3) == 0)
                                    Console.WriteLine("Fizz");
                                Console.WriteLine("\n");
                                continue;

                            case 3:
                                Console.WriteLine("Enter a number");
                                number = int.Parse(Console.ReadLine());
                                if ((number % 5) == 0)
                                    Console.WriteLine("Buzz");
                                Console.WriteLine("\n");
                                continue;

                            case 4:
                                Console.WriteLine("Enter a number");
                                number = int.Parse(Console.ReadLine());
                                if (((number % 3) & (number % 5)) == 0)
                                    Console.WriteLine("FizzBuzz");
                                Console.WriteLine("\n");
                                continue;
                        }
                        throw new System.Exception();

                    }
                    catch 
                    {
                        Console.WriteLine("Please enter a valid choice");
                    }

            } while(i!= 5);

            }

    }
}
