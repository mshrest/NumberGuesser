using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();

           
            while (true)
            {
         
                // Create a new Random object
                Random random = new Random();

                //Init correct number
                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                //Ask user to guess a number
                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    //Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        ColorMessage(ConsoleColor.Red, "Alert! Please enter a number.");

                        //Keep going
                        continue;

                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        ColorMessage(ConsoleColor.Red, "Sorry! Your are wrong. Try again!");
                    }
                }

                // Print success message
                ColorMessage(ConsoleColor.Green, "You are correct. YOU WON!");


                //Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        //Get and display app info
        static void GetAppInfo()
        {
            //Setting app vars
            var appName = "Number Guesser";
            var appVersion = "1.0.0";
            var appAuthor = "Mala";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();
        }

        // Ask users name and greet
        static void GreetUser()
        {
            //Ask users name
            Console.WriteLine("What is your name?");

            //Get users input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, Let's play a game!", inputName);
        }

        // Print color message
        static void ColorMessage(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color;

            //Write out app info
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();
        }
    }
}
