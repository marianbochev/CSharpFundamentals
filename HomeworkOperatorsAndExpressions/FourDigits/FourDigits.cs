using System;

namespace FourDigits
{
    class FourDigits
    {
        static void Main()
        {
            //input
            int num = int.Parse(Console.ReadLine());
            int a, b, c, d, sum = 0;

            //logic
            d = num % 10;
            num = num / 10;

            c = num % 10;
            num = num / 10;

            b = num % 10;
            num = num / 10;

            a = num;
            sum = a + b + c + d;
            Console.WriteLine(sum);
            Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);

        }
    }
}
