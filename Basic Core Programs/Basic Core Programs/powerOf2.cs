using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    public class powerOf2
    {
        public void findPowerOf2()
        {
            int initialValue = 2;
            Console.WriteLine("Enter values from 1 to 30");
            int power = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= power; i++)
            {
                initialValue = initialValue * 2;
            }
            Console.WriteLine("2 power of " + power + " is " + initialValue);
        }
    }
}
