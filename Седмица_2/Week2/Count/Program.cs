using System;

namespace Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число:");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Броят на единиците в двоичното число на {number} e: {CountBits(number)}");
        }

        static int CountBits(int number)
        {
            int count = 0;

            while (number > 0)
            {
                count += number & 1;
                number >>= 1;
            }

            return count;
        }
    }
}
