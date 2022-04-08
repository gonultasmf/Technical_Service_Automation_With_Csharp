
namespace Vodi_Pro
{
    partial class FrmSMSAyar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSMSAyar));
            this.txtParola = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboSMS = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMesaj2 = new System.Windows.Forms.RichTextBox();
            this.txtMesaj1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl1 = new System.Windows.Forms.PictureBox();
            this.btnKaydol = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtParola
            // 
            resources.ApplyResources(this.txtParola, "txtParola");
            this.txtParola.Name = "txtParola";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtKAdi
            // 
            resources.ApplyResources(this.txtKAdi, "txtKAdi");
            this.txtKAdi.Name = "txtKAdi";
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
            // comboSMS
            // 
            resources.ApplyResources(this.comboSMS, "comboSMS");
            this.comboSMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSMS.FormattingEnabled = true;
            this.comboSMS.Items.AddRange(new object[] {
            resources.GetString("comboSMS.Items"),
            resources.GetString("comboSMS.Items1"),
            resources.GetString("comboSMS.Items2")});
            this.comboSMS.Name = "comboSMS";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMesaj2);
            this.panel1.Controls.Add(this.txtMesaj1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
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
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Image = global::Vodi_Pro.Properties.Resources.hide__1_;
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.TabStop = false;
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // btnKaydol
            // 
            resources.ApplyResources(this.btnKaydol, "btnKaydol");
            this.btnKaydol.Image = global::Vodi_Pro.Properties.Resources.checkmark;
            this.btnKaydol.Name = "btnKaydol";
            this.btnKaydol.UseVisualStyleBackColor = true;
            this.btnKaydol.Click += new System.EventHandler(this.btnKaydol_Click);
            // 
            // btnIptal
            // 
            resources.ApplyResources(this.btnIptal, "btnIptal");
            this.btnIptal.Image = global::Vodi_Pro.Properties.Resources.multiply;
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // FrmSMSAyar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnKaydol);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboSMS);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSMSAyar";
            this.Load += new System.EventHandler(this.FrmSMSAyar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labelControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboSMS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtMesaj2;
        private System.Windows.Forms.RichTextBox txtMesaj1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydol;
        private System.Windows.Forms.PictureBox labelControl1;
    }
}