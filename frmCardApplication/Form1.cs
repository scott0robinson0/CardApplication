using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardApplication;

namespace frmCardApplication
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

        private void button1_Click(object sender, EventArgs e)
        {
            Sender currentSender = new Sender();

            try
            {
                currentSender.FirstName = textBox1.Text;
                currentSender.LastName = textBox2.Text;
                currentSender.Phone = textBox3.Text;
                currentSender.Address.Street = textBox4.Text;
                currentSender.Address.HouseNo = Convert.ToInt32(textBox5.Text);
                currentSender.Address.Postcode = textBox8.Text;
                currentSender.PaymentInfo = textBox6.Text;
            } catch (System.FormatException)
            {
                MessageBox.Show("House number is mandatory.");
            }

            panel1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
