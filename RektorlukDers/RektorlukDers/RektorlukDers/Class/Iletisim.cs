﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RektorlukDers.Class
{
    public class Iletisim
    {
        public int iletisimIDYolcu = 1;
        public int iletisimIDPersonel = 2;
        public int iletisimIDFirma = 3;
        public Iletisim(string inCepTelefonu, string inMail, string inEvTelefonu, int inTip, int inTipID)
        {
            cepTelefonu = inCepTelefonu;
            mail = inMail;
            evTelefonu = inEvTelefonu;
            tip = inTip;
            TipID = inTipID;
        }
        public Iletisim()
        {

        }

        public int ID { get; set; }
        public string cepTelefonu { get; set; }

        public string mail { get; set; }

        public string evTelefonu { get; set; }

        public int tip { get; set; }

        public int TipID { get; set; }

    }
}