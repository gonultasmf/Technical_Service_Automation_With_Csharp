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
    public partial class FrmProfilDuzenle : Form
    {
        public static csVodi ver = new csVodi();
        Tema tema;
        public FrmProfilDuzenle()
        {
            InitializeComponent();
        }

        private void chckSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chckSifreGoster.Checked)
            {
                txtSifre.PasswordChar = '\0';
                txtTekrarSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '•';
                txtTekrarSifre.PasswordChar = '•';
            }
        }

        private void FrmProfilDuzenle_Load(object sender, EventArgs e)
        {
            List<UserDB> list = ver.Database_Kullanici_Bilgileri_Getir();
            List<SystemDB> lit = ver.Database_Sistem_Bilgi_Getir();
            tema = new Tema(lit[0].indexTema);
            tema.backArray(this);
            tema.buttonArray(btnIptal, btnKaydet);
            tema.labelArray(label1, label2, label3, label4, label5, label8, label9);
            tema.chckArray(chckSifreGoster);
            txtKullaniciAdi.Text = list[0].kAdi;
            txtAdSoyad.Text = list[0].ad;
            txtFirmaAdi.Text = list[0].sAdi;
            txtTelNo.Text = list[0].tel;
            txtAdres.Text = list[0].adres;
            txtSifre.Text = list[0].sifre;
            txtTekrarSifre.Text = list[0].sifre;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            List<UserDB> users = ver.Database_Kullanici_Getir();
            if (txtSifre.Text == txtTekrarSifre.Text)
            {
                    ver.Database_Kullanici_Guncelle(txtKullaniciAdi.Text, txtAdSoyad.Text,
                        txtFirmaAdi.Text, txtTelNo.Text, txtAdres.Text, txtSifre.Text);
                    lblHata.Visible = false;
                    this.Close();
            }
            else
                lblHata.Visible = true;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
