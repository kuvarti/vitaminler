using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vitaminler
{
    public partial class bosluk_doldurma : Form
    {
        string[] vitamin = new string[6];
        public bosluk_doldurma()
        {
            InitializeComponent();
        }

        private void bosluk_doldurma_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new System.Drawing.Size(410, 253);
            this.MinimumSize = new System.Drawing.Size(410, 253);

            vitamin[0] = "a";
            vitamin[1] = "b";
            vitamin[2] = "c";
            vitamin[3] = "d";
            vitamin[4] = "e";
            vitamin[5] = "k";

            for (int i = 0; i < 6; i++)
            {
                comboBox1.Items.Add(vitamin[i]);
                comboBox2.Items.Add(vitamin[i]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==2)
            {
                pictureBox1.BackColor = Color.Green;
            }
            else
            {
                pictureBox1.BackColor = Color.Red;
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 1)
            {
                pictureBox2.BackColor = Color.Green;
            }
            else
            {
                pictureBox2.BackColor = Color.Red;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text=="göz"||textBox1.Text=="Göz")
            {
                pictureBox3.BackColor = Color.Green;
            }
            else
            {
                pictureBox3.BackColor = Color.Red;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "erime"||textBox2.Text=="Erime")
            {
                pictureBox4.BackColor = Color.Green;
            }
            else
            {
                pictureBox4.BackColor = Color.Red;
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "6")
            {
                pictureBox5.BackColor = Color.Green;
            }
            else
            {
                pictureBox5.BackColor = Color.Red;
            }
        }
    }
}
