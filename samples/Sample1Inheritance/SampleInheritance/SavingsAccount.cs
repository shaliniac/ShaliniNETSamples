using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleInheritance
{
    class SavingsAccount : Account
    {
        private double minBalance;   // If the balance drops below minBalance, 
        // the bank will charge a fee on the account

        public SavingsAccount(string nm, double bal, double min)
            : base(nm, bal)           // Call base-class constructor first
        {
            minBalance = min;         // Then initialize fields in this class



        }

        public override void Debit(double amount)
        {
            if (amount <= balance)    // Use balance, inherited from base class
                base.Debit(amount);    // Call Debit, inherited from base class 
        }
        public override void Display()
        {
            base.Display();          // Call Display, inherited from base class
            Console.WriteLine("$5 charge if balance goes below ${0}", minBalance);

         

        }

        public override double CalculateBankCharge()
        {
            if (balance < minBalance)
                return 5.00;
            else
                return 0.00;

        }

    }
    

}
