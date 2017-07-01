using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class NumberGuesser
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            GetUserInfo();

            //This is where action begins
            while (true)
            {
                Random random = new Random();
                int correctNumber = random.Next(10) + 1;

                Console.WriteLine("Guess a number between 1 and 10");
                string input = Console.ReadLine();
                int userInput = int.Parse(input);

                while (userInput != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong Number!!! Please try again.... \a \n");
                    Console.ResetColor();

                    input = Console.ReadLine();
                    userInput = int.Parse(input);
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congratulations!!! You are correct");
                Console.ResetColor();

                Console.WriteLine("Would you like to play again? Yes or No");
                string reply = Console.ReadLine().ToUpper();
                if (reply == "YES")
                {
                    continue;
                }

                //else
                //{
                //    return;
                //}

            }//While loop ends here

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            
        }

        //Method to get user information
        private static void GetUserInfo()
        {
            Console.WriteLine("\nPlease introduce yourself:");
            string userName = Console.ReadLine();
            Console.WriteLine($"Welcome {userName} \n");
            //Console.WriteLine(Environment.NewLine);
        }

        //method to print App Information
        static void GetAppInfo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("This is a number guessing game.");
            Console.WriteLine("Version 1.0");
            Console.WriteLine("Sam-Iduh Priscilla");
            Console.ResetColor();
        }
    }
}
