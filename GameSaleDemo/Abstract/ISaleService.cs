using System;
using System.Collections.Generic;
using System.Text;
using GameSaleDemo.Entities;

namespace GameSaleDemo.Abstract
{
    public interface ISaleService
    {
        void Sale(Customer customer, Game game, Campaign campaign);
    }
}
