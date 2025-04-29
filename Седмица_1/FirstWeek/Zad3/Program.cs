using System;
using System.Linq;

namespace Zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете поредица от номера, които да завършат с end:");
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ')
                .Where(x => x != "end") 
                .Select(int.Parse)
                .ToArray();
            Console.WriteLine("Средното на числата е: " + FindAverage(numbers));
        }

        static double FindAverage(int[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum / numbers.Length;
        }
    }
}
