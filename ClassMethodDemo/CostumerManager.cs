using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CostumerManager
    {
        public void Add(Costumer costumer)
        {
            Console.WriteLine(costumer.FirstName + " " + costumer.LastName + " " + costumer.Id);
            Console.WriteLine("Müşteri Eklendi!");
        }

        public void Read(Costumer costumer)
        {
            Console.WriteLine(costumer.FirstName + " " + costumer.LastName + " " + costumer.Id);
        }

        public void Delete(Costumer costumer)
        {
            Console.WriteLine(costumer.FirstName + " " + costumer.LastName + " " + costumer.Id);
            Console.WriteLine("Müşteri Silindi.");
        }
    }
}
