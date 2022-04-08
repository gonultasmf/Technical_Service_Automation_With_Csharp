using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vodi_Pro.Class;

namespace Vodi_Pro
{
    public partial class FrmMaill : Form
    {
        public static csVodi ver = new csVodi();
        Tema tema;
        public int index;
        public FrmMaill(int index)
        {
            this.index = index;
            InitializeComponent();
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            try
            {
                List<UserDB> lit = ver.Database_Kullanici_Bilgileri_Getir();
                List<SystemDB> list = ver.Database_Sistem_Bilgi_Getir();
                if (list[0].mail == "" || list[0].mailSifre == "")
                {
                    MessageBox.Show(Properties.Languages.S0230, Properties.Languages.S0205,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(list[0].mail, lit[0].sAdi);
                    mail.To.Add(txtMail.Text);
                    mail.Subject = txtKonu.Text;
                    if (rdBtnMesaj1.Checked)
                        mail.Body = txtMesaj1.Text;
                    else if (rdBtnMesaj2.Checked)
                        mail.Body = txtMesaj2.Text;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Credentials = new System.Net.NetworkCredential(list[0].mail,
                        list[0].mailSifre);
                    smtp.Port = list[0].mailPort;
                    smtp.Host = list[0].mailHost;
                    smtp.EnableSsl = list[0].mailSSL;
                    smtp.SendAsync(mail, (object)mail);
                    MessageBox.Show(Properties.Languages.S0215, Properties.Languages.S0221,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (SmtpException ex)
            {
                MessageBox.Show(ex.Message, Properties.Languages.S0205,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMail_Load(object sender, EventArgs e)
        {
            List<SystemDB> lit = ver.Database_Sistem_Bilgi_Getir();
            tema = new Tema(lit[0].indexTema);
            tema.backArray(this);
            tema.buttonArray(btnIptal, btnMail);
            tema.labelArray(label1, label2, label3);
            tema.richArray(txtMesaj1, txtMesaj2);
            tema.textBoxArray(txtMail,txtKonu);
            tema.rdBtnArray(rdBtnMesaj1, rdBtnMesaj2);
            List<CustomerDB> list = ver.Database_Musteri_Bilgileri_Getir(index);
            txtMail.Text = list[0].mail;
            txtMesaj1.Text = lit[0].mesaj1;
            txtMesaj2.Text = lit[0].mesaj2;
            rdBtnMesaj1.Checked = true;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
