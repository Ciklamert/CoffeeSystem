using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo.Business.Abstract
{
    public interface ICustomerManager
    {
        void Register(Customer customer);
        void Sale(Customer customer);
    }
}
