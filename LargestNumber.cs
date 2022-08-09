using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class LargestNumber
    {
        public void Largest()
        {
            Console.WriteLine("Enter 1st Number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd Number:");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine(a+" is Largest number");
                }
            }
            if (b > c)
            {
                Console.WriteLine(b+" is Largest number");
            }
            else
            {
                Console.WriteLine(c+" is Largest number");
            }
        }
    }
}
