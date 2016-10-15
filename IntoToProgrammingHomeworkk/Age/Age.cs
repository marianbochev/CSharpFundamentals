using System;

class Age
{
    static void Main()
    {
        String inputDate = Console.ReadLine();
        DateTime myDate = Convert.ToDateTime(inputDate);
        DateTime currentDate = DateTime.Now;

        int year = currentDate.Year - myDate.Year;
        int month = currentDate.Month - myDate.Month;
        int day = currentDate.Day - myDate.Day;
        int age = 0;
        if (year >= 0 && month >= 0 && day >= 0)
        {
            age = year;
            Console.WriteLine(age);
        }
        else
        {
            age = year - 1;
            Console.WriteLine(age);
        }
        Console.WriteLine(age + 10);
    }

}
}