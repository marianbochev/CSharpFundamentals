using System;

namespace ExchangeNumbers
{
    class ExchangeNumbers
    {
        static void Main()
        {
            //input
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());

            //logic
            if (a > b)
            {
                float c = a;
                a = b;
                b = c;
                Console.WriteLine("{0} {1}" ,a,b);
            }
            else
            {
                Console.WriteLine("{0} {1}" ,a,b);
            }
        }
    }
}
