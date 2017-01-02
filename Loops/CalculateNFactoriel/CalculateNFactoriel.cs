using System;
using System.Numerics;

namespace CalculateNFactoriel
{
    class CalculateNFactoriel
    {
        static void Main()
        {
            //input
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger k = BigInteger.Parse(Console.ReadLine());
            BigInteger nFactoriel = 1;
            BigInteger kFactoriel = 1;
            BigInteger nkFactoriel = 1;
            BigInteger nka = n - k;
            //logic
            for (long x = 1, i = 1, j = 1; i <= n || x <= nka || j <= k; x++, i++, j++)
            {
                if (n >= i)
                {
                    nFactoriel *= i;
                }
                if (k >= j)
                {
                    kFactoriel *= j;
                }
                if (nka >= x)
                {
                    nkFactoriel *= x;
                }
            }
            // N! / (K! * (N -K)!))
            BigInteger formula = nFactoriel / (kFactoriel * (nkFactoriel));
            Console.WriteLine(formula);
        }
    }
}
