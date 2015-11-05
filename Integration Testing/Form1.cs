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


       
        public static int findage(int tday,int dob)
        {
            tday = DateTime.Today.Year;
         
            int age = tday-dob; // CurrentYear - BirthDate

            return age;
           
        }
        public static void checkage(int age)
        {
            if (age > 18)
            {
                MessageBox.Show( "Alcohol in Canada Permitted");
            }
            else
            {
                MessageBox.Show("Alcohol in Canada Permitted");
            }
        }
        public static void calculate(int age)
        {
            if (age > 16)
            {
                MessageBox.Show("Alcohol in Germany Permitted");
            }
            else
            {
                MessageBox.Show("Alcohol in Germany Permitted");
            }
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            int tday = DateTime.Today.Year;
            int dob = Convert.ToInt32(tb1.Text);
            textBox1.Text = findage(tday, dob).ToString();
        }

     
    }
}
