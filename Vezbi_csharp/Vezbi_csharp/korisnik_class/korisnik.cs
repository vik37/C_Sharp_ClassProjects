using System;
using System.Collections.Generic;
using System.Text;
using Vezbi_csharp;

namespace Vezbi_csharp.korisnik_class
{
    class Korisnik
    {
        public string ime;
        public string prezime;
        public int godinaNaRaganje;
        public Korisnik()
        {
            Console.WriteLine("Konstruktor - korisnik 0");
        }
        public Korisnik(string _ime, string _prezime)
        {
            Console.WriteLine("Konstruktor - korisnik 1");
            ime = _ime;
            prezime = _prezime;
        }
        public Korisnik(string _ime, string _prezime, int _godinaNaRaganje)
        {
            Console.WriteLine("Konstruktor - korisnik 2");
            ime = _ime;
            prezime = _prezime;
            godinaNaRaganje = _godinaNaRaganje;
        }

        private string ImeIPrezime()
        {
            return ime + " " + prezime;
        }
        private int Godini()
        {
            int _godini = 2020 - godinaNaRaganje;
            return _godini;
        }

        public void Pecati()
        {
            Console.WriteLine("------------");
            Console.WriteLine("Ime i Prezime: " + ImeIPrezime());
            Console.WriteLine("Godini {0}", Godini());
            Console.WriteLine("------------");
        }
       
    }
}
