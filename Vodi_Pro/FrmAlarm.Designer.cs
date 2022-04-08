
namespace Vodi_Pro
{
    partial class FrmAlarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlarm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAlarmKapat = new System.Windows.Forms.Button();
            this.btnErtele = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnWp = new System.Windows.Forms.Button();
            this.btnMail = new System.Windows.Forms.Button();
            this.btnSMS = new System.Windows.Forms.Button();
            this.txtAlarmAciklama = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTeslim = new System.Windows.Forms.Label();
            this.lblUcretAlindi = new System.Windows.Forms.Label();
            this.lblABilgi = new System.Windows.Forms.Label();
            this.lblABedel = new System.Windows.Forms.Label();
            this.lblCihazModel = new System.Windows.Forms.Label();
            this.lblCihazMarka = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.lblMID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.btnAlarmKapat);
            this.panel1.Controls.Add(this.btnErtele);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtAlarmAciklama);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTeslim);
            this.panel1.Controls.Add(this.lblUcretAlindi);
            this.panel1.Controls.Add(this.lblABilgi);
            this.panel1.Controls.Add(this.lblABedel);
            this.panel1.Controls.Add(this.lblCihazModel);
            this.panel1.Controls.Add(this.lblCihazMarka);
            this.panel1.Controls.Add(this.lblTel);
            this.panel1.Controls.Add(this.lblMusteri);
            this.panel1.Controls.Add(this.lblMID);
            this.panel1.Name = "panel1";
            // 
            // btnAlarmKapat
            // 
            resources.ApplyResources(this.btnAlarmKapat, "btnAlarmKapat");
            this.btnAlarmKapat.Image = global::Vodi_Pro.Properties.Resources.bell;
            this.btnAlarmKapat.Name = "btnAlarmKapat";
            this.btnAlarmKapat.UseVisualStyleBackColor = true;
            this.btnAlarmKapat.Click += new System.EventHandler(this.btnAlarmKapat_Click);
            // 
            // btnErtele
            // 
            resources.ApplyResources(this.btnErtele, "btnErtele");
            this.btnErtele.Image = global::Vodi_Pro.Properties.Resources.snooze;
            this.btnErtele.Name = "btnErtele";
            this.btnErtele.UseVisualStyleBackColor = true;
            this.btnErtele.Click += new System.EventHandler(this.btnErtele_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.btnWp);
            this.panel2.Controls.Add(this.btnMail);
            this.panel2.Controls.Add(this.btnSMS);
            this.panel2.Name = "panel2";
            // 
            // btnWp
            // 
            resources.ApplyResources(this.btnWp, "btnWp");
            this.btnWp.Image = global::Vodi_Pro.Properties.Resources.whatsapp;
            this.btnWp.Name = "btnWp";
            this.btnWp.UseVisualStyleBackColor = true;
            this.btnWp.Click += new System.EventHandler(this.btnWp_Click);
            // 
            // btnMail
            // 
            resources.ApplyResources(this.btnMail, "btnMail");
            this.btnMail.Image = global::Vodi_Pro.Properties.Resources.gmail;
            this.btnMail.Name = "btnMail";
            this.btnMail.UseVisualStyleBackColor = true;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // btnSMS
            // 
            resources.ApplyResources(this.btnSMS, "btnSMS");
            this.btnSMS.Image = global::Vodi_Pro.Properties.Resources.smartphone;
            this.btnSMS.Name = "btnSMS";
            this.btnSMS.UseVisualStyleBackColor = true;
            this.btnSMS.Click += new System.EventHandler(this.btnSMS_Click);
            // 
            // txtAlarmAciklama
            // 
            resources.ApplyResources(this.txtAlarmAciklama, "txtAlarmAciklama");
            this.txtAlarmAciklama.Name = "txtAlarmAciklama";
            this.txtAlarmAciklama.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblTeslim
            // 
            resources.ApplyResources(this.lblTeslim, "lblTeslim");
            this.lblTeslim.Name = "lblTeslim";
            // 
            // lblUcretAlindi
            // 
            resources.ApplyResources(this.lblUcretAlindi, "lblUcretAlindi");
            this.lblUcretAlindi.Name = "lblUcretAlindi";
            // 
            // lblABilgi
            // 
            resources.ApplyResources(this.lblABilgi, "lblABilgi");
            this.lblABilgi.Name = "lblABilgi";
            // 
            // lblABedel
            // 
            resources.ApplyResources(this.lblABedel, "lblABedel");
            this.lblABedel.Name = "lblABedel";
            // 
            // lblCihazModel
            // 
            resources.ApplyResources(this.lblCihazModel, "lblCihazModel");
            this.lblCihazModel.Name = "lblCihazModel";
            // 
            // lblCihazMarka
            // 
            resources.ApplyResources(this.lblCihazMarka, "lblCihazMarka");
            this.lblCihazMarka.Name = "lblCihazMarka";
            // 
            // lblTel
            // 
            resources.ApplyResources(this.lblTel, "lblTel");
            this.lblTel.Name = "lblTel";
            // 
            // lblMusteri
            // 
            resources.ApplyResources(this.lblMusteri, "lblMusteri");
            this.lblMusteri.Name = "lblMusteri";
            // 
            // lblMID
            // 
            resources.ApplyResources(this.lblMID, "lblMID");
            this.lblMID.Name = "lblMID";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::Vodi_Pro.Properties.Resources.tenor;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // FrmAlarm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAlarm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAlarm_FormClosed);
            this.Load += new System.EventHandler(this.FrmAlarm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUcretAlindi;
        private System.Windows.Forms.Label lblABilgi;
        private System.Windows.Forms.Label lblABedel;
        private System.Windows.Forms.Label lblCihazModel;
        private System.Windows.Forms.Label lblCihazMarka;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.Label lblMID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txtAlarmAciklama;
        private System.Windows.Forms.Button btnSMS;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.Button btnErtele;
        private System.Windows.Forms.Button btnWp;
        private System.Windows.Forms.Button btnAlarmKapat;
        private System.Windows.Forms.Label lblTeslim;
    }
}