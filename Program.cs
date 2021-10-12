using System;
using System.Collections.Generic;

namespace Bibkioteka1
{
    class Program
    {
        static void Main(string[] args)
        {
            BooksManager manager = new BooksManager(); // jhgkgkjhkhv

            manager.CreateNewBook ("Henryk Sienkiewicz", "Potop");
            manager.CreateNewBook("Czesław Miłosz", "Wiersze wybrane");
            manager.CreateNewBook("Adam Mickiewicz", "Dziady");

            IEnumerable<Books1> books = manager.GetAllBooks();
            Printer printer = new Printer();
            foreach (Books1 book in books)
            {
                printer.Print(book);
            }

            Console.WriteLine(manager.GetBook1("Potop"));

            //IList<Books1> books = (IList < Books1 >) manager.GetAllBooks(); // tego totalnie nie rozumiem, wiem tylko że robimy to po to żeby skorzystać z klasy Printer
            //Printer Print = new Printer();
            //Print.Print(books[0]);
        }
    }
}
