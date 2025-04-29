using System;

namespace FirstWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (var i = 1; i <= n; i++)
            {
                sum += i;
            }
        }
    }
}
