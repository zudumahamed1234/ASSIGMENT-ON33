using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSIGMENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            txtdayoftheWeek.Text = "";

            txtdayofthemonth.Clear();

            txtdayofthenumeric.Text = string.Empty;

            txtyear.Text = string.Empty;

            lbldatoutput.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            string DayoftheWeek, Month, Day, Year, FullDate;

           

            DayoftheWeek = txtdayoftheWeek.Text;

            Month = txtdayofthemonth.Text;

            Day = txtdayofthenumeric.Text;

            Year = txtyear.Text;

            
            FullDate = DayoftheWeek +Month + "" + Day + "," + Year;

            

            lbldatoutput.Text = FullDate;
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
