using System;
using System.Collections.Generic;
using System.Text;

namespace CardApplication
{
    public class Address
    {
        public string street { get; set; }
        public int HouseNo 
        { 
            get { return HouseNo; }
            set 
            {
                if (value > 0)
                {
                    HouseNo = value;
                }
                else
                {
                    throw new Exception("The house number must be greater than 0.");
                }
            }
        }
        public string Postcode { get; set; }

        public Address() { }
    }
}
