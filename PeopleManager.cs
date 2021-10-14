using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Bibkioteka1
{
    class PeopleManager
    {
        private List<People> _people;
        public PeopleManager()
        {
            _people = new List<People>(); 
        }

        public People CreateNewPeople (string FirstName, string LastName, int Pesel)
        {
            int id = GenerateId();
            People people = new People(FirstName,LastName,Pesel,id);
            _people.Add(people);
            return people;
        }

        public int GenerateId()
        {
            int id = 1;
            if (_people.Any())
            {
                id = _people.Max(n => n.id + 1);
            }
            return id;
        }

        public List<People> GetAllPeople()
        {
            return _people;
        }
    }
}
