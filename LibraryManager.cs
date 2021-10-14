using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Bibkioteka1
{
    class LibraryManager
    {
        private BooksManager booksManager; // dlaczego tutaj deklaruje się klasę ? czy tylko dlatego by można odwoływać się do jej metod ?
        private Printer printer;
        private PeopleManager peopleManager;

        public LibraryManager()
        {
            booksManager = new BooksManager();
            peopleManager = new PeopleManager();
            printer = new Printer();
        }

        private void MenuLibrary() //tutaj private żeby nie można było zmienić
        {
            Console.Clear();
            Console.WriteLine("1 - Sprawdź dostępność książki");
            Console.WriteLine("2 - Wyświetl liste książek");
            Console.WriteLine("3 - Dodaj nową książkę");
            Console.WriteLine("4 - Zobacz wypożyczenia");
            Console.WriteLine("5 - Dodaj nowego użytkownika");
            Console.WriteLine("6 - Sprawdź listę wszystkich użytkowników");
            Console.WriteLine("8 - Zakończ program");
        }

        public void Run() // ta metoda udostępnia Menu- public
        {
            int choice;
            do
            {
                MenuLibrary();
                choice = SelectionAction();

                switch (choice) // dlaczego po naciśnięciu enter przełącza na visuala i wskazuje wiersz 86 ? 
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
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Dodaj nowego użytkownika");
                        AddUsser();
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Wyświetl wszystkich użytkowników");
                        ListOfPeople();
                        Console.ReadKey();
                        break;
                    defult:
                        Console.WriteLine("nieznane polecenie");
                        break;
                }

            } while (choice != 8);
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

        private void AddUsser()
        {
            Console.WriteLine("Imię: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Nazwisko: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Podaj nr pesel: ");
            int pesel = int.Parse(Console.ReadLine());
            People people = peopleManager.CreateNewPeople(firstName, lastName, pesel); // co tu jest nie tak ?
        }

        private void ListOfPeople()
        {
            foreach (People usser in peopleManager.GetAllPeople()) // to dla mnie niezbyt jasne
            {
                Console.WriteLine(usser.id);
                Console.WriteLine(usser.firstName + " " + usser.lastName);
                Console.WriteLine();
            }
        }
    }

}
