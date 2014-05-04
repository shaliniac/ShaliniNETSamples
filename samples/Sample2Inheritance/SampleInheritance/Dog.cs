using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleInheritance
{
    class Dog : Animal // Dog is a derived class which Inherits the base class Animal
    {
       

        public Dog( string animalName)            : base(  animalName)           // Call base-class constructor first
        {       
        }
   
        public override void Display()

        {
            base.Display();          // Call Display, inherited from base class
           
        }

        public override void Speak(string action) // Displays what is speak for a dog ?
        {
            if (action =="speak")


                Console.WriteLine("The dog barks - Derived class");
            else
                Console.WriteLine("Sorry data mismatch check if you are passing the right parameter");            
        }

        public override void AnimalEats(string action) // Displays what can a dog eat ?
        {
            if (action == "eat")
                Console.WriteLine("The dog eats cooked /processed/ or raw non-vegetarian items - Derived class");
            else
                Console.WriteLine("Sorry data mismatch check if you are passing the right parameter");

        }

        public override void AnimalLives(string action) // Displays where does a dog live ?
        {
            if (action == "lives")
                Console.WriteLine("The dog lives as a domestic animal - Derived class");
            else
                Console.WriteLine("Sorry data mismatch check if you are passing the right parameter");
        }
              
    }
    

}
