using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibkioteka1
{
    class BooksManager
    {
        private IList<Books1> _books1; // czy tutaj tworzymy nową listę, ale jeszcze bez obiektów? Dlaczego IList? nie List?

        public BooksManager()
        {
           _books1 = new List<Books1>(); // dlaczego to w konstruktorze ?? 


        }
        //new BooksManager().Init().Add(new Books1())

        //public void Init()
        //{
        //    _books1 = new List<Books1>();
        //}

        //public void Add(Books1 book)
        //{
        //    _books1.Add(book);
        //}

        public IEnumerable<Books1> GetAllBooks() // zwraca wszystkie obiekty z listy, ale jak? co daje to IEnumerable?
        {
            return _books1;
        }

        private int GenerateId()
        {
            int id = 1;

            if (_books1.Any())
            {
                id = _books1.Max(x => x.id) + 1; // co to za x ?? i to co za odwłoanie x.id ?? bo rozumiem, że to => znaczy po prostu tyle co zmień???
            }
            return id;
        }
        public Books1 CreateNewBook(string Autor, string Nazwa)
        {
            int id = GenerateId();
            Books1 book = new Books1(Autor, Nazwa, id);
            _books1.Add(book);
            return book;
        }
        //public Books1 GetBook(string bookNazwa) // tu nie wiem jak przekonwertować bookNazwa na obiekt book
        //{
        //    Books1 book;
        //    foreach (Books1 item in _books1)
        //    {
        //        if(item.nazwa == bookNazwa)
        //        {
        //            book = bookNazwa;
        //            break;
        //        }
        //    }
        //    return book;
        //}
        public bool GetBook1 (string nameBook) // zwraca true jeśli nazwa książki jest na liście _books1
        {
            foreach (Books1 nazwa in _books1)
            {
                if (nazwa.nazwa == nameBook) break;
            }
            string a = "jest";
            return true; // jak przekonwertować true na string a ??
        }

    }
}
