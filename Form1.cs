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
        private readonly Person person;
        private readonly Student student;

        public Form1()
        {
            InitializeComponent();
        }

        private Student GetStudent()
        {
            return student;
        }

        private void Form1_Load(object sender, EventArgs e, Student student)
        {
            string name = Student_Name.Text;
            int age = int.Parse(Age.Text);
            int studentNumber = int.Parse(INFO.Text);
            student = new Student(studentNumber, 1, 2023, 85, name, age, 1, "");  // Provide default values for id and address

            DisplayPersonInfo();
            DisplayStudentInfo();
        }

        private void DisplayPersonInfo()
        {
            // Assuming you have a RichTextBox control named "INFO"
            INFO.Text = $"Name: {person.Name}" +
                        Environment.NewLine +
                        $"Age: {person.Age}" +
                        Environment.NewLine +
                        $"ID: {person.Id}" +
                        Environment.NewLine +
                        $"Address: {person.Address}";
        }

        private void DisplayStudentInfo()
        {
            // Assuming you have a RichTextBox control named "Student_Name"
            Student_Name.Text = $"Student Name: {student.Name}" +
                                Environment.NewLine +
                                $"Student Number: {student.Number}" +
                                Environment.NewLine +
                                $"Year: {student.Year}" +
                                Environment.NewLine +
                                $"Grade Average: {student.GradeAverage}";
        }
    }
}
