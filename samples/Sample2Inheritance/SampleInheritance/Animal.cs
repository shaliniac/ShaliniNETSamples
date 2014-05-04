using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleInheritance
{
    public abstract class Animal // this is an abstract class 
    {
     
        public string animalName; // Only accessible in base class


        public Animal(string animalNam) // constructor with one string argument
        {
            
            this.animalName = animalNam;
           
        }
        public virtual void Speak(string action) // Speak method is implemented in the abstract class , however since it has virtual key word it can be overidden in the derived class
        {
            if (action=="speak")
             Console.WriteLine("The animal speaks - Base class");
            else
                Console.WriteLine("Check your argument");

        }


        public virtual void Display() // Display method answers the question, which animal? , since it has the virtual key word it can be overidden in the derived class
        {
            Console.WriteLine("Name={0}", this.animalName+"- Base class");            
        }

        public void ChangeName(string newName)//This method changes the animal name or category of animal
        {
            this.animalName = newName;
            Console.WriteLine("Name={0}", this.animalName + "- Base class");     

        }

        public abstract  void AnimalEats(string action); // this is an abstract method with implementation in the derived class
        public abstract void AnimalLives(string action); // this is an abstract method with implementation in the derived class
      
        

    }


}
