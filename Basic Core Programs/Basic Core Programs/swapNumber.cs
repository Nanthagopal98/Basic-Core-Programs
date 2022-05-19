using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    public class swapNumber
    {
        public void doSwap()
        {
            int x, y, temp;
            Console.WriteLine("Enter Value x");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value y");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swap x = " + x + ", y = " + y);
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("After swap x = " + x + ", y = " + y);
        }
    }
}
