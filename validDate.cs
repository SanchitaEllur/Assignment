using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter year (2000-2050):");
        int year = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter month (1-12):");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter day (1-31):");
        int day = Convert.ToInt32(Console.ReadLine());

        if (IsValidDate(year, month, day))
        {
            Console.WriteLine("Valid date entered!");
        }
        else
        {
            Console.WriteLine("Invalid date entered!");
        }
    }

    public static bool IsValidDate(int year, int month, int day)
    {
        if (year >= 2000 && year <= 2050)
        {
            if (month >= 1 && month <= 12)
            {
                int daysInMonth = DateTime.DaysInMonth(year, month);

                if (day >= 1 && day <= daysInMonth)
                {
                    return true;
                }
            }
        }

        return false;
    }
}