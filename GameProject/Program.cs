using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //OYUN OLUŞTURMA
            Game game1 = new Game();
            game1.GameId = 1;
            game1.GameName = "Sky Soldier";
            game1.GamePrice = 300;
            game1.GameType = "War";
            
            GameManager gameManager1 = new GameManager();
            //OYUN EKLEME
            gameManager1.Add(game1);
            //OYUN SİLME
            gameManager1.Delete(game1);
            //OYUN GÜNCELLEME
            gameManager1.Update(game1);


            //OYUNCU OLUŞTURMA
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "Gizem Kübra";
            gamer1.LastName = "Yaman";
            gamer1.BirthYear = 1994;
            gamer1.NationalityId = 11122334455;

            //OYUNCU METOTLARI İÇİN KİMLİK DOĞRULAMA YAPMAMIZ GEREKLİ
            GamerManager gamerManager1 = new GamerManager(new MernisServiceAdapter());
            //OYUNCU EKLEME
            gamerManager1.Add(gamer1);
            //OYUNCU SİLME
            gamerManager1.Delete(gamer1);
            //OYUNCU GÜNCELLEME
            gamerManager1.Update(gamer1);


            //KAMPANYA OLUŞTURMA
            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 1;
            campaign1.CampaignName = "March opportunity";
            campaign1.DiscountRate = 50;
            campaign1.StartDate = new DateTime(2021, 3, 1);
            campaign1.EndDate = new DateTime(2021, 3, 15);

            CampaignManager campaignManager1 = new CampaignManager();
            //KAPMANYA EKLEME
            campaignManager1.Add(campaign1);
            //KAMPANYA SİLME
            campaignManager1.Delete(campaign1);
            //KAMPANYA GÜNCELLEME
            campaignManager1.Update(campaign1);


            //SATIŞ İŞLEMLERİ
            SalesManager salesManager = new SalesManager();
            //STANDART SATIŞ
            salesManager.StandartSales(game1, gamer1);
            //KAMPANYALI SATIŞ
            salesManager.CampaignSales(game1, gamer1, campaign1);






        }
    }
}
