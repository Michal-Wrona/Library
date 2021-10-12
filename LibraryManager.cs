using System;
using System.Collections.Generic;
using System.Text;

namespace Bibkioteka1
{
    class LibraryManager
    {
        private BooksManager booksManager;
        private Printer _printer;

        public LibraryManager()
        {
            booksManager = new BooksManager();
            _printer = new Printer();
        }

        private void MenuLibrary() //tutaj private żeby nie można było zmienić
        {
            Console.Clear();
            Console.WriteLine("1 - Sprawdź dostępność książki");
            Console.WriteLine("2 - Wyświetl liste książek");
            Console.WriteLine("3 - Dodaj nową książkę");
            Console.WriteLine("4 - Zakończ");
        }

        public void Run() // ta metoda udostępnia Menu- public
        {
            int choice;
            do
            {
                MenuLibrary();
                choice = SelectionAction();
            } while (choice == 0);
        }

        private int SelectionAction()
        {
            Console.Write("Wybierz: ");
            string choice = Console.ReadLine();
            return int.Parse(choice);
        }
    }
}
