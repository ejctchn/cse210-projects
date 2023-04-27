using System;

class Program
{
    static void Main(string[] args)
    {
        Random rdm = new Random();
        bool play = true;
        bool keep_playing = true;
        int num_guesses = 0;
        
        while(keep_playing)
        {
            Console.WriteLine("Welcome to the Number Guessing Game!");
            int number = rdm.Next(100);

            while(play)
            {
                Console.Write("What is your guess? ");
                int guess = Convert.ToInt32(Console.ReadLine());
                num_guesses++;

                if(guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else if(guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    play = false;
                }
            }
            Console.WriteLine("It took you " + num_guesses + " tries!");
            Console.Write("Would you like to play again (y/n)?");
            string kp = Console.ReadLine();
            if(kp.ToLower() == "y")
            {
                keep_playing = true;
                play = true;
            }
            else if(kp.ToLower() == "n")
            {
                keep_playing = false;
            }
            else
            {
                Console.WriteLine("That is not a valid entry. Please only enter 'y' or 'n'.");
            }
            
        }
    }
}