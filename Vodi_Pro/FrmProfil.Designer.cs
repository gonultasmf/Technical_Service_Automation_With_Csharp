
namespace Vodi_Pro
{
    partial class FrmProfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfil));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::Vodi_Pro.Properties.Resources.profileIcon;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtKullaniciAdi
            // 
            resources.ApplyResources(this.txtKullaniciAdi, "txtKullaniciAdi");
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            // 
            // txtAdSoyad
            // 
            resources.ApplyResources(this.txtAdSoyad, "txtAdSoyad");
            this.txtAdSoyad.Name = "txtAdSoyad";
            // 
            // txtFirmaAdi
            // 
            resources.ApplyResources(this.txtFirmaAdi, "txtFirmaAdi");
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            // 
            // txtTelNo
            // 
            resources.ApplyResources(this.txtTelNo, "txtTelNo");
            this.txtTelNo.Name = "txtTelNo";
            // 
            // txtAdres
            // 
            resources.ApplyResources(this.txtAdres, "txtAdres");
            this.txtAdres.BackColor = System.Drawing.SystemColors.Window;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.ReadOnly = true;
            // 
            // btnDuzenle
            // 
            resources.ApplyResources(this.btnDuzenle, "btnDuzenle");
            this.btnDuzenle.Image = global::Vodi_Pro.Properties.Resources.Apps_system_software_update_icon;
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnYedekle_Click);
            // 
            // FrmProfil
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.txtFirmaAdi);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmProfil";
            this.Load += new System.EventHandler(this.FrmProfil_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtFirmaAdi;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.RichTextBox txtAdres;
        private System.Windows.Forms.Button btnDuzenle;
    }
}