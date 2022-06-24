using InterfacesDemo.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo.Business.Abstract
{
    public abstract class BaseCustomerManager 
    {
        protected CustomerDal customerDal;
        public void Save(Customer customer)
        {
            customerDal.Create(customer);
            Console.WriteLine(customer.FirstName + " saved to database");
        }
       
    }
}
