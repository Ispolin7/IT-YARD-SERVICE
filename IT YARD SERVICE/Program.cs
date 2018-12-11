using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_YARD_SERVICE
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new User("First", "password");
            var user2 = new User("And", "BOOster!");
            var testUser = new User("Test", "test");
            var repo = new UserRepository();
            repo.Insert(user1);
            repo.Insert(user2);
            repo.Insert(testUser);

            repo.GetById(testUser._id);
            repo.DisplayUserInfo(testUser._id);
            repo.Update(testUser._id, "update", "update");
            repo.DisplayUserInfo(testUser._id);
            repo.Delete(testUser._id);

            /*var users = repo.All();
            foreach(var user in users)
            {
                user.DisplayInfo();
                user.DisplayPassword();
            }*/

            Console.ReadKey();
        }
    }
}
