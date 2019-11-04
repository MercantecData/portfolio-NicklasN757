using System;

namespace hejApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(int.MaxValue);
            Console.WriteLine("Hvad skal jeg tæller til?");
            long howManyTimes = long.Parse(Console.ReadLine());
            int i = 0;
            while (howManyTimes > i)
            {
                i += 1;
                Console.WriteLine(i);
            }
        }
    }
}