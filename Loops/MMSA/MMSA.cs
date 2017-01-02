using System;
using System.Linq;

namespace MMSA
{
    class MMSA
    {
        static void Main()
        {
            ulong n = ulong.Parse(Console.ReadLine());
            double[] array = new double[n];
            double sum = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
                sum += array[i];
            }
            double average = sum / n;
            Console.WriteLine("min={0:F2}",array.Min());
            Console.WriteLine("max={0:F2}", array.Max());
            Console.WriteLine("sum={0:F2}",sum);
            Console.WriteLine("avg={0:F2}",average);
        }
    }
}
