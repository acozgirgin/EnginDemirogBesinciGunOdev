using BesinciGunOdevler2.Abstract;
using BesinciGunOdevler2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesinciGunOdevler2.Concrete
{
    public class PlayerCheckManager : IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player playerToCheck)
        {
            return true; // Mernis service calismazsa kullanabilecegimiz method
        }
    }
}
