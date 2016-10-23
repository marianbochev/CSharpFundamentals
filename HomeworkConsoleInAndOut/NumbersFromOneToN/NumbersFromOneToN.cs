using System;

namespace NumbersFromOneToN
{
    class NumbersFromOneToN
    {
        static void Main()
        {
            //input
            ushort n = ushort.Parse(Console.ReadLine());

            //logic
            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
