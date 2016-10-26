using System;

namespace PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            //input
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double r = 2.0d;
            double distance = Math.Sqrt(Math.Pow(0-x, 2) + Math.Pow(0-y, 2));

            //output
            if (distance < r)
            {
                Console.WriteLine("yes {0:F2}" , distance);
            }
            else
            {
                Console.WriteLine("no {0:F2}", distance);
            }

        }
    }
}
