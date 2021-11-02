using System;
using System.Collections.Generic;
using System.Text;

namespace CardApplication
{
    public class Person
    {
        public Person()
        {
            Address = new Address();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }


    }
}
