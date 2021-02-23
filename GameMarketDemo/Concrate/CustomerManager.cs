using System;
using System.Collections.Generic;
using System.Text;
using GameMarketDemo.Abstract;
using GameMarketDemo.Entities;

namespace GameMarketDemo.Abstract
{
    class CustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheck)
        {
            _customerCheckService = customerCheck;
        }

        public override void Add(Customer customer)
        {
            if (_customerCheckService.CheckPerson(customer))
            {

            }
            else
            {
                Console.WriteLine("Not a valid person ");
            }

            base.Add(customer);
        }
        public override void Delete(Customer customer)
        {
            base.Delete(customer); 
        }
        public override void ShowCustomer()
        {
           
        }

    }
}
