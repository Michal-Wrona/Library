using System;
using System.Collections.Generic;

namespace Bibkioteka1
{
    class Program
    {
        static void Main(string[] args)
        {
            BooksManager manager = new BooksManager();

            manager.CreateNewBook ("Henryk Sienkiewicz", "Potop");
            manager.CreateNewBook("Czesław Miłosz", "Wiersze wybrane");
            manager.CreateNewBook("Adam Mickiewicz", "Dziady");

            IList<Books1> books = (IList < Books1 >) manager.GetAllBooks(); // tego totalnie nie rozumiem, wiem tylko że robimy to po to żeby skorzystać z klasy Printer
            Printer Print = new Printer();
            Print.Print(books[0]);
        }
    }
}
