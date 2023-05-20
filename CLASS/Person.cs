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
        protected string name;
        protected int age;
        protected int id;
        protected string address;

        public Person(string name, int age, int id, string address)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.address = address;
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value >= 18 && value <= 120)
                {
                    this.age = value;
                }
            }
        }

        public int Id
        {
            get { return this.id; }
        }

        public string Name
        {
            get { return this.name; }
        }

        public string Address
        {
            get { return this.address; }
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Person otherPerson = (Person)obj;

            return id == otherPerson.id;
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
    }
}
