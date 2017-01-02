using System;

namespace GCD
{
    class GCD
    {
        static void Main()
        {
            //input
            var input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            //logic
            int greaterAB = Math.Min(a, b);
            for (int i = greaterAB; i >= 1; i--)
            {
                if (a%i == 0 && b % i == 0)
                {
                    int GCD = i;
                    Console.WriteLine(GCD);
                    break;
                }
            }
        }
    }
}
