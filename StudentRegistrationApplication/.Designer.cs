namespace StudentRegistrationApplication
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.registerStudent = new System.Windows.Forms.Button();
            this.studentRegistrationForm = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.middleName = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.dateOfBirth = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(71, 157);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 26);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Helvetica", 12F);
            this.textBox2.Location = new System.Drawing.Point(71, 104);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 26);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Helvetica", 12F);
            this.textBox3.Location = new System.Drawing.Point(71, 51);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(233, 26);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Font = new System.Drawing.Font("Helvetica", 12F);
            this.male.Location = new System.Drawing.Point(114, 266);
            this.male.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(66, 23);
            this.male.TabIndex = 3;
            this.male.TabStop = true;
            this.male.Text = "Male ";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Font = new System.Drawing.Font("Helvetica", 12F);
            this.female.Location = new System.Drawing.Point(190, 266);
            this.female.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(81, 23);
            this.female.TabIndex = 4;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            this.female.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Helvetica", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(162, 212);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(59, 27);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Day";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Helvetica", 12F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(231, 212);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(73, 27);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.Text = "Year";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Helvetica", 12F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(71, 212);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(74, 27);
            this.comboBox3.TabIndex = 7;
            this.comboBox3.Text = "Month";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // registerStudent
            // 
            this.registerStudent.BackColor = System.Drawing.Color.Crimson;
            this.registerStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerStudent.Font = new System.Drawing.Font("Helvetica", 12F);
            this.registerStudent.ForeColor = System.Drawing.Color.White;
            this.registerStudent.Location = new System.Drawing.Point(109, 349);
            this.registerStudent.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.registerStudent.Name = "registerStudent";
            this.registerStudent.Size = new System.Drawing.Size(157, 30);
            this.registerStudent.TabIndex = 8;
            this.registerStudent.Text = "Register Student";
            this.registerStudent.UseVisualStyleBackColor = false;
            this.registerStudent.Click += new System.EventHandler(this.registerStudent_Click);
            // 
            // studentRegistrationForm
            // 
            this.studentRegistrationForm.AutoSize = true;
            this.studentRegistrationForm.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentRegistrationForm.Location = new System.Drawing.Point(67, 9);
            this.studentRegistrationForm.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.studentRegistrationForm.Name = "studentRegistrationForm";
            this.studentRegistrationForm.Size = new System.Drawing.Size(255, 19);
            this.studentRegistrationForm.TabIndex = 9;
            this.studentRegistrationForm.Text = "STUDENT REGISTRATION FORM";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(144, 28);
            this.lastName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(102, 19);
            this.lastName.TabIndex = 10;
            this.lastName.Text = "Last Name *";
            this.lastName.Click += new System.EventHandler(this.label2_Click);
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold);
            this.firstName.Location = new System.Drawing.Point(144, 81);
            this.firstName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(102, 19);
            this.firstName.TabIndex = 11;
            this.firstName.Text = "First Name *";
            // 
            // middleName
            // 
            this.middleName.AutoSize = true;
            this.middleName.Location = new System.Drawing.Point(132, 134);
            this.middleName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(119, 19);
            this.middleName.TabIndex = 12;
            this.middleName.Text = "Middle Name *";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(157, 243);
            this.gender.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(78, 19);
            this.gender.TabIndex = 13;
            this.gender.Text = "Gender *";
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.AutoSize = true;
            this.dateOfBirth.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold);
            this.dateOfBirth.Location = new System.Drawing.Point(133, 189);
            this.dateOfBirth.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(118, 19);
            this.dateOfBirth.TabIndex = 14;
            this.dateOfBirth.Text = "Date Of Birth *";
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Helvetica", 12F);
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(12, 315);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(356, 27);
            this.comboBox4.TabIndex = 15;
            this.comboBox4.Text = "Select Program";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 293);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Programs To Apply *";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(373, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.middleName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.studentRegistrationForm);
            this.Controls.Add(this.registerStudent);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmStudentRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button registerStudent;
        private System.Windows.Forms.Label studentRegistrationForm;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label middleName;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label dateOfBirth;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label1;
    }
}

