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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student student = new Student(123, 1, 2023, 85, "John Doe", 20, 1, "123 Main St");

            // Display the student details in a MessageBox
            MessageBox.Show(student.ToString());
        }
    }
}
