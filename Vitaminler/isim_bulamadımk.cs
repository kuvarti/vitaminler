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
    public partial class isim_bulamadımk : Form
    {
        int puanlama;
        public isim_bulamadımk()
        {
            InitializeComponent();
        }
        private void isim_bulamadımk_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new System.Drawing.Size(747,273);
            this.MinimumSize = new System.Drawing.Size(747, 273);

            radioButton1.Checked = true;

            label1.Text = "Bulmanız gereken vitamin";
            label2.Text = "Puan";
            label3.Text = "0";
            label4.Text = "a";

            radioButton1.Text = "Kolay";
            radioButton2.Text = "Orta";
            radioButton3.Text = "Zor";

            button1.Text = "Başla";
            button2.Text = "Durdur";
            button3.Text = "Puan'ı sıfırla";

            groupBox1.Text = "Zorluk Seviyeleri";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            kalk_az_haraket_et();
            kalk_az_haraket_et2();
            kalk_az_haraket_et3();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        /// Resim doğrulama
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (label4.Text==vitamin1.ToString())
            {
                puanlama=Convert.ToInt16(label3.Text);
                puanlama+=10;
                label3.Text=puanlama.ToString();
            }
            else
            {
                puanlama = Convert.ToInt16(label3.Text);
                puanlama -= 10;
                label3.Text = puanlama.ToString();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (label4.Text == vitamin2.ToString())
            {
                puanlama = Convert.ToInt16(label3.Text);
                puanlama += 10;
                label3.Text = puanlama.ToString();
            }
            else
            {
                puanlama = Convert.ToInt16(label3.Text);
                puanlama -= 10;
                label3.Text = puanlama.ToString();
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (label4.Text == vitamin3.ToString())
            {
                puanlama = Convert.ToInt16(label3.Text);
                puanlama += 10;
                label3.Text = puanlama.ToString();
            }
            else
            {
                puanlama = Convert.ToInt16(label3.Text);
                puanlama -= 10;
                label3.Text = puanlama.ToString();
            }
        }

        /// Rastgele resim getirme 

        Random salla = new Random();
        Random salla2 = new Random();
        int sallananı_tut, vitamin_tut;
        char vitamin1,vitamin2,vitamin3;
        public void kalk_az_haraket_et()
        {
            isim_bulamadımk nesne = new isim_bulamadımk();
            vitamin_tut = salla.Next(0, 5);
            sallananı_tut = salla2.Next(0, 4);

            if (vitamin_tut == 0)
            {
                vitamin1 = 'a';
            }
            else if (vitamin_tut == 1)
            {
                vitamin1 = 'b';
            }
            else if (vitamin_tut == 2)
            {
                vitamin1 = 'c';
            }
            else if (vitamin_tut == 3)
            {
                vitamin1 = 'd';
            }
            else if (vitamin_tut == 4)
            {
                vitamin1 = 'e';
            }
            else if (vitamin_tut == 5)
            {
                vitamin1 = 'k';
            }

            if (vitamin1 == 'a')
            {
                if (sallananı_tut == 0)
                {
                    pictureBox1.BackgroundImage = A_vitamini.greyfurt;
                }
                else if (sallananı_tut == 1)
                {
                    pictureBox1.BackgroundImage = A_vitamini.havuç;
                }
                else if (sallananı_tut == 2)
                {
                    pictureBox1.BackgroundImage = A_vitamini.ıspanak;
                }
                else if (sallananı_tut == 3)
                {
                    pictureBox1.BackgroundImage = A_vitamini.kayısı;
                }
            }
            else if (vitamin1 == 'b')
            {
                if (sallananı_tut == 0)
                {
                    pictureBox1.BackgroundImage = B_vitamini.k_et;
                }
                else if (sallananı_tut == 1)
                {
                    pictureBox1.BackgroundImage = B_vitamini.süt;
                }
                else if (sallananı_tut == 2)
                {
                    pictureBox1.BackgroundImage = B_vitamini.tavuk;
                }
                else if (sallananı_tut == 3)
                {
                    pictureBox1.BackgroundImage = B_vitamini.yumurta;
                }
            }
            else if (vitamin1 == 'c')
            {
                if (sallananı_tut == 0)
                {
                    pictureBox1.BackgroundImage = C_vitamini.greyfurt;
                }
                else if (sallananı_tut == 1)
                {
                    pictureBox1.BackgroundImage = C_vitamini.kivi;
                }
                else if (sallananı_tut == 2)
                {
                    pictureBox1.BackgroundImage = C_vitamini.mandalina;
                }
                else if (sallananı_tut == 3)
                {
                    pictureBox1.BackgroundImage = C_vitamini.portakal;
                }
            }
            else if (vitamin1 == 'd')
            {
                if (sallananı_tut == 0)
                {
                    pictureBox1.BackgroundImage = d_vitamini.balık;
                }
                else if (sallananı_tut == 1)
                {
                   pictureBox1.BackgroundImage = d_vitamini.güneş;
                }
                else if (sallananı_tut == 2)
                {
                    pictureBox1.BackgroundImage = d_vitamini.istiridye;
                }
                else if (sallananı_tut == 3)
                {
                    pictureBox1.BackgroundImage = d_vitamini.patates;
                }
            }
            else if (vitamin1 == 'e')
            {
                if (sallananı_tut == 0)
                {
                    pictureBox1.BackgroundImage = E_vitamini.badem;
                }
                else if (sallananı_tut == 1)
                {
                    pictureBox1.BackgroundImage = E_vitamini.çekirdek;
                }
                else if (sallananı_tut == 2)
                {
                   pictureBox1.BackgroundImage = E_vitamini.yerfıstığı;
                }
                else if (sallananı_tut == 3)
                {
                    pictureBox1.BackgroundImage = E_vitamini.yeşil_z;
                }
            }
            else if (vitamin1 == 'k')
            {
                if (sallananı_tut == 0)
                {
                    pictureBox1.BackgroundImage = K_vitamini.armut;
                }
                else if (sallananı_tut == 1)
                {
                    pictureBox1.BackgroundImage = K_vitamini.böğürtlen;
                }
                else if (sallananı_tut == 2)
                {
                    pictureBox1.BackgroundImage = K_vitamini.kekik;
                }
                else if (sallananı_tut == 3)
                {
                    pictureBox1.BackgroundImage = K_vitamini.pul_biber;
                }
            }
        }
        public void kalk_az_haraket_et2()
        {
            isim_bulamadımk nesne = new isim_bulamadımk();
            vitamin_tut = salla.Next(0, 5);
            sallananı_tut = salla2.Next(0, 4);

            if (vitamin_tut == 0)
            {
                vitamin2 = 'a';
            }
            else if (vitamin_tut == 1)
            {
                vitamin2 = 'b';
            }
            else if (vitamin_tut == 2)
            {
                vitamin2 = 'c';
            }
            else if (vitamin_tut == 3)
            {
                vitamin2 = 'd';
            }
            else if (vitamin_tut == 4)
            {
                vitamin2 = 'e';
            }
            else if (vitamin_tut == 5)
            {
                vitamin2 = 'k';
            }

            if (vitamin2 == 'a')
            {
                if (sallananı_tut == 0)
                {
                    pictureBox2.BackgroundImage = A_vitamini.greyfurt;
                }
                else if (sallananı_tut == 1)
                {
                    pictureBox2.BackgroundImage = A_vitamini.havuç;
                }
                else if (sallananı_tut == 2)
                {
                    pictureBox2.BackgroundImage = A_vitamini.ıspanak;
                }
                else if (sallananı_tut == 3)
                {
                    pictureBox2.BackgroundImage = A_vitamini.kayısı;
                }
            }
            else if (vitamin2 == 'b')
            {
                if (sallananı_tut == 0)
                {
                    pictureBox2.BackgroundImage = B_vitamini.k_et;
                }
                else if (sallananı_tut == 1)
                {
                    pictureBox2.BackgroundImage = B_vitamini.süt;
                }
                else if (sallananı_tut == 2)
                {
                    pictureBox2.BackgroundImage = B_vitamini.tavuk;
                }
                else if (sallananı_tut == 3)
                {
                    pictureBox2.BackgroundImage = B_vitamini.yumurta;
                }
            }
            else if (vitamin2 == 'c')
            {
                if (sallananı_tut == 0)
                {
                    pictureBox2.BackgroundImage = C_vitamini.greyfurt;
                }
                else if (sallananı_tut == 1)
                {
                    pictureBox2.BackgroundImage = C_vitamini.kivi;
                }
                else if (sallananı_tut == 2)
                {
                    pictureBox2.BackgroundImage = C_vitamini.mandalina;
                }
                else if (sallananı_tut == 3)
                {
                    pictureBox2.BackgroundImage = C_vitamini.portakal;
                }
            }
            else if (vitamin2 == 'd')
            {
                if (sallananı_tut == 0)
                {
                    pictureBox2.BackgroundImage = d_vitamini.balık;
                }
                else if (sallananı_tut == 1)
                {
                    pictureBox2.BackgroundImage = d_vitamini.güneş;
                }
                else if (sallananı_tut == 2)
                {
                    pictureBox2.BackgroundImage = d_vitamini.istiridye;
                }
                else if (sallananı_tut == 3)
                {
                    pictureBox2.BackgroundImage = d_vitamini.patates;
                }
            }
            else if (vitamin2 == 'e')
            {
                if (sallananı_tut == 0)
                {
                    pictureBox2.BackgroundImage = E_vitamini.badem;
                }
                else if (sallananı_tut == 1)
                {
                    pictureBox2.BackgroundImage = E_vitamini.çekirdek;
                }
                else if (sallananı_tut == 2)
                {
                    pictureBox2.BackgroundImage = E_vitamini.yerfıstığı;
                }
                else if (sallananı_tut == 3)
                {
                    pictureBox2.BackgroundImage = E_vitamini.yeşil_z;
                }
            }
            else if (vitamin2 == 'k')
            {
                if (sallananı_tut == 0)
                {
                    pictureBox2.BackgroundImage = K_vitamini.armut;
                }
                else if (sallananı_tut == 1)
                {
                    pictureBox2.BackgroundImage = K_vitamini.böğürtlen;
                }
                else if (sallananı_tut == 2)
                {
                    pictureBox2.BackgroundImage = K_vitamini.kekik;
                }
                else if (sallananı_tut == 3)
                {
                    pictureBox2.BackgroundImage = K_vitamini.pul_biber;
                }
            }
        }
        public void kalk_az_haraket_et3()
        {
            isim_bulamadımk nesne = new isim_bulamadımk();
            vitamin_tut = salla.Next(0, 5);
            sallananı_tut = salla2.Next(0, 4);

            if (vitamin_tut == 0)
            {
                vitamin3 = 'a';
            }
            else if (vitamin_tut == 1)
            {
                vitamin3 = 'b';
            }
            else if (vitamin_tut == 2)
            {
                vitamin3 = 'c';
            }
            else if (vitamin_tut == 3)
            {
                vitamin3 = 'd';
            }
            else if (vitamin_tut == 4)
            {
                vitamin3 = 'e';
            }
            else if (vitamin_tut == 5)
            {
                vitamin3 = 'k';
            }

            if (vitamin3 == 'a')
            {
                if (sallananı_tut == 0)
                {
                    pictureBox3.BackgroundImage = A_vitamini.greyfurt;
                }
                else if (sallananı_tut == 1)
                {
                    pictureBox3.BackgroundImage = A_vitamini.havuç;
                }
                else if (sallananı_tut == 2)
                {
                    pictureBox3.BackgroundImage = A_vitamini.ıspanak;
                }
                else if (sallananı_tut == 3)
                {
                    pictureBox3.BackgroundImage = A_vitamini.kayısı;
                }
            }
            else if (vitamin3 == 'b')
            {
                if (sallananı_tut == 0)
                {
                    pictureBox3.BackgroundImage = B_vitamini.k_et;
                }
                else if (sallananı_tut == 1)
                {
                    pictureBox3.BackgroundImage = B_vitamini.süt;
                }
                else if (sallananı_tut == 2)
                {
                    pictureBox3.BackgroundImage = B_vitamini.tavuk;
                }
                else if (sallananı_tut == 3)
                {
                    pictureBox3.BackgroundImage = B_vitamini.yumurta;
                }
            }
            else if (vitamin3 == 'c')
            {
                if (sallananı_tut == 0)
                {
                    pictureBox3.BackgroundImage = C_vitamini.greyfurt;
                }
                else if (sallananı_tut == 1)
                {
                    pictureBox3.BackgroundImage = C_vitamini.kivi;
                }
                else if (sallananı_tut == 2)
                {
                    pictureBox3.BackgroundImage = C_vitamini.mandalina;
                }
                else if (sallananı_tut == 3)
                {
                    pictureBox3.BackgroundImage = C_vitamini.portakal;
                }
            }
            else if (vitamin3 == 'd')
            {
                if (sallananı_tut == 0)
                {
                    pictureBox3.BackgroundImage = d_vitamini.balık;
                }
                else if (sallananı_tut == 1)
                {
                    pictureBox3.BackgroundImage = d_vitamini.güneş;
                }
                else if (sallananı_tut == 2)
                {
                    pictureBox3.BackgroundImage = d_vitamini.istiridye;
                }
                else if (sallananı_tut == 3)
                {
                    pictureBox3.BackgroundImage = d_vitamini.patates;
                }
            }
            else if (vitamin3 == 'e')
            {
                if (sallananı_tut == 0)
                {
                    pictureBox3.BackgroundImage = E_vitamini.badem;
                }
                else if (sallananı_tut == 1)
                {
                    pictureBox3.BackgroundImage = E_vitamini.çekirdek;
                }
                else if (sallananı_tut == 2)
                {
                    pictureBox3.BackgroundImage = E_vitamini.yerfıstığı;
                }
                else if (sallananı_tut == 3)
                {
                    pictureBox3.BackgroundImage = E_vitamini.yeşil_z;
                }
            }
            else if (vitamin3 == 'k')
            {
                if (sallananı_tut == 0)
                {
                    pictureBox3.BackgroundImage = K_vitamini.armut;
                }
                else if (sallananı_tut == 1)
                {
                    pictureBox3.BackgroundImage = K_vitamini.böğürtlen;
                }
                else if (sallananı_tut == 2)
                {
                    pictureBox3.BackgroundImage = K_vitamini.kekik;
                }
                else if (sallananı_tut == 3)
                {
                    pictureBox3.BackgroundImage = K_vitamini.pul_biber;
                }
            }
        }


        /// Vitamin bulma

        private void timer2_Tick(object sender, EventArgs e)
        {
            uret();
        }
        public void uret()
        {
            vitamin_tut = salla.Next(0, 5);

            if (vitamin_tut == 0)
            {
                label4.Text = "a";
            }
            else if (vitamin_tut == 1)
            {
                label4.Text = "b";
            }
            else if (vitamin_tut == 2)
            {
                label4.Text = "c";
            }
            else if (vitamin_tut == 3)
            {
                label4.Text = "d";
            }
            else if (vitamin_tut == 4)
            {
                label4.Text = "e";
            }
            else if (vitamin_tut == 5)
            {
                label4.Text = "k";
            }
        }

        /// Zorluk aşamaları

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                timer1.Interval = 2000;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                timer1.Interval = 1000;
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                timer1.Interval = 500;
            }
        }

        /// Butonlar
        
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "0";
        }

    }
}