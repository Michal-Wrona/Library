using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Bibkioteka1
{
    class LibraryManager
    {
        private BooksManager booksManager;
        private Printer printer;

        public LibraryManager()
        {
            booksManager = new BooksManager();
            printer = new Printer();
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

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Dostępność książki(Wprowadź tytuł): ");
                        CheckBook();
                        Console.ReadKey();
                            break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Lista wszystkich książek:");
                        Console.WriteLine();
                        ListOfBooks();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Dodaj nową książkę:");
                        AddBook();
                        Console.ReadKey();
                        break;
                }

            } while (choice != 4);
        }

        private int SelectionAction()
        {
            Console.Write("Wybierz: ");
            string choice = Console.ReadLine();
            int parseChoice = int.Parse(choice);
            return parseChoice;
        }
        private void AddBook()
        {
            Console.WriteLine("Autor: ");
            string autor = Console.ReadLine();
            Console.WriteLine("Tytuł: ");
            string tytul = Console.ReadLine();

            Books1 book = booksManager.CreateNewBook(autor, tytul);
            Console.WriteLine("Dodano książkę: ");
            printer.Print(book);
        }

        private void ListOfBooks()
        {
            foreach (Books1 book in booksManager.GetAllBooks())
            {
                printer.Print(book);
            }
        }

        private void CheckBook()
        {
            Console.WriteLine("Wprowadź tytuł: ");
            string a = Console.ReadLine();

            // if(a == co tu wstawić żeby sprawdzał string a z tytułem na liście

            //var check = _books1.Select(x => x.nazwa == a);
            Console.WriteLine(booksManager.GetBook1(a));
        }
    }

}
