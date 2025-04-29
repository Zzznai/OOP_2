using System;

namespace ZAd2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());
            Console.WriteLine(IsPrimeNumber(number));
        }

        static bool IsPrimeNumber(int number)
        {
            if (number < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
