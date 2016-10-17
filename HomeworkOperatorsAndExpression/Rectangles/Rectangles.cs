using System;

namespace Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            //input
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            //logic
            double area = width * height;
            double perimeter = (2 * width) + (2 * height);

            //output
            Console.Write("{0:F2}", area);
            Console.WriteLine(" " + "{0:F2}", perimeter);
           
            //output 2 - in case.
            Console.WriteLine("{0:0.00} {1:0.00}", area, perimeter);
        }
    }
}
          