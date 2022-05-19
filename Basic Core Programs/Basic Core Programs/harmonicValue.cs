using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    public class harmonicValue
    {
        public void checkHarmonicValue()
        {
            int initial = 1;
            Decimal harmonicValue = 0, temp;
            Console.WriteLine("Enter value to find Harmonic Value");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                temp = Decimal.Divide(initial, i);
                harmonicValue = temp + harmonicValue;
                Console.WriteLine(temp);
            }
            Console.WriteLine("Harmonic value for " + input + " is " + Math.Round(harmonicValue, 4));
        }
    }
}
