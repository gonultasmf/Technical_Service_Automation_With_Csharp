using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desen;
using Vodi_Pro.Class;

namespace Vodi_Pro
{
    public partial class FrmMusteriGoruntule : Form
    {
        public int index;
        public bool desenMi;
        public static csVodi ver = new csVodi();
        Tema tema;
        public FrmMusteriGoruntule(int index)
        {
            this.index = index;
            InitializeComponent();
        }
        private void FrmMusteriGoruntule_Load(object sender, EventArgs e)
        {
            List<SystemDB> lit = ver.Database_Sistem_Bilgi_Getir();
            tema = new Tema(lit[0].indexTema);
            tema.textBoxArray(txtAlarmTarihi,txtArizaBedeli,txtBitisTarihi,txtKayitTarihi,
                txtYapilanİslem, txtArizaBilgi, txtCihazMarka, txtCihazModel,
                txtCihazSifresi, txtMail, txtMusteriAdi, txtMusteriID);
            tema.labelArray(lblABedel, lblABilgi, lblAciklama, lblCMarka, lblCModel, lblImei,
                lblMAdi, lblKTarih, lblTelNo, lblYIslem, label11, label5,lblMID,label12,
                label14,label15,label16,label17);
            tema.buttonArray(btnDesenSifre, btnFiyatHesapla, btnWp, btnSMS, btnMail,
                btnMusteriGuncelle, btnMusteriSil, btnSorgula, btnMusteriPos, btnMusteriYazdir,
                btnMusteriEtiket,btnBitti,btnKur,btnAlarmSil);
            tema.panelArray(panel1);
            tema.panelUstArray(panel2, panel3, panel4);
            tema.chckArray(chckTeslimEdildi, chckUcretAlindi);
            tema.dateArray(date, time);
            tema.richArray(txtAciklama, txtAlarmAciklama);
            tema.maskTextArray(txtTelefonNo, txtImeiNo);
            tema.backArray(this);
            List<CustomerDB> list = ver.Database_Musteri_Bilgileri_Getir(index);
            txtMusteriID.Text = list[0].Id.ToString();
            txtMusteriAdi.Text = list[0].adi;
            txtTelefonNo.Text = list[0].telNo;
            txtCihazMarka.Text = list[0].cihazMarka;
            txtCihazModel.Text = list[0].cihazModel;
            txtKayitTarihi.Text = list[0].kayitTarihi.ToString();
            txtAciklama.Text = list[0].aciklama;
            if (list[0].teslimEdildi)
                chckTeslimEdildi.Checked = true;
            else
                chckTeslimEdildi.Checked = false;
            txtCihazSifresi.Text = list[0].cihazSifre;
            txtArizaBilgi.Text = list[0].arizaBilgi;
            txtYapilanİslem.Text = list[0].yapilanIslem;
            txtArizaBedeli.Text = list[0].arizaBedeli;
            txtImeiNo.Text = list[0].imeiNo;
            txtBitisTarihi.Text = list[0].bitisTarihi.ToString();
            if (list[0].ucretAlindi)
                chckUcretAlindi.Checked = true;
            else
                chckUcretAlindi.Checked = false;
            txtAlarmTarihi.Text = list[0].alarmTarihi.ToString();
            desenMi = list[0].desen;
            txtMail.Text = list[0].mail;
            txtAlarmAciklama.Text = list[0].alarmAciklama;
            if (desenMi)
            {
                txtCihazSifresi.PasswordChar = '•';
                txtCihazSifresi.Enabled = false;
            }
            else
            {
                txtCihazSifresi.PasswordChar = '\0';
                txtCihazSifresi.Enabled = true;
            }
            if(txtBitisTarihi.Text != "01.01.0001 00:00:00")
                btnBitti.Text = Properties.Languages.S0217;
        }
        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            ver.Database_Musteri_Guncelle(index, txtMusteriAdi.Text, txtCihazMarka.Text, txtCihazModel.Text,
               txtCihazSifresi.Text, txtTelefonNo.Text, txtArizaBilgi.Text, txtAciklama.Text, txtImeiNo.Text,
               txtYapilanİslem.Text, DateTime.Parse(txtBitisTarihi.Text), chckTeslimEdildi.Checked,
               txtArizaBedeli.Text, chckUcretAlindi.Checked, desenMi, txtMail.Text, DateTime.Parse(txtAlarmTarihi.Text),
               txtAlarmAciklama.Text, DateTime.Parse(txtKayitTarihi.Text));
            this.Close();
        }
        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Properties.Languages.S0209, Properties.Languages.S0208, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ver.Database_Musteri_Sil(index);
                    this.Close();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message, Properties.Languages.S0205, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnMusteriEtiket_Click(object sender, EventArgs e)
        {
            try
            {
                printDoc2.PrinterSettings.PrinterName = FrmYaziciAyar.etiket;
                printDialog2.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Languages.S0205,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void printDoc2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Font font = new Font("Arial", 6);
                SolidBrush firca = new SolidBrush(Color.Black);
                Pen kalem = new Pen(Color.LightGray);

                e.Graphics.DrawString($"Tarih: {DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss")}",
                    font, firca, 20, 10);
                font = new Font("Arial", 9, FontStyle.Bold);
                e.Graphics.DrawString("BELLİ İLETİŞİM", font, firca, 40, 25);
                font = new Font("Arial", 7, FontStyle.Bold);
                e.Graphics.DrawString("0534 799 17 82", font, firca, 50, 40);

