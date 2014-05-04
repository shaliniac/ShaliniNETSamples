using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleInheritance
{
    class Program
    {
        static void Main()
        {
            Dog sa = new Dog("dog");
            sa.Display();
            sa.AnimalEats("eat");        
            sa.Speak("speak");
            sa.AnimalLives("lives");
            Console.WriteLine("\n");

            Lion l = new Lion("lion");
            l.Display();
            l.AnimalEats("eat");
            l.Speak("speak");
            l.AnimalLives("lives");      
            Console.WriteLine("\n");

            Console.WriteLine("You are calling the ChangeName method from the base class");
            l.ChangeName("dog");
          
        }
    }
}
