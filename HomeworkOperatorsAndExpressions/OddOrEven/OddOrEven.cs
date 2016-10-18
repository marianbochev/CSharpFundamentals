using System;

namespace OddOrEven
{
    class OddOrEven
    {
        static void Main()
        {
            //input
            sbyte num = sbyte.Parse(Console.ReadLine());
            
            //logic
            if (num % 2 == 0)
            {
                Console.WriteLine("even"+ " " +num);
            }
            else
            {
                Console.WriteLine("odd"+ " " +num);
            }
        }
    }
}
