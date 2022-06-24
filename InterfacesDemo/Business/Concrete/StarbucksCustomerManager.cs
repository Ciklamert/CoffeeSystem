using InterfacesDemo.Business.Abstract;
using InterfacesDemo.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo.Business.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager, ICustomerManager
    {
        private ICheckService _checkService;
        
        public StarbucksCustomerManager(ICheckService checkService)
        {
            _checkService = checkService;
            this.customerDal = new StarbucksCustomerDal();
        }

        public void Register(Customer customer)
        {
            if (_checkService.CheckIfRealPerson(customer))
            {
                Console.WriteLine(customer.FirstName + " registered");
                Save(customer);
            }
            else
            {
                Console.WriteLine(customer.FirstName + " cannot be registered. Please enter a real person.");
            }
            
        }
        public void Sale(Customer customer)
        {
            customer.StarNumber += 1;
            customerDal.Update(customer);
            Console.WriteLine(customer.FirstName + " bought the coffee");
        }
    }
}
