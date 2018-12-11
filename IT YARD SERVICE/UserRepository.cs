using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_YARD_SERVICE
{
    class UserRepository
    {
        public static Dictionary<Guid, User> _users = new Dictionary<Guid, User>();

        public User[] All()
        {
            return _users.Values.ToArray();
        }

        public void Insert(User user)
        {
            _users.Add(user._id, user);
        }

        public User GetById(Guid id)
        {
            User currentUser = null;
            if (_users.ContainsKey(id))
            {
                _users.TryGetValue(id, out currentUser);
                Console.WriteLine("GetById +");
            }
            return currentUser;
        }

        public bool Delete(Guid id)
        {
            if (_users.ContainsKey(id))
            {
                Console.WriteLine("Delete +");
                return _users.Remove(id);
            }
            return false;
            
        }

        public void DisplayUserInfo(Guid id)
        {
            User user = GetById(id);
            if (user != null)
            {
                user.DisplayInfo();
                user.DisplayPassword();
            }            
        }

        public bool Update(Guid id, string name, string password)
        {
            User user = GetById(id);
            if (user != null)
            {
                user._username = name;
                user._password = Cryptographer.Encrypt(password);
                _users[user._id] = user;
                Console.WriteLine("Update +");
                return true;
            }
            return false;           
        }
    }
}
