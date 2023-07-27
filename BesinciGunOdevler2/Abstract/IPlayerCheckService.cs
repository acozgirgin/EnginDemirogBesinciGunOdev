using BesinciGunOdevler2.Adapters;
using BesinciGunOdevler2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesinciGunOdevler2.Abstract
{


    public interface IPlayerCheckService
    {
        bool CheckIfRealPerson(Player playerToCheck);


    }
}
