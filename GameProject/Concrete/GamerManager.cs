using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService //Sen bir IGamerService'sin. Bu alanda kimlik doğrulaması yapmamız gerekiyor.
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Oyuncu eklendi : " + " " + gamer.FirstName + " " + gamer.LastName);
            }
            else
            {
                Console.WriteLine("KİMLİK DOĞRULAMASI BAŞARISIZ!");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silindi : " + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            if (_userValidationService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Oyuncu güncellendi : " + " " + gamer.FirstName + " " + gamer.LastName);
            }
            else
            {
                Console.WriteLine("GÜNCELLENEMEDİ! KİMLİK DOĞRULAMASI BAŞARISIZ!");
            }
        }
    }
}
