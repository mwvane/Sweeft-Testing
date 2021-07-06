using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetTesting
{
    public class MyDataStructure
    {
        private Dictionary<int,Person> Data { get; set; }
        public MyDataStructure()
        {
            Data = new Dictionary<int, Person>();
            Person p1 = new Person()
            {
                ID = 1,
                Firstname = "ani",
                Lastname = "birtvelishvili",
                Age = 25,
                Gender = Gender.Female,
            };
            Data.Add(p1.ID, p1);
            Person p2 = new Person()
            {
                ID = 2,
                Firstname = "giorgi",
                Lastname = "shatakishvili",
                Age = 21,
                Gender = Gender.Male,
            };
            Data.Add(p2.ID, p2);
            Person p3 = new Person()
            {
                ID = 3,
                Firstname = "nuci",
                Lastname = "zoziashvili",
                Age = 25,
                Gender = Gender.Female,
            };
            Data.Add(p3.ID, p3);

        }
        public bool RemoveAt(int id)
        {
            if (Data.ContainsKey(id))
            {
                Data.Remove(id);
                return true;
            }
            return false;
        }
    }
}
