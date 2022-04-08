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
    public partial class FrmFeedBack : Form
    {
        public csVodi ver = new csVodi();
        Tema tema;
        public FrmFeedBack()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            
           
        }

        private void FrmFeedBack_Load(object sender, EventArgs e)
        {
            List<SystemDB> lit = ver.Database_Sistem_Bilgi_Getir();
            tema = new Tema(lit[0].indexTema);
            tema.buttonArray(btnIptal, btnMail);
            tema.textBoxArray(txtKonu,textBox1);
            tema.labelArray(label1, label2, label3);
            tema.richArray(txtMesaj);
            tema.backArray(this);
        }
    }
}
