﻿using System;
using GameSaleDemo.Abstract;
using GameSaleDemo.Entities;
using GameSaleDemo.Concrete;

namespace GameSaleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerService customerService = new CustomerService(new PersonCheckService());
            Customer customer = new Customer { NationalityID = "1234567890", DateofBirthYear = "1991", FirstName = "SALİH", LastName = "TATAR" };
            customerService.Save(customer);            

            GameService gameService = new GameService();
            Game game = new Game { GameId = "1452", GameName = "Witcher 3", GamePrice = 120 };
            gameService.Add(game);

            CampaignService campaignService = new CampaignService();
            Campaign campaign = new Campaign { CampaignId = "1234", CampaignName = "Black Friday", Discount = 60 };
            campaignService.Add(campaign);

            SaleService saleService = new SaleService();
            saleService.Sale(customer, game, campaign);
        }
    }
}
