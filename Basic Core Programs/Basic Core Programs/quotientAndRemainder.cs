using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    public class quotientAndRemainder
    {
        public void findQuotientAndRemainder()
        {
            Console.WriteLine("Enter Divident value");
            int divident = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor value");
            int divisor = Convert.ToInt32(Console.ReadLine());
            double quotient = divident / divisor;
            double remainder = divident % divisor;
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
        }
    }
}
