// See https://aka.ms/new-console-template for more information
using System;
using System.Drawing;

// Namespace
namespace NumberGuesser
{   
    // Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo();

            Greeting();
            
            while(true) {
            // Init correct number
            Random random = new Random();
            int correctNumber =random.Next(1, 10);

            // Init guess var
            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10");
            
            // While guess is not correct
            while (guess != correctNumber) {
                string input = Console.ReadLine();

                // Make sure input is a number
                if(!int.TryParse(input, out guess)) {
                   PrintColorMessage(ConsoleColor.Red, "Input was not a number, please try again");
                }
                // Cast to int and put in guess
                guess = Int32.Parse(input);

                // Match guess to correct number
                if(guess != correctNumber) {
                    PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                }

            }

            // Output success message
            PrintColorMessage(ConsoleColor.Green, "You guessed the number!");

            // Ask to play again
            Console.WriteLine("Play again? [Y or N]");

            // Get answer
            string answer = Console.ReadLine().ToUpper();

            if (answer == "Y") {
                continue;
            } else if (answer == "N"){
                return;
            } else {
                return;
            }
            }
        }

        static void GetAppInfo() {
            // Set variáveis do aplicativo
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Paulo Kitayama";
            
            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        static void Greeting() {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message) {
             // Change text color
            Console.ForegroundColor = color;

            // Write message
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();
        }
    }
}
