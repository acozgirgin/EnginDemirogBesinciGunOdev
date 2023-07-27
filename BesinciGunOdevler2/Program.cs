using BesinciGunOdevler2.Abstract;
using BesinciGunOdevler2.Adapters;
using BesinciGunOdevler2.Concrete;
using BesinciGunOdevler2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesinciGunOdevler2
{
    class Program
    {
        static void Main(string[] args)
        {

            IPlayerCheckService playerCheckService = new MernisServiceAdapter(); // check service 
            BasePlayerManager playerManager = new PlayerManager(playerCheckService); // player management object


            //Adding players to website.
            Player newPlayer = new Player() { PlayerFirstName = "Onur", PlayerID = 1, PlayerLastName = "Temizkan", TcNo = 26494110704, YearOfBirth = "1999" };
            playerManager.Save(newPlayer);

            Player newPlayer2 = new Player() { PlayerFirstName = "Serpil Tuğçe", PlayerID = 2, PlayerLastName = "Özgirgin", TcNo = 17737854776, YearOfBirth = "2000" };
            playerManager.Save(newPlayer2);


            //gameDataBase.ListGames(); // prints the games that are stored in the GameDB
            // Game gameWithMinPricre = gameDataBase.FindCheapestGame(); // returns the game with minimum price


            // Adding games to database
            BaseGameDBManager gameDBManager = new GameDBManager();
            Game game1 = new Game() { GameID = 1, GameName="Silkroad", GamePrice = 10 }; 
            gameDBManager.Save(game1);
            Game game2 = new Game() { GameID = 2, GameName = "Fifa 2020", GamePrice = 100 };
            gameDBManager.Save(game2);
            Game game3 = new Game() { GameID = 3, GameName = "Knight Online", GamePrice = 1 };
            gameDBManager.Save(game3);
            Game game4 = new Game() { GameID = 4, GameName = "Valorant", GamePrice = 3 };
            gameDBManager.Save(game4);

            // gameDBManager.ListGames(); // list all of the games belongs to database
            // gameDBManager.FindCheapestGame(); // returns the cheapest game from the database

            PurchaseManager purchaseManager = new PurchaseManager(gameDBManager);


            // Player 1 wants to buy the cheapest game from database.


           // playerManager.ListUserGameWallet(newPlayer); // throws exception because users game list is empty
           // playerManager.ListUserGameWallet(newPlayer2); // throws exception because users game list is empty


            purchaseManager.AddCheapestGameToUserWallet(newPlayer);
            purchaseManager.AddTheMostExpensiveGameToUserWallet(newPlayer2);

            playerManager.ListUserGameWallet(newPlayer);
            playerManager.ListUserGameWallet(newPlayer2);








            Console.ReadKey();

        }
    }
}
