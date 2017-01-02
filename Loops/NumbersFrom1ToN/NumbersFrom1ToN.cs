using System;

namespace NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        static void Main()
        {
            //input
            int n = int.Parse(Console.ReadLine());

            //logic
            for (int i = 1; i <=n; i++)
            {
                Console.Write("{0} " ,i);
            }
        }
    }
}
