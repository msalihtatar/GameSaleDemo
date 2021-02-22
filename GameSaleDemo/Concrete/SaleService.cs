using System;
using System.Collections.Generic;
using System.Text;
using GameSaleDemo.Entities;
namespace GameSaleDemo.Concrete
{
    public class SaleService
    {
        public void Sale(Customer customer, Game game, Campaign campaign)
        {
            Console.WriteLine(game.GameName + ", was sold to " + customer.FirstName + " using " + campaign.CampaignName + " campaign for " + (game.GamePrice - campaign.Discount) + " TL.");
        }
    }
}
