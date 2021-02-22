using System;
using System.Collections.Generic;
using System.Text;
using GameSaleDemo.Entities;
namespace GameSaleDemo.Concrete
{
    public class GameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " is added");
        }
        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " is deleted");
        }
    }
}
