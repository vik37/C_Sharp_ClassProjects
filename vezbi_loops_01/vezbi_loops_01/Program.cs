using System;

namespace vezbi_loops_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string korisnickoIme = "";
            string lozinka = "";
            do
            {
                Console.WriteLine("-----------");
                Console.WriteLine("Vnesete go vaseto korisnicko ime ");
                korisnickoIme = Console.ReadLine();

                Console.WriteLine("Vnesete ja vasata lozinka ");
                lozinka = Console.ReadLine();

                Console.WriteLine("-----------");

            }
            while (korisnickoIme != "admin" && lozinka != "1234");
            
        }
    }
}
