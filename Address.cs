using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class Address
    {
        public string name;
        public string address;
        public string city;
        public string state;
        public int phone_no;

        public Address(string name, string address, string city, string state, int phone_no)
        {
            this.name = name;
            this.address = address;
            this.city = city;
            this.state = state;
            this.phone_no = phone_no;
        }
    }
}
