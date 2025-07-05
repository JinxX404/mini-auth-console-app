using Authentication_and_Authorization.Helpers;
using Authentication_and_Authorization.Models;

namespace Authentication_and_Authorization.Services
{
    internal class AuthService
    {
        private AppDbContext context;

        public AuthService(AppDbContext context)
        {
            this.context = context;
        }

        public AuthResult Login(string email, string password)
        {

            var existingUser = context.Users.FirstOrDefault(u => u.Email == email);

            if (existingUser == null)
            {
                return new AuthResult
                {
                    Success = false,
                    Message = "❌ Email not found. Please register."
                };
            }


            if (!AuthHelper.VerifyPassword(password, existingUser.PasswordHash))
            {
                return new AuthResult
                {
                    Success = false,
                    Message = "Login failed, Invalid Password."
                };

            }
            return new AuthResult
            {
                Success = true,
                Message = $"Login successful! welcome back {existingUser.Username}. \nYour role is {existingUser.Role}",
                user = existingUser
            };

        }

        public AuthResult Register(string email, string username, string password)
        {

            var existingUser = context.Users.FirstOrDefault(u => u.Email == email);

            if (existingUser != null)
            {
                return new AuthResult
                {
                    Success = false,
                    Message = "❌ Email already exists. Try logging in."
                };
            }


            User user = new User { Email = email, Username = username, PasswordHash = AuthHelper.HashPassword(password), Role = Roles.User };

            try
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                return new AuthResult
                {
                    Success = false,
                    Message = "⚠️ Failed to save user: " + ex.Message
                };
            }


            return new AuthResult
            {
                Success = true,
                Message = "✅ New User Added\n✅ Registration Successful",
                user = user
            };


        }

    }
}
