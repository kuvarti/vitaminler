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
    public partial class Kaynakcavs : Form
    {
        public Kaynakcavs()
        {
            InitializeComponent();
        }
        int sagpanel, solpanel;
        private void Kaynakcavs_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = YAZILAR.Adsız;
            solpanel = panel1.Left;
            pictureBox2.BackgroundImage = YAZILAR.ÖĞRENCİ_BİLGİSİ;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;

            MessageBox.Show("Alanın Açık Kalması için mause'nin imleçini kırmızı/Mavi alanda tutun");

            labelyazilari();

            this.MaximumSize = new System.Drawing.Size(357,566);
            this.MinimumSize = new System.Drawing.Size(357, 566);
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.Left = solpanel;
        }
        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.Left = solpanel - 280;
        }
        private void labelyazilari()
        {
            label1.Text = "ADI";         label5.Text = "Ahmet";
            label2.Text = "SOYADI";      label6.Text = "Eryılmaz";
            label3.Text = "NUMARASI";    label7.Text = "956";
            label4.Text = "SINIFI";      label8.Text = "11/c";

        }

        private void panel1_sd(object sender, EventArgs e)
        {
            panel1.Left = solpanel;
        }
    }
}
