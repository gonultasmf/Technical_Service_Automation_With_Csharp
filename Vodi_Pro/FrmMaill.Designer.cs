
namespace Vodi_Pro
{
    partial class FrmMaill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaill));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdBtnMesaj2 = new System.Windows.Forms.RadioButton();
            this.rdBtnMesaj1 = new System.Windows.Forms.RadioButton();
            this.txtMesaj2 = new System.Windows.Forms.RichTextBox();
            this.txtMesaj1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnMail = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.rdBtnMesaj2);
            this.panel1.Controls.Add(this.rdBtnMesaj1);
            this.panel1.Controls.Add(this.txtMesaj2);
            this.panel1.Controls.Add(this.txtMesaj1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
            // 
            // rdBtnMesaj2
            // 
            resources.ApplyResources(this.rdBtnMesaj2, "rdBtnMesaj2");
            this.rdBtnMesaj2.Name = "rdBtnMesaj2";
            this.rdBtnMesaj2.TabStop = true;
            this.rdBtnMesaj2.UseVisualStyleBackColor = true;
            // 
            // rdBtnMesaj1
            // 
            resources.ApplyResources(this.rdBtnMesaj1, "rdBtnMesaj1");
            this.rdBtnMesaj1.Name = "rdBtnMesaj1";
            this.rdBtnMesaj1.TabStop = true;
            this.rdBtnMesaj1.UseVisualStyleBackColor = true;
            // 
            // txtMesaj2
            // 
            resources.ApplyResources(this.txtMesaj2, "txtMesaj2");
            this.txtMesaj2.Name = "txtMesaj2";
            // 
            // txtMesaj1
            // 
            resources.ApplyResources(this.txtMesaj1, "txtMesaj1");
            this.txtMesaj1.Name = "txtMesaj1";
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
            this.label2.UseCompatibleTextRendering = true;
            // 
            // txtMail
            // 
            resources.ApplyResources(this.txtMail, "txtMail");
            this.txtMail.Name = "txtMail";
            // 
            // txtKonu
            // 
            resources.ApplyResources(this.txtKonu, "txtKonu");
            this.txtKonu.Name = "txtKonu";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnIptal
            // 
            resources.ApplyResources(this.btnIptal, "btnIptal");
            this.btnIptal.Image = global::Vodi_Pro.Properties.Resources.multiply;
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnMail
            // 
            resources.ApplyResources(this.btnMail, "btnMail");
            this.btnMail.Image = global::Vodi_Pro.Properties.Resources.send;
            this.btnMail.Name = "btnMail";
            this.btnMail.UseVisualStyleBackColor = true;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // FrmMaill
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnMail);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMaill";
            this.Load += new System.EventHandler(this.FrmMail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdBtnMesaj2;
        private System.Windows.Forms.RadioButton rdBtnMesaj1;
        private System.Windows.Forms.RichTextBox txtMesaj2;
        private System.Windows.Forms.RichTextBox txtMesaj1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.Label label3;
    }
}