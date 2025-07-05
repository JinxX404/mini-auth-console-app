using Authentication_and_Authorization.ConsoleUI;
using Authentication_and_Authorization.Models;
using Authentication_and_Authorization.Services;
using System.Security.Cryptography;
using System.Text;

namespace Authentication_and_Authorization
{
    internal class Program
    {

        static void Main(string[] args)
        {

            AppDbContext context = new AppDbContext();
            AuthService authService = new AuthService(context);
            AuthConsoleUI ui = new AuthConsoleUI(authService);
            ui.Run();
           

        }

        
    }
}
