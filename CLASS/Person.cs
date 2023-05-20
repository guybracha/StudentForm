using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentForm.CLASS
{
    public abstract class Person
    {
        private string name;
        private int age;
        private int id;

        public Person(string name, int age, int id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }
    }
}
