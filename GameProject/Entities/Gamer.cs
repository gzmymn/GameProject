using GameProject.Abstract;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Gamer : IEntity
    {
        //Oyuncu özellikleri
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public long NationalityId { get; set; }

    }
}
