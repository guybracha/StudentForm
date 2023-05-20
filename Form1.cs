using StudentForm.CLASS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentForm
{
    public partial class Form1 : Form
    {
        private Student student;
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayPersonInfo(Person person)
        {
            // Code to display person information
        }

        private void DisplayStudentInfo(Student student)
        {
            // Code to display student information
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studentName = Student_Name.Text;
            // Rest of your code
        }

        // Other methods and event handlers

        private void PrintButton_Click(object sender, EventArgs e)
        {
            string name = Student_Name.Text;
            int age = int.Parse(Age.Text);
            int studentNumber = int.Parse(INFO.Text);
            student.Name = name;
            student.Age = age;
            student.Number = studentNumber;

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}
