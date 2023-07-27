using BesinciGunOdevler2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesinciGunOdevler2.Abstract
{
    public interface IGameDBService
    {
        void Save(Game newGame);
        void ListGames();
        Game FindCheapestGame();

        Game FindTheMostExpensiveGame();

    }
}
