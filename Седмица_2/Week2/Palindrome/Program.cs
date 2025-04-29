using System;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 33;
            if (IsBinaryPalindrome(number))
            {
                Console.WriteLine("Полиндром");

            }
            else
            {
                Console.WriteLine("Не е полиндром");
            }


        }

        static bool IsBinaryPalindrome(int n)
        {
            int original = n;
            int reversed = 0;
            int bits = 0;

            int temp = n;
            while (temp > 0)
            {
                bits++;
                temp >>= 1;
            }

            for (int i = 0; i < bits; i++)
            {
                reversed <<= 1;
                reversed |= (n & 1);
                n >>= 1;
            }
            return original == reversed;
        }

    }
}
