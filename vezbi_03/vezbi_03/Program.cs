using System;

namespace vezbi_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string korisnickoIme = "";
            string lozinka = "";

           
            do
            {
                Console.WriteLine("___________");
                Console.WriteLine("Vnesete go vaseto korisnicko ime");
                korisnickoIme = Console.ReadLine();
                

                Console.WriteLine("Vnesete ja vasata lozinka");
                lozinka = Console.ReadLine();
                Console.WriteLine("___________");
            } while (korisnickoIme != "admin" || lozinka != "123456");
            char[] userCharachter = korisnickoIme.ToCharArray();
            char[] passCharachter = lozinka.ToCharArray();
            var login = new []{ userCharachter, passCharachter};
            int countPass = 0;
            int countUs = 0;
            char usEl;
            char pasEl;
            
            while (true)
            {

                Array.Resize(ref login, login.Length + 1);
                usEl = userCharachter[countUs];
                pasEl = passCharachter[countPass];
                
                if(login.Length == countPass)
                {
                    break;
                }
                countUs++;
                countPass++;
            }

            foreach (var userName in login)
            {
                Console.WriteLine(userName);
            }
            //foreach (var pass in passCharachter)
            //{
            //    Console.WriteLine(pass);
            //}
            Console.ReadLine();
        }
    }
}
