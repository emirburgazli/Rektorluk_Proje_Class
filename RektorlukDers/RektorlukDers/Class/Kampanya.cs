using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RektorlukDers.Class
{
    public class Kampanya
    {
        public Kampanya(Firma inFirma, string inIndirimAdi, int inIndirimYuzdesi)
        {
            firma = inFirma;
            indirimAdi = inIndirimAdi;
            indirimYuzdesi = inIndirimYuzdesi;
        }
        public Kampanya()
        {

        }
        public int ID { get; set; }
        public int indirimYuzdesi { get; set; }

        public string indirimAdi { get; set; }

        public Firma firma { get; set; }
    }
}