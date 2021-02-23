using GameMarketDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketDemo.Entities
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public string CategoryId { get; set; }
        public string PublisherId { get; set; }
        public string ProductName { get; set; }
        public string Publisher { get; set; }
        public int Price { get; set; }
        public string Detalis { get; set; }
        public int UnitsInStock { get; set; }
        public double UnitPrice { get; set; }
        public bool IsCampaign { get; set; }




    }
}
