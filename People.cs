using System;
using System.Collections.Generic;
using System.Text;

namespace Bibkioteka1
{
    class People
    {
        public string firstName;
        public string lastName;
        public int pesel;
        public int id;

        public People (string FirstName, string LastName, int Pesel, int ID)
        {
            firstName = FirstName;
            lastName = LastName;
            pesel = Pesel;
            id = ID;
        }
    }
}
