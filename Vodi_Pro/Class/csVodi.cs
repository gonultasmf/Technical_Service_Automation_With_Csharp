using LiteDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Vodi_Pro.Class;

namespace Vodi_Pro
{
    public class csVodi
    {
        private LiteDatabase db;
        private string dbFilePath = @"C:\ProgramData\VODI_PRO\vodiDatabase.db";
        public csVodi()
        {
            if (!Directory.Exists(@"C:\ProgramData\VODI_PRO"))
                Directory.CreateDirectory(@"C:\ProgramData\VODI_PRO");
            
            if (!File.Exists(@"C:\ProgramData\VODI_PRO\vodiDatabase.db"))
            {
                Database_Kullanici_Ekle("DrahnaSoft", "", "", "", "", "0000");
                Database_Kullanici_Ekle("m", "gfdh", "br", "dfh", "grsd", "0");
                Database_Sistem_Ekle(0, 0, "", "", "", 0, "", "", -1, -1, -1, 0, false, 0, 0, false, "smtp.gmail.com", 587, true,"","", @"C:\Program Files\");
            }
        }
        public static int index;
        public static bool ac = false;
        public void Database_Kullanici_Ekle(string kAdi, string ad, string sAdi, string adres,
            string tel, string sifre)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<UserDB>("User");
                var system = new UserDB
                {
                    kAdi = kAdi,
                    ad = ad,
                    sAdi = sAdi,
                    tel = tel,
                    adres = adres,
                    sifre = sifre
                };
                col.Insert(system);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Languages.S0205,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Database_Kullanici_Giris(FrmGiris giris, TextBox KAdi, TextBox sifre, Label lblHata)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<UserDB>("User");
                List<UserDB> lit = col.Find("$.kAdi = '" + KAdi.Text + "' AND $.sifre = '" + sifre.Text +"'").ToList();
                db.Dispose();
                if (lit.Count != 0)
                {
                    index = lit[0].Id;
                    lblHata.Visible = false;
                    FrmGiris.asds = true;
                    giris.Close();
                }
                else
                {
                    KAdi.ResetText();
                    sifre.ResetText();
                    FrmGiris.asds = false;
                    lblHata.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Languages.S0205,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<UserDB> Database_Kullanici_Bilgileri_Getir()
        {
            db = new LiteDatabase(dbFilePath);
            var col = db.GetCollection<UserDB>("User");
            List<UserDB> lit = col.Find(x => x.Id.Equals(index)).ToList();
            db.Dispose();
            return lit;
        }
        public List<UserDB> Database_Kullanici_Getir()
        {
            db = new LiteDatabase(dbFilePath);
            var col = db.GetCollection<UserDB>("User");
            List<UserDB> lit = col.FindAll().ToList();
            db.Dispose();
            return lit;
        }
        public void Database_Kullanici_Guncelle(string kAdi, string ad, string firmaAd,
            string telNo, string adres, string sifre)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<UserDB>("User");
                var user = new UserDB
                {
                    Id = index,
                    kAdi = kAdi,
                    ad = ad,
                    sAdi = firmaAd,
                    tel = telNo,
                    adres = adres,
                    sifre = sifre
                };
                col.Update(user);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Languages.S0205,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public void Database_Musteri_Ekle(string adi, string cihazMarka, string cihazModel, string cihazSifre,
             string telNo, string arizaBilgi, string aciklama, string imeiNo, bool desen, string mail)
        {
            
            db = new LiteDatabase(dbFilePath);
            var col = db.GetCollection<CustomerDB>("Customer");
            var customer = new CustomerDB
            {
                adi = adi,
                cihazMarka = cihazMarka,
                cihazModel = cihazModel,
                cihazSifre = cihazSifre,
                telNo = telNo,
                arizaBilgi = arizaBilgi,
                aciklama = aciklama,
                kayitTarihi = DateTime.Now,
                imeiNo = imeiNo,
                yapilanIslem = "",
                bitisTarihi = DateTime.MinValue,
                teslimEdildi = false,
                arizaBedeli = "",
                ucretAlindi = false,
                desen = desen,
                mail = mail,
                alarmTarihi = DateTime.MinValue,
                alarmAciklama = "",
            };
            col.Insert(customer);
            db.Dispose();
            
        }
        public List<CustomerDB> Database_Musterileri_Getir()
        {
            db = new LiteDatabase(dbFilePath);
            var col = db.GetCollection<CustomerDB>("Customer");
            List<CustomerDB> lit = col.FindAll().ToList();
            db.Dispose();
            return lit;
        }
        public void Database_Musteri_Sil(int index)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<CustomerDB>("Customer");
                col.Delete(index);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Languages.S0205,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Database_Musteri_Arama(int index, DataGridView liste, string aranacak)
        {
            try
            {
                List<CustomerDB> customerList = Database_Musterileri_Getir();
                DataTable tablom = new DataTable();
                tablom.Columns.Add(Properties.Languages.S0185, typeof(int));
                tablom.Columns.Add(Properties.Languages.S0186, typeof(string));
                tablom.Columns.Add(Properties.Languages.S0188, typeof(string));
                tablom.Columns.Add(Properties.Languages.S0189, typeof(string));
                tablom.Columns.Add(Properties.Languages.S0187, typeof(string));
                tablom.Columns.Add(Properties.Languages.S0193, typeof(DateTime));
                tablom.Columns.Add(Properties.Languages.S0191, typeof(string));
                tablom.Columns.Add(Properties.Languages.S0192, typeof(bool));
                for (int i = 0; i < customerList.Count; i++)
                    tablom.Rows.Add(customerList[i].Id, customerList[i].adi,
                        customerList[i].cihazMarka, customerList[i].cihazModel,
                        customerList[i].telNo, customerList[i].kayitTarihi,
                        customerList[i].aciklama, customerList[i].teslimEdildi);

                DataView dv = tablom.DefaultView;
                if (index == 0)
                {
                    dv.RowFilter = Properties.Languages.S0186 + " LIKE '%" + aranacak + "%'";
                    liste.DataSource = dv;
                }
                else if (index == 1)
                {
                    dv.RowFilter = Properties.Languages.S0188 + " LIKE '%" + aranacak + "%'";
                    liste.DataSource = dv;
                }
                else if (index == 2)
                {
                    dv.RowFilter = Properties.Languages.S0189 + " LIKE '%" + aranacak + "%'";
                    liste.DataSource = dv;
                }
                else if (index == 3)
                {
                    dv.RowFilter = Properties.Languages.S0187 + " LIKE '%" + aranacak + "%'";
                    liste.DataSource = dv;
                }
                else if (index == 4)
                {
                    dv.RowFilter = Properties.Languages.S0191 + " LIKE '%" + aranacak + "%'";
                    liste.DataSource = dv;
                }
                db.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Languages.S0205,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public void Database_Musteri_Guncelle(int index, string adi, string cihazMarka, string cihazModel,
            string cihazSifre, string telNo, string arizaBilgi, string aciklama, string imeiNo, string yapilanIslem,
            DateTime bitisTarihi, bool teslimEdildi, string arizaBedeli, bool ucretAlindi, bool desen, string mail,
            DateTime alarmTarihi, string alarmAciklama, DateTime kayitTarihi)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<CustomerDB>("Customer");
                var customer = new CustomerDB
                {
                    Id = index,
                    adi = adi,  
                    cihazMarka = cihazMarka,
                    cihazModel = cihazModel,
                    cihazSifre = cihazSifre,
                    telNo = telNo,
                    kayitTarihi = kayitTarihi,
                    arizaBilgi = arizaBilgi,
                    aciklama = aciklama,
                    imeiNo = imeiNo,
                    yapilanIslem = yapilanIslem,
                    bitisTarihi = bitisTarihi,
                    teslimEdildi = teslimEdildi,
                    arizaBedeli = arizaBedeli,
                    ucretAlindi = ucretAlindi,
                    desen = desen,
                    mail = mail,
                    alarmTarihi = alarmTarihi,
                    alarmAciklama = alarmAciklama,
                };
                col.Update(customer);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Languages.S0205,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public List<CustomerDB> Database_Musteri_Bilgileri_Getir(int id)
        {
            db = new LiteDatabase(dbFilePath);
            var col = db.GetCollection<CustomerDB>("Customer");
            List<CustomerDB> lit = col.Find(x => x.Id.Equals(id)).ToList();
            db.Dispose();
            return lit;
        }
        public void Database_Sistem_Bilgi_Guncelle(int tema, int indexPara, string text,
            string mesaj1, string mesaj2, int sms, string smsKAdi,
            string smsSifre, int yazici, int pos, int etiket, int aErtele, bool zilSes,
            int zilSesim, int zilSesTekrar, bool yedekle, string host, int port, bool ssl,
            string mail, string mailSİfre, string path)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<SystemDB>("System");
                var system = new SystemDB
                {
                    Id=1,
                    indexTema = tema,
                    indexPara = indexPara,
                    text = text,
                    mesaj1 = mesaj1,
                    mesaj2 = mesaj2,
                    sms = sms,
                    smsKAdi = smsKAdi,
                    smsSifre = smsSifre,
                    yazici = yazici,
                    pos = pos,
                    etiket = etiket,
                    aErtele = aErtele,
                    zilSes = zilSes,
                    zilSesim = zilSesim,
                    zilSesTekrar = zilSesTekrar,
                    yedekle = yedekle,
                    mailHost = host,
                    mailPort = port,
                    mailSSL = ssl,
                    mail = mail,
                    mailSifre = mailSİfre,
                    path = path
                };
                col.Update(system);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Languages.S0205,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public List<SystemDB> Database_Sistem_Bilgi_Getir()
        {
            db = new LiteDatabase(dbFilePath);
            var col = db.GetCollection<SystemDB>("System");
            List<SystemDB> lit = col.FindAll().ToList();
            db.Dispose();
            return lit;
        }
        public void Database_Sistem_Ekle(int indexTema, int indexPara, string text,
            string mesaj1, string mesaj2, int sms, string smsKAdi, string smsSifre, int yazici,
            int pos, int etiket, int aErtele, bool zilSes, int zilSesim, int zilSesTekrar,
            bool yedekle, string host, int port, bool ssl, string mail, string mailSifre,
            string path)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<SystemDB>("System");
                var system = new SystemDB
                {
                    indexTema = indexTema,
                    indexPara = indexPara,
                    text = text,
                    mesaj1 = mesaj1,
                    mesaj2 = mesaj2,
                    sms = sms,
                    smsKAdi = smsKAdi,
                    smsSifre = smsSifre,
                    yazici = yazici,
                    pos = pos,
                    etiket = etiket,
                    aErtele = aErtele,
                    zilSes = zilSes,
                    zilSesim = zilSesim,
                    zilSesTekrar = zilSesTekrar,
                    yedekle = yedekle,
                    mailHost = host,
                    mailPort = port,
                    mailSSL = ssl,
                    mail = mail,
                    mailSifre = mailSifre,
                    path = path
                };
                col.Insert(system);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Languages.S0205,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Database_Yedekle(string path)
        {
            File.Copy(dbFilePath, path, true);
        }
    }
}
