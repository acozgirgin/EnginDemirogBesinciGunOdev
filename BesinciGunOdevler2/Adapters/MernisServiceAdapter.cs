using BesinciGunOdevler2.Abstract;
using BesinciGunOdevler2.Entities;
using BesinciGunOdevler2.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesinciGunOdevler2.Adapters
{
    public class MernisServiceAdapter : IPlayerCheckService
    {
      
        //Service adapter kullanırız , servicede herhangi bir sıkıntı oldugu zaman bu kod parçasına bağımlı kalmamak icin

        public bool CheckIfRealPerson(Player playerToCheck)
        {
            MernisServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient();

            return client.TCKimlikNoDogrula(playerToCheck.TcNo, playerToCheck.PlayerFirstName.ToUpper(), playerToCheck.PlayerLastName.ToUpper(), Convert.ToInt32(playerToCheck.YearOfBirth));

        }
    }
}
