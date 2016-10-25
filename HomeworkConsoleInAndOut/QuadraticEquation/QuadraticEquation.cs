using System;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            //input
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
          //  double x1;
          //  double x2;
            //logic
            double D = ((b*b)-4*a*c);
            if (D < 0)
            {
                Console.WriteLine("no real roots");
            }
            else
            {
                if (D == 0)
                {
                    double x = (-b) / (2 * a);
                    Console.WriteLine("{0:F2}",x);
                }
                else
                {
                    D = ((b * b) - 4 * a * c);
                    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    double x2= (-b - Math.Sqrt(D)) / (2 * a);
                    if (x1 >= x2)
                    {
                        Console.WriteLine("{0:F2}" ,x2);
                        Console.WriteLine("{0:F2}", x1);
                    }
                    else
                    {
                        Console.WriteLine("{0:F2}", x1);
                        Console.WriteLine("{0:F2}", x2);
                    }
                }
            }
        }
    }
}