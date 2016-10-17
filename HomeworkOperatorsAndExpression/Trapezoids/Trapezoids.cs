using System;

namespace Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            //input
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal h = decimal.Parse(Console.ReadLine());

            //logic
            decimal result = (a + b) * h * 1 / 2;
            Console.WriteLine("{0:F7}",result);
        }
    }
}
