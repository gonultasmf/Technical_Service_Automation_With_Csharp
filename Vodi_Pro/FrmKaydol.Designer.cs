
namespace Vodi_Pro
{
    partial class FrmKaydol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKaydol));
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblHata = new System.Windows.Forms.Label();
            this.txtTekrarSifre = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIptal
            // 
            resources.ApplyResources(this.btnIptal, "btnIptal");
            this.btnIptal.Image = global::Vodi_Pro.Properties.Resources.multiply;
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnGiris
            // 
            resources.ApplyResources(this.btnGiris, "btnGiris");
            this.btnGiris.Image = global::Vodi_Pro.Properties.Resources.checkmark;
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblHata
            // 
            resources.ApplyResources(this.lblHata, "lblHata");
            this.lblHata.ForeColor = System.Drawing.Color.Red;
            this.lblHata.Name = "lblHata";
            // 
            // txtTekrarSifre
            // 
            resources.ApplyResources(this.txtTekrarSifre, "txtTekrarSifre");
            this.txtTekrarSifre.Name = "txtTekrarSifre";
            // 
            // txtSifre
            // 
            resources.ApplyResources(this.txtSifre, "txtSifre");
            this.txtSifre.Name = "txtSifre";
            // 
            // txtTelNo
            // 
            resources.ApplyResources(this.txtTelNo, "txtTelNo");
            this.txtTelNo.Name = "txtTelNo";
            // 
            // txtAdres
            // 
            resources.ApplyResources(this.txtAdres, "txtAdres");
            this.txtAdres.Name = "txtAdres";
            // 
            // txtFirmaAdi
            // 
            resources.ApplyResources(this.txtFirmaAdi, "txtFirmaAdi");
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            // 
            // txtAdSoyad
            // 
            resources.ApplyResources(this.txtAdSoyad, "txtAdSoyad");
            this.txtAdSoyad.Name = "txtAdSoyad";
            // 
            // txtKullaniciAdi
            // 
            resources.ApplyResources(this.txtKullaniciAdi, "txtKullaniciAdi");
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // FrmKaydol
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.lblHata);
            this.Controls.Add(this.txtTekrarSifre);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtFirmaAdi);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtKullaniciAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmKaydol";
            this.Load += new System.EventHandler(this.FrmKaydol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblHata;
        private System.Windows.Forms.TextBox txtTekrarSifre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtFirmaAdi;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}