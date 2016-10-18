using System;

namespace MoonGravity
{
    class MoonGravity
    {
        static void Main()
        {
            //input
            float weight = float.Parse(Console.ReadLine());

            //logic
            float moonGravity = 0.17f;
            float weightOnMoon = weight * moonGravity;
            Console.WriteLine("{0:F3}",weightOnMoon);
        }
    }
}
