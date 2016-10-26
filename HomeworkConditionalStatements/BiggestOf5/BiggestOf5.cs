using System;

namespace BiggestOf5
{
    class BiggestOf5
    {
        static void Main()
        {
            //input
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float d = float.Parse(Console.ReadLine());
            float e = float.Parse(Console.ReadLine());

            //logic
            float biggestOfThree = Math.Max(Math.Max(a,b),c);
            float biggestOfTwo = Math.Max(Math.Max(d, e),biggestOfThree);
            Console.WriteLine(biggestOfTwo);

        }
    }
}
