using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication_and_Authorization.Helpers
{
    internal class ConsoleHelper
    {
        public static string PromptUntilValid(string label, Func<string, bool> validator, string message)
        {
            string input;
            do
            {
                Console.Write($"Enter {label}: ");
                input = Console.ReadLine();
                if (!validator(input))
                    Console.WriteLine(message);
            } while (!validator(input));

            return input;
        }

        public static void PromptUntilMatch(Func<string,string, bool> validator, string password)
        {
            string confirmPassword;
            do
            {
                Console.Write("Confirm Password: ");
                confirmPassword = Console.ReadLine();

                if (!validator(password, confirmPassword))
                    Console.WriteLine("Passwords don't match. Try again.");


            } while (!validator(password, confirmPassword));

        }

    }
}
