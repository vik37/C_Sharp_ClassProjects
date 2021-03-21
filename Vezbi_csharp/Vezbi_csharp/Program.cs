using System;
using Vezbi_csharp.korisnik_class;

namespace Vezbi_csharp
{

    class Program
    {
        static void Main(string[] args)
        {
            

            Korisnik korisnik1 = new Korisnik();
            Korisnik korisnik2 = new Korisnik("Nikola","Gorgiev");
            Korisnik novKorisnik = new Korisnik("Viktor", "Zafirovski", 1982);

            korisnik1.Pecati();
            korisnik2.Pecati();
            novKorisnik.Pecati();
            Console.ReadLine();
        }
    }
}
