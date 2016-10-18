using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutantSquirrels
{
    class MutantSquirrels
    {
        static void Main(string[] args)
        {
            //input
            ulong t = ulong.Parse(Console.ReadLine());
            ulong b = ulong.Parse(Console.ReadLine());
            ulong s = ulong.Parse(Console.ReadLine());
            ulong n = ulong.Parse(Console.ReadLine());

            //logic
            double totalTails = t * b * s * n;
            if (totalTails % 2 == 0)
            {
                totalTails = totalTails * 376439;
                Console.WriteLine("{0:F3}", totalTails);
            }
            else
            {
                totalTails = totalTails / 7;
                Console.WriteLine("{0:F3}", totalTails);
            }

        }
    }
}
