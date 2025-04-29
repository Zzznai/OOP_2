using System;
using System.Linq;

namespace Zad8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 180.09, 277.08, 1.1, 1000.1, 1.1 };
            double sum = array.Sum();
            if (Math.Round(sum,2)== 1459.47)
                Console.WriteLine("The sum is correct");
            else
                Console.WriteLine("The sum is incorrect");

        }
    }
}
