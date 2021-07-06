using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetTesting
{
    public class Person
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public byte Age { get; set; }
        public Gender Gender { get; set; }

    }
    public enum Gender
    {
        Male,
        Female
    }
}
