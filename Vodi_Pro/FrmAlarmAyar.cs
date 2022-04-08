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
    public partial class FrmAlarmAyar : Form
    {
        public csVodi ver = new csVodi();
        Tema tema;
        public bool zil;
        public DataGridView tablo;
        public FrmAlarmAyar()
        {
            InitializeComponent();
            
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            List<SystemDB> lit= ver.Database_Sistem_Bilgi_Getir();
            if (chckCalsin.Checked)
                ver.Database_Sistem_Bilgi_Guncelle(lit[0].indexTema, lit[0].indexPara, lit[0].text,
                    lit[0].mesaj1, lit[0].mesaj2, lit[0].sms, lit[0].smsKAdi, lit[0].smsSifre,
                    lit[0].yazici, lit[0].pos, lit[0].etiket, comboErtele.SelectedIndex,
                    true, comboZilSesi.SelectedIndex, comboTekrar.SelectedIndex,
                    lit[0].yedekle, lit[0].mailHost, lit[0].mailPort,lit[0].mailSSL,
                    lit[0].mail, lit[0].mailSifre, lit[0].path);
            else
                ver.Database_Sistem_Bilgi_Guncelle(lit[0].indexTema, lit[0].indexPara, lit[0].text,
                     lit[0].mesaj1, lit[0].mesaj2, lit[0].sms, lit[0].smsKAdi, lit[0].smsSifre,
                     lit[0].yazici, lit[0].pos, lit[0].etiket, comboErtele.SelectedIndex,
                     false, lit[0].zilSesim, lit[0].zilSesTekrar, lit[0].yedekle,
                     lit[0].mailHost, lit[0].mailPort, lit[0].mailSSL, lit[0].mail,
                     lit[0].mailSifre, lit[0].path);
            this.Close();
        }

        private void FrmAlarmAyar_Load(object sender, EventArgs e)
        {
            
            List<SystemDB> lit = ver.Database_Sistem_Bilgi_Getir();
            tema = new Tema(lit[0].indexTema);
            tema.labelArray(label1, label2, label3, label4, lblMusteriSayisi);
            tema.backArray(this);
            tema.buttonArray(btnKaydet, btnIptal);
            tema.tableArray(listeAlarm);
            tema.comboArray(comboErtele, comboTekrar, comboZilSesi);
            tema.chckArray(chckCalsin);
            listeAlarm.DataSource = tablo.DataSource;
            listeAlarm.Columns[5].HeaderText = Properties.Languages.S0194;
            lblMusteriSayisi.Text = Properties.Languages.S0229 + (listeAlarm.Rows.Count - 1);
            comboErtele.SelectedIndex = lit[0].aErtele;
            if (lit[0].zilSes)
                zil = true;
            else
                zil = false;
            chckCalsin.Checked = zil;
            if (chckCalsin.Checked)
            {
                comboZilSesi.Enabled = true;
                comboTekrar.Enabled = true;
            }
            else
            {
                comboZilSesi.Enabled = false;
                comboTekrar.Enabled = false;
            }
            comboZilSesi.SelectedIndex = lit[0].zilSesim;
            comboTekrar.SelectedIndex = lit[0].zilSesTekrar;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chckCalsin_CheckedChanged(object sender, EventArgs e)
        {
            if (chckCalsin.Checked)
            {
                comboZilSesi.Enabled = true;
                comboTekrar.Enabled = true;
            }
            else
            {
                comboZilSesi.Enabled = false;
                comboTekrar.Enabled = false;
            }
        }

        private void listeAlarm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var currentMouseOverRow = listeAlarm.HitTest(e.X, e.Y).RowIndex;
            if (listeAlarm.CurrentRow.Cells[0].Value.ToString().Length > 0)
            {
                if (currentMouseOverRow >= 0)
                {
                    foreach (DataGridViewRow row in listeAlarm.SelectedRows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            FrmMusteriGoruntule ms = new FrmMusteriGoruntule(int.Parse(row.Cells[0].Value.ToString()));
                            ms.ShowDialog();
                        }
                    }
                    listeAlarm.DataSource = tablo.DataSource;
                    //listeAlarm.DataSource = ver.Database_Musterileri_Getir();
                    //listeAlarm.DataSource = ver.Database_Alarm_Musterileri_Getir();
                    lblMusteriSayisi.Text += (listeAlarm.RowCount - 1);
                }
            }
            else
            {
                MessageBox.Show(Properties.Languages.S0206, Properties.Languages.S0205, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
