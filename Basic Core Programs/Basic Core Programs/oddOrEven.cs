using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    public class oddOrEven
    {
        public void oddOrEvenNumber()
        {
            Console.WriteLine("Enter Number");
            int check = Convert.ToInt32(Console.ReadLine());
            if (check % 2 == 0)
            {
                Console.WriteLine(check + "is an even number");
            }
            else
            {
                Console.WriteLine(check + "is an odd number");
            }
        }
    }
}
