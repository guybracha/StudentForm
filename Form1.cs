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
        private Person person;
        private Student student;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string name = Student_Name.Text;
            int age = int.Parse(Age.Text);
            int studentNumber = int.Parse(INFO.Text);
            // Assuming other required fields are also present in rtbInfo

            student = new Student(studentNumber, 1, 2023, 85, name, age, 1, "");  // Provide default values for id and address

            DisplayPersonInfo();
            DisplayStudentInfo();
        }

        private void DisplayStudentInfo()
        {
            throw new NotImplementedException();
        }

        private void DisplayPersonInfo()
        {
            throw new NotImplementedException();
        }
    }
}
