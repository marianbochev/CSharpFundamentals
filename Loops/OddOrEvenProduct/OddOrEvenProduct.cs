using System;
using System.Linq;
using System.Numerics;

class OddAndEvenProduct
{
    static void Main()
    {
        {

            //input
            uint n = uint.Parse(Console.ReadLine());
            string[] stringArray = Console.ReadLine().Split();
            int[] numbers = new int[n];
            long sumOfEvenProduct = 1;
            long sumOfOddProduct = 1;
            //logic
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                numbers[i]=Convert.ToInt32(stringArray[i]);
                if (i % 2 == 0)
                {
                    sumOfEvenProduct *= numbers[i];
                }
                else
                {
                    sumOfOddProduct *= numbers[i];
                }
            }
            if (sumOfEvenProduct == sumOfOddProduct)
            {
                Console.WriteLine("yes " + sumOfEvenProduct);
            }
            else
            {
                Console.WriteLine("no " + sumOfEvenProduct + " " + sumOfOddProduct);
            }
        }
    }
}
