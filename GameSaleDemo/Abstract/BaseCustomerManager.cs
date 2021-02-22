using GameSaleDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer is Deleted");
        }

        public virtual void Save(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " is saved to database");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Your informations is updated.");
        }
    }
}
