using BesinciGunOdevler2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesinciGunOdevler2.Abstract
{
    public abstract class BasePlayerManager : IPlayerManagerService
    {
        public List<Game> ListUserGameWallet(Player player)
        {
            //checks the games that user owns 
            if (player.GameWallet.Count != 0)
            {
                Console.WriteLine("\n\n\nPlayer: "+player.PlayerFirstName+ "'s game list:");
                foreach (var game in player.GameWallet)
                {

                    Console.WriteLine(game.GameName); 
                }

             // returns list the games that player owns
                return player.GameWallet; 
            }

            else
            {
                throw new Exception("Player does not have any games !. ");
            }

        }


        //virtual fonksiyonu 
        public virtual void Save(Player player)
        {
            //Simulation for save the player to the database
            Console.WriteLine("Saved to db." +player.PlayerFirstName);
        }


    }
}
