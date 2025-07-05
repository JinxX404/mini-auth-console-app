using Authentication_and_Authorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Authentication_and_Authorization.Helpers
{
    internal class AuthHelper
    {

        
        public static string HashPassword(string password)
        {
            var sha256 = SHA256.Create();
            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }

        public static bool VerifyPassword(string input, string storedHash)
        {
            var inputPassHash = HashPassword(input);

            return inputPassHash.Equals(storedHash);

        }

    }
}
