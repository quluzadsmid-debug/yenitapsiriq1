using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yenitapsiriq1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Ad daxil edin", "Xeta");
                return;
            }

            string cinsiyet = "";
            if (radioButton1.Checked == true)
            {
                cinsiyet = "Kisi";
            }
            else if (radioButton2.Checked == true)
            {
                cinsiyet = "Qadin";
            }
            else
            {
                MessageBox.Show("Cinsiyyet sec !");
                return;
            }

            string telebemelumati = textBox1.Text + " - " + numericUpDown1.Value.ToString() + " yaş - " + comboBox1.Text + " - " + cinsiyet;

            listBox1.Items.Add(telebemelumati);
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Silmek ucun telebe secin ", "Xeberdarliq");
                return;
            }

            DialogResult cvb = MessageBox.Show("Silinsin?", "beli", MessageBoxButtons.YesNo);

            if (cvb == DialogResult.Yes)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                label1.Text = listBox1.SelectedItem.ToString();
            }
        }
    }
}
