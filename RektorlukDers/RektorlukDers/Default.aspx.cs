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
            //            Insan i = new Insan
            //            {
            //                ad = "emir",
            //                soyad = "burgazli",
            //                tc = "34258167063",
            //                dogumTarihi = Convert.ToDateTime("06/06/2016"),
            //                dogumYeri = "bursa",
            //                cinsiyet = true
            //            };

            //            Firma f = new Firma
            //{

            //    ad = "cola colaa",
            //    adres = "izmir",
            //    fax = "05415",
            //    vergiNo = 1531351
            //};

            //            Iletisim il = new Iletisim
            //            {
            //                cepTelefonu = "12351",
            //                evTelefonu = "3513535",
            //                mail = "emirh@gmail.com"
            //            };

            //            Iletisim ile = new Iletisim
            //            {
            //                cepTelefonu = "12351",
            //                evTelefonu = "3513535",
            //                mail = "emirh@gmail.com"
            //            };

            //            Personel p = new Personel
            //            {
            //                insan = i,
            //                maas = 500,
            //                gorevi = "temizlik",
            //                vardiya = "gece",
            //                firma = f
            //            };

            //            Arac a = new Arac
            //            {
            //                Firma = f,
            //                koltukSayisi = 35,
            //                marka = "TOŞAŞK",
            //                model = "ŞAHİN",
            //                plakaNo = "34 B 2341"
            //            };

            //            Kampanya k = new Kampanya
            //            {
            //                firma = f,
            //                indirimAdi = "Pro200",
            //                indirimYuzdesi = 50
            //            };

            //db.FirmaEkle(f, ile);
            //db.PersonelEkle(p, il);
            //db.KampanyaEkle(k);
            //db.AracEkle(a);
            //db.FirmaSil(1531351);



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

            //GUNCELLEMELER//


            //Firma f = new Firma
            //{
            //   ID=21

            //};

            //Insan i = new Insan()
            //{
            //    ID = 14,
            //    ad = "HUSEYİN",
            //    soyad = "HUSEYİN",
            //    tc = "112        "

            //};

            //Personel p = new Personel(i, f)
            //{
            //    gorevi = "SEXY MANKEN",
            //    maas = 10000,
            //    vardiya = "sabahar olmasın"
            //};


            //db.PersonelGuncelle(p);

            //Firma f = new Firma
            //{
            //    vergiNo = 123,

            //};

            //Arac a = new Arac(f)
            //{
            //    ID = 3,
            //    koltukSayisi = 20,
            //    marka = "MBB",
            //    model = "B12",
            //    plakaNo = "34B2341"
            //};


            //db.AracGuncelle(a);

            //Firma f = new Firma
            //{
            //    vergiNo = 123,

            //};

            //Kampanya k = new Kampanya()
            //{
            //    ID = 3,
            //    indirimAdi = "YENİ AD",
            //    indirimYuzdesi = 50,
            //    firma = f
            //};
            //db.KampanyaGuncelle(k);



            //Firma f = new Firma()
            //{
            //    ID = 17,
            //    ad = "dede",
            //    adres = "dede",
            //    fax = "324234",
            //    vergiNo = 3423423
            //};

            //db.FirmaGuncelle(f);

            //Arac a = new Arac()
            //{
            //    ID = 3,
            //    //koltukSayisi = 20,
            //    //marka = "MBB",
            //    //model = "B12",
            //    //plakaNo = "34B2341"
            //};



            //Ikram i = new Ikram(a) { 
            //adedi=344,
            //adi="23423424",
            // turu="234234234",
            // arac=a,
            // ID=1
            //};

            //db.IkramGuncelle(i);


            //Insan i = new Insan(){
            //    ID=17,
            //    ad="24234",
            //    cinsiyet=false,
            //    soyad="23423423",
            //    tc="123234234"
            //};
            //db.InsanGuncelle(i);




            //Arac a = new Arac()
            //{
            //    ID = 3,

            //};


            //Firma f = new Firma()
            //{
            //    ID = 16,

            //};

            //Sefer s = new Sefer(f,a)
            //{
            //    ID=1,
            //    arac = a,
            //    firma = f,
            //    ucret = 500,
            //    kalkısYeri = "izmir",
            //    varısYeri = "amerika"
            //};
            //db.SeferGuncelle(s);




            List<Personel> personel = db.PersonelleriGetir();



            foreach (Personel item in personel)
            {
                ListBox1.Items.Add(item.ToString());
            }

            ListBox1.DataSource = personel;







            //Personel p = new Personel();
            //List<Personel> personeller = db.PersonelleriGetir();
            //foreach (Personel item in personeller)
            //{
            //    ListBox1.Items.Add(item.ToString());
            //}


        }
    }
}