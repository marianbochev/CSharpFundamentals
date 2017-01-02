using System;
using System.Linq;


namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            //input
            string inputFirstArray = Console.ReadLine();
            string inputSecondArray = Console.ReadLine();
            char[] firstArray = inputFirstArray.ToCharArray();
            char[] secondArray = inputSecondArray.ToCharArray();
            if (firstArray.Length < secondArray.Length)
            {
                Console.WriteLine("<");
            }
            else if (firstArray.Length > secondArray.Length)
            {
                Console.WriteLine(">");
            }
            else
            {
                Console.WriteLine("=");
            }
        }
    }
}