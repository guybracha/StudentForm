using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentForm.CLASS
{
    public class Student : Person
    {
        public int Number { get; set; }
        public int Year { get; set; }
        public double GradeAverage { get; set; }
        public int Status { get; set; }

        public Student(int number, int status, int year, int gradeLevel, string name, int age, int id, string address)
            : base(name, age, id, address)
        {
            Number = number;
            Status = status;
            Year = year;
            GradeAverage = gradeLevel;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Student otherStudent = (Student)obj;

            return base.Equals(obj) &&
                Number == otherStudent.Number &&
                Status == otherStudent.Status &&
                Year == otherStudent.Year &&
                GradeAverage == otherStudent.GradeAverage;
        }

        public override int GetHashCode()
        {
            return Number.GetHashCode() ^ Status.GetHashCode() ^ Year.GetHashCode() ^ GradeAverage.GetHashCode();
        }
    }
}
