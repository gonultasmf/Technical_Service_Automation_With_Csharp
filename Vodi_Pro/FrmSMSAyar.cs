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
    public partial class FrmSMSAyar : Form
    {
        public static csVodi ver = new csVodi();
        Tema tema;
        bool resim = true;
        public FrmSMSAyar()
        {
            InitializeComponent();
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            List<SystemDB> lit = ver.Database_Sistem_Bilgi_Getir();
            ver.Database_Sistem_Bilgi_Guncelle(lit[0].indexTema, lit[0].indexPara,
                    lit[0].text, txtMesaj1.Text, txtMesaj2.Text, comboSMS.SelectedIndex,
                    txtKAdi.Text, lit[0].smsSifre, lit[0].yazici, lit[0].pos, lit[0].etiket,
                    lit[0].aErtele, lit[0].zilSes, lit[0].zilSesim, lit[0].zilSesTekrar,
                    lit[0].yedekle, lit[0].mailHost, lit[0].mailPort, lit[0].mailSSL,
                    lit[0].mail, lit[0].mailSifre, lit[0].path);
            this.Close();
        }

        private void FrmSMSAyar_Load(object sender, EventArgs e)
        {
            List<SystemDB> lit = ver.Database_Sistem_Bilgi_Getir();
            tema = new Tema(lit[0].indexTema);
            tema.backArray(this);
            tema.buttonArray(btnIptal, btnKaydol);
            tema.comboArray(comboSMS);
            tema.richArray(txtMesaj1, txtMesaj2);
            tema.textBoxArray(txtKAdi, txtParola);
            tema.labelArray(label1, label2, label3, label4, label5, label6);
            txtMesaj1.Text = lit[0].mesaj1;
            txtMesaj2.Text = lit[0].mesaj2;
            comboSMS.SelectedIndex = lit[0].sms;
            txtKAdi.Text = lit[0].smsKAdi;
            txtParola.Text = lit[0].smsSifre;
            txtParola.PasswordChar = '•';
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            if (resim)
            {
                labelControl1.Image = Vodi_Pro.Properties.Resources.eye1;
                txtParola.PasswordChar = '\0';
                resim = !resim;
            }
            else
            {
                labelControl1.Image = Vodi_Pro.Properties.Resources.hide__1_;
                txtParola.PasswordChar = '•';
                resim = !resim;
            }
        }
    }
}
