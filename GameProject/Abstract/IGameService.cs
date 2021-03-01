using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IGameService //Oyunlar için kullanılacak metotlar
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);

    }
}
