using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void frmStudentRegistration_Load(object sender, EventArgs e)
        {
       
            for (int days = 1; days <= 31; days++)
            {
                comboBox1.Items.Add(days);
            }
            for (int year = DateTime.Now.Year; year >= 1900; year--)
            {
                comboBox2.Items.Add(year);
            }
            string[] months = {"January", "February", "March", "April", "May", "June",
                               "July", "August", "September", "October", "November", "December"};

            ArrayList course = new ArrayList()
            {
                "Bachelor of Science in Computer Science",
                "Bachelor of Science in Information Technology",
                "Bachelor of Science in Information Systems",
                "Bachelor of Science in Computer Engineering"
            };

            foreach (string month in months)
            {
                comboBox3.Items.Add(month);
            }

            foreach (string programs in course)
            {
               comboBox4.Items.Add(programs);
            }
        }

    

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void registerStudent_Click(object sender, EventArgs e)
        {
            if (female.Checked)
            {
                MessageBox.Show("Student Name: " + textBox3.Text + " " + textBox2.Text + " " + textBox1.Text + "\nGender : Female\nDate Of Birth :" + comboBox3.Text + " / "
               + comboBox1.Text + " / " + comboBox2.Text + " \nProgram :" + comboBox4.Text);
            }
            else if (male.Checked)
            {
                MessageBox.Show("Student Name: " + textBox3.Text + " " + textBox2.Text + " " + textBox1.Text + "\nGender : Male\nDate Of Birth :" + comboBox3.Text + " / "
               + comboBox1.Text + " / " + comboBox2.Text + " \nProgram :" + comboBox4.Text);
            }


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }

}