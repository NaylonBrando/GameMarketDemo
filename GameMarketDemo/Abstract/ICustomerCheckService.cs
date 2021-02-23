using GameMarketDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketDemo.Abstract
{
    interface ICustomerCheckService
    {
        bool CheckPerson(Customer customer);
    }
}
