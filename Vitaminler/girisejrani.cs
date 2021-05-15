using System;
using System.Collections;
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
    public partial class girisejrani : Form
    {
        ArrayList kuladi = new ArrayList();
        ArrayList sifre = new ArrayList();
        
        int giris_indisi=0;
        string cks_kontrol="b";
        public girisejrani()
        {
            InitializeComponent();
        }

        private void girisejrani_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new System.Drawing.Size(600, 301);
            this.MinimumSize = new System.Drawing.Size(600, 301);

            kuladi.Add(3);
            sifre.Add(3);
            Form1 nesne1 = new Form1();
            nesne1.Visible = false;
            DialogResult soru = MessageBox.Show("Kullanıcı hesabınız Varsa 'Evet' Yoksa 'İptal'e tıklayınız", "Kullanıcı girişi",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk);
            if (soru==DialogResult.OK)
            {
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
            }
            yazilar();
        }
        private void yazilar()
        {
            groupBox1.Text = "Kayıt ol";
            groupBox2.Text = "Giriş Yap";

            label1.Text = "Kullanıcı adı";
            label2.Text = "Şifre";
            label3.Text = "Tekrar şifre";
            label5.Text = "Kullanıcı adı";
            label6.Text = "Şifre";

            radioButton1.Text = "Öğrenci Kayıt";
            radioButton1.Checked = true;
            radioButton2.Text = "Öğretmen Kayıt";
            
            button1.Text="Kayıt Yap";
            button2.Text="Kayıt ol";
            button3.Text="Giriş";
            button4.Text="Kayıt ol";

            checkBox1.Text = "Şifreyi gizle";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                textBox5.PasswordChar = '*';
            }
            else
            {
                textBox5.PasswordChar = '\0';
            }
        }
        byte sayac = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayac = 0;
            foreach (var sorr in kuladi)
            {
                if (sorr.ToString() == textBox1.Text)
                {
                    sayac++;
                }
            }
            if (sayac == 1)
            {
                MessageBox.Show("Böyle bir kullanıcı var");
            }
            else if (sayac == 0)
            {
                if (textBox2.Text==textBox3.Text)
                {
                    kuladi.Add(Convert.ToString(textBox1.Text));
                    sifre.Add(Convert.ToString(textBox2.Text));
                    MessageBox.Show("Kullanıcı başarıyla oluşturuldu");
                    groupBox1.Enabled = false;

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
                else
                {
                    MessageBox.Show("Şifreler yanlış");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 nesne1 = new Form1();
            giris_indisi = kuladi.IndexOf(textBox4.Text);
            if (giris_indisi!=-1)
            {
                if (sifre[giris_indisi].ToString()==textBox5.Text)
                {

                    cks_kontrol = "a";
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Şifre yanlış");
                }
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı yok");
            }
        }

        private void girisejrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 nesne = new Form1();
            if (cks_kontrol == "b")
            {
                DialogResult sor = MessageBox.Show("LÜTFEN GİRİŞ YAPINIZ\nPROGRAMI KAPATMAK İÇİN İPTAL'E BASIN", "", MessageBoxButtons.OKCancel);
                if (sor == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                else if (sor == DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                MessageBox.Show("Başarılı giriş");
            }

            
        }
    }
}
