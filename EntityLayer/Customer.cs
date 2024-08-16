using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Customer : Person
    {
        public bool Active { get; set; }

        public Customer() { }
        public Customer(int systemId, string id, string name, string firstLastName, string secondLastName, DateTime birthDate, DateTime entryDate, bool active) : base(systemId, id, name, firstLastName, secondLastName, birthDate, entryDate)
        {
            Active = active;
        }

    }
}
