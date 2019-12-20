using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_Program
{
    class consoleColor
    {
        //Ændre farven til grøn
        public void green()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        //Ændre farven til rød
        public void red()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        //Ændre farven til gul
        public void yellow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        //Ændre farven til grå
        public void gray()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
