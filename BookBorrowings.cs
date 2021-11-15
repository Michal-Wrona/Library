using System;
using System.Collections.Generic;
using System.Text;

namespace Bibkioteka1
{
    class BookBorrowings
    {
        public int Id { get; set; }

        public int BookId { get; set; }

        public int PeopleId { get; set; }

        public Books1 Book { get; set; }

        public People People { get; set; }


    }
}
