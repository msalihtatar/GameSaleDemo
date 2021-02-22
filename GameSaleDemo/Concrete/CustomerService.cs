using System;
using System.Collections.Generic;
using System.Text;
using GameSaleDemo.Entities;
using GameSaleDemo.Abstract;

namespace GameSaleDemo.Concrete
{
    public class CustomerService: BaseCustomerManager
    {
        private IPersonCheckService _personCheckService;
        public CustomerService(IPersonCheckService personcheckService)
        {
            _personCheckService = personcheckService;
        }
        public override void Save(Customer customer)
        {
            if (_personCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("not a valid person");
            }
        }
    }
}
