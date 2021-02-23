using System;
using System.Collections.Generic;
using System.Text;
using GameMarketDemo.Abstract;
using GameMarketDemo.Entities;

namespace GameMarketDemo.Concrate //Müsterinin kayıt olabileceği, bilgilerini güncelleyebileceği ve kaydını silebileceği bölüm.
{
    class CustomerSelfRegister : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public CustomerSelfRegister(ICustomerCheckService customerCheck)
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
        public override void Update(Customer customer)
        {
            base.Update(customer);
        }
        public override void Delete(Customer customer)
        {
            base.Delete(customer);
        }
    }
}
