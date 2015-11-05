using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integration_Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            findage(DateTime.Today.Year, dateTimePicker1.Value.Year);
        }

        private void findage(int tday,int dob)
        {
            tday = DateTime.Today.Year;
            dob = dateTimePicker1.Value.Year;
            int Age = tday-dob; // CurrentYear - BirthDate

            tb1.Text = Age.ToString();
            checkage(Age);
        }
        private void checkage(int Age)
        {
            if (Age > 18)
            {
                label2.Text = "Alcohol in Canada Permitted";
            }
            else
            {
                label2.Text = "Alcohal not permitted in canada";
            }
        }
    }
}
