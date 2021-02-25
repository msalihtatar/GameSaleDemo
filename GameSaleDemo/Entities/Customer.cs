using GameSaleDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Entities
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string NationalityID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateofBirthYear { get; set; }
    }
}
