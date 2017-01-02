using System;

namespace AllocateArray
{
    class AllocateArray
    {
        static void Main()
        {
            //input
            byte n = byte.Parse(Console.ReadLine());
            int[] array = new int[n];
            //logic
            for (int i = 0; i <= array.Length-1; i++)
            {
                array[i] = i;
                array[i] *= 5;
                Console.WriteLine(array[i]);
            }
        }
    }
}
