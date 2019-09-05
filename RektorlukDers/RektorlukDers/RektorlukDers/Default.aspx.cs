using RektorlukDers.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RektorlukDers
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


        }
        DbProcess db = new DbProcess();
        protected void Button1_Click1(object sender, EventArgs e)
        {
            //Insan i = new Insan
            //{
            //    ad = "emir",
            //    soyad = "burgazli",
            //    tc = "34258167063",
            //    dogumTarihi = Convert.ToDateTime("06/06/2016"),
            //    dogumYeri = "bursa",
            //    cinsiyet = true
            //};

            //Firma f = new Firma
            //{

            // ad = "cola colaa",
            // adres = "izmir",
            // fax = "05415",
            // vergiNo = 1531351
            //};

            //Iletisim il = new Iletisim
            //{
            //    cepTelefonu = "12351",
            //    evTelefonu = "3513535",
            //    mail = "emirh@gmail.com"
            //};

            //Iletisim ile = new Iletisim
            //{
            //    cepTelefonu = "12351",
            //    evTelefonu = "3513535",
            //    mail = "emirh@gmail.com"
            //};

            //Personel p = new Personel
            //{
            //    insan = i,
            //    maas = 500,
            //    gorevi = "temizlik",
            //    vardiya = "gece",
            //    firma = f
            //};

            //Arac a = new Arac
            //{
            //    Firma = f,
            //    koltukSayisi = 35,
            //    marka = "TOŞAŞK",
            //    model = "ŞAHİN",
            //    plakaNo = "34 B 2341"
            //};

            //Kampanya k = new Kampanya
            //{
            //    firma = f,
            //    indirimAdi = "Pro200",
            //    indirimYuzdesi = 50
            //};

            //db.FirmaEkle(f, ile);
            //db.PersonelEkle(p, il);
            //db.KampanyaEkle(k);
            //db.AracEkle(a);
            ////db.FirmaSil(1531351);

            //db.PersonelSil("34258167062");
            //db.AracSil("34 B 2341");


            //  Iletisim il = new Iletisim{
            //cepTelefonu="12351",
            //evTelefonu="3513535",
            //mail="emirh@gmail.com"

            //};

            //  db.FirmaEkle(f, il);
            //Arac a = new Arac
            //{
            //    Firma = f,
            //    koltukSayisi = 35,
            //    marka = "TOŞAŞK",
            //    model = "ŞAHİN",
            //    plakaNo = "34 B 2341"
            //};

            //Yolcu y = new Yolcu
            //{
            //    firma = f,
            //    insan = i
            //};


            //Sefer s = new Sefer
            //{
            //    peronNo = "1",
            //    arac = a,
            //    firma = f,
            //    kalkısYeri = "izmir",
            //    varısYeri = "istanbul",
            //    ucret = 78,
            //    tarih = Convert.ToDateTime("06/06/2019"),
            //    seferNo = 1,
            //    saat = "14:30"
            //};

            //Koltuk k = new Koltuk
            //{
            //    arac = a,
            //    sefer = s,
            //    yolcu = y,
            //    Durumu = false,
            //    No = 4

            //};
            //db.FirmaEkle(f,il);
            //db.YolcuEkle(y);
            //db.SeferEkle(s);
            //db.AracEkle(a);
            //db.KoltukEkle(k);




            //Firma f = new Firma
            //{
            //    ad = "cola colaa",
            //    adres = "izmir",
            //    fax = "05415",
            //    vergiNo = 1531351
            //};

            //Personel p = new Personel
            //{
            //    insan = i,
            //    maas = 500,
            //    gorevi = "temizlik",
            //    vardiya = "gece",
            //    firma=f
            //};
            //db.InsanEkle(i);
            //db.FirmaEkle(f);
            //db.PersonelEkle(p,f);


            //Firma f = new Firma
            //{
            //    ad = "Holgind",
            //    adres = "Holgind",
            //    fax = "15413513",
            //    vergiNo = 351351
            //};
            //Arac a = new Arac
            //{
            //    Firma = f,
            //    koltukSayisi = 35,
            //    marka = "TOŞAŞK",
            //    model = "ŞAHİN",
            //    plakaNo = "34 B 2341"
            //};

            //db.FirmaEkle(f);

            //db.AracEkle(a, f);

            //Firma f = new Firma
            //{
            //    ad = "Holgind",
            //    adres = "Holgind",
            //    fax = "15413513",
            //    vergiNo = 351351
            //};

            //Kampanya k = new Kampanya { 
            //firma=f,
            //indirimAdi="Pro200",
            //indirimYuzdesi=50
            //};

            //db.FirmaEkle(f);
            //db.KampanyaEkle(k, f);

            //Tip t = new Tip
            //{
            //    TipAd = "PERSONEL"
            //};
            //db.TipSil(1);

            //Firma f = new Firma
            //{
            //    ad = "Holgind",
            //    adres = "Holgind",
            //    fax = "15413513",
            //    vergiNo = 351351
            //};



            //Ikram i = new Ikram
            //{
            //    adedi = 40,
            //    adi = "eti puf",
            //    arac = a,
            //    turu = "yiyecek"

            //};
            //db.FirmaEkle(f);
            //db.AracEkle(a, f);
            //db.IkramEkle(i, a);


            //Insan i = new Insan
            //{
            //    ad = "emir",
            //    soyad = "burgazli",
            //    tc = "34258167063",
            //    dogumTarihi = Convert.ToDateTime("06/06/2016"),
            //    dogumYeri = "bursa",
            //    cinsiyet = true
            //};


            //Firma f = new Firma
            //{
            //    ad = "Holgind",
            //    adres = "Holgind",
            //    fax = "15413513",
            //    vergiNo = 351351
            //};

            //db.InsanEkle(i);
            //db.YolcuEkle(y);

            //Insan i = new Insan
            //{
            //    ad = "Emirhan",
            //    soyad = "BURAZLI",
            //    tc = "34258167062",
            //    dogumTarihi = Convert.ToDateTime("06/06/2016"),
            //    dogumYeri = "bursa",
            //    cinsiyet = true
            //};

            //Firma f = new Firma
            //{
            //    ad = "DEU",
            //    adres = "alsancak",
            //    fax = "15413513",
            //    vergiNo = 351351
            //};

            //Yolcu y = new Yolcu(i, f);
            //db.FirmaEkle(f);
            //db.YolcuEkle(y);



            //Arac a = new Arac
            //{
            //    Firma = f,
            //    koltukSayisi = 35,
            //    marka = "bmw",
            //    model = "i30",
            //    plakaNo = "35 HRL 66"
            //};

            //Bilet b = new Bilet
            //{
            //    firma = f,
            //    sefer = s,
            //    yolcu = y,
            //    koltukNo = 20
            //};
            //db.FirmaEkle(f);
            //db.YolcuEkle(y);
            //db.SeferEkle(s);
            //db.AracEkle(a);
            //db.BiletEkle(b);
            Firma f = new Firma("deneme", "deneme", 23423, "234234");
            Insan i = new Insan("emir", "burazli", "34258167062", Convert.ToDateTime("06/06/2019"), "bursa", true);
            Personel p = new Personel(500, "gece", "yazılıcı", i, f);
            Iletisim il = new Iletisim("51531531", "adasd@", "4234234", 2, 8);
            db.FirmaEkle(f, il);
            db.PersonelEkle(p, il);
            //db.IletisimEkle(il);

        }
    }
}