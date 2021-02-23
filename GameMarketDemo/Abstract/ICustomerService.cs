using System;
using System.Collections.Generic;
using System.Text;
using GameMarketDemo.Entities;

namespace GameMarketDemo.Abstract
{
    interface ICustomerService
    {
        public void Add(Customer customer);
        public void Delete(Customer customer);
        public void Update(Customer customer);
    }
}
