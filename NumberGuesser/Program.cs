using System;

namespace NumberGuesser
{
    class Program
    {
       
        static void Main(string[] args)
        {
            GetAppInfo();

            // User credentials
            GreetUser();

            while (true)
            {
                //Generate a random winning number 
                Random randomNumber = new Random();

                //Between 1 and 10
                int correctNumber = randomNumber.Next(1, 10);

                //Initial guess variable
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    //User guess input
                    string userInput = Console.ReadLine();

                    //Check if the user entered a number
                    if (!int.TryParse(userInput, out guess))
                    {
                        printColorMsg(ConsoleColor.Red,"Please enter a number and not a string!");
                        continue;
                    }

                    //Parse input and assign it to guess
                    guess = Int32.Parse(userInput);

                    if (guess != correctNumber)
                    {
                        printColorMsg(ConsoleColor.Red, "Wrong number please try again");
                    }
                }

                printColorMsg(ConsoleColor.Yellow, "CONGRATS\n You've guessed the correct number!!!");

                //Wanna play again?
                Console.WriteLine("Play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
                            
          

        }

        static void GetAppInfo()
        {
            // Header of the app
            string appName = "Number guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Petar Zaf";

            //Change txt color
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("{0}: Version {1} by {2} ", appName, appVersion, appAuthor);

            //Reset the txt color 
            Console.ResetColor();

        }

        static void GreetUser()
        {
            
            Console.WriteLine("Enter your name: ");
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game!", inputName);
        }

        static void printColorMsg(ConsoleColor color,string msg)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}
