using System;
using System.Collections.Generic;
using System.Text;
using GameMarketDemo.Abstract;

namespace GameMarketDemo.Entities
{
    class Campaign:IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        List<string> Publisher = new List<string>();
        List<string> Category = new List<string>();
        public short DiscountPercent { get; set; }
        public DateTime DateOfStart { get; set; }
        public DateTime DateOfEnd { get; set; }






    }
}
