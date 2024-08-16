using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class BranchAdmin : Person
    {
        public BranchAdmin() { }
        public BranchAdmin(int systemId, string id, string name, string firstLastName, string secondLastName, DateTime birthDate, DateTime entryDate) : base(systemId, id, name, firstLastName, secondLastName, birthDate, entryDate)
        {
        }
    }
}
