using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private int gradeLevel;

        public Student(int student_number, int status, int year, int gradeLevel, string name, int age, int id, string address)
            : base(name, age, id, address)
        {
            this.student_number = student_number;
            this.status = status;
            this.year = year;
            this.gradeLevel = gradeLevel;
        }

        public int Number { get { return student_number; } set { this.student_number = value; } }
        public int Year { get { return this.year; } set { this.year = value; } }
        public int GradeAverage { get { return gradeLevel; } set { gradeLevel = value; } }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Student otherStudent = (Student)obj;

            return base.Equals(obj) &&
                student_number == otherStudent.student_number &&
                status == otherStudent.status &&
                year == otherStudent.year &&
                gradeLevel == otherStudent.gradeLevel;
        }

        public override int GetHashCode()
        {
            return student_number.GetHashCode() ^ status.GetHashCode() ^ year.GetHashCode() ^ gradeLevel.GetHashCode();
        }
    }
}