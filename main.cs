// C# Guess a letter

// pseudo code: 
// setup:
// dictionary of words
// cound number of words in dictionary array
// random number
// pick random word
// - number of letters in word
// - array of guessed letters
// - 
// game loop
//. user picks letter
// is letter already guessed
// is letter in word 
// draw word
// draw hangman 
// pick again
//
// end game routine 


using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)

        {
            // Game Intro and setup -- enter name a generate a random number 
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Welcome to Hangman, " + userName + "! I'll pick a random word from the dictionary and you'll have 10 chances to guess my word.  Ready begin!");

            // adding a for loop
            for (int i = 0; i < 3; i++)
            {
            
            
            // adding a random number and assigning an array
            Random rnd = new Random();
            int rand1 = rnd.Next(8);


            string[] letters = {"mushroom", "guacamole", "computer", "linguine", "television", "calendar", "exaggerate", "football"};
            Console.WriteLine(letters[rand1]);
            Console.WriteLine(letters[rand1].Length);
            init stringLength = letters[rand1].Length
            
            for i = 1 to stringLength
            {
                
            }

            
            string answer = (letters[rand1]);
            string userGuess = "";
            int guesses = 0;

            // prompt the user for an initial guess 
            Console.WriteLine(userName + ", please type letter " + answer + ":");
           
            // begin the game loop
            while (userGuess != answer)
            {
                userGuess = Console.ReadLine();
                guesses++;
                
                if (userGuess != answer)
                {
                    Console.WriteLine("Please try again");
                }
                
            }
            
            // game ends
           Console.WriteLine("Congrats! You guessed it right.");
           Console.WriteLine("It took you " + guesses + " guesses to get it correct!");
           Console.WriteLine("=========================");
           
            }
        
        Console.WriteLine("Well Done! Game Over.");    
        
        }
    
    }
            
}
