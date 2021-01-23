using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " isimli müşterinin kaydı yapılmıştır");
        }

        public void CustomerListing(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + customer.TcNo);

        }

        public void Delete(Customer customer )
        {
            Console.WriteLine(customer.Id + " numaralı müşterinin kaydı silinmiştir");
        }
    }
}
