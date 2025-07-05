using Authentication_and_Authorization.Helpers;
using Authentication_and_Authorization.Services;

namespace Authentication_and_Authorization.ConsoleUI
{
    internal class AuthConsoleUI
    {

        AuthService authService;

        public AuthConsoleUI(AuthService service)
        {
            this.authService = service;
        }

        public void Run()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1. Register\n2. Login\n3. Exit");
                Console.Write("Choose an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": HandleRegister(); break;
                    case "2": HandleLogin(); break;
                    case "3": return;
                    default: Console.WriteLine("❌ Invalid choice."); break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

            }

        }

        private void HandleRegister()
        {
            Console.WriteLine("--------> User Registration <--------");

            string email = ConsoleHelper.PromptUntilValid("Email", InputValidator.IsValidEmail, "❌ Invalid email format.");
            string username = ConsoleHelper.PromptUntilValid("Username", InputValidator.IsValidUsername, "❌ Invalid username. Use only letters, numbers, or _");
            string password = ConsoleHelper.PromptUntilValid("Password", InputValidator.IsStrongPassword, "❌ Password too weak. Must be at least 6 characters.");
            ConsoleHelper.PromptUntilMatch(InputValidator.IsPasswordMatch, password); ;


            var result = authService.Register(email, username, password);

            Console.WriteLine(result.Message);
        }


        private void HandleLogin()
        {
            Console.WriteLine("--------> User Login <--------");

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            var result = authService.Login(email, password);

            Console.WriteLine(result.Message);
        }





    }
}
