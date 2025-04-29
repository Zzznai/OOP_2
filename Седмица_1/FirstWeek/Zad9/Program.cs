using System;
using System.Linq;

namespace Zad9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] euroArray = { 3, 6, 9, 12, 15, 18 };
            double[] usdArray = { 3.25, 6.5, 9.75, 13, 16.25, 19.5 };

            double[] euroToBgnArray = euroArray.Select(e => e * 1.95).ToArray();
            double[] usdToBgnArray = usdArray.Select(u => u * 1.80).ToArray();

            Console.WriteLine(AreArraysTheSame(euroToBgnArray, usdToBgnArray)?"They are the same":"they arent the same");

        }
        static bool AreArraysTheSame(double[] array1, double[] array2)
        {
            for(var i = 0; i < array1.Length; i++)
            {
                if (Math.Round(array1[i], 2) != Math.Round(array2[i], 2))
                    return false;
            }
            return true;
        }

    }
}
