using StudentForm.CLASS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
            bool isNameValid = CheckNameValidity(studentName);
            List<string> names2 = new List<string>();
            /*
            int age = int.Parse(Age.Text);
            bool legalAge = Check_age(age);
            int studentNumber = int.Parse(INFO.Text);
            bool goodStudent = Check_ave(studentNumber);
            */
            if (isNameValid)
            {
                // String[] names = { "guy", "avi", "alon", "moshe" };
                isNameValid = false;
                for (int i = 0; i < names2.Count; i++)
                {
                    if (names2[i].Equals(studentName))
                    {
                        isNameValid = true; break;
                    }
                }
            }
            if (isNameValid)
            {
                MessageBox.Show("Hello " + studentName);
            } else
            {
                MessageBox.Show("Sorry, you're not registered");
            }
            /*
            if (legalAge)
            {
                MessageBox.Show("You're Adult");
            } else
            {
                MessageBox.Show("You're a minor");
            }

            if (goodStudent)
            {
                MessageBox.Show("You're a great student");
            } else
            {
                MessageBox.Show("You need to get better");
            }
             */
        }

        private bool CheckNameValidity(string name)
        {
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            addName();
        }

        private void addName()
        {
            String addTitle = "add";
            List<string> names2 = new List<string>();
            MessageBoxButtons butt = MessageBoxButtons.YesNo;
            String question = "Do you want to add this name " + Student_Name.Text + " to the array?";
            DialogResult result = MessageBox.Show(question, addTitle, butt);
            if (result == DialogResult.Yes)
            {
                names2.Add(Student_Name.Text);
                Console.WriteLine(string.Join(", ", names2));
            }
            else
            {
                MessageBox.Show("Adding was canceled");
            }
        }
    }
}
