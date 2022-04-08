using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vodi_Pro.Class;

namespace Vodi_Pro
{
    public partial class FrmAlarm : Form
    {
        public csVodi ver = new csVodi();
        SoundPlayer sound = new SoundPlayer();
        Tema tema;
        public int id;
        public FrmAlarm(int id)
        {
            this.id = id;
            InitializeComponent();
        }
        private void btnAlarmKapat_Click(object sender, EventArgs e)
        {
            List<CustomerDB> list = ver.Database_Musteri_Bilgileri_Getir(id);
            ver.Database_Musteri_Guncelle(id, list[0].adi, list[0].cihazMarka, list[0].cihazModel,
                list[0].cihazSifre, list[0].telNo, list[0].arizaBilgi, list[0].aciklama, list[0].imeiNo,
                list[0].yapilanIslem, list[0].bitisTarihi, list[0].teslimEdildi, list[0].arizaBedeli,
                list[0].ucretAlindi, list[0].desen, list[0].mail, DateTime.MinValue,
                list[0].alarmAciklama, list[0].kayitTarihi);
            sound.Stop();
            this.Close();
        }
        private void FrmAlarm_Load(object sender, EventArgs e)
        {
            List<SystemDB> lit = ver.Database_Sistem_Bilgi_Getir();
            tema = new Tema(lit[0].indexTema);
            tema.backArray(this);
            tema.buttonArray(btnAlarmKapat, btnErtele, btnMail, btnSMS, btnWp);
            tema.labelArray(label1, lblABedel, lblABilgi, lblCihazMarka, lblCihazModel,
                lblMID, lblMusteri, lblTel, lblTeslim, lblUcretAlindi);
            tema.richArray(txtAlarmAciklama);
            tema.panelUstArray(panel2);
            tema.panelArray(panel1);
            List<CustomerDB> list = ver.Database_Musteri_Bilgileri_Getir(id);
            lblMID.Text = list[0].Id.ToString();
            lblMusteri.Text = list[0].adi;
            lblTel.Text = list[0].telNo;
            lblCihazMarka.Text = list[0].cihazMarka;
            lblCihazModel.Text = list[0].cihazModel;
            if (list[0].teslimEdildi)
                lblTeslim.Text = Properties.Languages.S0112;
            else
                lblTeslim.Text = Properties.Languages.S0202;
            lblABilgi.Text = list[0].arizaBilgi;
            lblABedel.Text = list[0].arizaBedeli;
            if (list[0].ucretAlindi)
                lblUcretAlindi.Text = Properties.Languages.S0116;
            else
                lblUcretAlindi.Text = Properties.Languages.S0203;
            txtAlarmAciklama.Text = list[0].alarmAciklama;

            if (lit[0].zilSes)
            {
                if (lit[0].zilSesim == 0)
                {
                    System.IO.Stream str = Properties.Resources.Agile;
                    sound = new System.Media.SoundPlayer(str);
                    sound.Play();
                }
                else if (lit[0].zilSesim == 1)
                {
                    System.IO.Stream str = Properties.Resources.bip;
                    sound = new System.Media.SoundPlayer(str);
                    sound.Play();
                }
                else if (lit[0].zilSesim == 2)
                {
                    System.IO.Stream str = Properties.Resources.Carnation;
                    sound = new System.Media.SoundPlayer(str);
                    sound.Play();
                }
                else if (lit[0].zilSesim == 3)
                {
                    System.IO.Stream str = Properties.Resources.Peach;
                    sound = new System.Media.SoundPlayer(str);
                    sound.Play();
                }
                else if (lit[0].zilSesim == 4)
                {
                    System.IO.Stream str = Properties.Resources.Triumph;
                    sound = new System.Media.SoundPlayer(str);
                    sound.Play();
                }
                else if (lit[0].zilSesim == 5)
                {
                    System.IO.Stream str = Properties.Resources.Vermillion;
                    sound = new System.Media.SoundPlayer(str);
                    sound.Play();
                }
                else if (lit[0].zilSesim == 6)
                {
                    System.IO.Stream str = Properties.Resources.Watsonia;
                    sound = new System.Media.SoundPlayer(str);
                    sound.Play();
                }
                if (lit[0].zilSesTekrar == 1)
                {
                    sound.PlayLooping();
                }
            }
        }
        private void btnErtele_Click(object sender, EventArgs e)
        {
            List<CustomerDB> list = ver.Database_Musteri_Bilgileri_Getir(id);
            List<SystemDB> lit = ver.Database_Sistem_Bilgi_Getir();
            if (lit[0].aErtele == 0)
            {
                ver.Database_Musteri_Guncelle(id, list[0].adi, list[0].cihazMarka, list[0].cihazModel,
                    list[0].cihazSifre, list[0].telNo, list[0].arizaBilgi, list[0].aciklama, list[0].imeiNo,
                    list[0].yapilanIslem, list[0].bitisTarihi, list[0].teslimEdildi, list[0].arizaBedeli,
                    list[0].ucretAlindi, list[0].desen, list[0].mail, list[0].alarmTarihi.AddHours(1),
                    list[0].alarmAciklama, list[0].kayitTarihi);
            }
            else if (lit[0].aErtele == 1)
            {
                ver.Database_Musteri_Guncelle(id, list[0].adi, list[0].cihazMarka, list[0].cihazModel,
                    list[0].cihazSifre, list[0].telNo, list[0].arizaBilgi, list[0].aciklama, list[0].imeiNo,
                    list[0].yapilanIslem, list[0].bitisTarihi, list[0].teslimEdildi, list[0].arizaBedeli,
                    list[0].ucretAlindi, list[0].desen, list[0].mail, list[0].alarmTarihi.AddHours(2),
                    list[0].alarmAciklama, list[0].kayitTarihi);
            }
            else if (lit[0].aErtele == 2)
            {
                ver.Database_Musteri_Guncelle(id, list[0].adi, list[0].cihazMarka, list[0].cihazModel,
                    list[0].cihazSifre, list[0].telNo, list[0].arizaBilgi, list[0].aciklama, list[0].imeiNo,
                    list[0].yapilanIslem, list[0].bitisTarihi, list[0].teslimEdildi, list[0].arizaBedeli,
                    list[0].ucretAlindi, list[0].desen, list[0].mail, list[0].alarmTarihi.AddHours(3),
                    list[0].alarmAciklama, list[0].kayitTarihi);
            }
            else if (lit[0].aErtele == 3)
            {
                ver.Database_Musteri_Guncelle(id, list[0].adi, list[0].cihazMarka, list[0].cihazModel,
                    list[0].cihazSifre, list[0].telNo, list[0].arizaBilgi, list[0].aciklama, list[0].imeiNo,
                    list[0].yapilanIslem, list[0].bitisTarihi, list[0].teslimEdildi, list[0].arizaBedeli,
                    list[0].ucretAlindi, list[0].desen, list[0].mail, list[0].alarmTarihi.AddHours(4),
                    list[0].alarmAciklama, list[0].kayitTarihi);
            }
            else if (lit[0].aErtele == 4)
            {
                ver.Database_Musteri_Guncelle(id, list[0].adi, list[0].cihazMarka, list[0].cihazModel,
                    list[0].cihazSifre, list[0].telNo, list[0].arizaBilgi, list[0].aciklama, list[0].imeiNo,
                    list[0].yapilanIslem, list[0].bitisTarihi, list[0].teslimEdildi, list[0].arizaBedeli,
                    list[0].ucretAlindi, list[0].desen, list[0].mail, list[0].alarmTarihi.AddHours(5),
                    list[0].alarmAciklama, list[0].kayitTarihi);
            }
            sound.Stop();
            this.Close();
        }
        private void btnSMS_Click(object sender, EventArgs e)
        {
            FrmSMS frmSMS = new FrmSMS(id);
            frmSMS.ShowDialog();
        }
        private void btnWp_Click(object sender, EventArgs e)
        {
            FrmWp wp = new FrmWp(id);
            wp.ShowDialog();
        }
        private void btnMail_Click(object sender, EventArgs e)
        {
            FrmMaill mail = new FrmMaill(id);
            mail.ShowDialog();
        }

        private void FrmAlarm_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<CustomerDB> list = ver.Database_Musteri_Bilgileri_Getir(id);
            ver.Database_Musteri_Guncelle(id, list[0].adi, list[0].cihazMarka, list[0].cihazModel,
                list[0].cihazSifre, list[0].telNo, list[0].arizaBilgi, list[0].aciklama, list[0].imeiNo,
                list[0].yapilanIslem, list[0].bitisTarihi, list[0].teslimEdildi, list[0].arizaBedeli,
                list[0].ucretAlindi, list[0].desen, list[0].mail, DateTime.MinValue,
                list[0].alarmAciklama, list[0].kayitTarihi);
            sound.Stop();
        }
    }
}
