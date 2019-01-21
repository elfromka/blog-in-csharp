using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blogClassLibrary
{
    internal class UsersService
    {
        private List<User> users;
        private int nextUserId = 1;

        public UsersService()
        {
            this.users = new List<User>();
            AddUser("elfromka@yahoo.co.uk", "Orsolya", "Sebestyen", new DateTime(1994, 01, 01));
        }

        public User AddUser(string eMail, string firstName, string lastName, DateTime birthDate)
        {
            User user = new User(nextUserId++, firstName, lastName, birthDate);
            this.users.Add(user);
            return user;
        }
    }
    
}
