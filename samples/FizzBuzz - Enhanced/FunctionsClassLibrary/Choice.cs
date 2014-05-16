using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsClassLibrary
{
    public class Choice
    {
        public Choice()
        {
            // This is the no parameter constructor method.
            // First Constructor
        }


        public void menu()
        {
            int number;
            int i = 0;
            bool fizzflag;
            bool buzzflag;

            do
            {
                //Display Menu
                Console.WriteLine("1.Print 1 to 100");
                Console.WriteLine("2.Find if a number is divisible by 3 or 5 or (3 and 5)");
                Console.WriteLine("3.Exit\n");
                Console.WriteLine("Please enter your choice\n");

                try
                {
                    i = int.Parse(Console.ReadLine());

                    switch (i)
                    {
                        case 1:
                            //Print 1 to 100
                            for (int j = 1; j <= 100; j++)
                                Console.Write(j+" ");
                            Console.WriteLine(" ");
                            break;

                        case 2:
                            // Print Fizz if the nuber divisble by 3 | Buzz if the nuber divisble by 3 |FizzBuzz if the nuber divisble by 3 and 5 

                            //create an instance of FizzBuzzMethodsClass
                            FizzBuzzMethods findFizzBuzz = new FizzBuzzMethods();
                            number = findFizzBuzz.getnumber();

                            //fizzflag is true if a number is divisible by 3
                            fizzflag = findFizzBuzz.Fizz(number);
                            //buzzflag is true if a number is divisible by 3
                            buzzflag = findFizzBuzz.Buzz(number);

                            if (fizzflag == true)
                                Console.Write("\nFizz");

                            if (buzzflag == true)
                                Console.WriteLine("Buzz");

                            // If both fizzflag and buzzflag are false the number is not divisible by 3 or 5
                            if ((fizzflag == false) & (buzzflag ==false))
                                Console.WriteLine("\nThe number is not divisible by 3 or 5\n");
                            break;

                        case 3:
                            return;                        

                        default:
                            System.Console.WriteLine(" Not a valid choice\n");
                            break;

                    }

               }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }

                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }


                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                    
                catch (InvalidCastException e)
                {
                    Console.WriteLine(e.Message);
                }


                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                }

                
                catch (NullReferenceException e)
                {
                    Console.WriteLine(e.Message);
                }

                catch (TypeInitializationException e)
                {
                    Console.WriteLine(e.Message);
                }


                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                finally
                {
                    Console.WriteLine("\nI am FizzBuzz Program\n");
                }

            } while ((i !=3));
        }
                
    }

}
    