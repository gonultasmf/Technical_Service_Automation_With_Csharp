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
    public partial class FrmKaydol : Form
    {
        public static csVodi ver = new csVodi();
        Tema tema;
        public FrmKaydol()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            List<UserDB> users = ver.Database_Kullanici_Getir();
            bool myControl = false;
            if (txtSifre.Text == txtTekrarSifre.Text)
            {
                for (int i = 0; i < users.Count; i++)
                    if (users[i].kAdi == txtKullaniciAdi.Text)
                        myControl = true;
                if (!myControl)
                {
                    ver.Database_Kullanici_Ekle(txtKullaniciAdi.Text, txtAdSoyad.Text, txtFirmaAdi.Text,
                        txtAdres.Text, txtTelNo.Text, txtSifre.Text);
                    txtKullaniciAdi.ResetText();
                    txtAdSoyad.ResetText();
                    txtFirmaAdi.ResetText();
                    txtAdres.ResetText();
                    txtTelNo.ResetText();
                    txtSifre.ResetText();
                    txtTekrarSifre.ResetText();
                    lblHata.Visible = false;
                    this.Close();
                }
                else
                    MessageBox.Show(Properties.Languages.S0228, Properties.Languages.S0205, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblHata.Visible = true;
                txtSifre.ResetText();
                txtTekrarSifre.ResetText();
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmKaydol_Load(object sender, EventArgs e)
        {
            List<SystemDB> lit = ver.Database_Sistem_Bilgi_Getir();
            tema = new Tema(lit[0].indexTema);
            tema.backArray(this);
            tema.buttonArray(btnGiris, btnIptal);
            tema.labelArray(label1, label2, label3, label4, label5, label8, label9);
            tema.textBoxArray(txtAdres, txtAdSoyad, txtFirmaAdi, txtKullaniciAdi, txtSifre,
                txtTekrarSifre, txtTelNo);
        }
    }
}
