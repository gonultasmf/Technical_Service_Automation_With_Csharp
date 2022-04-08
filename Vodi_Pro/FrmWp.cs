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
    public partial class FrmWp : Form
    {
        public csVodi ver = new csVodi();
        Tema tema;
        public int index;
        public string mesajim;
        public FrmWp(int index)
        {
            this.index = index;
            InitializeComponent();
        }
        public void mesaj()
        {
            if (rdBtnMesaj1.Checked)
                mesajim = txtMesaj1.Text;
            else if (rdBtnMesaj2.Checked)
                mesajim = txtMesaj2.Text;
        }
        private void btnWp_Click(object sender, EventArgs e)
        {
            mesaj();
            string url = "http://api.whatsapp.com/send?phone=" + txtTelNo.Text + "&text=" + mesajim;
            System.Diagnostics.Process.Start(url);
        }

        private void FrmWp_Load(object sender, EventArgs e)
        {
            List<SystemDB> lit = ver.Database_Sistem_Bilgi_Getir();
            List<CustomerDB> list = ver.Database_Musteri_Bilgileri_Getir(index); 
            tema = new Tema(lit[0].indexTema);
            tema.backArray(this);
            tema.buttonArray(btnIptal, btnWp);
            tema.rdBtnArray(rdBtnMesaj1, rdBtnMesaj2);
            tema.textBoxArray(txtTelNo);
            tema.richArray(txtMesaj1, txtMesaj2);
            tema.labelArray(label1, label2);
            txtTelNo.Text = "+90" + list[0].telNo;
            txtTelNo.Text = txtTelNo.Text.Replace(" ", "");
            txtTelNo.Text = txtTelNo.Text.Replace("-", "");
            txtTelNo.Text = txtTelNo.Text.Replace("(", "");
            txtTelNo.Text = txtTelNo.Text.Replace(")", "");
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
