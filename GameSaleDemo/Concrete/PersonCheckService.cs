using System;
using System.Collections.Generic;
using System.Text;
using GameSaleDemo.Abstract;
using GameSaleDemo.Entities;

namespace GameSaleDemo.Concrete
{
    public class PersonCheckService : IPersonCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
