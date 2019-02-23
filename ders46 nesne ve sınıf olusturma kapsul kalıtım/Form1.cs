using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders46_nesne_ve_sınıf_olusturma_kapsul_kalıtım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            araba2 rb = new araba2();

            rb.renk = "kirmizi";
            rb.hiz = 180;
            rb.cesidi = "bmw";
            rb.durumu = 'i';
            rb.fiyat = 200000;
            // kapsulleme ders 47 baslıyor.
            rb.YIL = -2016;
            rb.MARKASI = "mercedes dikkat harfler buyuk oldu";

            // ikinci bir digerclass.cs ekledik. 
            rb.muayene = 2018;
            rb.sahip = "Ali Veli";
            rb.plaka = "31 CAN 2012";

            label1.Text = rb.renk;
            label2.Text = rb.cesidi;
            label3.Text = rb.hiz.ToString();
            label4.Text = rb.durumu.ToString();
            label5.Text = rb.fiyat.ToString();
            label7.Text = rb.YIL.ToString();
            label8.Text = rb.MARKASI;
            pictureBox2.BackColor = Color.Red;
            label9.Text = rb.muayene.ToString();
            label10.Text = rb.sahip;
            label11.Text = rb.plaka;


        }
    }
}
