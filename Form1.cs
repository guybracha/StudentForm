using StudentForm.CLASS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            MessageBox.Show("Hello");
        }

        private void DisplayStudentInfo(Student student)
        {
            MessageBox.Show("Hello " + student.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studentName = Student_Name.Text;
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

        private void Check_Click(object sender, EventArgs e)
        {
            string studentName = Student_Name.Text;
            int age = int.Parse(Age.Text);
            bool isNameValid = CheckNameValidity(studentName);

            if (isNameValid)
            {
                // Name is valid
                MessageBox.Show("Hello " + studentName + " Age: " + age);
            }
            else
            {
                // Name is invalid
                MessageBox.Show("Name is invalid.");
            }
        }

        private bool CheckNameValidity(string name)
        {
            // Add your name validation logic here
            // For example, check if the name is not empty
            bool isValid = !string.IsNullOrEmpty(name);

            return isValid;
        }

        private void INFO_TextChanged(object sender, EventArgs e)
        {

        }

        private bool Check_age(int age)
        {
            {
                if (age > 18) {
                    return true;
                } else { return false; }
            }
        }

        private bool Check_ave(int studentNumber)
        {
            if (studentNumber >= 55) { return true; } else { return false; } }

        private void Age_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
