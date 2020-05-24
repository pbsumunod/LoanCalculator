using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataHelper;

namespace SecondForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DataAccess newData = new DataAccess();

        public void Output(object anyObject)
        {
            if (anyObject != null)
                richTextBox1.AppendText(anyObject + "\n");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)

                MessageBox.Show("No Selected Type of Car to be Loan!");


            else
            {
                newData.Type = comboBox2.Text;
            }

            newData.Downpayment = numericUpDown1.Value;
            newData.Years = numericUpDown2.Value;
            Output("Total Contract Price: " + newData.ComputeTcp().ToString("#,###.00"));
            Output("Down Payment: " + newData.ComputeDown().ToString("#,###.00"));
            {
                if (newData.Years <= 4)
                {
                    Output("Chattel Mortgage: " + newData.ComputeMortgage().ToString("#,###.00"));
                    Output("Insurance with Acts of God:  " + newData.ComputeInsurance().ToString("#,###.00"));
                    Output("LTO Registration for 3 years:  " + newData.ComputeLTO().ToString("#,###.00"));
                }
                else
                {
                    Output("Chattel Mortgage: " + newData.ComputeMortgage().ToString("0.00"));
                    Output("Insurance with Acts of God:  " + newData.ComputeInsurance().ToString("0.00"));
                    Output("LTO Registration for 3 years:  " + newData.ComputeLTO().ToString("0.00"));
                    
                }
            }
            Output("Total Cash Out: " + newData.ComputeTotal().ToString("#,###.00"));
            Output("Monthly Amortization per month: " + newData.ComputeMonthlyAmortization().ToString("#,###.00"));
            Output("================================");
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been successfully LOGGED OUT");
            this.Close();
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Output is Already sent in your email address!");
            comboBox2.Enabled = false;
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            comboBox2.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
