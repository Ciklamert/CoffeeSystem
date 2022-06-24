using InterfacesDemo.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo.Business.Concrete
{
    public class MernisCheckManager : ICheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
