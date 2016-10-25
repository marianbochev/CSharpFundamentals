using System;
namespace SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main()
        {
            //input
            short num1 = short.Parse(Console.ReadLine());
            short num2 = short.Parse(Console.ReadLine());
            short num3 = short.Parse(Console.ReadLine());
            short num4 = short.Parse(Console.ReadLine());
            short num5 = short.Parse(Console.ReadLine());

            //logic
            int result = num1 + num2 + num3 + num4 + num5;
            Console.WriteLine(result);

        }
    }
}
