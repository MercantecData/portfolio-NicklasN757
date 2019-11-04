using System;

namespace navneArray
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] myArray = {"Nick", "Bob", "Peter", "Søren", "v_v", "o_o", "\"_\"", "p_p", "A_A", "8_8", "!_!"};


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
