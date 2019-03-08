using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperPlane
{
    public class User
    {
        private string _username;
        private string _password;
        public User(string username, string password)
        {
            this._username = username;
            this._password = password;
        }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public bool Verify()
        {
            if (_username == "Bakarit" && Password == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
