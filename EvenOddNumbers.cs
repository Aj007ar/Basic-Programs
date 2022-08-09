using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class EvenOddNumbers
    {
        public void EvenOdd()
        {
            Console.WriteLine("Enter any Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine(num + " is Even number");
            }
            else
            {
                Console.WriteLine(num+" is odd number");
            }
        }
    }
}
