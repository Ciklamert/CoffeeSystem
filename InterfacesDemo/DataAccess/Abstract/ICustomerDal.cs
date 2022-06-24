using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo.DataAccess.Abstract
{
    public interface ICustomerDal
    {
        void Create(Customer customer);
        List<Customer> GetAll();
        void Update(Customer customer);
        void Delete(Customer customer);

    }
}
