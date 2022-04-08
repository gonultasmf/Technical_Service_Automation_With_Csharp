
namespace Vodi_Pro
{
    partial class FrmFiyatHesabi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFiyatHesabi));
            this.txtDonenTL = new System.Windows.Forms.TextBox();
            this.txtGirilecekBirim = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBirimDonenFiyat = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIscilikBedel = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblBirimLogo = new System.Windows.Forms.Label();
            this.comboBirim = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.web = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDonenTL
            // 
            resources.ApplyResources(this.txtDonenTL, "txtDonenTL");
            this.txtDonenTL.Name = "txtDonenTL";
            this.txtDonenTL.ReadOnly = true;
            // 
            // txtGirilecekBirim
            // 
            resources.ApplyResources(this.txtGirilecekBirim, "txtGirilecekBirim");
            this.txtGirilecekBirim.Name = "txtGirilecekBirim";
            this.txtGirilecekBirim.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBox_MouseClick);
            this.txtGirilecekBirim.TextChanged += new System.EventHandler(this.txtGirilecekBirim_TextChanged);
            this.txtGirilecekBirim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGirilecekBirim_KeyPress);
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // txtBirimDonenFiyat
            // 
            resources.ApplyResources(this.txtBirimDonenFiyat, "txtBirimDonenFiyat");
            this.txtBirimDonenFiyat.Name = "txtBirimDonenFiyat";
            this.txtBirimDonenFiyat.ReadOnly = true;
            this.txtBirimDonenFiyat.TextChanged += new System.EventHandler(this.txtBirimDonenFiyat_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSonuc);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtIscilikBedel);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.lblBirimLogo);
            this.panel1.Controls.Add(this.comboBirim);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBirimDonenFiyat);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txtGirilecekBirim);
            this.panel1.Controls.Add(this.txtDonenTL);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // txtSonuc
            // 
            resources.ApplyResources(this.txtSonuc, "txtSonuc");
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.ReadOnly = true;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // txtIscilikBedel
            // 
            resources.ApplyResources(this.txtIscilikBedel, "txtIscilikBedel");
            this.txtIscilikBedel.Name = "txtIscilikBedel";
            this.txtIscilikBedel.Click += new System.EventHandler(this.txtIscilikBedel_Click);
            this.txtIscilikBedel.TextChanged += new System.EventHandler(this.txtIscilikBedel_TextChanged);
            this.txtIscilikBedel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGirilecekBirim_KeyPress);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // lblBirimLogo
            // 
            resources.ApplyResources(this.lblBirimLogo, "lblBirimLogo");
            this.lblBirimLogo.Name = "lblBirimLogo";
            // 
            // comboBirim
            // 
            this.comboBirim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBirim.FormattingEnabled = true;
            this.comboBirim.Items.AddRange(new object[] {
            resources.GetString("comboBirim.Items"),
            resources.GetString("comboBirim.Items1"),
            resources.GetString("comboBirim.Items2")});
            resources.ApplyResources(this.comboBirim, "comboBirim");
            this.comboBirim.Name = "comboBirim";
            this.comboBirim.SelectedIndexChanged += new System.EventHandler(this.comboBirim_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // web
            // 
            resources.ApplyResources(this.web, "web");
            this.web.Name = "web";
            this.web.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webDolar_DocumentCompleted);
            // 
            // FrmFiyatHesabi
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.web);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmFiyatHesabi";
            this.Load += new System.EventHandler(this.frmFiyatHesabi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtDonenTL;
        private System.Windows.Forms.TextBox txtGirilecekBirim;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBirimDonenFiyat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBirim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser web;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIscilikBedel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblBirimLogo;
    }
}