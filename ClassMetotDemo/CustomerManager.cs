using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.FirstName + " isimli müşterinin kaydı yapılmıştır");
        }

        public void CustomerListing(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.FirstName + " " + customer.TcNo);

        }

        public void Delete(Customer customer )
        {
            Console.WriteLine(customer.Id + " numaralı müşterinin kaydı silinmiştir");
        }
    }
}
