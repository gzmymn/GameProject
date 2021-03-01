using GameProject.Abstract;

namespace GameProject.Entities
{
    public class Game : IEntity
    {
        //Oyun özellikleri
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string GameType { get; set; }
        public int GamePrice { get; set; }
    }
}
