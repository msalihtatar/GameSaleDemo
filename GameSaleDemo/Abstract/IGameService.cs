using System;
using System.Collections.Generic;
using System.Text;
using GameSaleDemo.Entities;
namespace GameSaleDemo.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
    }
}
