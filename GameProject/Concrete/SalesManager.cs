using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class SalesManager : ISalesService
    {
        public void CampaignSales(Game game, Gamer gamer, Campaign campaign)
        {
            int campaignPrice = game.GamePrice - ((game.GamePrice * campaign.DiscountRate) / 100); //Kampanyalı fiyat hesaplama

            Console.WriteLine(game.GameName + "oyunu" + campaign.StartDate + "tarihinde başlayıp" + campaign.EndDate + "tarihinde bitecek olan" +
                campaign.CampaignName + " kampanyası ile %" + campaign.DiscountRate + " indirimle " +
                gamer.FirstName + " " + gamer.LastName + " tarafından " + " - "+  campaignPrice + " TL'ye satın alınmıştır." + '\n');
        }

        public void StandartSales(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName + " " + "oyunu" + " " + gamer.FirstName + gamer.LastName + "tarafından" + " " + game.GamePrice + "Tl'ye satın alınmıştır." + '\n');
        }
    }
}
