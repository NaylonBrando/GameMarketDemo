using GameMarketDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketDemo.Abstract
{
    interface ICampaignService
    {
        public void AddCampaign(Campaign campaign);
        public void Delete(Campaign campaign);
        public void Update(Campaign campaign);

    }
}