                font = new Font("Arial", 6, FontStyle.Bold);
                e.Graphics.DrawString(lblMID.Text, font, firca, 15, 60);
                e.Graphics.DrawString(lblMAdi.Text, font, firca, 15, 70);
                e.Graphics.DrawString(lblTelNo.Text, font, firca, 15, 80);
                e.Graphics.DrawString(lblABilgi.Text, font, firca, 15, 90);
                e.Graphics.DrawString(lblABedel.Text, font, firca, 15, 100);

                font = new Font("Arial", 7);
                e.Graphics.DrawString(txtMusteriID.Text, font, firca, 75, 60);
                e.Graphics.DrawString(txtMusteriAdi.Text, font, firca, 75, 70);
                e.Graphics.DrawString(txtTelefonNo.Text, font, firca, 75, 80);
                e.Graphics.DrawString(txtArizaBilgi.Text, font, firca, 75, 90);
                e.Graphics.DrawString(txtArizaBedeli.Text + " ₺", font, firca, 75, 100);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Languages.S0205,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnMusteriPos_Click(object sender, EventArgs e)
        {
            try
            {
                printDoc1.PrinterSettings.PrinterName = FrmYaziciAyar.pos;
                printDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Languages.S0205,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void printDoc1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Font font = new Font("Arial", 7);
                SolidBrush firca = new SolidBrush(Color.Black);
                Pen kalem = new Pen(Color.LightGray);

                e.Graphics.DrawString($"Tarih: {DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss")}",
                    font, firca, 25, 15);
                font = new Font("Arial", 12, FontStyle.Bold);
                e.Graphics.DrawString("BELLİ İLETİŞİM", font, firca, 60, 35);
                font = new Font("Arial", 8, FontStyle.Bold);
                e.Graphics.DrawString("0534 799 17 82", font, firca, 85, 55);
                /*
                e.Graphics.DrawLine(kalem, 15, 30, 300, 30);
                e.Graphics.DrawLine(kalem, 15, 70, 300, 70);
                e.Graphics.DrawLine(kalem, 15, 30, 15, 350);
                e.Graphics.DrawLine(kalem, 300, 30, 300, 350);
                e.Graphics.DrawLine(kalem, 15, 350, 300, 350);
                */

