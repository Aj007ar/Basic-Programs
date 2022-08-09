using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class SwapNumbers
    {
        public void SwapNumber()
        {
            Console.WriteLine("Enter 1st number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swaping numbers are:\nA= "+num1 +"\nB= "+num2);
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine("After Swaping numbers are \nA= "+num1 +"\nB= "+num2);

        }
    }
}
