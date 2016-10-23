using System;

namespace SumOf3Numbers
{
    class SumOf3Numbers
    {
        static void Main()
        {
            //input
            short num1 = short.Parse(Console.ReadLine());
            short num2 = short.Parse(Console.ReadLine());
            short num3 = short.Parse(Console.ReadLine());

            //logic
            int result = num1 + num2 + num3;
            Console.WriteLine(result);
        }
    }
}
