using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vodi_Pro.Class;

namespace Vodi_Pro
{
    public partial class FrmFiyatHesabi : Form
    {
        public static csVodi ver = new csVodi();
        static double donenPara;
        Tema tema;
        public FrmFiyatHesabi()
        {
            InitializeComponent();
        }
        private void frmFiyatHesabi_Load(object sender, EventArgs e)
        {
            List<SystemDB> lit = ver.Database_Sistem_Bilgi_Getir();
            tema = new Tema(lit[0].indexTema);
            tema.backArray(this);
            tema.textBoxArray(txtIscilikBedel,txtGirilecekBirim);
            tema.labelArray(label1, label11, label12,label13,label14,label15,label16,label17,label18,lblBirimLogo);
            comboBirim.SelectedIndex = lit[0].indexPara;
            tema.comboArray(comboBirim);
            web.ScriptErrorsSuppressed = true;
        }
        private void comboBirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBirim.Text == "Dolar")
                web.Navigate("https://www.google.com/search?q=dolar&oq=dolar&aqs=chrome.0.69i59.2192j0j7&sourceid=chrome&ie=UTF-8");
            else if (comboBirim.Text == "Euro")
                web.Navigate("https://www.google.com/search?q=euro&oq=euro&aqs=chrome..69i57j69i59j69i60.1213j0j7&sourceid=chrome&ie=UTF-8");
            else if (comboBirim.Text == "Sterlin")
                web.Navigate("https://www.google.com/search?q=sterlin&oq=sterlin&aqs=chrome..69i57.1400j0j7&sourceid=chrome&ie=UTF-8");
        }

        private void webDolar_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlElementCollection veri = web.Document.All;
            if (comboBirim.Text == "Dolar")
            {
                foreach (HtmlElement name in veri)
                {
                    if (name.GetAttribute("className") == "DFlfde SwHCTb")
                    {
                        donenPara = Double.Parse(name.InnerText.Replace(",", "."), CultureInfo.InvariantCulture);
                        txtBirimDonenFiyat.Text = name.InnerText + " $";
                        lblBirimLogo.Text = "($)";
                    }
                }
            }
            else if (comboBirim.Text == "Euro")
            {
                foreach (HtmlElement name in veri)
                {
                    if (name.GetAttribute("className") == "DFlfde SwHCTb")
                    {
                        donenPara = Double.Parse(name.InnerText.Replace(",","."), CultureInfo.InvariantCulture);
                        txtBirimDonenFiyat.Text = name.InnerText + " €";
                        lblBirimLogo.Text = "(€)";
                    }
                }
            }
            else if (comboBirim.Text == "Sterlin")
            {
                foreach (HtmlElement name in veri)
                {
                    if (name.GetAttribute("className") == "DFlfde SwHCTb")
                    {
                        donenPara = Double.Parse(name.InnerText.Replace(",", "."), CultureInfo.InvariantCulture);
                        txtBirimDonenFiyat.Text = name.InnerText + " £";
                        lblBirimLogo.Text = "(£)";
                    }
                }
            }
        }

        private void txtGirilecekBirim_TextChanged(object sender, EventArgs e)
        {
            if (txtGirilecekBirim.Text == "")
                txtGirilecekBirim.Text = "0";
            txtDonenTL.Text = (donenPara * Convert.ToDouble(txtGirilecekBirim.Text)).ToString();
            if (txtIscilikBedel.Text != "")
                txtSonuc.Text = (Convert.ToDouble(txtDonenTL.Text) + Convert.ToDouble(txtIscilikBedel.Text)).ToString();
            else
                txtSonuc.Text = (Convert.ToDouble(txtDonenTL.Text) + Convert.ToDouble(0)).ToString();
        }

        private void txtIscilikBedel_TextChanged(object sender, EventArgs e)
        {
            if (txtIscilikBedel.Text == "")
                txtIscilikBedel.Text = "0";
            if (txtGirilecekBirim.Text != "")
                txtSonuc.Text = (Convert.ToDouble(txtDonenTL.Text) + Convert.ToDouble(txtIscilikBedel.Text)).ToString();
            else
                txtSonuc.Text = (Convert.ToDouble(txtDonenTL.Text) + Convert.ToDouble(txtIscilikBedel.Text)).ToString();
        }

        private void txtBirimDonenFiyat_TextChanged(object sender, EventArgs e)
        {
            if (txtGirilecekBirim.Text == "" && txtIscilikBedel.Text == "")
            {
                txtGirilecekBirim.Text = "0";
                txtIscilikBedel.Text = "0";
            }
            
            txtDonenTL.Text = (donenPara * Convert.ToDouble(txtGirilecekBirim.Text)).ToString();
            txtSonuc.Text = (Convert.ToDouble(txtDonenTL.Text) + Convert.ToDouble(txtIscilikBedel.Text)).ToString();
        }

        private void txtBox_MouseClick(object sender, MouseEventArgs e)
        {
            txtGirilecekBirim.SelectAll();
        }

        private void txtIscilikBedel_Click(object sender, EventArgs e)
        {
            txtIscilikBedel.SelectAll();
        }

        private void txtGirilecekBirim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
