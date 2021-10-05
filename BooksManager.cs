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
    }
}
