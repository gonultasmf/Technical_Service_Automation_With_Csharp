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
    public partial class FrmVeriTabani : Form
    {
        public static csVodi ver = new csVodi();
        Tema tema;
        DataGridView tablo;
        public FrmVeriTabani(DataGridView tablo)
        {
            this.tablo = tablo;
            InitializeComponent();
        }

        private void btnYedekle_Click(object sender, EventArgs e)
        {
            if (txtPath.Text != "")
            {
                ver.Database_Yedekle(txtPath.Text);
                lblYedekleme.Visible = true;
            }
            else
            {
                MessageBox.Show(Properties.Languages.S0222, Properties.Languages.S0205,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnYedekleMailTablo_Click(object sender, EventArgs e)
        {
            try
            {
                List<UserDB> list= ver.Database_Kullanici_Bilgileri_Getir();
                List<SystemDB> lit = ver.Database_Sistem_Bilgi_Getir();
                ver.Database_Yedekle(@"C:\ProgramData\VODI_PRO\backup_database.db");
                if (txtMail.Text.Length.Equals(0))
                {
                    MessageBox.Show(Properties.Languages.S0223, Properties.Languages.S0205,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (lit[0].mail == "" || lit[0].mailSifre == "")
                    {
                        MessageBox.Show(Properties.Languages.S0230, Properties.Languages.S0205,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string mailBody = "<table width='100%' style='border:Solid 1px Black'>";
                        foreach (DataGridViewRow row in tablo.Rows)
                        {
                            mailBody += "<tr>";
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                mailBody += "<td style='color:blue;'>" + cell.Value + "</td>";
                            }
                            mailBody += "</tr>";
                        }
                        mailBody += "</table>";

                        MailMessage msj = new MailMessage();
                        msj.To.Add(txtMail.Text);
                        msj.From = new MailAddress(lit[0].mail, list[0].sAdi);
                        msj.Subject = "BACKUP";
                        msj.IsBodyHtml = true;
                        msj.Body = mailBody;

                        SmtpClient smtp = new SmtpClient();
                        smtp.UseDefaultCredentials = true;
                        smtp.Credentials = new System.Net.NetworkCredential(lit[0].mail,
                             lit[0].mailSifre);
                        smtp.Host = "smtp.gmail.com";
                        smtp.Port = 587;
                        smtp.EnableSsl = true;
                        smtp.Send(msj);
                        msj.Dispose();
                        MessageBox.Show(Properties.Languages.S0224, Properties.Languages.S0221,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Languages.S0205, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDosyaYedekleMail_Click(object sender, EventArgs e)
        {
            try
            {
                List<UserDB> list = ver.Database_Kullanici_Bilgileri_Getir();
                List<SystemDB> lit = ver.Database_Sistem_Bilgi_Getir();
                ver.Database_Yedekle(@"C:\ProgramData\VODI_PRO\backup_database.db");
                if (txtMail.Text.Length.Equals(0))
                {
                    MessageBox.Show(Properties.Languages.S0223, Properties.Languages.S0205,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (lit[0].mail == "" || lit[0].mailSifre == "")
                    {
                        MessageBox.Show(Properties.Languages.S0230, Properties.Languages.S0205,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MailMessage msj = new MailMessage();
                        msj.To.Add(txtMailYedek.Text);
                        msj.From = new MailAddress(lit[0].mail,
                            list[0].sAdi);
                        msj.Subject = "BACKUP";
                        msj.IsBodyHtml = true;
                        msj.Body = Properties.Languages.S0225;
                        Attachment attachment;
                        attachment = new Attachment(@"C:\ProgramData\VODI_PRO\backup_database.db");
                        msj.Attachments.Add(attachment);
                        SmtpClient smtp = new SmtpClient();
                        smtp.UseDefaultCredentials = true;
                        smtp.Credentials = new System.Net.NetworkCredential(lit[0].mail,
                            lit[0].mailSifre);
                        smtp.Host = "smtp.gmail.com";
                        smtp.Port = 587;
                        smtp.EnableSsl = true;
                        smtp.Send(msj);
                        msj.Dispose();
                        MessageBox.Show(Properties.Languages.S0224, Properties.Languages.S0221,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Languages.S0205, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMailPath_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "db";
            saveFile.Filter = "db files (*.db)|*.db|All files (*.*)|*.*";
            saveFile.FileName = "backup_database.db";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                txtMailDosyaYolu.Text = saveFile.FileName;
            }
        }

        private void FrmVeriTabani_Load(object sender, EventArgs e)
        {
            List<SystemDB> lit = ver.Database_Sistem_Bilgi_Getir();
            tema = new Tema(lit[0].indexTema);
            tema.backArray(this);
            tema.buttonArray(btnDosyaYedekleMail, btnKapat, btnMailPath,
                btnPath, btnYedekle, btnYedekleMailTablo);
            tema.labelArray(label1, label2, label3, label4, label5, label6, label7);
            tema.chckArray(chckMailYedekle, chckYedekle);
            tema.textBoxArray(txtMail, txtMailDosyaYolu, txtMailYedek, txtPath);
            lblYedekleme.Visible = false;
            chckYedekle.Checked = lit[0].yedekle;
            txtPath.Text = lit[0].path;
            if (lit[0].yedekle)
            {
                txtPath.Enabled = true;
                btnPath.Enabled = true;
                btnYedekle.Enabled = true;
            }
            else
            {
                txtPath.Enabled = false;
                btnPath.Enabled = false;
                btnYedekle.Enabled = false;
            }
            chckMailYedekle.Checked = false;
            txtMail.Enabled = false;
            txtMailDosyaYolu.Enabled = false;
            txtMailYedek.Enabled = false;
            btnDosyaYedekleMail.Enabled = false;
            btnMailPath.Enabled = false;
            btnYedekleMailTablo.Enabled = false;
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "db";
            saveFile.Filter = "db files (*.db)|*.db|All files (*.*)|*.*";
            saveFile.FileName = "backup_database.db";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = saveFile.FileName;
            }
        }

        private void chckYedekle_CheckedChanged(object sender, EventArgs e)
        {
            if (chckYedekle.Checked == false)
            {
                txtPath.Enabled = false;
                btnPath.Enabled = false;
                btnYedekle.Enabled = false;
            }
            else
            {
                txtPath.Enabled = true;
                btnPath.Enabled = true;
                btnYedekle.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chckMailYedekle.Checked == false)
            {
                txtMail.Enabled = false;
                txtMailDosyaYolu.Enabled = false;
                txtMailYedek.Enabled = false;
                btnDosyaYedekleMail.Enabled = false;
                btnMailPath.Enabled = false;
                btnYedekleMailTablo.Enabled = false;
            }
            else
            {
                txtMail.Enabled = true;
                txtMailDosyaYolu.Enabled = true;
                txtMailYedek.Enabled = true;
                btnDosyaYedekleMail.Enabled = true;
                btnMailPath.Enabled = true;
                btnYedekleMailTablo.Enabled = true;
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            List<SystemDB> lit = ver.Database_Sistem_Bilgi_Getir();
            if(chckYedekle.Checked)
                ver.Database_Sistem_Bilgi_Guncelle(lit[0].indexTema, lit[0].indexPara,
                   lit[0].text, lit[0].mesaj1, lit[0].mesaj2, lit[0].sms, lit[0].smsKAdi,
                   lit[0].smsSifre, lit[0].yazici, lit[0].pos, lit[0].etiket, lit[0].aErtele,
                   lit[0].zilSes, lit[0].zilSesim, lit[0].zilSesTekrar, true,
                   lit[0].mailHost, lit[0].mailPort, lit[0].mailSSL, lit[0].mail,
                   lit[0].mailSifre, txtPath.Text);
            else
                ver.Database_Sistem_Bilgi_Guncelle(lit[0].indexTema, lit[0].indexPara,
                   lit[0].text, lit[0].mesaj1, lit[0].mesaj2, lit[0].sms, lit[0].smsKAdi,
                   lit[0].smsSifre, lit[0].yazici, lit[0].pos, lit[0].etiket, lit[0].aErtele,
                   lit[0].zilSes, lit[0].zilSesim, lit[0].zilSesTekrar, false,
                   lit[0].mailHost, lit[0].mailPort, lit[0].mailSSL, lit[0].mail,
                   lit[0].mailSifre, txtPath.Text);
            this.Close();
        }
    }
}
