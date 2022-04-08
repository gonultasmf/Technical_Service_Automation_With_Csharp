using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vodi_Pro.Class;

namespace Vodi_Pro
{
    public partial class FrmProfil : Form
    {
        public static csVodi ver = new csVodi();
        Tema tema;
        public FrmProfil()
        {
            InitializeComponent();
        }
        private void btnYedekle_Click(object sender, EventArgs e)
        {
            FrmProfilDuzenle duzenle = new FrmProfilDuzenle();
            duzenle.ShowDialog();
            this.Close();
        }
        private void FrmProfil_Load(object sender, EventArgs e)
        {
            List<UserDB> list = ver.Database_Kullanici_Bilgileri_Getir();
            List<SystemDB> lit= ver.Database_Sistem_Bilgi_Getir();
            tema = new Tema(lit[0].indexTema);
            tema.backArray(this);
            tema.buttonArray(btnDuzenle);
            tema.labelArray(label1, label2, label3, label4, label5);
            tema.textBoxArray(txtAdSoyad, txtFirmaAdi, txtKullaniciAdi, txtTelNo);
            tema.richArray(txtAdres);
            txtKullaniciAdi.Text = list[0].kAdi;
            txtAdSoyad.Text = list[0].ad;
            txtFirmaAdi.Text = list[0].sAdi;
            txtTelNo.Text = list[0].tel;
            txtAdres.Text = list[0].adres;
        }
    }
}
