namespace StudentForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.Student_Name.Location = new System.Drawing.Point(67, 76);
            this.Student_Name.Name = "Student_Name";
            this.Student_Name.Size = new System.Drawing.Size(164, 76);
            this.Student_Name.TabIndex = 0;
            this.Student_Name.Text = "NAME";
            // 
            // IMG
            // 
            this.IMG.Location = new System.Drawing.Point(579, 76);
            this.IMG.Name = "IMG";
            this.IMG.Size = new System.Drawing.Size(147, 76);
            this.IMG.TabIndex = 1;
            this.IMG.Text = "IMG";
            // 
            // INFO
            // 
            this.INFO.Location = new System.Drawing.Point(68, 230);
            this.INFO.Name = "INFO";
            this.INFO.Size = new System.Drawing.Size(259, 96);
            this.INFO.TabIndex = 2;
            this.INFO.Text = "INFO";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(599, 230);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(100, 96);
            this.Age.TabIndex = 3;
            this.Age.Text = "AGE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "StudentUp";
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(305, 365);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(216, 63);
            this.Check.TabIndex = 5;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.INFO);
            this.Controls.Add(this.IMG);
            this.Controls.Add(this.Student_Name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Student_Name;
        private System.Windows.Forms.RichTextBox IMG;
        private System.Windows.Forms.RichTextBox INFO;
        private System.Windows.Forms.RichTextBox Age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Check;
    }
}

