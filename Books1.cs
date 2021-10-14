using System;
using System.Collections.Generic;
using System.Text;

namespace Bibkioteka1
{
    class Books1
    {
        public string autor { get; } // czy tutaj get ma jakieś logiczne zastosowanie ??
        public string nazwa;
        public int id;

        public Books1(string Autor, string Nazwa, int ID)
        {
            autor = Autor;
            nazwa = Nazwa;
            id = ID;
        }
        public Books1() // konstruktor używany w klasie Loans, czy nie zepsuje opcji dodawania książek ??
        {

        }
    }
}
