using InterfacesDemo.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    public class Customer :IEntity
    {
        public Customer(int ıd, string firstName, string lastName, string nationalityId, int birthYear)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            NationalityId = nationalityId;
            BirthYear = birthYear;
            StarNumber = 0;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public int BirthYear { get; set; }
        public int StarNumber { get; set; }
    }
}
