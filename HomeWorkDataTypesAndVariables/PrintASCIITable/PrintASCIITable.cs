using System;

namespace PrintASCIITable
{
    class PrintASCIITable
    {
        static void Main()
        {
            for (char c = (char)32; c <= 126; c++)
            {
                Console.Write(c);
            }
        }
    }
}
