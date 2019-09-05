using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RektorlukDers.Class
{
    public class Tip
    {
        public Tip(int inID, string inTipAd)
        {
            ID = inID;
            TipAd = inTipAd;
        }
        public Tip()
        {

        }
        public int ID { get; set; }

        public string TipAd { get; set; }
    }
}