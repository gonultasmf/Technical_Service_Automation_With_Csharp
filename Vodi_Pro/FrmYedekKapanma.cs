using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Vodi_Pro.Class;

namespace Vodi_Pro
{
    public partial class FrmYedekKapanma : Form
    {
        csVodi ver = new csVodi();
        public FrmYedekKapanma()
        {
            InitializeComponent();
            
        }

        private void FrmYedekKapanma_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = ver.Database_Sistem_Bilgi_Getir();
            try
            {
                ver.Database_Yedekle(list[0].path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
