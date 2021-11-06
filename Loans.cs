using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Bibkioteka1
{
    class Loans:BooksManager
    {
        private List<Books1> _books1Loans;

        private Loans()
        {
            _books1Loans = new List<Books1> ();
        }

        //public Books1 BorrowBook(int id)
        //{
        //    int ID = id;
        //    Console.WriteLine("Podaj id");
        //    Books1 borrowBook = new Books1();

        //    //var idi = _books1.Select(x => x.id);

        //    /* var idi = from book in _books1 where book.id == ID select book;*/ // to jest poprawne znalezienie obiektu book z listy _books1?

        //    //var elementPos = array.map(function(x) { return x.id; }).indexOf(idYourAreLookingFor);
        //    //var objectFound = array[elementPos];

        //    foreach (Books1 book in _books1)
        //    {
        //        if (_books1.
        //    }

        
    }
}
