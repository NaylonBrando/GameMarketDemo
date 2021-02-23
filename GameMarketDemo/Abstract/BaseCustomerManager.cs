using System;
using System.Collections.Generic;
using System.Text;
using GameMarketDemo.Entities;

namespace GameMarketDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public virtual void Delete(Customer customer)
        {
            Console.WriteLine("Kullanıcı Silindi!");
        }

        public virtual void Update(Customer customer)
        {
            Console.WriteLine("Kullanıcı Bilgileri Güncellendi!");
        }
        public virtual void ShowCustomer()
        {
            
        }
    }
}
