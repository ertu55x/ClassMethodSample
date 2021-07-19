using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Costumer costumer1 = new Costumer();
            costumer1.Id = 55;
            costumer1.FirstName = "Ertuğ";
            costumer1.LastName = "Gül";

            Costumer costumer2 = new Costumer();
            costumer2.Id = 34;
            costumer2.FirstName = "Ertuğrul";
            costumer2.LastName = "Güllüoğlu";

            Costumer costumer3 = new Costumer();
            costumer3.Id = 54;
            costumer3.FirstName = "Ertan";
            costumer3.LastName = "Güllü";

            Costumer[] costumers = new Costumer[] { costumer1, costumer2, costumer3 };

            foreach (Costumer costumer in costumers)
            {
                Console.WriteLine(costumer.FirstName + " " + " => " + costumer.LastName + " " + "=>" + " " + costumer.Id);
            }
            Console.WriteLine("------------------------");
            CostumerManager musteriManager = new CostumerManager();
            musteriManager.Read(costumer1);
            musteriManager.Read(costumer2);
            musteriManager.Read(costumer3);
            Console.WriteLine("Müşteriler Listelendi");
            Console.WriteLine("------------------------");
            musteriManager.Add(costumer1);
            Console.WriteLine("------------------------");
            musteriManager.Delete(costumer3);

            Console.ReadKey();
        }
    }
}
