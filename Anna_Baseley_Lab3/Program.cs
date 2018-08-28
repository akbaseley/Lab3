using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anna_Baseley_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool UserPlay = true;
            string UserName = UserInput("Hello! What is your name?");

            Console.WriteLine($"Nice to meet you, {UserName}.");

            int UserNumber;

            while (!int.TryParse(UserInput("Give me a number, please!"), out UserNumber)) ;

            while (UserPlay)
            {
                while ((UserNumber < 1) || (UserNumber > 100))
                {
                    while (!int.TryParse(UserInput($"Sorry, {UserName}!  Could you please give me a number between 1 and 100?"), out UserNumber)) ;
                }

                if (UserNumber % 2 == 1)
                {
                    Console.WriteLine($"{UserNumber} is odd.");
                }

                else if (UserNumber <= 25)
                {
                    Console.WriteLine($"{UserNumber} is even and less than 25.");
                }
                else
                {
                    Console.WriteLine($"{UserNumber} is even");
                }

                string UserContinue = UserInput($"Would you like to play again, {UserName}?");

                if (UserContinue.ToLower() != "y")
                {
                    UserPlay = false;
                    Console.WriteLine("Okay! See you next time!");
                }
                else
                {
                    UserPlay = true;
                    while (!int.TryParse(UserInput("Great! Another number, please!"), out UserNumber)) ;
                }

            }
        }

        public static string UserInput(string message)
        {
            Console.WriteLine(message);
            string UserInput = Console.ReadLine();
            return UserInput;
        }
    }
}
