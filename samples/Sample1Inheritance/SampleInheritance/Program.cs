using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount sa = new SavingsAccount("Freda Smith", 100.00, 25);
            sa.Display();
            sa.Credit(100);
            sa.Debit(180);
            sa.ChangeName("Freda Jones");
            sa.Display();
            Console.WriteLine("Bank charge: ${0}", sa.CalculateBankCharge());

        }
    }
}
