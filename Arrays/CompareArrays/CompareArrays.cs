using System;
using System.Linq;

namespace CompareArrays
{
    class CompareArrays
    {
        static void Main()
        {
            //logic
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];
            //logic
            for (int i = 0; i <= firstArray.Length - 1; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j <= secondArray.Length - 1; j++)
            {
                secondArray[j] = int.Parse(Console.ReadLine());
            }
            bool compare = firstArray.SequenceEqual(secondArray);
            if (compare == true)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}
