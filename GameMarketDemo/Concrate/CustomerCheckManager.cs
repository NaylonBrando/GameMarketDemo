using System;
using System.Collections.Generic;
using System.Text;
using GameMarketDemo.Abstract;
using GameMarketDemo.Entities;

namespace GameMarketDemo.Concrate
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckPerson(Customer customer)
        {
            return true;
        }
    }
}
