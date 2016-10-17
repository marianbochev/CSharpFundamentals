using System;

namespace PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main()
        {
            sbyte num = sbyte.Parse(Console.ReadLine());
            int remainder = 0;
            string result = "true";
            if (num > 1)
            {
                for (sbyte i = 2; i <num; i++)
                {
                    remainder = num % i;
                    if (remainder == 0)
                    {
                        result = "false";
                        break; 
                    }
                }
            }
            // if num is < 2
            else
            {
                result = "false";
            }
            Console.WriteLine(result);
        }
    }
}