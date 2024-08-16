using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Person
    {
        public int SystemId { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string FirstLastName { get; set; }
        public string SecondLastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime EntryDate { get; set; }

        public Person() { }

        public Person(int systemId, string id, string name, string firstLastName, string secondLastName, DateTime birthDate, DateTime entryDate)
        {
            SystemId = systemId;
            Id = id;
            Name = name;
            FirstLastName = firstLastName;
            SecondLastName = secondLastName;
            BirthDate = birthDate;
            EntryDate = entryDate;
        }
    }
}