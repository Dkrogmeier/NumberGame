using System;

namespace NumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            Greeting();

            while (true)
            {

                //set correct number
                //int correctNum = 7;
                //create a new random object
                Random random = new Random();

                int correctNum = random.Next(1, 10);

                //init guess var
                int guess = 0;
                Console.WriteLine("Guess a number between 1-10");
                while (guess != correctNum)
                {
                    //get user input
                    string readGuess = Console.ReadLine();

                    if (!int.TryParse(readGuess, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Thats not a number, try again.");
                        continue;
                    }

                    //cast to int and put in guess
                    guess = Int32.Parse(readGuess);

                    //match guess to correct number
                    if (guess != correctNum)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong! Try again.");
                    }
                }

                //success message
                PrintColorMessage(ConsoleColor.Green, "Correct! Good job.");

                //ask to play again
                Console.WriteLine("Play Again? [y or n]");

                //get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            //set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Dakota K";

            //change text color
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }

        static void Greeting()
        {
            //ask for name
            Console.WriteLine("What is your name?");

            //get user input
            string input = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game.", input);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("{0}", message);
            Console.ResetColor();
        }
    }
}
