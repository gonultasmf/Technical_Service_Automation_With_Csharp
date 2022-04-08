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
    public delegate void FilnfilasHandler(object sender, EventArgs e);
    public partial class FrmSistemAyarlari : Form
    {
        public event FilnfilasHandler NewDele;

        public static csVodi ver = new csVodi();
        Tema tema;
        public int index;
        public FrmSistemAyarlari()
        {
            InitializeComponent();
        }

        private void FrmSistemAyarlari_Load(object sender, EventArgs e)
        {
            List<SystemDB> lit = ver.Database_Sistem_Bilgi_Getir();
            tema = new Tema(lit[0].indexTema);
            tema.backArray(this);
            tema.buttonArray(btnIptal, btnKaydet);
            tema.labelArray(label2, label1);
            tema.comboArray(comboBirim, comboTema);
            comboBirim.SelectedIndex = lit[0].indexPara;
            comboTema.SelectedIndex = lit[0].indexTema;
            index = comboTema.SelectedIndex;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            List<SystemDB> lit = ver.Database_Sistem_Bilgi_Getir();
            ver.Database_Sistem_Bilgi_Guncelle(comboTema.SelectedIndex, comboBirim.SelectedIndex,
                    lit[0].text, lit[0].mesaj1, lit[0].mesaj2, lit[0].sms, lit[0].smsKAdi,
                    lit[0].smsSifre, lit[0].yazici, lit[0].pos, lit[0].etiket, lit[0].aErtele,
                    lit[0].zilSes, lit[0].zilSesim, lit[0].zilSesTekrar, lit[0].yedekle,
                    lit[0].mailHost, lit[0].mailPort, lit[0].mailSSL, lit[0].mail,
                    lit[0].mailSifre, lit[0].path);
            index = comboTema.SelectedIndex;
            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tema newTemay = new Tema(comboTema.SelectedIndex);
            newTemay.backArray(this);
            newTemay.buttonArray(btnIptal, btnKaydet);
            newTemay.labelArray(label2, label1);
            newTemay.comboArray(comboBirim, comboTema);
            this.Refresh();
        }
    }
}
