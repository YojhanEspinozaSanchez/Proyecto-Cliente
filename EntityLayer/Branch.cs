using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BranchAdmin Admin { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool Active { get; set; }

        public Branch() { }

        public Branch(int id, string name, BranchAdmin admin, string address, string phoneNumber, bool active)
        {
            Id = id;
            Name = name;
            Admin = admin;
            Address = address;
            PhoneNumber = phoneNumber;
            Active = active;
        }

    }
}
