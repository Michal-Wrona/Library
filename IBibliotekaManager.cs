using System;
using System.Collections.Generic;
using System.Text;

namespace Bibkioteka1
{
    interface IBibliotekaManager
    {
        Books1 GetBooks(string name);

        People GetPeople(string name, string surname);

        void BorrowBook(string bookName, string peopleName, string peopleSurname);

        void BorrowBook(Books1 book, People people);
    }
}
