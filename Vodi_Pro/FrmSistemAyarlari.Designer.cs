
namespace Vodi_Pro
{
    partial class FrmSistemAyarlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSistemAyarlari));
            this.comboBirim = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboTema = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
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
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // comboTema
            // 
            this.comboTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTema.FormattingEnabled = true;
            this.comboTema.Items.AddRange(new object[] {
            resources.GetString("comboTema.Items"),
            resources.GetString("comboTema.Items1"),
            resources.GetString("comboTema.Items2"),
            resources.GetString("comboTema.Items3"),
            resources.GetString("comboTema.Items4"),
            resources.GetString("comboTema.Items5"),
            resources.GetString("comboTema.Items6")});
            resources.ApplyResources(this.comboTema, "comboTema");
            this.comboTema.Name = "comboTema";
            this.comboTema.SelectedIndexChanged += new System.EventHandler(this.comboTema_SelectedIndexChanged);
            // 
            // FrmSistemAyarlari
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.comboTema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBirim);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSistemAyarlari";
            this.Load += new System.EventHandler(this.FrmSistemAyarlari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBirim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboTema;
    }
}