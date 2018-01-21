using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Address  
    {
        public string country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string address { get; set; }

        public override string ToString()
        {
            return country + " " + city + " " + street + " " + address;
        }
    }
}
