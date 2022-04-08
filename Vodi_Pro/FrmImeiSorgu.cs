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
    public partial class FrmImeiSorgu : Form
    {
        public csVodi ver = new csVodi();
        Tema tema;
        public string imeiNo;
        bool imeitaked = false;
        public FrmImeiSorgu()
        {
            InitializeComponent();
        }

        private void FrmImeiSorgu_Load(object sender, EventArgs e)
        {
            List<SystemDB> lit = ver.Database_Sistem_Bilgi_Getir();
            tema = new Tema(lit[0].indexTema);
            tema.backArray(this);
            tema.labelArray(label3, label1, label2, label4, label5);
            tema.richArray(txtMarka, txtDurum, txtKaynak);
            tema.textBoxArray(txtSTarihi,txtImei);
            tema.buttonArray(btnKapat);
            txtImei.Text = imeiNo;
            webBrowser.Navigate("https://www.turkiye.gov.tr/imei-sorgulama");
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (!imeitaked)
            {
                foreach (HtmlElement item in webBrowser.Document.GetElementsByTagName("input"))
                {
                    if (item.GetAttribute("name") == "txtImei")
                    {
                        item.SetAttribute("value", txtImei.Text);
                        foreach (HtmlElement sitem in webBrowser.Document.GetElementsByTagName("input"))
                        {
                            if (sitem.GetAttribute("className") == "submitButton")
                            {
                                sitem.InvokeMember("Click");
                                imeitaked = true;
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (HtmlElement item in webBrowser.Document.GetElementsByTagName("dl"))
                {
                    if (item.GetAttribute("className") == "compact")
                    {
                        int i = 0;
                        foreach (HtmlElement itesm in item.Children)
                        {
                            if (i % 2 == 1)
                            {
                                if (i == 1)
                                    txtImei.Text = itesm.InnerText;
                                else if (i == 3)
                                    txtDurum.Text = itesm.InnerText;
                                else if (i == 5)
                                    txtKaynak.Text = itesm.InnerText;
                                else if (i == 7)
                                    txtSTarihi.Text = itesm.InnerText;
                                else if (i == 9)
                                    txtMarka.Text = itesm.InnerText;
                            }
                            i++;
                        }
                        imeitaked = false;
                    }
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
