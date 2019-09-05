using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace RektorlukDers.Class
{
    public class DbProcess
    {
        SqlConnection con = new SqlConnection("Data Source=W10-1903-PC\\SQLExpress;Initial Catalog=otobus_firmasi;integrated Security=SSPI");
        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-JRMRCGU;Initial Catalog=otobus_firmasi;integrated Security=SSPI");
        int result;

        #region ID Getiren İşlemler
        public int FirmaIDGetir(int inVergiNo)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID FROM Firma where VergiNo = " + inVergiNo + "", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                result = int.Parse(dr[0].ToString());
            }
            con.Close();
            cmd.Dispose();
            dr.Close();
            return result;
        }
        public int InsanIDGetir(string inTC)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID FROM Insan where TC = '" + inTC + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                result = int.Parse(dr["ID"].ToString());
            }
            con.Close();
            cmd.Dispose();
            dr.Close();
            return result;
        }
        public int TipIDGetir(string inTipAdi)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID FROM Tip where TipAd= '" + inTipAdi + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                result = int.Parse(dr["ID"].ToString());
            }
            con.Close();
            cmd.Dispose();
            dr.Close();
            return result;
        }
        public int SeferIDGetir(int inSeferNo)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID FROM Sefer where SeferNo = '" + inSeferNo + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                result = int.Parse(dr["ID"].ToString());
            }
            con.Close();
            cmd.Dispose();
            dr.Close();
            return result;
        }
        public int AracIDGetir(string inPlaka)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID FROM Arac where PlakaNo='" + inPlaka + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                result = int.Parse(dr["ID"].ToString());
            }
            con.Close();
            cmd.Dispose();
            dr.Close();
            return result;
        }
        public int IkramIDGetir(string inIkramAdi)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID FROM Ikram where IkramAdi = '" + inIkramAdi + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                result = int.Parse(dr["ID"].ToString());
            }
            con.Close();
            cmd.Dispose();
            dr.Close();
            return result;
        }
        public int KampanyaIDGetir(string inKampanya)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID FROM Kampanya where indirimAdi = '" + inKampanya + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                result = int.Parse(dr["ID"].ToString());
            }
            con.Close();
            cmd.Dispose();
            dr.Close();
            return result;
        }
        public int YolcuIDGetir(string inTC, string FirmaAd)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select ID from YolcuDetay where Tc='" + inTC + "'and FirmaAd= '" + FirmaAd + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                result = int.Parse(dr["ID"].ToString());
            }
            con.Close();
            cmd.Dispose();
            dr.Close();
            return result;
        }
        public int PersonelIDGetir(string inPersonelTc)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID FROM PersonelDetay where Tc = '" + inPersonelTc + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                result = int.Parse(dr["ID"].ToString());
            }
            con.Close();
            cmd.Dispose();
            dr.Close();
            return result;
        }
        #endregion

        public void Sorgu(string inSorgu)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(inSorgu, con);
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }

        #region Select işlemleri 
        public List<Personel> SelectPersonelSorgu(string inSorgu)
        {
            con.Open();
            List<Personel> personeller = new List<Personel>();
            SqlCommand cmd = new SqlCommand(inSorgu, con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Insan insan = new Insan()
            {
                ad = dr[1].ToString(),
                tc = dr[0].ToString(),
                soyad = dr[2].ToString(),
                dogumTarihi = (DateTime)dr[3],
                dogumYeri = dr[4].ToString(),
                cinsiyet = (Boolean)dr[5]
            };
                Firma firma = new Firma()
                {
                    ad = dr[9].ToString()
                };

                Personel personel = new Personel(insan, firma)
                {
                    maas = float.Parse(dr[6].ToString()),
                    vardiya = dr[7].ToString(),
                    gorevi = dr[8].ToString()
                };
                personeller.Add(personel);
            }
            dr.Close();
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
            return personeller;

        }

        #endregion

        #region Calısan Islemler

        #region Personel İşlemleri
        public void PersonelSil(string inSilinecekPersonelTc)
        {
            Sorgu("update Personel set Aktif=0 where ID= '" + PersonelIDGetir(inSilinecekPersonelTc) + "'");

            //cmd.CommandType = CommandType.StoredProcedure;
        }

        public void PersonelEkle(Personel inPersonel, Iletisim iniletisim)
        {
            Sorgu("Insert Into Insan (Ad,Soyad,Tc,DogumTarihi,DogumYeri,Cinsiyet) Values ('" + inPersonel.insan.ad + "','" + inPersonel.insan.soyad + "','" + inPersonel.insan.tc + "','" + inPersonel.insan.dogumTarihi + "','" + inPersonel.insan.dogumYeri + "','" + inPersonel.insan.cinsiyet + "')");

            Sorgu("Insert Into Personel (Maas,Vardiya,Gorev,InsanID,FirmaID) Values (" + inPersonel.maas + ",'" + inPersonel.vardiya + "','" + inPersonel.gorevi + "'," + InsanIDGetir(inPersonel.insan.tc) + "," + FirmaIDGetir(inPersonel.firma.vergiNo) + ")");

            Sorgu("Insert Into Iletisim (CepTelefonu,EvTelefonu,Email,Tip,TipID) Values ('" + iniletisim.cepTelefonu + "','" + iniletisim.evTelefonu + "','" + iniletisim.mail + "'," + iniletisim.iletisimIDPersonel + "," + PersonelIDGetir(inPersonel.insan.tc) + ")");
        }

        public void PersonelGuncelle(Personel inPersonel)
        {
            //Güncelle kısmı cok kötü oldu araştır.
            Sorgu("update Personel set Maas=" + inPersonel.maas + ",Vardiya='" + inPersonel.vardiya + "',Gorev='" + inPersonel.gorevi + "',InsanID=" + inPersonel.insan.ID + ",FirmaID=" + inPersonel.firma.ID + "  where InsanID=" + inPersonel.insan.ID + "");
            //Sorgu("update Insan set Ad='" + inPersonel.insan.ad + "',Soyad='" + inPersonel.insan.soyad + "',Tc='" + inPersonel.insan.tc + "',DogumTarihi='" + Convert.ToDateTime(inPersonel.insan.dogumTarihi) + "',DogumYeri='" + inPersonel.insan.dogumYeri + "',Cinsiyet='" + inPersonel.insan.cinsiyet + "'  where ID=" + inPersonel.insan.ID + "");

        }

        public List<Personel> PersonelleriGetir()
        {
            return SelectPersonelSorgu("select i.Tc,i.Ad,i.Soyad,i.DogumTarihi,i.DogumYeri,i.Cinsiyet,p.Maas,p.Vardiya,p.Gorev,f.Ad as FirmaAd from personel p inner join Insan i on(p.InsanID=i.ID) inner join Firma f on(p.FirmaID=f.ID)");
        }
        #endregion

        #region Arac İşlemleri
        public void AracSil(string inPlaka)
        {
            Sorgu("update Arac set Aktif=0 where ID= '" + AracIDGetir(inPlaka) + "'");
        }

        public void AracEkle(Arac inArac)
        {
            Sorgu("Insert Into Arac (KoltukSayisi,PlakaNo,Model,Marka,FirmaID) Values (" + inArac.koltukSayisi + ",'" + inArac.plakaNo + "','" + inArac.model + "','" + inArac.marka + "','" + FirmaIDGetir(inArac.Firma.vergiNo) + "')");
        }

        public void AracGuncelle(Arac inArac)
        {
            Sorgu("update Arac set KoltukSayisi=" + inArac.koltukSayisi + ",Model='" + inArac.model + "',Marka='" + inArac.marka + "',FirmaID=" + FirmaIDGetir(inArac.Firma.vergiNo) + " where ID=" + AracIDGetir(inArac.plakaNo) + "");

        }
        #endregion

        #region Kampanya İşlemleri
        public void KampanyaSil(string inKampanyaAdi)
        {
            Sorgu("update Kampanya set Aktif=0 where ID= '" + KampanyaIDGetir(inKampanyaAdi) + "'");
        }

        public void KampanyaEkle(Kampanya inKampanya)
        {
            Sorgu("Insert Into Kampanya (IndirimYuzdesi,Ad,FirmaID) Values (" + inKampanya.indirimYuzdesi + ",'" + inKampanya.indirimAdi + "'," + FirmaIDGetir(inKampanya.firma.vergiNo) + ")");
        }

        public void KampanyaGuncelle(Kampanya inkampanya)
        {
            Sorgu("update Kampanya set IndirimYuzdesi=" + inkampanya.indirimYuzdesi + ",Ad='" + inkampanya.indirimAdi + "',firmaID='" + FirmaIDGetir(inkampanya.firma.vergiNo) + "' where ID='" + inkampanya.ID + "'");
        }
        #endregion

        #region Firma İşlemleri
        public void FirmaSil(int inVergiNo)
        {
            Sorgu("update Firma set Aktif=0 where ID= " + FirmaIDGetir(inVergiNo) + "");
            //cmd.CommandType = CommandType.StoredProcedure;
        }

        public void FirmaEkle(Firma inFirma, Iletisim inIletisim)
        {
            Sorgu("Insert Into Firma (Ad,Adres,VergiNo,Fax) Values ('" + inFirma.ad + "','" + inFirma.adres + "','" + inFirma.vergiNo + "'," + inFirma.fax + ")");

            Sorgu("Insert Into Iletisim (CepTelefonu,EvTelefonu,Email,Tip,TipID) Values ('" + inIletisim.cepTelefonu + "','" + inIletisim.evTelefonu + "','" + inIletisim.mail + "'," + inIletisim.iletisimIDFirma + "," + FirmaIDGetir(inFirma.vergiNo) + ")");
        }

        public void FirmaGuncelle(Firma inFirma)
        {
            Sorgu("update Firma set Ad='" + inFirma.ad + "',Adres='" + inFirma.adres + "',VergiNo='" + inFirma.vergiNo + "',Fax='" + inFirma.fax + "' where ID= " + inFirma.ID + "");
        }
        #endregion

        #region Ikram İşlemleri
        public void IkramSil(string inIkramAd)
        {
            Sorgu("update Ikram set Aktif=0 where ID= '" + IkramIDGetir(inIkramAd) + "'");
            //cmd.CommandType = CommandType.StoredProcedure;
        }

        public void IkramEkle(Ikram inIkram)
        {
            Sorgu("Insert Into Ikram (IkramAdi,Adet,Tur,AracID) Values ('" + inIkram.adi + "'," + inIkram.adedi + ",'" + inIkram.turu + "'," + AracIDGetir(inIkram.arac.plakaNo) + ")");
        }

        public void IkramGuncelle(Ikram inIkram)
        {
            Sorgu("update Ikram set IkramAdi='" + inIkram.adi + "',Adet='" + inIkram.adedi + "',Tur='" + inIkram.turu + "',AracID='" + inIkram.arac.ID + "' where  ID=" + inIkram.ID + "");
        }
        #endregion

        #region Insan İşlemleri
        public void InsanSil(string inSilinecekInsanTc)
        {
            Sorgu("update Insan set Aktif=0 where ID= '" + InsanIDGetir(inSilinecekInsanTc) + "'");
            //cmd.CommandType = CommandType.StoredProcedure;
        }

        public void InsanEkle(Insan inInsan)
        {
            Sorgu("Insert Into Insan (Ad,Soyad,Tc,DogumTarihi,DogumYeri,Cinsiyet) Values ('" + inInsan.ad + "','" + inInsan.soyad + "','" + inInsan.tc + "','" + Convert.ToDateTime(inInsan.dogumTarihi) + "','" + inInsan.dogumYeri + "','" + inInsan.cinsiyet + "')");
        }

        public void InsanGuncelle(Insan inInsan)
        {
            Sorgu("update Insan set Ad='" + inInsan.ad + "',Soyad='" + inInsan.soyad + "',Tc=" + inInsan.tc + ",DogumTarihi='" + inInsan.dogumTarihi + "',DogumYeri='" + inInsan.dogumYeri + "',Cinsiyet='" + inInsan.cinsiyet + "'  where ID='" + inInsan.ID + "'");
        }
        #endregion

        #region Sefer İşlemleri
        public void SeferSil(int inSilinecekSeferNo)
        {
            Sorgu("update Sefer set Aktif=0 where ID= '" + SeferIDGetir(inSilinecekSeferNo) + "'");
            //cmd.CommandType = CommandType.StoredProcedure;
        }

        public void SeferEkle(Sefer inSefer)
        {
            Sorgu("Insert Into Sefer (SeferNo,PeronNo,KalkısYeri,VarısYeri,Tarih,Saat,Ucret,FirmaID,AracID) Values (" + inSefer.seferNo + ",'" + inSefer.peronNo + "','" + inSefer.kalkısYeri + "','" + inSefer.varısYeri + "','" + inSefer.tarih + "','" + inSefer.saat + "'," + inSefer.ucret + "," + FirmaIDGetir(inSefer.firma.vergiNo) + "," + AracIDGetir(inSefer.arac.plakaNo) + ")");
        }

        public void SeferGuncelle(Sefer inSefer)
        {
            Sorgu("update Sefer set SeferNo=" + inSefer.seferNo + ",PeronNo='" + inSefer.peronNo + "',KalkısYeri='" + inSefer.kalkısYeri + "',VarısYeri='" + inSefer.varısYeri + "',Tarih='" + inSefer.tarih + "',Saat='" + inSefer.saat + "',Ucret=" + inSefer.ucret + ",FirmaID=" + inSefer.firma.ID + ",AracID=" + inSefer.arac.ID + " where ID=" + inSefer.ID + "");
        }
        #endregion

        #region Bilet İşlemleri
        public void BiletSil(int silinecekBiletID)
        {
            Sorgu("exec biletSil'" + @silinecekBiletID + "'");
        }

        public void BiletEkle(Bilet inBilet)
        {
            Sorgu("Insert Into Bilet (FirmaID,YolcuID,SeferID) Values (" + FirmaIDGetir(inBilet.firma.vergiNo) + "," + YolcuIDGetir(inBilet.yolcu.insan.tc, inBilet.firma.ad) + "," + SeferIDGetir(inBilet.sefer.seferNo) + ")");
        }

        #endregion

        #region Yolcu İşlemleri
        public void YolcuSil(string inSilinecekYolcuTc, string inSilinecekFirmaAd)
        {
            Sorgu("update Yolcu set Aktif=0 where ID= '" + YolcuIDGetir(inSilinecekYolcuTc, inSilinecekFirmaAd) + "'");
        }

        public void YolcuEkle(Yolcu inyolcu)
        {
            Sorgu("Insert Into Insan (Ad,Soyad,Tc,DogumTarihi,DogumYeri,Cinsiyet) Values ('" + inyolcu.insan.ad + "','" + inyolcu.insan.soyad + "','" + inyolcu.insan.tc + "','" + inyolcu.insan.dogumTarihi + "','" + inyolcu.insan.dogumYeri + "','" + inyolcu.insan.cinsiyet + "')");

            Sorgu("Insert Into Yolcu (InsanID,FirmaID) Values (" + InsanIDGetir(inyolcu.insan.tc) + ",'" + FirmaIDGetir(inyolcu.firma.vergiNo) + "')");
        }

        public void YolcuGuncelle(Yolcu inYolcu)
        {
            Sorgu("update Yolcu set InsanID=" + inYolcu.insan.ID + ",FirmaID=" + inYolcu.firma.ID + " where ID=" + inYolcu.ID + "");
        }
        #endregion

        #region Koltuk İşlemleri

        public void KoltukEkle(Koltuk inKoltuk)
        {
            Sorgu("Insert Into Koltuk (KoltukNo,Durum,KoltukCinsiyet,YolcuID,AracID,SeferID) Values ('" + inKoltuk.No + "','" + inKoltuk.Durumu + "','" + inKoltuk.yolcu.insan.cinsiyet + "'," + YolcuIDGetir(inKoltuk.yolcu.insan.tc, inKoltuk.arac.Firma.ad) + "," + AracIDGetir(inKoltuk.arac.plakaNo) + "," + SeferIDGetir(inKoltuk.sefer.seferNo) + ")");
        }

        public void KoltukGuncelle(Koltuk inKoltuk)
        {
            Sorgu("update Koltuk set KoltukNo=" + inKoltuk.No + ",Durum='" + inKoltuk.Durumu + "',KoltukCinsiyet=" + inKoltuk.Cinsiyet + ",YolcuID=" + inKoltuk.yolcu.ID + ",AracID=" + inKoltuk.arac.ID + ",SeferID=" + inKoltuk.sefer.ID + "  where ID=" + inKoltuk.ID + "");
        }
        #endregion


        //Baştan Yaz.!!
        #region Iletisim İşlemleri
        //public void IletisimSil(string inTipAd, int inIletisimTCVergiNo)
        //{
        //    Sorgu("update Iletisim set Aktif=0 where ID= '" + IletisimIDGetir(inTipAd, inIletisimTCVergiNo) + "'");
        //    //cmd.CommandType = CommandType.StoredProcedure;
        //}

        //public void IletisimEkle(Iletisim iniletisim)
        //{
        //    Sorgu("Insert Into iletisim (CepTelefonu,EvTelefonu,Email,TipID,HangiTipinID) Values ('" + iniletisim.cepTelefonu + "','" + iniletisim.evTelefonu + "','" + iniletisim.mail + "'," + TipIDGetir(iniletisim.tip.TipAd) + "," + iniletisim.HangiTipinID + ")");
        //}

        //public void IletisimGuncelle(Iletisim inIletisim)
        //{
        //    //KONTROL ET
        //    //InsanIDGetir();
        //    //IletisimIDGetir();
        //    //Sorgu("update iletisim set CepTelefonu='" + inIletisim.cepTelefonu + "',EvTelefonu='" + inIletisim.evTelefonu + "',Mail='" + inIletisim.mail + "',TipID='" + TipIDGetir(inIletisim.tip.TipAd) + "',HangiTipinID='" + inIletisim.HangiTipinID + "' where TipID=" + inIletisim.HangiTipinID + "");
        //}
        #endregion

        //#region Tip İşlemleri
        //public void TipSil(string inSilinecekTipAd)
        //{
        //    Sorgu("update Tip set Aktif=0 where ID= '" + TipIDGetir(inSilinecekTipAd) + "'");
        //}

        //public void TipEkle(Tip tip)
        //{
        //    Sorgu("Insert Into Tip (TipAd) Values ('" + tip.TipAd + "')");
        //}

        //public void Tipguncelle(Tip inTip)
        //{
        //    Sorgu("update Tip set TipAd='" + inTip.TipAd + "' where ID='" + inTip.ID + "'");
        //}
        //#endregion

        #endregion

    }
}