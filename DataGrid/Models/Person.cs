using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid.Models
{
    public class Person
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string PhoneNumber { get; set; }

        public Person()
        {
            
        }
        public Person(int code, string name, string family, string phoneNumber)
        {
            Code = code;
            Name = name;
            Family = family;
            PhoneNumber = phoneNumber;
        }
    }
}
