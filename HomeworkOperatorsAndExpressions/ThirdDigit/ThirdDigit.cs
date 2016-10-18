using System;

namespace ThirdDigit
{
    class ThirdDigit
    {
        static void Main()
        {
            //input
            int n = int.Parse(Console.ReadLine());

            //logic
            int num = n / 100;
            int num1 = num % 10;
            if (num1 == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false " + num1);
            }
            
        }
    }
}
