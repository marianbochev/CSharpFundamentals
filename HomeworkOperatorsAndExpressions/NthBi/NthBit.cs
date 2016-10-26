using System;

namespace NthBi
{
    class NthBit
    {
        static void Main()
        {
            //input
            ulong p = ulong.Parse(Console.ReadLine());
            byte n = byte.Parse(Console.ReadLine());

            //output
            Console.WriteLine((p >> n) & 1);
        }
    }
}


