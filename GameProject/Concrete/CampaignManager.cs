using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService //Sen bir ICampaignService'sin :)
                                                    //impelemet ettiğimizde gelen metotların içerisini istediğimiz şekilde kodlayabiliyoruz.
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi : " + campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi : " + campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi : " + campaign.CampaignName);
        }
    }
}
