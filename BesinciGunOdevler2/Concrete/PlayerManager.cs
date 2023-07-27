using BesinciGunOdevler2.Abstract;
using BesinciGunOdevler2.Adapters;
using BesinciGunOdevler2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesinciGunOdevler2.Concrete
{
    class PlayerManager : BasePlayerManager
    {
        //BasePlayerManager abstract clasını inherit ediyor

        private IPlayerCheckService _playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            //Mernis service referansıyla input verirsek mernis service calisir
            //PlayerCheckManager reference ile input verirsek kendi yazdığımız method çalışır.
            _playerCheckService = playerCheckService;
        }


        public override void Save(Player player)
        { 
            //Saves the player if the identifaction informations are true 
            //Checks the informations using Mernis Service 

            if(_playerCheckService.CheckIfRealPerson(player) ) // check the information that provided from player
            {
                base.Save(player);
            }
            else
            {
                throw new Exception("Player could not found.");

            }
        }


    }
}
