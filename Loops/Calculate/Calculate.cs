using System;

namespace Calculate
{
    class Calculate
    {
        static void Main()
        {
            //input
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double nFactoriel = 1;
            double sum = 1;

            //logic
            for (int i = 1; i <= n; i++)
            {
                nFactoriel *= i;
                sum +=  nFactoriel / Math.Pow(x, i);
            }
            Console.WriteLine("{0:F5}",sum);
        }
    }
}
