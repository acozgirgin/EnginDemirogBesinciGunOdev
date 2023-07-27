using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesinciGunOdevler2.Entities
{
    public class Player
    {

        public long TcNo { get; set; }
        public string PlayerFirstName { get; set; }
        public string PlayerLastName { get; set; }
        public int PlayerID { get; set; }

        public string YearOfBirth;

        public List<Game> GameWallet; // game list that player posses

        public Player()
        {

            this.GameWallet = new List<Game>();
        }


    }
}
