using System;
using System.Collections.Generic;
using System.Text;

namespace RealClassMetotDemo
{
    class CustomerManager
    {
       public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri eklendi !" + " : " + customer.Name + " " +customer.LastName);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri silindi !" + " : " + customer.Name + " " + customer.LastName);
        }
        public void Listele(Customer customer)
        {
            Console.WriteLine(" Müşteriler Listelendi !  :  " + customer.Name + " " + customer.LastName);
        }
    }
}
