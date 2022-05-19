using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    public class findLargeNumber
    {
        public void largeNumber()
        {
            List<int> number = new List<int>(0);
            Console.WriteLine("Three numbers are ");
            for (int i = 0; i < 3; i++)
            {
                Random random = new Random();
                number.Add(random.Next(1, 1000));
                Console.WriteLine(number[i]);
            }
                if (number[0] > number[1] && number[0] > number[2])
                {
                    Console.WriteLine(number[0]+" is largest number");
                }
                else if (number[1] > number[0] && number[1] > number[2])
                {
                    Console.WriteLine(number[1] + " is largest number");
                }
                else
                {
                    Console.WriteLine(number[2] + " is largest number");
                }
            

        }
    }
}
