using System;
using System.Collections.Generic;
using System.Text;

namespace Bibkioteka1
{
    class Printer
    {
        public void Print(Books1 ID)
        {
            // jhk
            Console.WriteLine("Autor: {0}", ID.autor);
            Console.WriteLine("Tytuł: {0}", ID.nazwa);
            Console.WriteLine("ID książki= {0}", ID.id);
            Console.WriteLine();
        }
}
}
