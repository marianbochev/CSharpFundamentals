using System;
namespace DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main()
        {
            //input
            int num = int.Parse(Console.ReadLine());

            //logic
            if  (num % 5 == 0 && num % 7 == 0)
            {
                Console.WriteLine("true" + " " + num);
            }
            else
            {
                Console.WriteLine("false" + " " + num);
            }
        }
    }
}
