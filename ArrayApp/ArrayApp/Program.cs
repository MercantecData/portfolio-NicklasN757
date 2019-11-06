using System;

namespace ArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int arraySize = int.Parse(Console.ReadLine());

            int[] myArray = new int[arraySize];

            int i = 0;
            while ( i < myArray.Length )
            {
                myArray[i] = int.Parse(Console.ReadLine());
                i += 1;
            }
            Console.WriteLine();
            Console.WriteLine("Dit array består af: ");
            int s = 0;
            while (s < myArray.Length)
            {
                Console.WriteLine(myArray[s]);
                s += 1;
            }
            

        }
    }
}
