using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class QuotientReminder
    {
        public void QuotReminder()
        {
            int quotient = 0;
            int reminder = 0;
            Console.WriteLine("Enter number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Diviser");
            int b = Convert.ToInt32(Console.ReadLine());

            quotient = a / b;
            reminder = a % b;

            Console.WriteLine("Quotient= "+a+" / "+b+" = "+quotient);
            Console.WriteLine("Reminder= "+a + " % " + b + " = " + reminder);

        }
    }
}
