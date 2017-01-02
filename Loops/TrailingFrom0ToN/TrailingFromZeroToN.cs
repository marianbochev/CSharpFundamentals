using System;
using System.Numerics;


namespace TrailingFrom0ToN
{
    class TrailingFromZeroToN
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factoriel = 1;

            for (int i = 1; i <= n; i++)
            {
                factoriel *= i;
            }

            int sumOfZeros = 0;
            BigInteger cutLastDigit = factoriel;
            while (cutLastDigit != 0)
            {
                BigInteger getLastDigit = cutLastDigit % 10;
                if (getLastDigit == 0)
                {
                    sumOfZeros += 1;
                }
                else
                {
                    break;
                }
                cutLastDigit = cutLastDigit / 10;
            }
            Console.WriteLine(sumOfZeros);
        }
    }
}