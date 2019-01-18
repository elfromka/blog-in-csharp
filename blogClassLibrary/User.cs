using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blogClassLibrary
{
    public class User : Person
    {
        public int Id { get; private set; }

        public User(int id, string eMail, string firstName, string lastName, DateTime birthDate) : base(eMail, firstName, lastName, birthDate)
        {
            this.Id = id;
        }
    }
}
