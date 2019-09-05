using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RektorlukDers.Class
{
    public class Insan
    {
        public Insan(string inAd, string inSoyad, string inTc, DateTime inDogumTarihi, string indogumYeri, bool inCinsiyet)
        {
            ad = inAd;
            soyad = inSoyad;
            tc = inTc;
            dogumTarihi = inDogumTarihi;
            dogumYeri = indogumYeri;
            cinsiyet = inCinsiyet;
        }
        public Insan(int inID)
        {
            ID = inID;
        }
        public Insan()
        {

        }
        public override string ToString()
        {
            return ad;
        }
        public int ID { get; set; }
        public string ad { get; set; }

        public string soyad { get; set; }

        public string tc { get; set; }

        public DateTime dogumTarihi { get; set; }

        public string dogumYeri { get; set; }

        public bool cinsiyet { get; set; }
    }
}