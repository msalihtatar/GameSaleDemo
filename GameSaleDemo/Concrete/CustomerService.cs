using System;
using System.Collections.Generic;
using System.Text;
using GameSaleDemo.Entities;
using GameSaleDemo.Abstract;

namespace GameSaleDemo.Concrete
{
    public class CustomerService: ICustomerService
    {
        private IPersonCheckService _personCheckService;
        public CustomerService(IPersonCheckService personcheckService)
        {
            _personCheckService = personcheckService;
        }
        public void Save(Customer customer)
        {
            if (_personCheckService.CheckIfRealPerson(customer))
            {
                Console.WriteLine("Doğrulama başarılı. Kaydedildi.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kaydedilemedi.");
            }
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer is Deleted");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Your informations is updated.");
        }
    }
}
