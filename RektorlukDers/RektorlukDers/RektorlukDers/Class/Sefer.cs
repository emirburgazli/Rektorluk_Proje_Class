using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;


namespace RektorlukDers.Class
{
    public class Sefer
    {
        public Sefer(int inSeferNo, string inKalkısYeri, string inVarisYeri, DateTime intarih, string inSaat, float inUcret, string inPeronNo, Firma inFirma, Arac inArac)
        {
            seferNo = inSeferNo;
            kalkısYeri = inKalkısYeri;
            varısYeri = inVarisYeri;
            peronNo = inPeronNo;
            ucret = inUcret;
            tarih = intarih;
            saat = inSaat;
            firma = inFirma;
            arac = inArac;
        }
        public Sefer()
        {

        }
        public int ID { get; set; }
        public int seferNo { get; set; }

        public string kalkısYeri { get; set; }
        
        public string varısYeri { get; set; }

        public DateTime tarih { get; set; }

        public string saat { get; set; }

        public float ucret { get; set; }

        public string peronNo { get; set; }

        public Firma firma { get; set; }

        public Arac arac { get; set; }
    }
}