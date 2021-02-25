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
            if (customer.NationalityID == "1234567890" && customer.DateofBirthYear == "1991")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
