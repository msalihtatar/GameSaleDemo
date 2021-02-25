using System;
using System.Collections.Generic;
using System.Text;
using GameSaleDemo.Abstract;
using GameSaleDemo.Entities;
namespace GameSaleDemo.Concrete
{
    public class CampaignService: ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " is added to campaigns");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " is deleted from campaigns");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " is updated");
        }
    }
}
