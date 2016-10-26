using System;

namespace BiggestOf3
{
    class BiggestOf3
    {
        static void Main()
        {
            //input
            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());
            float num3 = float.Parse(Console.ReadLine());

            //logic
            Console.WriteLine(Math.Max(Math.Max(num1,num2),num3));
        }
    }
}
