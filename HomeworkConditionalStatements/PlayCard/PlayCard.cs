﻿using System;

namespace PlayCard
{
    class PlayCard
    {
        static void Main()
        {
            //input
            string card = Console.ReadLine();

            //logic
            switch (card)
            {
                case "2": Console.WriteLine("yes " + card);break;
                case "3": Console.WriteLine("yes " + card);break;
                case "4": Console.WriteLine("yes " + card);break;
                case "5": Console.WriteLine("yes " + card);break;
                case "6": Console.WriteLine("yes " + card);break;
                case "7": Console.WriteLine("yes " + card);break;
                case "8": Console.WriteLine("yes " + card);break;
                case "9": Console.WriteLine("yes " + card);break;
                case "10": Console.WriteLine("yes " + card);break;
                case "J": Console.WriteLine("yes " + card);break;
                case "Q": Console.WriteLine("yes " + card); break;
                case "K": Console.WriteLine("yes " + card); break;
                case "A": Console.WriteLine("yes " + card); break;
                default: Console.WriteLine("no " + card);break;
            }
        }
    }
}
