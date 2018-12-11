using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_YARD_SERVICE
{
    public class User
    {
        public Guid _id;
        public string _username;
        public string _password { get; set; }

        public User()
        {
            this._id = Guid.NewGuid();
        }

        public User(string username, string password) : this()
        {
            this._username = username;
            this._password = Cryptographer.Encrypt(password);
        }

        

        public void DisplayInfo()
        {
            Console.WriteLine($"Username - {this._username} and password - {this._password}");
        }

        public void DisplayPassword()
        {
            Console.WriteLine($"Password {this._username} - {Cryptographer.Decrypt(this._password)}");
        }
    }
}
