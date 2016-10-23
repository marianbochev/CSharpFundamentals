using System;

namespace Circle
{
    class Circle
    {
        static void Main()
        {
            //input
            double r = double.Parse(Console.ReadLine());

            //logic
            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * r*r;
            Console.WriteLine("{0:F2} {1:F2}",perimeter,area);
        }
    }
}
