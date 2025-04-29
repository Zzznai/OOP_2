using System;

namespace OddEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число:");
            var number=int.Parse(Console.ReadLine());
            if((number & 1)==0)
            {
                Console.WriteLine("Четно");
            }
            else
            {
                Console.WriteLine("Нечетно");
            }
        }
    }
}
