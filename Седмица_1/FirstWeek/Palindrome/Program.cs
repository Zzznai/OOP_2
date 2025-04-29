using System;
using System.Linq;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число : ");
            var input = Console.ReadLine();
            var reversed = new string(input.Reverse().ToArray());

            if (input.Equals(reversed))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a palindrome");
            }
        }
    }
}
