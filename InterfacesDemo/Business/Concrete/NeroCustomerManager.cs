using InterfacesDemo.Business.Abstract;
using InterfacesDemo.DataAccess.Abstract;
using InterfacesDemo.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo.Business.Concrete
{
    public class NeroCustomerManager :BaseCustomerManager, ICustomerManager
    {
       public NeroCustomerManager()
        {
            this.customerDal = new NeroCustomerDal();
        }

        public void Register(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " registered");
            
            Save(customer);
        }

        public void Sale(Customer customer)
        {
            customerDal.Update(customer);
            Console.WriteLine(customer.FirstName + " bought the coffee");
        }
    }
}
