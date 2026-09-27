using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showdata_Click(object sender, EventArgs e)
        {
            string dayofweek, month, dayofmonth, year, showdata;
            dayofweek = txtdayofweek.Text;
            month=txtnamemonth.Text;
            dayofmonth = txtdaymonth.Text;
            year = txtyear.Text;
            showdata = dayofweek + "" + month + "" + dayofmonth + "" + year;
            dateoutlabel.Text = showdata;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtdayofweek.Clear();
            txtnamemonth.Clear();
             txtdaymonth.Clear();
            txtyear.Clear();
            dateoutlabel.Text = " ";


        }
    }
}
