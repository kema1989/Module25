using System;
using System.Linq;

namespace Module25
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppContext())
            {
                var user1 = new User { Name = "Arthur", Role = "Admin" };
                var user2 = new User { Name = "Bob", Role = "Admin" };
                var user3 = new User { Name = "Clark", Role = "User" };
                var user4 = new User { Name = "Dan", Role = "User" };

                var user1Creds = new UserCredential { Login = "ArthurL", Password = "qwerty123", User = user1 };
                var user2Creds = new UserCredential { Login = "BobJ", Password = "asdfgh585", User = user2 };
                var user3Creds = new UserCredential { Login = "ClarkK", Password = "111zlt777", User = user3 };
                var user4Creds = new UserCredential { Login = "DanE", Password = "zxc333vbn", User = user4 };

                db.Users.AddRange(user1, user2, user3, user4);

                db.UserCredentials.AddRange(user1Creds, user2Creds, user3Creds, user4Creds);

                db.SaveChanges();
            }
        }
    }
}
