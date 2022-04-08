using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Net.NetworkInformation;
using Desen;
using System.IO;
using Vodi_Pro.Class;

namespace Vodi_Pro
{
    public partial class FrmAnaSayfa : Form
    {
        public csVodi ver = new csVodi();
        Tema tema;
        public bool desenMi;
        public int count;
        public FrmAnaSayfa()
        {
            this.Hide();
            FrmGiris frmGiris = new FrmGiris();
            frmGiris.ShowDialog();
            InitializeComponent();
         
        }
        
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            if (!FrmGiris.asds)
            {
                this.Close();
                return;
            }
            List<SystemDB> lit = ver.Database_Sistem_Bilgi_Getir();
            tema = new Tema(lit[0].indexTema);
            türkçeToolStripMenuItem.Checked = false;
            ingilizceToolStripMenuItem.Checked = false;
            ispanyolcaToolStripMenuItem.Checked = false;
            arapçaToolStripMenuItem.Checked = false;
            txtImeiNo.Culture = InputLanguage.DefaultInputLanguage.Culture;
            txtTelefonNo.Culture = InputLanguage.DefaultInputLanguage.Culture;
            tema.textBoxArray(txtArama, txtArizaBilgi, txtCihazMarka, txtCihazModel,
                txtCihazSifresi, txtMail, txtMusteriAdi);
            tema.richArray(txtAciklama);
            tema.labelArray(label1, lblABilgi, lblAciklama, lblCMarka, lblCModel, lblImei,
                lblMAdi, lblMusteriSayisi, lblTeslimEdilmeyen, lblTelNo, lblZaman, label11, label5);
            tema.buttonArray(btnDesenSifre, btnFiyatHesapla, btnIptal, btnKaydet,
                btnMusteriGoruntule, btnMusteriSil, btnSorgula, btnSorgula);
            tema.menuItemArray(profilimToolStripMenuItem, profilEkleToolStripMenuItem,
                sistemAyarlarıToolStripMenuItem, yazıcıAyarlarıToolStripMenuItem,
                sMSAyarlarıToolStripMenuItem, verileriExceleAktarToolStripMenuItem, mailAyarlarıToolStripMenuItem,
                veriTabanıToolStripMenuItem, dilAyarlarıToolStripMenuItem, hakkındaToolStripMenuItem,
                aktivasyonToolStripMenuItem, kullanımKılavuzuToolStripMenuItem, geriBildirimToolStripMenuItem,
                alarmAyarlarıToolStripMenuItem, türkçeToolStripMenuItem, ingilizceToolStripMenuItem,
                ispanyolcaToolStripMenuItem, arapçaToolStripMenuItem, çıkışToolStripMenuItem);
            tema.panelArray(panel1, panel2);
            tema.panelUstArray(panel3, panel4, panel5);
            tema.menuArray(menuStrip1);
            tema.comboArray(comboAramaOlcutu);
            tema.tableArray(listeMusteri);
            tema.maskTextArray(txtImeiNo, txtTelefonNo);
            tema.backArray(this);
            if (Properties.Settings.Default.Languages == "TR")
                türkçeToolStripMenuItem.Checked = true;
            else if (Properties.Settings.Default.Languages == "EN")
                ingilizceToolStripMenuItem.Checked = true;
            else if (Properties.Settings.Default.Languages == "ES")
                ispanyolcaToolStripMenuItem.Checked = true;
            else if (Properties.Settings.Default.Languages == "AR")
                arapçaToolStripMenuItem.Checked = true;
            comboAramaOlcutu.SelectedIndex = 0;
            ListDoldur(listeMusteri,false);
            ListDoldur(listeAlarm, true);
            listMusteri.DataSource = ver.Database_Musterileri_Getir();
            count = listeMusteri.RowCount - 1;
            lblMusteriSayisi.Text = Properties.Languages.S0226 + listeMusteri.RowCount.ToString();
            TeslimMusteri();
            timer1.Start();
        }
        public void ListDoldur(DataGridView gridView, bool alarm)
        {
            List<CustomerDB> customerList = ver.Database_Musterileri_Getir();
            System.Data.DataTable tablom = new System.Data.DataTable();
            tablom.Columns.Add(Properties.Languages.S0185, typeof(int));
            tablom.Columns.Add(Properties.Languages.S0186, typeof(string));
            tablom.Columns.Add(Properties.Languages.S0188, typeof(string));
            tablom.Columns.Add(Properties.Languages.S0189, typeof(string));
            tablom.Columns.Add(Properties.Languages.S0187, typeof(string));
            tablom.Columns.Add(Properties.Languages.S0193, typeof(DateTime));
            tablom.Columns.Add(Properties.Languages.S0190, typeof(string));
            tablom.Columns.Add(Properties.Languages.S0191, typeof(string));
            tablom.Columns.Add(Properties.Languages.S0192, typeof(bool));
            for (int i = 0; i < customerList.Count; i++)
            {
                if (alarm)
                    tablom.Rows.Add(customerList[i].Id, customerList[i].adi,
                        customerList[i].cihazMarka, customerList[i].cihazModel,
                        customerList[i].telNo, customerList[i].alarmTarihi,
                        customerList[i].arizaBilgi, customerList[i].aciklama,
                        customerList[i].teslimEdildi);
                else
                    tablom.Rows.Add(customerList[i].Id, customerList[i].adi,
                        customerList[i].cihazMarka, customerList[i].cihazModel,
                        customerList[i].telNo, customerList[i].kayitTarihi,
                        customerList[i].arizaBilgi, customerList[i].aciklama,
                        customerList[i].teslimEdildi);
            }
            gridView.DataSource = tablom;
        }
        public void TeslimMusteri()
        {
            int counter = 0;
            foreach (DataGridViewRow row in listeMusteri.Rows)
                if (row.Cells[0].Value != null)
                    foreach (DataGridViewCell cell in row.Cells)
                        if (cell.FormattedValue.Equals(false))
                            counter++;      
            lblTeslimEdilmeyen.Text = Properties.Languages.S0227 + counter;
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblZaman.Text = DateTime.Now.ToShortDateString() + "   " + DateTime.Now.ToLongTimeString();
            foreach (DataGridViewRow row in listeAlarm.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    int id = int.Parse(row.Cells[0].Value.ToString());
                    if (row.Cells[4].Value.Equals(DateTime.MinValue))
                    {
                        listeAlarm.CurrentRow.Selected = row.Selected;
                        listeAlarm.ClearSelection();
                    }
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        //MessageBox.Show(cell.Value.ToString() + "\n" + DateTime.Now.ToString());
                        if (DateTime.Now.ToString() == cell.Value.ToString())
                        {
                            FrmAlarm alarm = new FrmAlarm(id);
                            alarm.ShowDialog();
                        }
                    }
                }
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtMusteriAdi.TextLength != 0 || txtCihazMarka.TextLength != 0 ||
                txtArizaBilgi.TextLength != 0 || txtCihazModel.TextLength != 0 ||
                txtCihazSifresi.TextLength != 0 || txtAciklama.TextLength != 0)
                ver.Database_Musteri_Ekle(txtMusteriAdi.Text, txtCihazMarka.Text, txtCihazModel.Text,
                    txtCihazSifresi.Text, txtTelefonNo.Text, txtArizaBilgi.Text, txtAciklama.Text,
                    txtImeiNo.Text, desenMi, txtMail.Text);
            else
                MessageBox.Show(Properties.Languages.S0233,
                    Properties.Languages.S0205, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            txtMusteriAdi.ResetText();
            txtCihazMarka.ResetText();
            txtCihazModel.ResetText();
            txtCihazSifresi.ResetText();
            txtTelefonNo.ResetText();
            txtArizaBilgi.ResetText();
            txtAciklama.ResetText();
            txtImeiNo.ResetText();
            txtMail.ResetText();
            txtCihazSifresi.Enabled = true;
            desenMi = false;
            ListDoldur(listeMusteri, false);
            lblMusteriSayisi.Text = Properties.Languages.S0226 + listeMusteri.RowCount.ToString();
            TeslimMusteri();
            count = listeMusteri.RowCount - 1;
        }
        private void btnIptalEt_Click(object sender, EventArgs e)
        {
            txtMusteriAdi.ResetText();
            txtCihazMarka.ResetText();
            txtCihazModel.ResetText();
            txtCihazSifresi.ResetText();
            txtTelefonNo.ResetText();
            txtArizaBilgi.ResetText();
            txtAciklama.ResetText();
            txtImeiNo.ResetText();

        }
        private void btnFiyatHesapla_Click(object sender, EventArgs e)
        {
            if (NetworkInterface.GetIsNetworkAvailable() == true)
            {
                FrmFiyatHesabi hesap = new FrmFiyatHesabi();
                hesap.ShowDialog();
            }
            else
            {
                MessageBox.Show(Properties.Languages.S0207, Properties.Languages.S0205, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Properties.Languages.S0209, Properties.Languages.S0208, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in listeMusteri.SelectedRows)
                {
                    int index = Convert.ToInt32(row.Cells[0].Value);
                    ver.Database_Musteri_Sil(index);
                }
                ListDoldur(listeMusteri, false);
                ListDoldur(listeAlarm, true);
                lblMusteriSayisi.Text = Properties.Languages.S0226 + listeMusteri.RowCount.ToString();
                TeslimMusteri();
                count = listeMusteri.RowCount - 1;
            }
        }
        private void btnMusteriGoruntule_Click(object sender, EventArgs e)
        {
            if (listeMusteri.SelectedRows.Count == 1)
            {
                    if (listeMusteri.CurrentRow.Cells[0].Value.ToString().Length > 0)
                    {
                        foreach (DataGridViewRow row in listeMusteri.SelectedRows)
                        {
                            if (row.Cells[0].Value != null)
                            {
                                FrmMusteriGoruntule ms = new FrmMusteriGoruntule(int.Parse(row.Cells[0].Value.ToString()));
                                ms.ShowDialog();
                            }
                        }
                        ListDoldur(listeMusteri, false);
                        ListDoldur(listeAlarm, true);
                        lblMusteriSayisi.Text = Properties.Languages.S0226 + listeMusteri.RowCount.ToString();
                        TeslimMusteri();
                        count = listeMusteri.RowCount - 1;
                    }
                    else
                        MessageBox.Show(Properties.Languages.S0206, Properties.Languages.S0205, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (listeMusteri.SelectedRows.Count == 0)
            {
                MessageBox.Show(Properties.Languages.S0210, Properties.Languages.S0205, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(Properties.Languages.S0211, Properties.Languages.S0205, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtArama_EditValueChanged(object sender, EventArgs e)
        {
            ver.Database_Musteri_Arama(comboAramaOlcutu.SelectedIndex, listeMusteri, txtArama.Text);
        }
        private void listeMusteri_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var currentMouseOverRow = listeMusteri.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    foreach (DataGridViewRow row in listeMusteri.SelectedRows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            FrmMusteriGoruntule ms = new FrmMusteriGoruntule(int.Parse(row.Cells[0].Value.ToString()));
                            ms.ShowDialog();
                        }
                    }
                    ListDoldur(listeMusteri, false);
                    ListDoldur(listeAlarm, true);
                    lblMusteriSayisi.Text = Properties.Languages.S0226 + listeMusteri.RowCount.ToString();
                    TeslimMusteri();
                    count = listeMusteri.RowCount - 1;
                }
            else
                MessageBox.Show(Properties.Languages.S0206, Properties.Languages.S0205, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void listeMusteri_MouseClick(object sender, MouseEventArgs e)
        {
            var currentMouseOverRow = listeMusteri.HitTest(e.X, e.Y).RowIndex;
            if (currentMouseOverRow >= 0)
            {
                if (listeMusteri.CurrentRow.Selected == true)
                    btnMusteriGoruntule.Enabled = true;
                else
                    btnMusteriGoruntule.Enabled = false;
            }
        }
        private void menuSistemAyarlari_Click(object sender, EventArgs e)
        {
            FrmSistemAyarlari sistem = new FrmSistemAyarlari(); 
            using (sistem)
            {
                sistem.ShowDialog();
            }
            this.FrmAnaSayfa_Load(null,null);
        }
        private void menuCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void menuProfil_Click(object sender, EventArgs e)
        {
            FrmProfil profil = new FrmProfil();
            profil.ShowDialog();
        }
        private void btnSorgula_Click(object sender, EventArgs e)
        {
            if (NetworkInterface.GetIsNetworkAvailable() == true)
            {
                int length = txtImeiNo.TextLength;
                foreach (char item in txtImeiNo.Text)
                {
                    if (item == ' ')
                        length--;
                }
                if (length.Equals(15))
                {
                    FrmImeiSorgu imeiSorgu = new FrmImeiSorgu();
                    imeiSorgu.imeiNo = txtImeiNo.Text;
                    imeiSorgu.ShowDialog();
                }
                else
                    MessageBox.Show(Properties.Languages.S0212, Properties.Languages.S0205, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(Properties.Languages.S0207, Properties.Languages.S0205, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void menuHakkinda_Click(object sender, EventArgs e)
        {
            FrmHakkinda hakkinda = new FrmHakkinda();
            hakkinda.ShowDialog();
        }
        private void btnDesenSifre_Click(object sender, EventArgs e)
        {
            Form1 desen;
            Form1.passwordlast = txtCihazSifresi.Text;
            if (desenMi)
            {
                List<int> pass = new List<int>();
                for (int i = 0; i < txtCihazSifresi.Text.Length; i++)
                {
                    pass.Add(int.Parse(txtCihazSifresi.Text[i].ToString()));
                }
                desen = new Form1(liste: pass);
            }
            else
            {
                desen = new Form1();
            }

            desen.ShowDialog();

            if (Form1.passwordlast == null || Form1.passwordlast == "")
            {
                txtCihazSifresi.Enabled = true;
                txtCihazSifresi.PasswordChar = '\0';
                txtCihazSifresi.Text = "";
                desenMi = false;
            }
            else
            {
                desenMi = true;
                txtCihazSifresi.Enabled = false;
                txtCihazSifresi.PasswordChar = '•';
                txtCihazSifresi.Text = Form1.passwordlast;
            }
        }
        private void menuKullanimKilavuz_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCMsYLATtQ0aPB7q9d4o-umw");
        }
        private void comboAramaOlcutu_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtArama.Text = "";
        }
        private void sMSAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSMSAyar smsAyar = new FrmSMSAyar();
            smsAyar.ShowDialog();
        }
        private void yazıcıAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYaziciAyar yaziciAyar = new FrmYaziciAyar();
            yaziciAyar.ShowDialog();
        }
        private void verileriExceleAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Properties.Languages.S0213, Properties.Languages.S0208, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                object Missing = Type.Missing;
                Workbook workbook = excel.Workbooks.Add(Missing);
                Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.DefaultExt = "xls";
                saveFile.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFile.FileName = "backup_veri_excel.xls";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFile.FileName, XlFileFormat.xlWorkbookNormal);
                }
                int StartCol = 1;
                int StartRow = 1;
                for (int i = 0; i < listMusteri.Columns.Count; i++)
                {
                    Range myRange = (Range)sheet1.Cells[StartRow, StartCol + i];
                    myRange.Value2 = listMusteri.Columns[i].HeaderText;
                }
                StartRow++;
                for (int i = 0; i < listMusteri.Rows.Count; i++)
                {
                    for (int j = 0; j < listMusteri.Columns.Count; j++)
                    {
                        Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = listMusteri[j, i].Value == null ? "" : listMusteri[j, i].Value;
                        myRange.Select();
                    }
                }
                workbook.Close(true);
                excel.Quit();
            }
        }
        private void veriTabanıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVeriTabani veriTabani = new FrmVeriTabani(listMusteri);
            veriTabani.ShowDialog();
        }
        private void profilEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKaydol kaydol = new FrmKaydol();
            kaydol.ShowDialog();
        }
        private void alarmAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlarmAyar alarmAyar = new FrmAlarmAyar();
            alarmAyar.tablo = listeAlarm;
            alarmAyar.ShowDialog();
        }
        private void txtImeiNo_TextChanged(object sender, EventArgs e)
        {
            int length = txtImeiNo.TextLength;
            foreach (char item in txtImeiNo.Text)
            {
                if (item == ' ')
                    length--;
            }
            if (length.Equals(15))
                btnSorgula.Enabled = true;
            else
                btnSorgula.Enabled = false;
        }
        private void txtArama_Enter(object sender, EventArgs e)
        {
            txtArama.Text = "";
            txtArama.Font = new System.Drawing.Font("Tahoma", 9F,
                FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        }
        private void ingilizceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Languages = "EN";
            Properties.Settings.Default.Save();
            if (MessageBox.Show(Properties.Languages.S0214, Properties.Languages.S0208, MessageBoxButtons.OK,
                MessageBoxIcon.Information) == DialogResult.OK)
            {
                System.Windows.Forms.Application.Restart();
            }
        }
        private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Languages = "TR";
            Properties.Settings.Default.Save();
            if (MessageBox.Show(Properties.Languages.S0214, Properties.Languages.S0208, MessageBoxButtons.OK,
                MessageBoxIcon.Information) == DialogResult.OK)
            {
                System.Windows.Forms.Application.Restart();
            }
        }
        private void ispanyolcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Languages = "ES";
            Properties.Settings.Default.Save();
            if (MessageBox.Show(Properties.Languages.S0214, Properties.Languages.S0208, MessageBoxButtons.OK,
                MessageBoxIcon.Information) == DialogResult.OK)
            {
                System.Windows.Forms.Application.Restart();
            }
        }
        private void arapçaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Languages = "AR";
            Properties.Settings.Default.Save();
            if (MessageBox.Show(Properties.Languages.S0214, Properties.Languages.S0208, MessageBoxButtons.OK,
                MessageBoxIcon.Information) == DialogResult.OK)
            {
                System.Windows.Forms.Application.Restart();
            }
        }
        private void geriBildirimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFeedBack feedBack = new FrmFeedBack();
            feedBack.ShowDialog();
        }
        private void mailAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMailAyar mailAyar = new FrmMailAyar();
            mailAyar.ShowDialog();
        }

        private void txtTelefonNo_Click(object sender, EventArgs e)
        {
            txtTelefonNo.SelectAll();
        }

        private void txtImeiNo_Click(object sender, EventArgs e)
        {
            txtImeiNo.SelectAll();
        }

        private void aktivasyonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAktivasyon aktivasyon = new FrmAktivasyon();
            aktivasyon.ShowDialog();
        }
        private void FrmAnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<SystemDB> list = ver.Database_Sistem_Bilgi_Getir();
            if (list[0].yedekle)
            {
                this.Enabled = true;
                FrmYedekKapanma yedekKapanma = new FrmYedekKapanma();
                yedekKapanma.ShowDialog();
            }

        }
        private void yazıcıAyarlarıToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmYaziciAyar yaziciAyar = new FrmYaziciAyar();
            yaziciAyar.ShowDialog();
        }
    }
}
