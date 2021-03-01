using GameProject.Abstract;
using GameProject.Entities;
using KPSService;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    public class MernisServiceAdapter : IUserValidationService //Mernis bilgileri ile girilen bilgilerin karşılaştırıldığı alan
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(gamer.NationalityId, gamer.FirstName, gamer.LastName, gamer.BirthYear).Result;
            bool check = result.Body.TCKimlikNoDogrulaResult;
            return check;

        }
    }
}
