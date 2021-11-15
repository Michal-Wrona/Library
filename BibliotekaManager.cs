using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Bibkioteka1
{
    class BibliotekaManager : IBibliotekaManager
    {
        public Books1 GetBooks(string name)
        {
            using (var bibliotekaDbContext = new BibliotekaDbContext(Connection.ConnectionString))
            {
                var book = bibliotekaDbContext.Books1s.Single(x => x.NAME == name);
                bibliotekaDbContext.SaveChanges();

                return book;
            }
        }

        public People GetPeople(string name, string surname)
        {
            using (var bibliotekaDbContext = new BibliotekaDbContext(Connection.ConnectionString))
            {
                var people = bibliotekaDbContext.Peoples.Single(x => x.Name == name && x.Surname == name);
                bibliotekaDbContext.SaveChanges();

                return people;
            }
        }

        public void BorrowBook(string bookName, string peopleName, string peopleSurname)
        {
            using(var bibliotekaDbContext = new BibliotekaDbContext(Connection.ConnectionString))
            {
                var book = bibliotekaDbContext.Books1s.Single(x => x.NAME == bookName);
                var people = bibliotekaDbContext.Peoples.Single(x => x.Name == peopleName && x.Surname == peopleSurname);

                bibliotekaDbContext.BookBorrowings.Add(new BookBorrowings { Book = book, Peoplee = people });
                bibliotekaDbContext.SaveChanges();
            }
        }

        public void BorrowBook(Books1 book, People people)
        {
            using (var bibliotekaDbContext = new BibliotekaDbContext(Connection.ConnectionString))
            {
                bibliotekaDbContext.Attach(book);
                bibliotekaDbContext.Attach(people);

                bibliotekaDbContext.BookBorrowings.Add(new BookBorrowings { Book = book, Peoplee = people });
                bibliotekaDbContext.SaveChanges();
            }
        }
    }
}
