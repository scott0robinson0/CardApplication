using System;
using System.Collections.Generic;
using System.Text;

namespace CardApplication
{
    public class Address
    {
        public string Street { get; set; }
        private int _houseno;
        public int HouseNo 
        { 
            get { return this._houseno; }
            set 
            {
                if (value > 0)
                {
                    this._houseno = value;
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
