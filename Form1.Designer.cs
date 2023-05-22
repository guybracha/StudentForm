using System;

namespace StudentForm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RichTextBox Student_Name;
        private System.Windows.Forms.RichTextBox IMG;
        private System.Windows.Forms.RichTextBox INFO;
        private System.Windows.Forms.RichTextBox Age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Check;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Student_Name = new System.Windows.Forms.RichTextBox();
            this.IMG = new System.Windows.Forms.RichTextBox();
            this.INFO = new System.Windows.Forms.RichTextBox();
            this.Age = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Check = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Student_Name
            // 
            this.Student_Name.Location = new System.Drawing.Point(95, 65);
            this.Student_Name.Name = "Student_Name";
            this.Student_Name.Size = new System.Drawing.Size(231, 53);
            this.Student_Name.TabIndex = 0;
            this.Student_Name.Text = "Student Name";
            // 
            // IMG
            // 
            this.IMG.Location = new System.Drawing.Point(345, 65);
            this.IMG.Name = "IMG";
            this.IMG.Size = new System.Drawing.Size(131, 128);
            this.IMG.TabIndex = 1;
            this.IMG.Text = "IMG";
            // 
            // INFO
            // 
            this.INFO.Location = new System.Drawing.Point(95, 115);
            this.INFO.Name = "INFO";
            this.INFO.Size = new System.Drawing.Size(231, 78);
            this.INFO.TabIndex = 2;
            this.INFO.Text = "Student Info";
            this.INFO.TextChanged += new System.EventHandler(this.INFO_TextChanged);
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(345, 165);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(131, 53);
            this.Age.TabIndex = 3;
            this.Age.Text = "Age";
            this.Age.TextChanged += new System.EventHandler(this.Age_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Results:";
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(195, 210);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(106, 53);
            this.Check.TabIndex = 5;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter name, age, and info";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 46);
            this.button2.TabIndex = 8;
            this.button2.Text = "Display list";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 363);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.INFO);
            this.Controls.Add(this.IMG);
            this.Controls.Add(this.Student_Name);
            this.Name = "Form1";
            this.Text = "StudentUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

