using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RektorlukDers.Class
{
    public class Bilet
    {
        public Bilet(int inKoltukNo,Firma infirma, Yolcu inyolcu, Sefer insefer)
        {
            sefer = insefer;
            firma = infirma;
            yolcu = inyolcu;
            koltukNo = inKoltukNo;
        }
        public Bilet()
        {

        }
        public int ID { get; set; }
        public int koltukNo { get; set; }

        public Firma firma { get; set; }

        public Yolcu yolcu { get; set; }

        public Sefer sefer { get; set; }

    }
}