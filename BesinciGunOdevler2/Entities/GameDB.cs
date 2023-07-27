using BesinciGunOdevler2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesinciGunOdevler2.Entities
{
    class GameDB
    {

        public List<Game> GamesList;
        public GameDB()
        {  // holds the cames from the in the list like a DB

        GamesList = new List<Game>();

        }

    }
}
