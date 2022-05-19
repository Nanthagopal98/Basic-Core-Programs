using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    public class leapYear
    {
        public void checkLeapYear()
        {
            Console.WriteLine("Enter Year");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year > 999)
            {
                if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                {
                    Console.WriteLine(year + " is Leap Year");
                }
                else
                {
                    Console.WriteLine(year + " is not a leap year");
                }
            }
            else
            {
                Console.WriteLine("Enter Valid Year");
            }
        }
    }
}
