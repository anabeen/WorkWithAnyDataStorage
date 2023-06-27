using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithAnyDataStorage.Data
{
    public class Employee : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(string firstName, string lastName) 
        { 
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString() => $"ID: {ID} FirstName: {FirstName}, LastName: {LastName}";

    }

}
