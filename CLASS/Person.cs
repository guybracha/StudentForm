using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentForm.CLASS
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
        public string Address { get; set; }

        public Person(string name, int age, int id, string address)
        {
            Name = name;
            Age = age;
            Id = id;
            Address = address;
        }
    }
}
