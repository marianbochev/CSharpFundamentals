using System;

namespace ThirdBit
{
    class ThirdBit
    {
        static void Main()
        {
            // first way- easiest
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine((n >> 3) & 1);

            // second way 
            int p = int.Parse(Console.ReadLine());
            int mask = 1 << 3;
            Console.WriteLine((n & mask) >> 3);
        }
    }
}

