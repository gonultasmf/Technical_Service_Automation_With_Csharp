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
    public partial class FrmMailAyar : Form
    {
        csVodi ver = new csVodi();
        Tema tema;
        public FrmMailAyar()
        {
            InitializeComponent();
        }

        private void FrmMailAyar_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = ver.Database_Sistem_Bilgi_Getir();
            tema = new Tema(list[0].indexTema);
            tema.labelArray(label1, label2, label3, label4, label6, label7);
            tema.textBoxArray(txtHost, txtPort, txtMail, txtMailSifre);
            tema.buttonArray(btnIptal, btnKaydet);
            tema.panelArray(panel1);
            tema.chckArray(chckSSL);
            tema.comboArray(comboMail);
            tema.backArray(this);
            txtHost.Text = list[0].mailHost;
            txtPort.Text = list[0].mailPort.ToString();
            chckSSL.Checked = list[0].mailSSL;
            txtMail.Text = list[0].mail;
            txtMailSifre.Text = list[0].mailSifre;
            if (txtHost.Text == "smtp.gmail.com")
                comboMail.SelectedIndex = 1;
            else if (txtHost.Text == "smtp.live.com")
                comboMail.SelectedIndex = 0;
            else if (txtHost.Text == "smtp.mail.yahoo.com")
                comboMail.SelectedIndex = 2;
            else if (txtHost.Text == "smtp.mynet.com")
                comboMail.SelectedIndex = 4;
            else if (txtHost.Text == "smtp.yandex.ru")
                comboMail.SelectedIndex = 3;
            else if (txtHost.Text == "smtp.gmx.com")
                comboMail.SelectedIndex = 5;
            else if (txtHost.Text == "smtp.aol.com")
                comboMail.SelectedIndex = 6;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            List<SystemDB> lit = ver.Database_Sistem_Bilgi_Getir();
            ver.Database_Sistem_Bilgi_Guncelle(lit[0].indexTema, lit[0].indexPara,
                    lit[0].text, lit[0].mesaj1, lit[0].mesaj2, lit[0].sms, lit[0].smsKAdi,
                    lit[0].smsSifre, lit[0].yazici, lit[0].pos, lit[0].etiket, lit[0].aErtele,
                    lit[0].zilSes, lit[0].zilSesim, lit[0].zilSesTekrar, lit[0].yedekle,
                    txtHost.Text, int.Parse(txtPort.Text), chckSSL.Checked,
                    txtMail.Text, txtMailSifre.Text, lit[0].path);
            this.Close();
        }

        private void comboMail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboMail.SelectedIndex == 0)
            {
                txtHost.Text = "smtp.live.com";
                txtPort.Text = "587";
            }
            else if (comboMail.SelectedIndex == 1)
            {
                txtHost.Text = "smtp.gmail.com";
                txtPort.Text = "587";
            } 
            else if (comboMail.SelectedIndex == 2)
            {
                txtHost.Text = "smtp.mail.yahoo.com";
                txtPort.Text = "465";
            }
            else if (comboMail.SelectedIndex == 3)
            {
                txtHost.Text = "smtp.yandex.ru";
                txtPort.Text = "587";
            }
            else if (comboMail.SelectedIndex == 4)
            {
                txtHost.Text = "smtp.mynet.com";
                txtPort.Text = "25";
            }
            else if (comboMail.SelectedIndex == 5)
            {
                txtHost.Text = "smtp.gmx.com";
                txtPort.Text = "25";
            }
            else if (comboMail.SelectedIndex == 6)
            {
                txtHost.Text = "smtp.aol.com";
                txtPort.Text = "25";
            }
        }
    }
}
