using GameProject.Abstract;
using System;

namespace GameProject.Entities
{
    public class Campaign : IEntity 
    {
        //Kampanya özellikleri
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public int DiscountRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
