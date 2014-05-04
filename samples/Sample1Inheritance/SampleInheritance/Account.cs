using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleInheritance
{
    public abstract class Account
    {
        private string name;        // Only accessible in base class
        protected double balance;   // Accessible in base class and derived class

            
        public Account(string nm, double bal)
        {
            this.name = nm;
            this.balance = bal;

           
        }
        public virtual void Credit(double amount)
        {
            this.balance += amount;
        }

        public virtual void Debit(double amount)
        {
            this.balance -= amount;
        }

        public virtual void Display()
        {
            Console.WriteLine("Name={0}, balance={1}", this.name, this.balance);

        }
        public void ChangeName(string newName)
        {
            this.name = newName;

        }
        public abstract double CalculateBankCharge();


    }


}
