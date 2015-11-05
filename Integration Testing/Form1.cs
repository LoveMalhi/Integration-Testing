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



        private void Form1_Load(object sender, EventArgs e)
        {

        }



        public static int findage(int tday, int dob)
        {
            tday = DateTime.Today.Year;

            int age = tday - dob; // CurrentYear - BirthDate

            return age;

        }
        public static void checkage(int age)
        {
            if (age > 21)
            {
                MessageBox.Show("Alcohol in USA");
            }
            else
            {
                MessageBox.Show("Alcohol is not permitted");
            }
        }
      
    
        private void button1_Click(object sender, EventArgs e)
        {
            int tday = DateTime.Today.Year;
            int dob = Convert.ToInt32(textBox1.Text);
            tb1.Text = findage(tday, dob).ToString();

        }


    }
}