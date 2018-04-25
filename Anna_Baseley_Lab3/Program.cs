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
            //Input
            string restart;

            Console.WriteLine("Hi!  What's your name? I'm Anna");
            string UserName = Console.ReadLine();
            Console.WriteLine($"Nice to meet you, {UserName}!  Let's play a game!");

            do
            {
                Console.WriteLine("Please enter a number between 1 and 100.");
                int UserNumber = int.Parse(Console.ReadLine());

                while (UserNumber < 0 || UserNumber > 100)
                {
                    Console.WriteLine($"Sorry, {UserName}. I need a positive number between 1 and 100.");
                    UserNumber = int.Parse(Console.ReadLine());
                }

                //Processing & Output
                if ((UserNumber % 2) != 0)
                {
                    Console.WriteLine($"{UserNumber} is odd, {UserName}.");
                }

                else if (UserNumber <= 25)
                {
                    Console.WriteLine($"{UserName}, {UserNumber} is even and less than 25.");
                }

                else if (UserNumber <= 60)
                {
                    Console.WriteLine($"Your number is even, {UserName}.");
                }
                else
                {
                    Console.WriteLine($"{UserNumber} is even.");
                }

                Console.WriteLine($"Thank you for playing, {UserName}, would you like to play again? (y/n).");
                restart = Console.ReadLine();

                while (restart.ToLower() != "y" && restart.ToLower() != "n")
                {
                    Console.WriteLine("Oops!  Let's try that again.  Would you like to continue? (y/n)");
                    restart = Console.ReadLine();
                }

                if (restart != "y")
                {
                    Console.WriteLine("Okay!  Thank you for playing!");
                }
            }

            while (restart.ToLower() == "y"); 
        }
    }
}
