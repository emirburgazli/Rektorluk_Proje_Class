using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RektorlukDers.Class
{
    public class Firma
    {

        public Firma(string inAd,string inAdres,int inVergiNo,string inFaxNo)
        {
            ad = inAd;
            adres = inAdres;
            vergiNo = inVergiNo;
            fax = inFaxNo;
        }
        public Firma()
        {
           
        }

    
        public int ID { get; set; }
        public string ad { get; set; }

        public string adres { get; set; }

        public int vergiNo { get; set; }

        public string fax { get; set; }

    }
}