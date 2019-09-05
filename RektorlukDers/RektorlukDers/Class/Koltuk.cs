using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RektorlukDers.Class
{
    public class Koltuk
    {
        public Koltuk(int inNo,bool inDurumu,bool inCinsiyet,Yolcu inYolcu,Arac inArac,Sefer inSefer)
        {
            No = inNo;
            Durumu = inDurumu;
            Cinsiyet = inCinsiyet;
            yolcu = inYolcu;
            arac = inArac;
            sefer = inSefer;
        }

        public Koltuk()
        {

        }
        public int ID { get; set; }
        public int No { get; set; }

        public bool Durumu { get; set; }

        public bool Cinsiyet { get; set; }

        public Yolcu yolcu { get; set; }

        public Arac arac { get; set; }

        public Sefer sefer{ get; set; }

    }
}