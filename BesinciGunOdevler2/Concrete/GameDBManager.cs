using BesinciGunOdevler2.Abstract;
using BesinciGunOdevler2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesinciGunOdevler2.Concrete
{
    public class GameDBManager : BaseGameDBManager
    {


        public override void Save(Game newGame)
        {
            Console.WriteLine("Game saved to DB.");
            base.Save(newGame);
        }

      



    }
}
