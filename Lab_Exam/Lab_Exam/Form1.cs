using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibrary;
using LoanCalcu;

namespace Lab_Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Class1 myData = new Class1();

        public void Output(object anyObject)
        {
            if (anyObject != null)
                txtBoxOutput.AppendText(anyObject + "\n");
        }


        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            {
                if (String.IsNullOrEmpty(txtFName.Text) || String.IsNullOrEmpty(txtLName.Text) || String.IsNullOrEmpty(txtMI.Text))
                    MessageBox.Show("Please complete the information.");

                else
                myData.First = txtFName.Text;
                myData.Last = txtLName.Text;
                myData.Middle = txtMI.Text;
            }

            {
                if (String.IsNullOrEmpty(txtEAdd.Text))
                    MessageBox.Show("Please enter a valid email address!");

                else
                myData.Email = txtEAdd.Text;
                
            }
            Output("CLIENT INFORMATION\n");
            Output("Name: " + myData.Last + ", " + myData.First + " " + myData.Middle + ".");
            Output("Email Address: " + myData.Email);

        }

        private void btnProceed_Click_1(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtEAdd.Text) || String.IsNullOrEmpty(txtFName.Text) || String.IsNullOrEmpty(txtLName.Text) || String.IsNullOrEmpty(txtMI.Text) || String.IsNullOrEmpty(txtBoxOutput.Text))
            {
                Boolean isButton1 = btnRegister.Equals(sender);
                MessageBox.Show("Please register first!");
            }


            else
            {
                Boolean isButton1 = btnRegister.Equals(sender);
                MessageBox.Show("Successfully Registered!");
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxOutput_TextChanged(object sender, EventArgs e)
        {

        }

       
       
       
        
    }
}
