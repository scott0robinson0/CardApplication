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

                panel2.Enabled = false;
                panel3.Enabled = true;
            } catch (System.FormatException)
            {
                MessageBox.Show("House number is mandatory.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(comboBox1.SelectedItem) == "Birthday Card")
            {
                if (textBox8.TextLength == 0)
                {
                    BirthdayCard bCard = new BirthdayCard();
                }
                else 
                {
                    BirthdayCard bCard = new BirthdayCard(textBox8.Text);
                }

            }
            else if (Convert.ToString(comboBox1.SelectedItem) == "Event Card")
            {
                if(textBox8.TextLength == 0)
                {
                    EventCard eCard = new EventCard();
                }
                else
                {
                    EventCard eCard = new EventCard(textBox8.Text);
                }
            }
            panel1.Enabled = true;
            panel3.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Recipient recipient = new Recipient();

            recipient.FirstName = textBox9.Text;
            recipient.LastName = textBox10.Text;
            recipient.Age = Convert.ToInt32(textBox11.Text);
            recipient.FirstName = textBox9.Text;
            recipient.Address.Street = textBox13.Text;
            recipient.Address.HouseNo = Convert.ToInt32(textBox14.Text);
            recipient.Address.Postcode = textBox12.Text;
        }
    }
}
