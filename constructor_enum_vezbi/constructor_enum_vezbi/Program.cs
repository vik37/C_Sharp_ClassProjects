using System;

namespace constructor_enum_vezbi
{
    public class Something
    {
      public string firstName;
      public string lastName;
      public int Age;
        public int a;
        public int b;
       public string MyMother;
        public int SomeLength;
        public Something()
        {

        }
       public Something(string myMother, int age)
        {
          MyMother = myMother;
            Age = age;
            
        }

      public void fullName()
        {
            Console.WriteLine($"Hallo {firstName} {lastName}");
        }
        public void sum()
        {
            int result = sum(a, b);
            Console.WriteLine(result);
        }               
        
        static int sum(int c, int d)
        {
            return c + d;
        }
        public void mom()
        {
            Console.WriteLine(MyMother + " and she is " + Age + " years old!");
        }
    }
    public enum Length
    {
        MiliMetar,
        Metar,
        CentiMetar,
        KiloMetar
    }
    class Program
    {
        static void Main(string[] args)
        {
            var something1 = new Something();
            something1.firstName = "Viktor";
            something1.lastName = "Zafirovski";
            something1.Age = 37;   
            //something1.SomeLength = Length.KiloMetar;

            something1.fullName();

            var something2 = new Something();
            something2.MyMother = "Snezana Zafirovska";
            something2.Age = 59;
            something2.mom();
            something1.a = 145;
            something1.b = 83;
            something1.sum();

            int l = (int)Length.KiloMetar;
            Console.WriteLine(l);
            Console.ReadLine();
        }
    }
}
