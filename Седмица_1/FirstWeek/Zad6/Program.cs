using System;

namespace Zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("There are "+ DaysInMonth(year, month)+" days in monnth number "+month+" in the year of "+year);

        }

        static int DaysInMonth(int year, int month)
        {
            if (month < 1 || month > 12)
            {
                throw new ArgumentOutOfRangeException("month", "Month must be between 1 and 12.");
            }

            if (month == 2)
            {
                return isLeapYear(year) ? 29 : 28;
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30;
            }
            else
            {
                return 31;
            }
        }

        static bool isLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0 && year % 400 == 0)
                {
                    return true;
                }
                else if (year % 100 == 0)
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
