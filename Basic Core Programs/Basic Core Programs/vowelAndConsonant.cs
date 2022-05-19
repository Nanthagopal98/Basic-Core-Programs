using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    public class vowelAndConsonant
    {
        public void findVowelAndConsonant()
        {
            char[] charvalue = new char[] { 'a', 'e', 'i', 'o', 'u' };
            Console.WriteLine("Enter Alphabet");
            char userInput = Convert.ToChar(Console.ReadLine().ToLower());
            for (int i = 0; i < charvalue.Length; i++)
            {
                if (charvalue[i] == userInput)
                {
                    Console.WriteLine(userInput + " is Vowel");
                    break;
                }
                else if (i == charvalue.Length - 1)
                {
                    Console.WriteLine(userInput + " is Consonant");
                }
                else
                {
                    i++;
                }

            }
        }
    }
}
