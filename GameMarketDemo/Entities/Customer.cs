using System;
using System.Collections.Generic;
using System.Text;
using GameMarketDemo.Abstract;

namespace GameMarketDemo.Entities
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string TcNo { get; set; }

        
        
    }
}
