using System;

namespace Week2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3,3,4,3};

            Console.WriteLine(FindDiff(numbers));
        }

        static int FindDiff(int[] numbers)
        {
            for (var i = 1; i < numbers.Length - 1; i++)
            {
                int resultBefore = numbers[i - 1] ^ numbers[i];
                int resultAfter = numbers[i] ^ numbers[i + 1];
                if (resultBefore != 0 && resultAfter == 0)
                {
                    return(numbers[i - 1]);
                }
                else if (resultAfter != 0 && resultBefore != 0)
                {
                    return(numbers[i]);
                }
                else if (resultAfter != 0 && resultBefore == 0)
                {
                    return(numbers[i + 1]);
                }
            }

            return 0;
        }
    }
}
