using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Domains
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;

        public User()
        {
            
        }

        public User(int id, string login, string password)
        {
            Id = id;
            Login = login;
            Password = password;
        }
    }
}
