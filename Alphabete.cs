using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Alphabete
    {
        public void Vowel()
        {

            Console.WriteLine("Enter a Alphabte");
            char ch = Convert.ToChar(Console.ReadLine());

          
            if ((ch == 'a') || (ch == 'e') || (ch == 'i') || (ch == 'o') || (ch == 'u'))
            {
                Console.WriteLine("vowel");
            }
            else if (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine("consonent");
            }
            else
            {
                Console.WriteLine("not alphabete");
            }
        }
    }
}
