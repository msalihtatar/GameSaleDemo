using System;
using System.Collections.Generic;
using System.Text;
using GameSaleDemo.Entities;
namespace GameSaleDemo.Abstract
{
    public interface IPersonCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
