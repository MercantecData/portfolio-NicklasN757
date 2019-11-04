using System;

namespace sortereArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] myArray = new int[arraySize];
            Console.WriteLine();
            int i = 0;
            while (i < myArray.Length)
            {
                myArray[i] = int.Parse(Console.ReadLine());
                i += 1;
            }
            Array.Sort(myArray);

            Console.WriteLine();
            Console.WriteLine("Dit sorteret array består af: ");
            int s = 0;
            while (s < myArray.Length)
            {
                Console.WriteLine(myArray[s]);
                s += 1;
            }
        }
    }
}
