using BesinciGunOdevler2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesinciGunOdevler2.Abstract
{
    public abstract class BaseGameDBManager : IGameDBService
    {
        private GameDB _gameDB = new GameDB();

        public virtual void Save(Game newGame)
        {

            Console.WriteLine("Game :"+newGame.GameName+" ID: "+newGame.GameID+" saved to db.");
            _gameDB.GamesList.Add(newGame); // games saved to game list db.
        }

        public void ListGames()
        {
            // Method with filled body will be used inherited from GameDBManager

            if (_gameDB.GamesList.Count != 0)
            {
                Console.WriteLine("Games contained in the GamesDB: ");
                foreach (var game in _gameDB.GamesList)
                {

                    Console.WriteLine(game.GameName);

                }

            }

            else
            {
                throw new Exception("Game data base is empty.");

            }
        }

        public Game FindCheapestGame()
        {

            // finds the game with lowest price and returns the game object

            double minPrice = _gameDB.GamesList[0].GamePrice; // default value of the mininmum price 
            int indexOfGame = 0;
            int actualIndex = 0;

            foreach(var game in _gameDB.GamesList)
            {
                if (game.GamePrice < minPrice)
                {
                    minPrice = game.GamePrice; // defines the new minimum priced game
                    actualIndex = indexOfGame;
                }
                indexOfGame++;

            }

            Console.WriteLine("Game with minimum price is "+_gameDB.GamesList[actualIndex].GameName+ " price is  {0} dollars ", _gameDB.GamesList[actualIndex].GamePrice);
            return _gameDB.GamesList[actualIndex]; 

        }

        public Game FindTheMostExpensiveGame()
        {
            double maxPrice = _gameDB.GamesList[0].GamePrice; // default value of the maximum price 
            int indexOfGame = 0;
            int actualIndex = 0;

            foreach (var game in _gameDB.GamesList)
            {
                if (game.GamePrice > maxPrice)
                {
                    maxPrice = game.GamePrice; // defines the new maximum priced game
                    actualIndex = indexOfGame;
                }
                indexOfGame++;

            }

            Console.WriteLine("Game with minimum price is " + _gameDB.GamesList[actualIndex].GameName + " price is  {0} dollars ", _gameDB.GamesList[actualIndex].GamePrice);
            return _gameDB.GamesList[actualIndex];
        }
    }
}
