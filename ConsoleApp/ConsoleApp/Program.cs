using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Laver et tilfældig tal.
            static int randomNumber(int minNum, int maxNum)
            {
                if (minNum > maxNum)
                {
                    int min = minNum;
                    int max = maxNum;
                    maxNum = min;
                    minNum = max;
                }
                Random rnd = new Random();
                int randomNum = rnd.Next(minNum, maxNum);
                return randomNum;
            }
            //Tjekker om det gættede tal er mindre end det spilleren har trykket ind
            static double minRangeChecker(int guessNum, int playerNum, double minRange)
            {
                if (guessNum < playerNum)
                {
                    if (guessNum > 999999)
                    {
                        minRange *= 1.5;
                        while (minRange > playerNum)
                        {
                            minRange /= 1.001;
                        }
                    }
                    else if (guessNum > 99999)
                    {
                        minRange *= 1.5;
                        while (minRange > playerNum)
                        {
                            minRange /= 1.02;
                        }
                    }
                    else
                    {
                        minRange *= 2;
                        while (minRange > playerNum)
                        {
                            minRange /= 1.05;
                        }
                    }
                }
                return minRange;
            }
            //Tjekker om det gættede tal er støren end det spilleren har trykket ind
            static double maxRangeChecker(int guessNum, int playerNum, double maxRange)
            {
                if (guessNum > playerNum)
                {
                    if (guessNum > 999999)
                    {
                        maxRange /= 1.5;
                        while (maxRange > playerNum)
                        {
                            maxRange /= 1.001;
                        }
                    }
                    else if (guessNum > 99999)
                    {
                        maxRange /= 1.5;
                        while (maxRange < playerNum)
                        {
                            maxRange *= 1.02;
                        }
                    }
                    else
                    {
                        maxRange /= 2;
                        while (maxRange < playerNum)
                        {
                            maxRange *= 1.05;
                        }
                    }
                }
                return maxRange;
            }
            static int minRangeConverter(string minRange)
            {
                if (minRange.ToLower() == "min")
                {
                    return 1;
                }
                else
                {
                    return int.Parse(minRange);
                }
            }
            static int maxRangeConverter(string maxRange)
            {
                if (maxRange.ToLower() == "max")
                {
                    return int.MaxValue;
                }
                else
                {
                    return int.Parse(maxRange);
                }
            }

            Console.Write("Skriv minimum range: ");
            int minNumRange = minRangeConverter(Console.ReadLine());
            Console.Write("Skriv maximum range: ");
            int maxNumRange = maxRangeConverter(Console.ReadLine());
            Console.Write("Skriv det tal jeg skal gætte: ");
            int playerNumber = int.Parse(Console.ReadLine());
            
            int[] array = new int[100000];
            int totalGuess = 0; 
            int i = 0;
            int guessNumber = 0;
            bool run = true;
            while (run)
            {
                guessNumber = randomNumber(minNumRange, maxNumRange);

                if (!array.Contains(guessNumber))
                {
                    array[i] = guessNumber;
                    i += 1;
                    totalGuess += 1;
                    Console.WriteLine(guessNumber);

                    if (guessNumber == playerNumber)
                    {
                        run = false;
                        Console.WriteLine("Jeg har gættet dit nummer. Dit nummer er " + playerNumber + ".");
                        Console.WriteLine("Det tog " + totalGuess + " forsøg!");
                        Console.Write("Vil du spille igen? y/n: ");

                        string reply = Console.ReadLine();
                        if (reply == "y")
                        {
                            Console.Write("Skriv minimum range: ");
                            minNumRange = minRangeConverter(Console.ReadLine());
                            Console.Write("Skriv maximum range: ");
                            maxNumRange = maxRangeConverter(Console.ReadLine());
                            Console.Write("Skriv det tal jeg skal gætte: ");
                            playerNumber = int.Parse(Console.ReadLine());

                            array = new int[100000];
                            run = true;
                            totalGuess = 0;
                            i = 0;
                        }
                        else if (reply == "n")
                        {
                            Console.WriteLine("Tak fordi du gad at spille med. Hav en god dag!");
                        }
                    }
                    maxNumRange = Convert.ToInt32(maxRangeChecker(guessNumber, playerNumber, maxNumRange));
                    minNumRange = Convert.ToInt32(minRangeChecker(guessNumber, playerNumber, minNumRange));
                }
            }
        }
    }
}
