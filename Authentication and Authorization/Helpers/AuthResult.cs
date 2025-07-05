using Authentication_and_Authorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication_and_Authorization.Helpers
{
    internal class AuthResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public User? user { get; set; }

    }
}
