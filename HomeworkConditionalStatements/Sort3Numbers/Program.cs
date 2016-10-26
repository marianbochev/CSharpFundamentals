using System;

namespace Sort3Numbers
{
    class Program
    {
        static void Main()
        {
            //input
            short a = short.Parse(Console.ReadLine());
            short b = short.Parse(Console.ReadLine());
            short c = short.Parse(Console.ReadLine());

            //logic
            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b);
                }
            }
            if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine("{0} {1} {2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                }
            }
            if (c > a && c > b)
            {
                if (b > a)
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", c, a, b);
                }
            }
        }
    }
}
