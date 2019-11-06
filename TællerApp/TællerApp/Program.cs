using System;

namespace TællerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] myArray = new int[arraySize];

            int s = 0;
            int i = 0;
            while (i < arraySize)
            {
                s += 1;
                myArray[i] = s;
                i += 1;
            }
            Console.WriteLine();
            int e = 0;
            while (e < arraySize)
            {
                Console.WriteLine(myArray[e]);
                e += 1;
            }
        }
    }
}
