using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemester.Clear();
            lbloutput.Text = "  ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studentname = txtname.Text;

            int studentid = int.Parse(txtstudentid.Text);

            string department = txtdepartment.Text;

            int semester = int.Parse(txtsemester.Text);

            string allinformation = studentname + " " + studentid + " " + department + " " + semester;

            lbloutput.Text = allinformation;

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this close
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
