using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vodi_Pro.Class;

namespace Vodi_Pro
{
    public partial class FrmYaziciAyar : Form
    {
        public csVodi ver = new csVodi();
        Tema tema;
        public static string yazici, pos, etiket;
        public FrmYaziciAyar()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            List<SystemDB> lit = ver.Database_Sistem_Bilgi_Getir();
            ver.Database_Sistem_Bilgi_Guncelle(lit[0].indexTema, lit[0].indexPara,
                   txtAciklama.Text, lit[0].mesaj1, lit[0].mesaj2, lit[0].sms, lit[0].smsKAdi,
                   lit[0].smsSifre, comboYazici.SelectedIndex, comboPos.SelectedIndex,
                   comboEtiket.SelectedIndex, lit[0].aErtele, lit[0].zilSes,
                    lit[0].zilSesim, lit[0].zilSesTekrar, lit[0].yedekle,
                    lit[0].mailHost, lit[0].mailPort, lit[0].mailSSL, lit[0].mail,
                    lit[0].mailSifre, lit[0].path);
            yazici = comboYazici.SelectedItem.ToString();
            etiket = comboEtiket.SelectedItem.ToString();
            pos = comboPos.SelectedItem.ToString();
            this.Close();
        }

        private void FrmYaziciAyar_Load(object sender, EventArgs e)
        {
            try
            {
                List<SystemDB> lit = ver.Database_Sistem_Bilgi_Getir();
                tema = new Tema(lit[0].indexTema);
                tema.backArray(this);
                tema.buttonArray(btnIptal, btnKaydet);
                tema.labelArray(label1, label2, label3, label4, label5, label6, label7);
                tema.comboArray(comboEtiket, comboPos, comboYazici);
                tema.richArray(txtAciklama);
                foreach (string yazici in PrinterSettings.InstalledPrinters)
                {
                    comboYazici.Items.Add(yazici);
                    comboPos.Items.Add(yazici);
                    comboEtiket.Items.Add(yazici);
                }
                comboYazici.SelectedIndex = lit[0].yazici;
                comboPos.SelectedIndex = lit[0].pos;
                comboEtiket.SelectedIndex = lit[0].etiket;
                txtAciklama.Text = lit[0].text;
                yazici = comboYazici.SelectedItem.ToString();
                etiket = comboEtiket.SelectedItem.ToString();
                pos = comboPos.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Languages.S0205,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
