namespace Authentication_and_Authorization.Models
{

    internal class User
    {
        public int Id { set; get; }
        public string Username { set; get; }
        public string PasswordHash { set; get; }
        public string Email { set; get; }
        public string Role { set; get; }





    }
}
