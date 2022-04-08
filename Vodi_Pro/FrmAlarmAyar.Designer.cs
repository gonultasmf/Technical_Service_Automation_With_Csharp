
namespace Vodi_Pro
{
    partial class FrmAlarmAyar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlarmAyar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.comboErtele = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chckCalsin = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboTekrar = new System.Windows.Forms.ComboBox();
            this.comboZilSesi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMusteriSayisi = new System.Windows.Forms.Label();
            this.listeAlarm = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeAlarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // comboErtele
            // 
            this.comboErtele.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboErtele.FormattingEnabled = true;
            this.comboErtele.Items.AddRange(new object[] {
            resources.GetString("comboErtele.Items"),
            resources.GetString("comboErtele.Items1"),
            resources.GetString("comboErtele.Items2"),
            resources.GetString("comboErtele.Items3"),
            resources.GetString("comboErtele.Items4")});
            resources.ApplyResources(this.comboErtele, "comboErtele");
            this.comboErtele.Name = "comboErtele";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // chckCalsin
            // 
            resources.ApplyResources(this.chckCalsin, "chckCalsin");
            this.chckCalsin.Name = "chckCalsin";
            this.chckCalsin.UseVisualStyleBackColor = true;
            this.chckCalsin.CheckedChanged += new System.EventHandler(this.chckCalsin_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboTekrar);
            this.panel1.Controls.Add(this.comboZilSesi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // comboTekrar
            // 
            this.comboTekrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTekrar.FormattingEnabled = true;
            this.comboTekrar.Items.AddRange(new object[] {
            resources.GetString("comboTekrar.Items"),
            resources.GetString("comboTekrar.Items1")});
            resources.ApplyResources(this.comboTekrar, "comboTekrar");
            this.comboTekrar.Name = "comboTekrar";
            // 
            // comboZilSesi
            // 
            this.comboZilSesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboZilSesi.FormattingEnabled = true;
            this.comboZilSesi.Items.AddRange(new object[] {
            resources.GetString("comboZilSesi.Items"),
            resources.GetString("comboZilSesi.Items1"),
            resources.GetString("comboZilSesi.Items2"),
            resources.GetString("comboZilSesi.Items3"),
            resources.GetString("comboZilSesi.Items4"),
            resources.GetString("comboZilSesi.Items5"),
            resources.GetString("comboZilSesi.Items6")});
            resources.ApplyResources(this.comboZilSesi, "comboZilSesi");
            this.comboZilSesi.Name = "comboZilSesi";
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
            // lblMusteriSayisi
            // 
            resources.ApplyResources(this.lblMusteriSayisi, "lblMusteriSayisi");
            this.lblMusteriSayisi.Name = "lblMusteriSayisi";
            // 
            // listeAlarm
            // 
            this.listeAlarm.AllowUserToAddRows = false;
            this.listeAlarm.AllowUserToOrderColumns = true;
            this.listeAlarm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeAlarm.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.listeAlarm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listeAlarm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listeAlarm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.listeAlarm, "listeAlarm");
            this.listeAlarm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listeAlarm.GridColor = System.Drawing.Color.Black;
            this.listeAlarm.Name = "listeAlarm";
            this.listeAlarm.ReadOnly = true;
            this.listeAlarm.RowTemplate.ReadOnly = true;
            this.listeAlarm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeAlarm.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listeAlarm_MouseDoubleClick);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vodi_Pro.Properties.Resources.tenor;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // FrmAlarmAyar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listeAlarm);
            this.Controls.Add(this.lblMusteriSayisi);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chckCalsin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboErtele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAlarmAyar";
            this.Load += new System.EventHandler(this.FrmAlarmAyar_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listeAlarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboErtele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chckCalsin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboTekrar;
        private System.Windows.Forms.ComboBox comboZilSesi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label lblMusteriSayisi;
        private System.Windows.Forms.DataGridView listeAlarm;
    }
}