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
            Console.WriteLine("Hello! What is your name?");

            string UserName = Console.ReadLine();

            Console.WriteLine($"Nice to meet you, {UserName}.");

            while (true)
            {
                Console.WriteLine("Please give me a number between 1 and 100.");
                int UserNumber = int.Parse(Console.ReadLine());


                if ((UserNumber < 1) || (UserNumber > 100))
                {
                    Console.WriteLine($"Sorry, {UserName}!  Could you please give me a number between 1 and 100?");
                    UserNumber = int.Parse(Console.ReadLine());
                }

                else if (UserNumber % 2 == 1)
                {
                    Console.WriteLine($"{UserNumber} is odd.");
                }

                else if (UserNumber <= 25)
                {
                    Console.WriteLine($"{UserNumber} is even and less than 25.");
                }
                else if (UserNumber <= 60)
                {
                    Console.WriteLine($"{UserNumber} is even.");
                }
                else
                {
                    Console.WriteLine($"{UserNumber} is even");
                }

                Console.WriteLine($"Would you like to play again, {UserName}?");
                String UserContinue = Console.ReadLine();

                if (UserContinue.ToLower() != "y")
                {
                    Console.WriteLine("Okay! See you next time!");
                    break;
                }
            }
        }
    }
}