                font = new Font("Arial", 7, FontStyle.Bold);
                e.Graphics.DrawString(lblMID.Text, font, firca, 25, 80);
                e.Graphics.DrawString(lblMAdi.Text, font, firca, 25, 95);
                e.Graphics.DrawString(lblTelNo.Text, font, firca, 25, 110);
                e.Graphics.DrawString(lblCMarka.Text, font, firca, 25, 125);
                e.Graphics.DrawString(lblCModel.Text, font, firca, 25, 140);
                e.Graphics.DrawString(lblABilgi.Text, font, firca, 25, 155);
                e.Graphics.DrawString(lblImei.Text, font, firca, 25, 170);
                e.Graphics.DrawString(lblKTarih.Text, font, firca, 25, 185);
                e.Graphics.DrawString(lblYIslem.Text, font, firca, 25, 200);
                e.Graphics.DrawString(lblABedel.Text, font, firca, 25, 215);
                e.Graphics.DrawString(lblAciklama.Text, font, firca, 25, 230);

                font = new Font("Arial", 8);
                e.Graphics.DrawString(txtMusteriID.Text, font, firca, 100, 80);
                e.Graphics.DrawString(txtMusteriAdi.Text, font, firca, 100, 95);
                e.Graphics.DrawString(txtTelefonNo.Text, font, firca, 100, 110);
                e.Graphics.DrawString(txtCihazMarka.Text, font, firca, 100, 125);
                e.Graphics.DrawString(txtCihazModel.Text, font, firca, 100, 140);
                e.Graphics.DrawString(txtArizaBilgi.Text, font, firca, 100, 155);
                e.Graphics.DrawString(txtImeiNo.Text, font, firca, 100, 170);
                e.Graphics.DrawString(txtKayitTarihi.Text, font, firca, 100, 185);
                e.Graphics.DrawString(txtYapilanİslem.Text, font, firca, 100, 200);
                e.Graphics.DrawString(txtArizaBedeli.Text + " ₺", font, firca, 100, 215);
                font = new Font("Arial", 7);
                e.Graphics.DrawString(txtAciklama.Text, font, firca, 100, 230);
                e.Graphics.DrawLine(kalem, 15, 260, 250, 260);

                font = new Font("Arial", 6);
                firca = new SolidBrush(Color.Gray);
                List<SystemDB> lit = ver.Database_Sistem_Bilgi_Getir();
                e.Graphics.DrawString(lit[0].text, font, firca, 25, 270);
                //MessageBox.Show(sistem.aciklama);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Languages.S0205,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnMusteriYazdir_Click(object sender, EventArgs e)
        {
            try
            {
                printDoc.PrinterSettings.PrinterName = FrmYaziciAyar.yazici;
                printDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Languages.S0205,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Font font = new Font("Arial", 14);
                SolidBrush firca = new SolidBrush(Color.Black);
                Pen kalem = new Pen(Color.Black);

                e.Graphics.DrawString($"Tarih: {DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss")}",
                    font, firca, 60, 25);
                font = new Font("Arial", 20, FontStyle.Bold);
                e.Graphics.DrawString("DRAHNASOFT", font, firca, 325, 75);
                font = new Font("Arial", 12, FontStyle.Bold);
                e.Graphics.DrawString("5302626645", font, firca, 375, 105);
                //e.Graphics.DrawString("********************************", font, firca, 250, 115);
                e.Graphics.DrawLine(kalem, 50, 65, 780, 65);
                e.Graphics.DrawLine(kalem, 50, 130, 780, 130);
                e.Graphics.DrawLine(kalem, 50, 65, 50, 500);
                e.Graphics.DrawLine(kalem, 780, 65, 780, 500);
                e.Graphics.DrawLine(kalem, 50, 500, 780, 500);


