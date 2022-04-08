using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vodi_Pro.Class;

namespace Vodi_Pro
{
    public partial class FrmSMS : Form
    {
        public csVodi ver = new csVodi();
        Tema tema;
        public int index;
        public string mesajim;
        public FrmSMS(int index)
        {
            this.index = index;
            InitializeComponent();
        }
        void mesaj()
        {
            if (rdBtnMesaj1.Checked)
                mesajim = txtMesaj1.Text;
            else if (rdBtnMesaj2.Checked)
                mesajim = txtMesaj2.Text;
        }
        string XmlPost(string PostAddress, string xmlData)
        {
            using (System.Net.WebClient wUpload = new System.Net.WebClient())
            {
                wUpload.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                Byte[] bPostArray = Encoding.UTF8.GetBytes(xmlData);
                Byte[] bResponse = wUpload.UploadData(PostAddress, "POST", bPostArray);
                Char[] sReturnChars = Encoding.UTF8.GetChars(bResponse);
                string sWebPage = new string(sReturnChars);
                return sWebPage;
            }

        }
        string XMLPOST(string PostAddress, string xmlData)
        {
            try
            {
                var res = "";
                byte[] bytes = Encoding.UTF8.GetBytes(xmlData);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(PostAddress);

                request.Method = "POST";
                request.ContentLength = bytes.Length;
                request.ContentType = "text/xml";
                request.Timeout = 300000000;
                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(bytes, 0, bytes.Length);
                }
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        string message = String.Format(
                        Properties.Languages.S0219+" Received HTTP {0}",
                        response.StatusCode);
                        throw new ApplicationException(message);
                    }

                    Stream responseStream = response.GetResponseStream();
                    using (StreamReader rdr = new StreamReader(responseStream))
                    {
                        res = rdr.ReadToEnd();
                    }
                    return res;
                }
            }
            catch
            {
                return Properties.Languages.S0220;
            }

        }
        private void btnSMS_Click(object sender, EventArgs e)
        {
            mesaj();
            List<UserDB> list = ver.Database_Kullanici_Bilgileri_Getir();
            List<SystemDB> lit = ver.Database_Sistem_Bilgi_Getir();
            if (lit[0].sms == 0)
                using (WebClient client = new WebClient())
                {
                    try
                    {
                        string tur = "Normal";
                        string sms1N = "data=<sms>" +
                                "<kno>" + list[0].tel + "</kno>" +
                                "<kulad>" + lit[0].smsKAdi + "</kulad>" +
                                "<sifre>" + lit[0].smsSifre + "</sifre>" +
                                "<gonderen>" + "SMS TEST" + "</gonderen>" +
                                "<mesaj>" + mesajim + "</mesaj>" +
                                "<numaralar>" + txtTelNo.Text + "</numaralar>" +
                                "<tur>" + tur + "</tur>" +
                            "</sms>";
                        MessageBox.Show(XmlPost("http://panel.vatansms.com/panel/smsgonder1Npost.php", sms1N), Properties.Languages.S0221,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Properties.Languages.S0205, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            else if (lit[0].sms == 1)
            {
                try
                {
                    SmtpClient smtp = new SmtpClient();
                    MailMessage message = new MailMessage();
                    smtp.Credentials = new NetworkCredential(lit[0].smsKAdi,
                        lit[0].smsSifre);
                    smtp.Host = "https://www.ipipi.com/";
                    message.From = new MailAddress(string.Format("{0}@ipipi.com", list[0].tel));
                    message.To.Add(string.Format("{0}@ipipi.com", txtTelNo.Text));
                    message.Subject = list[0].sAdi;
                    message.Body = mesajim;
                    smtp.Send(message);
                    MessageBox.Show(Properties.Languages.S0215, Properties.Languages.S0221,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Properties.Languages.S0205, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (lit[0].sms == 2)
            {
                try
                {
                    String testXml = "<request>";
                    testXml += "<authentication>";
                    testXml += "<username>" + lit[0].smsKAdi + "</username>";
                    testXml += "<password>" + lit[0].smsSifre + "</password>";
                    testXml += "</authentication>";
                    testXml += "<order>";
                    testXml += "<sender>APITEST</sender>";
                    testXml += "<sendDateTime></sendDateTime>";
                    testXml += "<message>";
                    testXml += "<text>" + mesajim + "</text>";
                    testXml += "<receipents>";
                    testXml += "<number>" + txtTelNo.Text + "</number>";
                    testXml += "</receipents>";
                    testXml += "</message>";
                    testXml += "</order>";
                    testXml += "</request>";
                    this.XMLPOST("http://api.iletimerkezi.com/v1/send-sms", testXml);
                    MessageBox.Show(Properties.Languages.S0215, Properties.Languages.S0221,
                            MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Properties.Languages.S0205, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSMS_Load(object sender, EventArgs e)
        {
            List<SystemDB> lit = ver.Database_Sistem_Bilgi_Getir();
            List<CustomerDB> list = ver.Database_Musteri_Bilgileri_Getir(index);
            tema = new Tema(lit[0].indexTema);
            tema.backArray(this);
            tema.buttonArray(btnIptal, btnSMS);
            tema.richArray(txtMesaj1, txtMesaj2);
            tema.textBoxArray(txtTelNo);
            tema.rdBtnArray(rdBtnMesaj1, rdBtnMesaj2);
            tema.labelArray(label1, label2);
            txtTelNo.Text = "90" + list[0].telNo;
            txtTelNo.Text = txtTelNo.Text.Replace(" ", "");
            txtTelNo.Text = txtTelNo.Text.Replace("-", "");
            txtTelNo.Text = txtTelNo.Text.Replace("(", "");
            txtTelNo.Text = txtTelNo.Text.Replace(")", "");
            txtMesaj1.Text = lit[0].mesaj1;
            txtMesaj2.Text = lit[0].mesaj2;
            rdBtnMesaj1.Checked = true;
        }
    }
}
