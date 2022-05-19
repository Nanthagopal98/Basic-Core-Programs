using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    public class primeFactors
    {
        public void findPrimeFactors()
        {
            List<int> factors = new List<int>();
            int j = 0;
            Console.WriteLine("Enter value to find Prime Factor");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Primr factors for " + input);
            for (int i = 2; i <= input;)
            {
                var check = (input % i);
                if (check == 0)
                {
                    input = input / i;
                    factors.Add(i);
                    j++;
                }
                else
                {
                    i++;
                }
            }
            for (int n = 0; n < j; n++)
            {
                Console.WriteLine(factors[n]);
            }
        }
    }
}