                font = new Font("Arial", 15, FontStyle.Bold);
                e.Graphics.DrawString(lblMID.Text, font, firca, 60, 150);
                e.Graphics.DrawString(lblMAdi.Text, font, firca, 60, 180);
                e.Graphics.DrawString(lblTelNo.Text, font, firca, 60, 210);
                e.Graphics.DrawString(lblCMarka.Text, font, firca, 60, 240);
                e.Graphics.DrawString(lblCModel.Text, font, firca, 60, 270);
                e.Graphics.DrawString(lblABilgi.Text, font, firca, 60, 300);
                e.Graphics.DrawString(lblImei.Text, font, firca, 60, 330);
                e.Graphics.DrawString(lblKTarih.Text, font, firca, 60, 360);
                e.Graphics.DrawString(lblYIslem.Text, font, firca, 60, 390);
                e.Graphics.DrawString(lblABedel.Text, font, firca, 60, 420);
                e.Graphics.DrawString(lblAciklama.Text, font, firca, 60, 450);

                font = new Font("Arial", 15);
                e.Graphics.DrawString(txtMusteriID.Text, font, firca, 210, 150);
                e.Graphics.DrawString(txtMusteriAdi.Text, font, firca, 210, 180);
                e.Graphics.DrawString(txtTelefonNo.Text, font, firca, 210, 210);
                e.Graphics.DrawString(txtCihazMarka.Text, font, firca, 210, 240);
                e.Graphics.DrawString(txtCihazModel.Text, font, firca, 210, 270);
                e.Graphics.DrawString(txtArizaBilgi.Text, font, firca, 210, 300);
                e.Graphics.DrawString(txtImeiNo.Text, font, firca, 210, 330);
                e.Graphics.DrawString(txtKayitTarihi.Text, font, firca, 210, 360);
                e.Graphics.DrawString(txtYapilanİslem.Text, font, firca, 210, 390);
                e.Graphics.DrawString(txtArizaBedeli.Text + " ₺", font, firca, 210, 420);
                font = new Font("Arial", 14);
                e.Graphics.DrawString(txtAciklama.Text, font, firca, 210, 450);

                /////////////////////////////////////////////////////////////////////


                font = new Font("Arial", 14);

