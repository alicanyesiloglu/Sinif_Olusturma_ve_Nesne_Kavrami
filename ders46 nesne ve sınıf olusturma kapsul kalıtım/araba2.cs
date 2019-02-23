using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders46_nesne_ve_sınıf_olusturma_kapsul_kalıtım
{
    class araba2: digerclass
    {
        public string renk;
        public string cesidi;
        public int hiz;
        public char durumu;
        public int fiyat;
        private int yil;
        private string marka;

        

        //private tanımladığımız yılı  public olarak YIL'A dönüştürüyoruz. negatif girilen -2016 yılını pozitife dönüyor.
        public int YIL
        {
            get { return yil; }
            set { yil = Math.Abs(value); }


        }
        public string MARKASI
        {
            get { return marka; }
            set { marka = value.ToUpper(); }
        }


    }
}
