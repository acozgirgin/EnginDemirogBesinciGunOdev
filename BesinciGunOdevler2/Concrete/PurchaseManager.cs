using BesinciGunOdevler2.Abstract;
using BesinciGunOdevler2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesinciGunOdevler2.Concrete
{
    public class PurchaseManager
    {

        private IGameDBService _gameDBService;
        public PurchaseManager(IGameDBService gameDBService)
        {
            this._gameDBService = gameDBService;   
        }


        public void AddCheapestGameToUserWallet(Player player)
        {

            // Adds the chepest game to players vault from the game DB.

            player.GameWallet.Add(_gameDBService.FindCheapestGame()); // adds the cheapest game to users game wallet.

        }

        public void AddTheMostExpensiveGameToUserWallet(Player player)
        {

            // Adds the chepest game to players vault from the game DB.

            player.GameWallet.Add(_gameDBService.FindTheMostExpensiveGame()); // adds the cheapest game to users game wallet.

        }


    }
}
