using System;

class Program
{
    static void Main (string[] args)
    {
       Random randomGenerator = new Random();
       int magicNum = randomGenerator.Next(1, 100);

       int personGuess = 0;
       int guessCount = 0;

        do
        {
           Console.Write("What is your guess? ");
           personGuess = Convert.ToInt32(Console.ReadLine());
       
       if (personGuess < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else if (personGuess > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else Console.WriteLine("You guessed it!");

            guessCount++;

        } while (personGuess != magicNum);

        Console.Write($"It took you {guessCount} guesses to guess the correct number!");
           
        }

}