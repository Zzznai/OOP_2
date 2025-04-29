using System;

namespace Zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array1= new int[10];
            int[] array2 = new int[10];

            for(int i = 0; i < array1.Length; i++)
            {
                int number=random.Next(1,100);
                array1[i] = random.Next(1,100);
                array2[i] = random.Next(1, 100);
            }

            Console.WriteLine(AreArraysTheSame(array1, array2));

        }

        static bool AreArraysTheSame(int[] array1, int[] array2)
        {
            if(array1.Length != array2.Length)
                return false;
            else
            {
                for(var i= 0; i < array1.Length; i++)
                {
                    if (array1[i] != array2[i])
                        return false;
                }
                return true;
            }
        }


    }
}
