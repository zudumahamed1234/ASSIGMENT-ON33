using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASS_ASSIGMENT
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
        
            private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Creating Variables
            string customerName;
            double previousReading;
            double currentReading;

            double pricePerUnit;
            double fixedcharge;
            double usage;
            double energyCost;
            double tax;
            
            double totalBill;

            // Assigning Variables
            customerName = txtCustomer.Text;
            previousReading = double.Parse(txtPrevious.Text);
            currentReading = double.Parse(txtCurrent.Text);
            pricePerUnit = double.Parse(txtUnitPrice.Text);
            fixedcharge = 5.00;

            // Calculating Variables
            usage = currentReading - previousReading;
            energyCost = usage * pricePerUnit;
            tax = energyCost * 0.07;
            totalBill = energyCost + tax + fixedcharge;

            // Displaying Output
            txtUsage.Text = usage.ToString();
            txtTax.Text = "$" + tax.ToString("0.00");
            txtTotal.Text = "$" + totalBill.ToString("0.00");
        }
    }
    }
    
