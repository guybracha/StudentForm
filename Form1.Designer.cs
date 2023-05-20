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
            this.SuspendLayout();
            // 
            // Student_Name
            // 
            this.Student_Name.Location = new System.Drawing.Point(50, 50);
            this.Student_Name.Name = "Student_Name";
            this.Student_Name.Size = new System.Drawing.Size(200, 25);
            this.Student_Name.TabIndex = 0;
            this.Student_Name.Text = "Student Name";
            // 
            // IMG
            // 
            this.IMG.Location = new System.Drawing.Point(300, 50);
            this.IMG.Name = "IMG";
            this.IMG.Size = new System.Drawing.Size(100, 100);
            this.IMG.TabIndex = 1;
            this.IMG.Text = "IMG";
            // 
            // INFO
            // 
            this.INFO.Location = new System.Drawing.Point(50, 100);
            this.INFO.Name = "INFO";
            this.INFO.Size = new System.Drawing.Size(200, 50);
            this.INFO.TabIndex = 2;
            this.INFO.Text = "Student Info";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(300, 150);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(100, 25);
            this.Age.TabIndex = 3;
            this.Age.Text = "Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Results:";
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(150, 195);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(75, 25);
            this.Check.TabIndex = 5;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.INFO);
            this.Controls.Add(this.IMG);
            this.Controls.Add(this.Student_Name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
    }
}

