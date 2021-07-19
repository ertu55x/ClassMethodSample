using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CostumerManager
    {
        public void Ekleme(Costumer costumer)
        {
            Console.WriteLine(costumer.FirstName + " " + costumer.LastName + " " + costumer.Id);
            Console.WriteLine("Müşteri Eklendi!");
        }

        public void Listeleme(Costumer costumer)
        {
            Console.WriteLine(costumer.FirstName + " " + costumer.LastName + " " + costumer.Id);
        }

        public void Silme(Costumer costumer)
        {
            Console.WriteLine(costumer.FirstName + " " + costumer.LastName + " " + costumer.Id);
            Console.WriteLine("Müşteri Silindi.");
        }
    }
}
