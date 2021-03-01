using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ISalesService //Standart ve kampanyalı satış için kullanılacak metotlar
    {
        void StandartSales(Game game, Gamer gamer);
        void CampaignSales(Game game, Gamer gamer, Campaign campaign);
    }
}
