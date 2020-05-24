using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SecondForm;
using DataHelper;

namespace FirstForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataAccess myData = new DataAccess();

        public void Output(object anyObject)
        {
            if (anyObject != null)
                richTextBox1.AppendText(anyObject + "\n");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox4.Text))
                MessageBox.Show("Incomplete Information");

            else
            myData.First = textBox1.Text;
            myData.Last = textBox2.Text;
            myData.Middle = textBox4.Text;
        }

            {
            if (String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(comboBox1.Text))
                MessageBox.Show("Enter a VALID Email Address");

            else
            myData.Emailstart = textBox3.Text;
            myData.Emailend = comboBox1.Text;
        }
            Output("Client Information");
            Output("\n Name: " + myData.Last + ", " + myData.First + " " + myData.Middle + ".");
            Output("\n Email Address: " + myData.Emailstart + "@" + myData.Emailend);
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
        
            if (String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(comboBox1.Text) ||
                String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox4.Text)|| String.IsNullOrEmpty(richTextBox1.Text))
              
            {
                Boolean isButton1 = button1.Equals(sender);
                MessageBox.Show("REGISTER FIRST!");
        }
        
    
            else
            { Boolean isButton1 = button1.Equals(sender);
           MessageBox.Show("Successfully Registered");
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
    }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

  
    }
}

