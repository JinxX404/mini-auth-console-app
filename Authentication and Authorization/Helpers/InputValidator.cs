using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Authentication_and_Authorization.Helpers
{
    internal class InputValidator
    {

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;

            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public static bool IsStrongPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password)) return false;

            return password.Length >= 6;
        }
        public static bool IsValidUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username)) return false;

            return username.Length >= 3 && username.Length <= 20 &&
                   Regex.IsMatch(username, @"^[a-zA-Z0-9_]+$");
        }

        public static bool IsPasswordMatch(string password, string confirmPassword)
        {
            return password.Equals(confirmPassword);
        }

    }
}
