using System;
using System.Linq;

namespace SecondBiggest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int[] nums = Array.ConvertAll(numbers.Split(' '), int.Parse);
            int biggest=nums.Max();
            int secondBiggest = nums.Where(x => x != biggest).Max();
            Console.WriteLine(secondBiggest);

        }
    }
}
