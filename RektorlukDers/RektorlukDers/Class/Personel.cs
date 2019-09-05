  using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RektorlukDers.Class
{
    public class Personel
    {
        public Personel( /*float inMaas, string inVardiya, string inGorevi,*/ Insan inInsan, Firma inFirma)
        {
            //maas = inMaas;
            //vardiya = inVardiya;
            //gorevi = inGorevi;
            insan = inInsan;
            firma = inFirma;
        }
        public  Personel(int inID)
        {
            ID = inID;
        }
        public Personel()
        {

        }
      
        public int ID { get; set; }
        public float maas { get; set; }

        public string vardiya { get; set; }
        
        public string gorevi { get; set; }

        public Insan insan { get; set; }

        public Firma firma { get; set; }
    }
}