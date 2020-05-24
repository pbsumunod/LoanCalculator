using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibrary;

namespace LoanCalcu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Class1 myData2 = new Class1();

        public void Output(object anyObject)
        {
            if (anyObject != null)
                txtBoxResult.AppendText(anyObject + "\n");
        }


        private void btnOutput_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)

                MessageBox.Show("Select a type of car to be loan!");


            else
            {
                myData2.Type = comboBox1.Text;
            }

            myData2.Downpayment = numericUpDown1.Value;
            myData2.Years = numericUpDown2.Value;
            Output("Total Contract Price: " + myData2.ComputeTcp().ToString("#,###.00"));
            Output("Down Payment: " + myData2.ComputeDown().ToString("#,###.00"));
            {
                if (myData2.Years <= 4)
                {
                    Output("Chattel Mortgage: " + myData2.ComputeMortgage().ToString("#,###.00"));
                    Output("Insurance with Acts of God:  " + myData2.ComputeInsurance().ToString("#,###.00"));
                    Output("LTO Registration for 3 years:  " + myData2.ComputeLTO().ToString("#,###.00"));
                }
                else
                {
                    Output("Chattel Mortgage: " + myData2.ComputeMortgage().ToString("0.00"));
                    Output("Insurance with Acts of God:  " + myData2.ComputeInsurance().ToString("0.00"));
                    Output("LTO Registration for 3 years:  " + myData2.ComputeLTO().ToString("0.00"));

                }
            }
            Output("Total Cash Out: " + myData2.ComputeTotal().ToString("#,###.00"));
            Output("Monthly Amortization per month: " + myData2.ComputeMonthlyAmortization().ToString("#,###.00"));
            Output("==================================");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxResult.Clear();
            comboBox1.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BYE!");
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Sent to your email address!");
            comboBox1.Enabled = false;
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }      
    }
}
