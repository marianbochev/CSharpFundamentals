using System;
using System.Linq;

namespace SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            //input
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            //logic
            for (int i = 0; i <=array.Length-1; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
             Array.Sort(array);
            Console.WriteLine(string.Join(Environment.NewLine, array));
        }
    }
}
