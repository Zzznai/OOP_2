using System;

namespace Zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());
            for(var i=2;i<=number;i++)
            {
                if(IsPrimeNumber(i))
                {
                    Console.Write(i+' ');
                }
            }
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
