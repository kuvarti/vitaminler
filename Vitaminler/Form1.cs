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
    public partial class Form1 : Form
    {
        public byte login = 0;
        public girisejrani nesne = new girisejrani();
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        public void sen_kimsin()
        {
            nesne.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sen_kimsin();
            A_vitamin();
            B_vitamin();
            C_Vitamin();
            D_Vitamin();
            E_vitamin();
            K_vitamin();
            tuultip();

            this.MaximumSize = new System.Drawing.Size(833, 448);
            this.MinimumSize = new System.Drawing.Size(833, 448);
        }
        private void A_vitamin()
        {
            pictureBox1.BackgroundImage = A_vitamini.A_vitamini_1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            label1.Text = "A VİTAMİNİ";
            label2.Text = "A vitamini; doku, kemik, diş ve cildin korunmasında en önemli besinlerden biridir.  Aynı zamanda göz\nsağlığı için de önemli rol oynar.";
            label3.Text = "Bulunduğu Besinler";
            label3.ForeColor = Color.Green;


            pictureBox2.BackgroundImage = A_vitamini.havuç;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BackgroundImage = A_vitamini.ıspanak;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.BackgroundImage = A_vitamini.kayısı;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.BackgroundImage = A_vitamini.greyfurt;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void B_vitamin()
        {
            label4.Text = "B VİTAMİNİ";
            label5.Text = "Suda erime özelliğine sahip olan B vitaminleri hayvansal ürünlerde, yeşil sebzelerde, kuru meyvelerde\n ve süt ürünlerinde bol miktarda bulunmaktadır Bu mineral; karbonhidratların yakılmasına, hormonların\nüretilmesine, cilt dokusunun sağlıklı kalmasına, öğrenme bozukluklarının giderilmesine, hafızanın\ngüçlendirilmesine yardımcı olur.";
            label6.Text = "Bulunduğu Besinler";
            label6.ForeColor = Color.Green;

            pictureBox6.BackgroundImage = B_vitamini.indir;
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox7.BackgroundImage = B_vitamini.k_et;
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox8.BackgroundImage = B_vitamini.süt;
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox9.BackgroundImage = B_vitamini.tavuk;
            pictureBox9.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox10.BackgroundImage = B_vitamini.yumurta;
            pictureBox10.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void C_Vitamin()
        {
            label7.Text = "C VİTAMİNİ";
            label8.Text = "Vücuttan ter ya da idrar yoluyla atılan C vitamini bağışıklık sisteminin güçlenmesi için en önemli \nvitaminlerden biridir. Bağışıklık sistemini güçlendirir";
            label9.Text = "Bulunduğu Besinler";
            label9.ForeColor = Color.Green;

            pictureBox11.BackgroundImage = C_vitamini.C;
            pictureBox11.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox12.BackgroundImage = C_vitamini.greyfurt;
            pictureBox12.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox13.BackgroundImage = C_vitamini.mandalina;
            pictureBox13.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox14.BackgroundImage = C_vitamini.portakal;
            pictureBox14.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox15.BackgroundImage = C_vitamini.kivi;
            pictureBox15.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void D_Vitamin()
        {
            label10.Text = "D VİTAMİNİ";
            label11.Text = "D vitamini, kalsiyum ve fosforun sindirim yollarında kullanımı ve emilimi ile özellikle çocuklarda büyüme \niçin gerekli vitamin.";
            label12.Text = "Bulunduğu Besinler";
            label12.ForeColor = Color.Green;

            pictureBox16.BackgroundImage = d_vitamini.vitamin;
            pictureBox16.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox17.BackgroundImage = d_vitamini.güneş;
            pictureBox17.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox18.BackgroundImage = d_vitamini.istiridye;
            pictureBox18.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox19.BackgroundImage = d_vitamini.patates;
            pictureBox19.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox20.BackgroundImage = d_vitamini.balık;
            pictureBox20.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void E_vitamin()
        {
            label13.Text = "E VİTAMİNİ";
            label14.Text = "E vitamini, kimyasal yapı itibarı ile bir tokol olup antisterilite vitamin olarak da bilinir. E vitamini yağda \nçözünen önemli bir antioksidandır ve özellikle hücre zarları ve lipoproteinlerde önemli antioksidan \nişlevler görmektedir.";
            label15.Text = "Bulunduğu Besinler";
            label15.ForeColor = Color.Green;

            pictureBox21.BackgroundImage = E_vitamini.E;
            pictureBox21.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox22.BackgroundImage = E_vitamini.çekirdek;
            pictureBox22.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox23.BackgroundImage = E_vitamini.badem;
            pictureBox23.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox24.BackgroundImage = E_vitamini.yeşil_z;
            pictureBox24.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox25.BackgroundImage = E_vitamini.yerfıstığı;
            pictureBox25.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void K_vitamin()
        {
            label16.Text = "K VİTAMİNİ";
            label17.Text = "K vitamini kanın pıhtılaşmasını önler";
            label18.Text = "Bulunduğu Besinler";
            label18.ForeColor = Color.Green;

            pictureBox26.BackgroundImage = K_vitamini.K;
            pictureBox26.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox27.BackgroundImage = K_vitamini.böğürtlen;
            pictureBox27.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox28.BackgroundImage = K_vitamini.armut;
            pictureBox28.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox29.BackgroundImage = K_vitamini.kekik;
            pictureBox29.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox30.BackgroundImage = K_vitamini.pul_biber;
            pictureBox30.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void tuultip()
        {
            toolTip1.SetToolTip(pictureBox2, "Havuç");
            toolTip1.SetToolTip(pictureBox3, "Ispanak");
            toolTip1.SetToolTip(pictureBox4, "Kayısı");
            toolTip1.SetToolTip(pictureBox5, "Greyfurt");
            toolTip1.SetToolTip(pictureBox7, "Kırmızı et");
            toolTip1.SetToolTip(pictureBox8, "Süt");
            toolTip1.SetToolTip(pictureBox9, "Tavuk");
            toolTip1.SetToolTip(pictureBox10, "Yumurta");
            toolTip1.SetToolTip(pictureBox12, "Greyfurt");
            toolTip1.SetToolTip(pictureBox13, "Mandalina");
            toolTip1.SetToolTip(pictureBox14, "Portakal");
            toolTip1.SetToolTip(pictureBox15, "Kivi");
            toolTip1.SetToolTip(pictureBox17, "Güneş");
            toolTip1.SetToolTip(pictureBox18, "İstiridye");
            toolTip1.SetToolTip(pictureBox19, "Patates");
            toolTip1.SetToolTip(pictureBox20, "Balık");
            toolTip1.SetToolTip(pictureBox22, "Çekirdek");
            toolTip1.SetToolTip(pictureBox23, "Badem");
            toolTip1.SetToolTip(pictureBox24, "Yeşil Zeytin");
            toolTip1.SetToolTip(pictureBox25, "Yerfıstığı");
            toolTip1.SetToolTip(pictureBox27, "Böğürtlen");
            toolTip1.SetToolTip(pictureBox28, "Armut");
            toolTip1.SetToolTip(pictureBox29, "Kekik");
            toolTip1.SetToolTip(pictureBox30, "Pul Biber");
        }

        private void öğrenciBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kaynakçaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kaynakcavs nesne = new Kaynakcavs();
            nesne.ShowDialog();
        }

        private void testSorularıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            test nesne1 = new test();
            nesne1.ShowDialog();
        }

        private void vitaminiBulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isim_bulamadımk nesne2 = new isim_bulamadımk();
            nesne2.ShowDialog();
        }

        private void boşluklarıDoldurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bosluk_doldurma nesne3 = new bosluk_doldurma();
            nesne3.ShowDialog();
        }
    }
}
