namespace BasicPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n**********************WELCOME TO BASIC PROGRAMS*********************");
            Console.WriteLine(" 1.Flip Coin Program.");
            Console.WriteLine(" 2.Leap year Program.");
            Console.WriteLine(" 3.Power of Two Program.");
            Console.WriteLine(" 4.Prime Factors Program.");
            Console.WriteLine(" 5.Swap Numbers Program.");
            Console.WriteLine(" 6.Even Odd Numbers Program.");
            Console.WriteLine(" 7.Quotient and Reminder Program.");
            Console.WriteLine(" 8.Largest Number Program.");
            Console.WriteLine(" 9.Alphabete Program.");
            Console.WriteLine(" 10.Harmonic Program.");

            Console.WriteLine("Enter number which program you want to execute: ");
            int check = Convert.ToInt32(Console.ReadLine());

            switch (check)
            {
                case 1:
                    Console.WriteLine("\n*********************Flip Coin Program****************************");
                    FlipCoins flip = new FlipCoins();
                    flip.HaidTail();
                    break;
                case 2:
                    Console.WriteLine("\n***********************Leap Year Program*****************************");
                    LeapYear leap = new LeapYear();
                    leap.Leap();
                    break;
                case 3:
                    Console.WriteLine("\n***********************Power of Two***********************************");
                    PowerOfTwo pwr = new PowerOfTwo();
                    pwr.PowerTwo();
                    break;
                case 4:
                    Console.WriteLine("\n***********************Prime Factors**********************************");
                    primeFactor prime = new primeFactor();
                    prime.Factor();
                    break;
                case 5:
                    Console.WriteLine("\n***********************Swap Numbers**********************************");
                    SwapNumbers swap = new SwapNumbers();
                    swap.SwapNumber();
                    break;
                case 6:
                    Console.WriteLine("\n***********************Even Odd Number*******************************");
                    EvenOddNumbers evenOdd = new EvenOddNumbers();
                    evenOdd.EvenOdd();
                    break;
                case 7:
                    Console.WriteLine("\n***********************Quotient and Reminder Program*****************");
                    QuotientReminder quotientReminder = new QuotientReminder();
                    quotientReminder.QuotReminder();
                    break;
                case 8:
                    Console.WriteLine("\n***********************Largest Program*****************");
                    LargestNumber largest = new LargestNumber();
                    largest.Largest();
                    break;
                case 9:
                    Console.WriteLine("\n***********************Alphabete vowel or Consonent*****************");
                    Alphabete alphabete = new Alphabete();
                    alphabete.Vowel();
                    break;
                case 10:
                    Console.WriteLine("\n*********************** Harmonic *****************");
                    Harmonic harm = new Harmonic();
                    harm.HarmoncValue();
                    break;
            }
        }
    }
}