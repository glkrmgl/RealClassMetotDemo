using System;

namespace RealClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.Name = "Sezai";
            customer1.LastName = "Karakoç";
            customer1.IdentityNumber = 12345;
            customer1.City = "Diyarbakır";
            

            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.Name = "Fuat";
            customer2.LastName = "Sezgin";
            customer2.IdentityNumber = 123456;
            customer2.City = "Bitlis";

            Customer customer3 = new Customer();
            customer3.CustomerId = 3;
            customer3.Name = "Rasim";
            customer3.LastName = "Özdenören";
            customer3.IdentityNumber = 1234567;
            customer3.City = "Kahramanmaraş";

            Customer[] customers = new Customer[]
            {
                customer1,customer2,customer3
            };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer2);
            //customerManager.Listele(customer3);

            foreach (var c in customers)
            {
                customerManager.Listele(c);
                
            }

        }
    }
}
