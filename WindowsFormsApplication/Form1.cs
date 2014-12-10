using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label5.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text=="BRAC")
            {

                string bankname = comboBox1.SelectedText; 
                double date = Convert.ToDouble(textBox1.Text);
                double amount = Convert.ToDouble(textBox2.Text);
                double interest = Convert.ToDouble(.06 * date * amount);
                //textBox3.Text = Convert.ToString(interest);
                label5.Text = Convert.ToString(interest);
                label5.Show();

            }
             else if (comboBox1.Text == "DBBL")
            {

                string bankname = comboBox1.SelectedText;
                double date = Convert.ToDouble(textBox1.Text);
                double amount = Convert.ToDouble(textBox2.Text);
                double interest = Convert.ToDouble(.07 * date * amount);
                //textBox3.Text = Convert.ToString(interest);
                label5.Text = Convert.ToString(interest);
                label5.Show();

            }

        else if (comboBox1.Text=="HSBC")
            {

                string bankname = comboBox1.SelectedText; 
                double date = Convert.ToDouble(textBox1.Text);
                double amount = Convert.ToDouble(textBox2.Text);
                double interest = Convert.ToDouble(.08 * date * amount);
                //textBox3.Text = Convert.ToString(interest);
                label5.Text = Convert.ToString(interest);
                label5.Show();

            }}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
