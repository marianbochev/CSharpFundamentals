using System;

namespace SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main()
        {
            //input
            int nnumbers = int.Parse(Console.ReadLine());
            double sum = 0;

            //logic
            for (int i = 1; i <=nnumbers; i++)
            {
               int numbers = int.Parse(Console.ReadLine());
                sum += numbers;
            }
            Console.WriteLine(sum);
        }
    }
}
