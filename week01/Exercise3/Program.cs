using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            Random randomGenerator = new Random ();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int guessCount = 0;


            while (guess != magicNumber)
            {

                // Always make sure to add a space at the end so the imput isn't combined with the prompt
                Console.Write("Take a guess ");
                guess = int.Parse(Console.ReadLine());

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Yep");
                    Console.WriteLine($"You got it in {guessCount} tries");
                }
            }

            Console.Write("Want to play again? (yes/no) ");
            playAgain = Console.ReadLine();
        }
    }
}