using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseTestConsole;

namespace DatabaseTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRights rights = new UserRights(new accountdbEntities());
            string test = rights.LookupPassword("test");
            Console.WriteLine(test);

        }
    }
}