                e.Graphics.DrawString($"Tarih: {DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss")}",
                    font, firca, 60, 545);
                font = new Font("Arial", 20, FontStyle.Bold);
                e.Graphics.DrawString("DRAHNASOFT", font, firca, 325, 590);
                font = new Font("Arial", 12, FontStyle.Bold);
                e.Graphics.DrawString("5302626645", font, firca, 375, 620);
                //e.Graphics.DrawString("********************************", font, firca, 250, 115);
                e.Graphics.DrawLine(kalem, 50, 580, 780, 580);
                e.Graphics.DrawLine(kalem, 50, 645, 780, 645);
                e.Graphics.DrawLine(kalem, 50, 580, 50, 1020);
                e.Graphics.DrawLine(kalem, 780, 580, 780, 1020);
                e.Graphics.DrawLine(kalem, 50, 1020, 780, 1020);


                font = new Font("Arial", 15, FontStyle.Bold);
                e.Graphics.DrawString(lblMID.Text, font, firca, 60, 670);
                e.Graphics.DrawString(lblMAdi.Text, font, firca, 60, 700);
                e.Graphics.DrawString(lblTelNo.Text, font, firca, 60, 730);
                e.Graphics.DrawString(lblCMarka.Text, font, firca, 60, 760);
                e.Graphics.DrawString(lblCModel.Text, font, firca, 60, 790);
                e.Graphics.DrawString(lblABilgi.Text, font, firca, 60, 820);
                e.Graphics.DrawString(lblImei.Text, font, firca, 60, 850);
                e.Graphics.DrawString(lblKTarih.Text, font, firca, 60, 880);
                e.Graphics.DrawString(lblYIslem.Text, font, firca, 60, 910);
                e.Graphics.DrawString(lblABedel.Text, font, firca, 60, 940);
                e.Graphics.DrawString(lblAciklama.Text, font, firca, 60, 970);

                font = new Font("Arial", 17);
                e.Graphics.DrawString(txtMusteriID.Text, font, firca, 210, 670);
                e.Graphics.DrawString(txtMusteriAdi.Text, font, firca, 210, 700);
                e.Graphics.DrawString(txtTelefonNo.Text, font, firca, 210, 730);
                e.Graphics.DrawString(txtCihazMarka.Text, font, firca, 210, 760);
                e.Graphics.DrawString(txtCihazModel.Text, font, firca, 210, 790);
                e.Graphics.DrawString(txtArizaBilgi.Text, font, firca, 210, 820);
                e.Graphics.DrawString(txtImeiNo.Text, font, firca, 210, 850);
                e.Graphics.DrawString(txtKayitTarihi.Text, font, firca, 210, 880);
                e.Graphics.DrawString(txtYapilanİslem.Text, font, firca, 210, 910);
                e.Graphics.DrawString(txtArizaBedeli.Text + " ₺", font, firca, 210, 940);
                font = new Font("Arial", 14);
                e.Graphics.DrawString(txtAciklama.Text, font, firca, 210, 970);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Languages.S0205,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSMS_Click(object sender, EventArgs e)
        {
            FrmSMS frmSMS = new FrmSMS(index);
            frmSMS.ShowDialog();
        }
        private void btnWp_Click(object sender, EventArgs e)
        {
            FrmWp wp = new FrmWp(index);
            wp.ShowDialog();
        }
        private void btnMail_Click(object sender, EventArgs e)
        {
            FrmMaill mail = new FrmMaill(index);
            mail.ShowDialog();
        }
        private void btnFiyatHesapla_Click(object sender, EventArgs e)
        {
            FrmFiyatHesabi hesap = new FrmFiyatHesabi();
            hesap.MaximizeBox = false;
            hesap.MinimizeBox = false;
            hesap.ShowDialog();
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
                    MessageBox.Show("IMEI No 15 haneli olmalıdır!!!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("İnternet bağlnatısı hatası. Bağlantınız yok!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnKur_Click(object sender, EventArgs e)
        {
            if (DateTime.Parse(DateTime.Now.ToShortDateString()+" "+DateTime.Now.ToShortTimeString()) >=
                DateTime.Parse(date.Value.ToShortDateString()+" "+time.Value.ToShortTimeString()))
            {
                MessageBox.Show(Properties.Languages.S0218,Properties.Languages.S0205,
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                txtAlarmTarihi.Text = date.Value.ToShortDateString() + " " + time.Value.ToLongTimeString();
            }
        }
        private void btnBitti_Click(object sender, EventArgs e)
        {
            txtBitisTarihi.Text = DateTime.Now.ToString();
        }
        private void txtBitisTarihi_TextChanged(object sender, EventArgs e)
        {
            btnBitti.Text = Properties.Languages.S0217;
        }
        private void btnDesenSifre_Click(object sender, EventArgs e)
        {
            Form1 desen;
            Form1.passwordlast = txtCihazSifresi.Text;
            if (desenMi)
            {
                List<int> pass = new List<int>();
                for (int i = 0; i < txtCihazSifresi.Text.Length; i++)
                    pass.Add(int.Parse(txtCihazSifresi.Text[i].ToString()));
                desen = new Form1(liste: pass);
            }
            else
                desen = new Form1();
            desen.ShowDialog();
            if (Form1.passwordlast == null || Form1.passwordlast == "")
            {
                txtCihazSifresi.Enabled = true;
                txtCihazSifresi.PasswordChar = '\0';
                txtCihazSifresi.Text = "";
                desenMi =false;
            }
            else
            {
                desenMi = true;
                txtCihazSifresi.Enabled = false;
                txtCihazSifresi.PasswordChar = '•';
                txtCihazSifresi.Text = Form1.passwordlast;
            }
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
        private void btnAlarmSil_Click(object sender, EventArgs e)
        {
            txtAlarmTarihi.ResetText();
            txtAlarmAciklama.ResetText();
        }

        private void txtImeiNo_Click(object sender, EventArgs e)
        {
            txtImeiNo.SelectAll();
        }

        private void txtTelefonNo_Click(object sender, EventArgs e)
        {
            txtTelefonNo.SelectAll();
        }

        private void txtArizaBedeli_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
