using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    public class flipCoin
    {
        public void flip()
        {
            int HeadsPossibility = 0;
            int TailsPossibility = 0;
            Console.WriteLine("Enter number of times to flip");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Random random = new Random();
                int value = random.Next(2);
                if (value == 0) // Heads
                {
                    HeadsPossibility++;
                }
                else   // tails
                {
                    TailsPossibility++;
                }
            }
            Console.WriteLine("HeadsPossibility " + HeadsPossibility);
            Console.WriteLine("TailsPossibility " + TailsPossibility);
            int headPercentage = ((HeadsPossibility * 100) / count);
            Console.WriteLine("HeadsPercent = " + headPercentage + "%");
            int tailPercentage = ((TailsPossibility * 100) / count);
            Console.WriteLine("TailsPercent = " + tailPercentage + "%");
        }
    }
}
