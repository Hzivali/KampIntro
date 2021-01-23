using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.TcNo = "14578964522";
            customer1.Name = "Hakan";
            customer1.FirstName = "Zıvalı";
            
            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.TcNo = "77854964123";
            customer2.Name = "Muhammet Mustafa";
            customer2.FirstName = "Zıvalı";
            
            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.TcNo = "25485298732";
            customer3.Name = "Ozan Arif";
            customer3.FirstName = "Zıvalı";


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.CustomerListing(customer2);
            customerManager.Delete(customer3);
        }
    }
}
