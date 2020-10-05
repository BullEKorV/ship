using System;

namespace shi
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameActive = true;
            Console.WriteLine("Welcome to battleships!");
            Console.WriteLine("Guess on a number between 1- 10 to try to sink the enemy ship!");
            Random rnd = new Random();
            int x = rnd.Next(1, 10);
            string stringGuess;
            int guess = 0;
            while (gameActive)
            {
                bool guessing = true;
                stringGuess = Console.ReadLine();
                while (guessing)
                {
                    if (int.TryParse(stringGuess, out guess))
                    {
                        if ((guess <= 10 && guess >= 1)) guessing = false;
                        else
                        {
                            Console.WriteLine("The number entered was not in the valid range of 1 - 10");
                            Console.WriteLine("Please enter a new number");
                            stringGuess = Console.ReadLine();
                        }
                    }
                    else if (!int.TryParse(stringGuess, out guess))
                    {
                        Console.WriteLine("Please enter a number");
                        stringGuess = Console.ReadLine();
                    }
                }

                if (guess == x)
                {
                    gameActive = false;
                    Console.WriteLine("Hit!\n");
                    Console.WriteLine("You hit the silly bastard!\n");
                    Console.WriteLine("Press the \"enter\" key to quit the application");
                    Console.ReadLine();
                }
                else if (-2 <= guess - x && 2 >= guess - x) Console.WriteLine("Near miss!");
                else Console.WriteLine("Miss!");
            }
        }
    }
}
