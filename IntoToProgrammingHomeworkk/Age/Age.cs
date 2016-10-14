using System;

class Age
{
    static void Main()
    {
        var bornDate = Console.ReadLine();
        DateTime a = Convert.ToDateTime(bornDate);
        DateTime c = DateTime.Now;
        int y = c.Year - a.Year;
        int m = c.Month - a.Month;
        int d = c.Day - a.Day;
        int age = 0;
        if (y >= 0)
        {
            if (m >= 0)
            {
                if (d >= 0)
                {
                    age = y;
                    Console.WriteLine(age);
                }
                else
                {
                    age = y - 1;
                    Console.WriteLine(age);
                }
            }
            else
            {
                age = y - 1;
                Console.WriteLine(age);
            }
        }
        else
        {
            age = y - 1;
            Console.WriteLine(age);
        }
        Console.WriteLine(age + 10);

    }
}
