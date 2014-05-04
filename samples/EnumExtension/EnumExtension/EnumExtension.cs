using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EnumExtension
{
    // Define an extension method in a non-nested static class. 
    public static class Extensions
    {
        public static Days weakendDay1 = Days.Sun;
        public static Days weakendDay2 = Days.Sat;

        public static bool weakEnd(this Days day)
        {
            if (day == weakendDay1 || day == weakendDay2)
                return true;
            else
                return false;

        }
    }

    public enum Days { Sat = 0, Sun = 1, Mon = 2, Tue = 3, Wed = 4, Thurs = 5, Fri = 6 };
    class EnumExtension
    {
        static void Main(string[] args)
        {
            Days day1 = Days.Mon;
            Days day2 = Days.Sun;

            Console.WriteLine("\r\nFinding if the day is a weak end!\r\n");
            Console.WriteLine("Day1 {0} a weak end.", day1.weakEnd() ? "is" : "is not");
            Console.WriteLine("Day2 {0} a weak end.", day2.weakEnd() ? "is" : "is not");
        }
    }
}


