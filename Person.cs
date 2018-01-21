using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int studentAge { get; set; }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }
    }
}
