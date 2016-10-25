using System;

namespace NumberComparer
{
    class NumberComparer
    {
        static void Main()
        {
            //input
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            //logic
            Console.WriteLine(Math.Max(a,b));
        }
    }
}
