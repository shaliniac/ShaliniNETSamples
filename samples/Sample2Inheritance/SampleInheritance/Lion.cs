using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleInheritance
{
    class Lion : Animal // Lion is the sub class and Animal is the base class
    {
        

        public Lion( string animalName): base(animalName)           // Call base-class constructor first
        {
           
        }


        public override void Display() // This Display method overides the Display method in the Base class
        {
            Console.WriteLine("The animal is Lion - Derived class");
        }

        // If the following method is not commented it will overide the Speak method implemented in the base class

      /*  public override void Speak(string action) 
          {
            if (action == "speak")

                Console.WriteLine("The lions roars - delived class");
            else
                Console.WriteLine("Sorry data mismatch check if you are passing the right parameter");

          }
        */

        public override void AnimalEats(string action) // This method displays what does a lion eat?
        {
            if(action=="eat")

                Console.WriteLine("The lion hunted or supplied meat - Derived class");
            else
                Console.WriteLine("Please check your argument");
        }

        public override void AnimalLives(string action) // This method displays where does the lion lives?
        {
            if (action== "lives" )
                Console.WriteLine("The lion lives in the forest - Derived class");
            else
                Console.WriteLine("Please check your argument");
        }
       
    }


}
