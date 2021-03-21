using System;
using System.Collections.Generic;
using System.Linq;
using Vezbi_svasta01.Costumerce;

namespace Vezbi_svasta01
{
    
    class Program
    {
        static void Main(string[] args)
        {

            Costumer costumer1 = new Costumer()
            {
                Id = 101,
                Name = "Mark",
                Salery = 5000
            };
            Costumer costumer2 = new Costumer()
            {
                Id = 110,
                Name = "Pam",
                Salery = 6500
            };
            Costumer costumer3 = new Costumer()
            {
                Id = 119,
                Name = "John",
                Salery = 3500
            };

            //List<Costumer> costum = new List<Costumer>();
            //costum.Add(costumer1);
            //costum.Add(costumer2);
            //costum.Add(costumer3);
            //costum.Insert(1, costumer3);

            //Dictionary<int, Costumer> DicCostum = new Dictionary<int, Costumer>();
            //DicCostum.Add(costumer1.Id, costumer1);
            //DicCostum.Add(costumer2.Id, costumer2);
            //DicCostum.Add(costumer3.Id, costumer3);

            Costumer[] costumers = new Costumer[3];
            costumers[0] = costumer1;
            costumers[1] = costumer2;
            costumers[2] = costumer3;
            Dictionary<int,Costumer> Coust = costumers.ToDictionary(c => c.Id, c => c);
            foreach (KeyValuePair<int,Costumer> co in Coust)
            {
                Console.WriteLine($"Key = {co.Key}");
                Costumer c = co.Value;
                Console.WriteLine($"Id = {c.Id} | Name = {c.Name} | Salery = {c.Salery}");
            }
            //DicCostum.Clear();

            //Console.WriteLine("Total items = {0}",DicCostum.Count(kvp => kvp.Value.Salery > 4000));
            //Console.WriteLine("Total items = {0}", DicCostum.Count);
            

            //Costumer cust;
            //if(DicCostum.TryGetValue(210, out cust))
            //{
            //    Console.WriteLine($"ID {cust.Id} Name {cust.Name} Salery {cust.Salery}");
            //}
            //else
            //{
            //    Console.WriteLine("Key is not found");
            //}

            //if (!DicCostum.ContainsKey(costumer1.Id))
            //{
            //    DicCostum.Add(costumer1.Id, costumer3);
            //}
            //if (DicCostum.ContainsKey(135))
            //{
            //    Costumer cust = DicCostum[135];
            //}
            //foreach (Costumer cust in DicCostum.Values)
            //{
            //    //Console.WriteLine(key);
            //    //Console.WriteLine($"Key = {costKeyPer.Key}" );
            //    // Costumer cust = costKeyPer.Value;
            //    Console.WriteLine("Id {0},Name {1}, Salery {2}",cust.Id, cust.Name,cust.Salery);
            //    //Console.WriteLine("---------------------------------------------");
            //}

            Console.ReadLine();
        }
    }
}
