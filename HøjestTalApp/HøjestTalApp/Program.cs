using System;
using System.Linq;

namespace HøjestTalApp
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
            Console.WriteLine("Det største tal er: ");
            Console.WriteLine(myArray.Max());
        }
    }
}
