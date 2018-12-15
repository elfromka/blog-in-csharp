﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blogClassLibrary
{
    class User
    {
        public int Id;
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        private DateTime BirthDate;
        public string EmailAdress { get; private set; }
    }
}
