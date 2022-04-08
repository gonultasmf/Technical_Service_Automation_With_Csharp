
namespace Vodi_Pro
{
    partial class FrmImeiSorgu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImeiSorgu));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.btnKapat = new System.Windows.Forms.Button();
            this.txtSTarihi = new System.Windows.Forms.TextBox();
            this.txtImei = new System.Windows.Forms.TextBox();
            this.txtDurum = new System.Windows.Forms.RichTextBox();
            this.txtKaynak = new System.Windows.Forms.RichTextBox();
            this.txtMarka = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            resources.ApplyResources(this.webBrowser, "webBrowser");
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // btnKapat
            // 
            resources.ApplyResources(this.btnKapat, "btnKapat");
            this.btnKapat.Image = global::Vodi_Pro.Properties.Resources.multiply;
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // txtSTarihi
            // 
            resources.ApplyResources(this.txtSTarihi, "txtSTarihi");
            this.txtSTarihi.Name = "txtSTarihi";
            this.txtSTarihi.ReadOnly = true;
            // 
            // txtImei
            // 
            resources.ApplyResources(this.txtImei, "txtImei");
            this.txtImei.Name = "txtImei";
            this.txtImei.ReadOnly = true;
            // 
            // txtDurum
            // 
            resources.ApplyResources(this.txtDurum, "txtDurum");
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.ReadOnly = true;
            // 
            // txtKaynak
            // 
            resources.ApplyResources(this.txtKaynak, "txtKaynak");
            this.txtKaynak.Name = "txtKaynak";
            this.txtKaynak.ReadOnly = true;
            // 
            // txtMarka
            // 
            resources.ApplyResources(this.txtMarka, "txtMarka");
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.ReadOnly = true;
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
            // FrmImeiSorgu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSTarihi);
            this.Controls.Add(this.txtImei);
            this.Controls.Add(this.txtDurum);
            this.Controls.Add(this.txtKaynak);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.btnKapat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmImeiSorgu";
            this.Load += new System.EventHandler(this.FrmImeiSorgu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.TextBox txtSTarihi;
        private System.Windows.Forms.TextBox txtImei;
        private System.Windows.Forms.RichTextBox txtDurum;
        private System.Windows.Forms.RichTextBox txtKaynak;
        private System.Windows.Forms.RichTextBox txtMarka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}