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
    public partial class FrmGiris : Form
    {
        public static csVodi ver = new csVodi();
        Tema tema;
        public bool kaydol = true;
        public static bool asds = false;
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            /*
            if (!Properties.Settings.Default.Control)
            {
                if (Properties.Settings.Default.deneme == 0)
                {
                    MessageBox.Show(Properties.Languages.S0231,
                    Properties.Languages.S0205, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    FrmAktivasyon aktivasyon = new FrmAktivasyon();
                    aktivasyon.ShowDialog();
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show(Properties.Languages.S0232 + Properties.Settings.Default.deneme,
                       Properties.Languages.S0221, MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    Properties.Settings.Default.deneme--;
                    Properties.Settings.Default.Save();
                }
            }*/
            List<SystemDB> lit = ver.Database_Sistem_Bilgi_Getir();
            tema = new Tema(lit[0].indexTema);
            tema.textBoxArray(txtKullaniciAdi, txtSifre);
            tema.labelArray(label1, label2, label3);
            tema.buttonArray(btnCikis, btnGiris, btnKaydol);
            tema.chckArray(chckSifreGoster);
            tema.panelArray(panel1,panel2);
            tema.backArray(this);
            if (kaydol)
                btnKaydol.Enabled = true;
            else
                btnKaydol.Enabled = false;
            if (lit[0].indexTema.Equals(2) || lit[0].indexTema.Equals(6) ||
                lit[0].indexTema.Equals(3) || lit[0].indexTema.Equals(4) ||
                lit[0].indexTema.Equals(5)) 
                pictureBox1.Image = Properties.Resources.drahnaosft_yazi;
            
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            ver.Database_Kullanici_Giris(this, txtKullaniciAdi, txtSifre, lblHata);
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            FrmKaydol kaydol = new FrmKaydol();
            kaydol.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chckSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chckSifreGoster.Checked)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '•';
            }
        }

        private void FrmGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
