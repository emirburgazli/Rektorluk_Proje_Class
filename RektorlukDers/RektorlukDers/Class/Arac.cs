using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RektorlukDers.Class
{
    public class Arac
    {
        public Arac(/* int inKoltukSayisi, string inPlakaNo, string inModel,  string inMarka,*/ Firma inFirma)
        {
            //koltukSayisi = inKoltukSayisi;
            //plakaNo = inPlakaNo;
            //model = inModel;
            //marka = inMarka;
            Firma = inFirma;

        }
        public Arac()
        {

        }
        public int ID { get; set; }
        public int koltukSayisi { get; set; }

        public string plakaNo { get; set; }

        public string model { get; set; }

        public string marka { get; set; }

        public  Firma Firma { get; set; }


    }
}