using System;

namespace Zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year=int.Parse(Console.ReadLine());
            Console.WriteLine(isLeapYear(year));

        }


        static bool isLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if(year%100==0 && year%400==0)
                {
                    return true;
                }
                else if (year % 100 == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
