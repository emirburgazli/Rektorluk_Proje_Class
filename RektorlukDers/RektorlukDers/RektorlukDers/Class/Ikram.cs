using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RektorlukDers.Class
{
    public class Ikram
    {
        public Ikram(string inIkramAdi, int inIkramAdedi, string inIkramTuru,Arac inArac)
        {
            adi = inIkramAdi;
            adedi = inIkramAdedi;
            turu = inIkramTuru;
            arac = inArac;
        }

        public Ikram()
        {

        }
        public int ID { get; set; }
        public string adi { get; set; }

        public int adedi { get; set; }

        public string turu { get; set; }

        public Arac arac { get; set; }
    }
}