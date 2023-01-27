using System;

// Namespace
namespace NumberGuesser
{   
    // Main Class
    internal class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {

            Get_app_info();

            Greet_user();

            while (true)
            {
                // Set correct number between 1 and 10
                Random random_num = new Random();
                int ans = random_num.Next(1, 11);

                // Ask user for number
                int guess = 0;
                Console.WriteLine("Guess number between 1 and 10");

                // While guess is not correct
                while (guess != ans)
                {

                    // Get user input
                    string input = Console.ReadLine();
                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        Print_coloured(ConsoleColor.Red, "Please enter an actual whole number (without commas).");

                        // Skips current iteration of while loop, and starts from the top again 
                        continue;
                    }
                    // Cast to int and put to guess
                    guess = Int32.Parse(input);

                    if (guess == ans) { continue; }

                    // Error messages 
                    if (guess > 10 || guess < 1)
                    {
                        Print_coloured(ConsoleColor.Red, "Please enter a number between 1 and 10.");
                    }
                    else
                    {
                        Print_coloured(ConsoleColor.Red, "Wrong guess, try again.");
                    }
                }

                // Success message
                Print_coloured(ConsoleColor.Yellow, "Guessed it! Good job! :)");

                // Ask to play again
                Console.WriteLine("Play again? [Y for 'Yes' / anything else for 'No']");
                string play_again = Console.ReadLine().ToUpper();

                if (play_again == "Y") { continue; }
                else { return; }

            }
        }

        static void Get_app_info() {
            // App name, version, creator
            string app_name = "Number Guesser";
            string app_version = "1.0";
            string app_creator = "Edson Li";

            // Change colour
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", app_name, app_version, app_creator);
            Console.ResetColor();

        }

        static void Greet_user(){

            string app_name = "Number Guesser";

            // Ask user for name
            Console.WriteLine("What is your name?");
            string user_name = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play {1}", user_name, app_name);

        }

        static void Print_coloured(ConsoleColor colour, string message)
        {
            Console.ForegroundColor = colour;
            Console.WriteLine(message);
            Console.ResetColor();

        }
    }
}