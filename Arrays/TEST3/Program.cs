using System;
namespace TEST3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(text[2]);
            if(text[2] % 2 == 0)
            {
                Console.WriteLine("da");
            }
        }
    }
}
