
namespace Vodi_Pro
{
    partial class FrmMailAyar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMailAyar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboMail = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMailSifre = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.chckSSL = new System.Windows.Forms.CheckBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.comboMail);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtMailSifre);
            this.panel1.Controls.Add(this.txtMail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.btnIptal);
            this.panel1.Controls.Add(this.chckSSL);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.txtHost);
            this.panel1.Name = "panel1";
            // 
            // comboMail
            // 
            resources.ApplyResources(this.comboMail, "comboMail");
            this.comboMail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMail.FormattingEnabled = true;
            this.comboMail.Items.AddRange(new object[] {
            resources.GetString("comboMail.Items"),
            resources.GetString("comboMail.Items1"),
            resources.GetString("comboMail.Items2"),
            resources.GetString("comboMail.Items3"),
            resources.GetString("comboMail.Items4"),
            resources.GetString("comboMail.Items5"),
            resources.GetString("comboMail.Items6")});
            this.comboMail.Name = "comboMail";
            this.comboMail.SelectedIndexChanged += new System.EventHandler(this.comboMail_SelectedIndexChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // txtMailSifre
            // 
            resources.ApplyResources(this.txtMailSifre, "txtMailSifre");
            this.txtMailSifre.Name = "txtMailSifre";
            // 
            // txtMail
            // 
            resources.ApplyResources(this.txtMail, "txtMail");
            this.txtMail.Name = "txtMail";
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
            // btnKaydet
            // 
            resources.ApplyResources(this.btnKaydet, "btnKaydet");
            this.btnKaydet.Image = global::Vodi_Pro.Properties.Resources.checkmark;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            resources.ApplyResources(this.btnIptal, "btnIptal");
            this.btnIptal.Image = global::Vodi_Pro.Properties.Resources.multiply;
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // chckSSL
            // 
            resources.ApplyResources(this.chckSSL, "chckSSL");
            this.chckSSL.Name = "chckSSL";
            this.chckSSL.UseVisualStyleBackColor = true;
            // 
            // txtPort
            // 
            resources.ApplyResources(this.txtPort, "txtPort");
            this.txtPort.Name = "txtPort";
            // 
            // txtHost
            // 
            resources.ApplyResources(this.txtHost, "txtHost");
            this.txtHost.Name = "txtHost";
            // 
            // FrmMailAyar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMailAyar";
            this.Load += new System.EventHandler(this.FrmMailAyar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chckSSL;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMailSifre;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboMail;
        private System.Windows.Forms.Label label4;
    }
}