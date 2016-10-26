using System;

namespace IntDoubleString
{
    class IntDoubleString
    {
        static void Main()
        {
            //input
            string choose = Console.ReadLine();

            //output
            switch (choose)
            {
                case "integer": int integerNumber = int.Parse(Console.ReadLine());
                                Console.WriteLine(integerNumber+1); break;
                case "real": double doubleNumber = double.Parse(Console.ReadLine());
                             Console.WriteLine("{0:F2}",doubleNumber+1);break;
                case "text": string stringText = Console.ReadLine();
                             Console.WriteLine("{0}*",stringText);break;
            }
        }
    }
}
