using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool CheckIfRealPerson(Gamer gamer) //Kimlik doğrulaması yapıldığında true dönmesi için 
        {
            return true;
        }
    }
}
