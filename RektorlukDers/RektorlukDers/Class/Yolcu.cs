using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RektorlukDers.Class
{
    public class Yolcu
    {
        public Yolcu(Insan inInsan, Firma inFirma)
        {
            insan = inInsan;
            firma = inFirma;
        }
        public Yolcu()
        {

        }
        public int ID { get; set; }
        public Insan insan { get; set; }

        public Firma firma { get; set; }


    }
}