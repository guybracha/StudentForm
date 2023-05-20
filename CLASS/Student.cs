using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentForm.CLASS
{
    public class Student : Person
    {
        private int student_number;
        private int status;
        private int year;
        private int grade_ave;

        public Student(int student_number, int status, int year, int grade_ave, string name, int age, int id, string address)
            : base(name, age, id, address)
        {
            this.student_number = student_number;
            this.status = status;
            this.year = year;
            this.grade_ave = grade_ave;
        }

        public int Number
        {
            get { return student_number; }
            set { student_number = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
    }
}