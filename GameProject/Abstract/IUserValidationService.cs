using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IUserValidationService //Kimlik doğrulama servisi
    {
        bool CheckIfRealPerson(Gamer gamer); //Oyuncuların gerçek kişiler olup olmadıklarını kontrol etmek için
    }
}
