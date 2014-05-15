using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestSample
{
    class Program
{
    static void Main(string[] args)
    {

        try
        {
            // Get two numbers 
            Console.WriteLine("Enter two numbers \n");
            Console.WriteLine("First number --> Press Enter --> Second number --> Press Enter\n");
            int number1;
            int number2;
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            number2 = int.Parse(Console.ReadLine());

            // Create an onject for the class MathsHelper
            MathsHelper helper = new MathsHelper();

            // Call the Add method
            int x = helper.Add(number1, number2);
            Console.WriteLine("\nThe sum of " + number1 +
                " and " + number2 + " is " + x);
            Console.ReadKey();
            // Call the Subtract function
            int y = helper.Subtract(number1, number2);
            Console.WriteLine("\nThe difference between " +
                  number1 + " and " + number2 + "  is " + y);
            ConsoleKeyInfo info = Console.ReadKey();
            if (info.Key == ConsoleKey.Enter)
                goto Finish;
               
            // Throw any Exception
            throw new System.Exception();

            Finish:
            Console.WriteLine("\nThank you\n");
        }
            // Catch the exception
        catch
        {
            Console.WriteLine("Please Enter a valid number following the instruction\n");
        }
               
    }
}
    
    // Class which contains a method to add and subtract
public class MathsHelper
{
        public MathsHelper() { }
    // Add method
    public int Add(int a, int b)
    {
        int x = a + b;
        return x;
    }
    // Subtract method 
    public int Subtract(int a, int b)
    {
        int x = a - b;
        return x;
    }
}


}
