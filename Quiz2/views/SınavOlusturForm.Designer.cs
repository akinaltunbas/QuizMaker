namespace Quiz2.views
{
    partial class SınavOlusturForm
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
            this.components = new System.ComponentModel.Container();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpKategori = new DevExpress.XtraEditors.LookUpEdit();
            this.txtSınavAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtSinavYeri = new DevExpress.XtraEditors.TextEdit();
            this.txtGözetmen = new DevExpress.XtraEditors.TextEdit();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.soruBankasıDataSet = new Quiz2.SoruBankasıDataSet();
            this.kategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategoriTableAdapter = new Quiz2.SoruBankasıDataSetTableAdapters.KategoriTableAdapter();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cmbSeviye = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpKategori.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSınavAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSinavYeri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGözetmen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruBankasıDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSeviye.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbSeviye);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnEkle);
            this.groupControl1.Controls.Add(this.txtGözetmen);
            this.groupControl1.Controls.Add(this.txtSinavYeri);
            this.groupControl1.Controls.Add(this.txtSınavAdi);
            this.groupControl1.Controls.Add(this.lookUpKategori);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(376, 497);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Sınav Adı";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 111);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Sınav Yeri";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 77);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Kategori";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 148);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Gözetmen Adı";
            // 
            // lookUpKategori
            // 
            this.lookUpKategori.Location = new System.Drawing.Point(100, 70);
            this.lookUpKategori.Name = "lookUpKategori";
            this.lookUpKategori.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpKategori.Properties.DataSource = this.kategoriBindingSource;
            this.lookUpKategori.Properties.DisplayMember = "Ad";
            this.lookUpKategori.Properties.ValueMember = "Id";
            this.lookUpKategori.Size = new System.Drawing.Size(100, 20);
            this.lookUpKategori.TabIndex = 4;
            // 
            // txtSınavAdi
            // 
            this.txtSınavAdi.Location = new System.Drawing.Point(100, 35);
            this.txtSınavAdi.Name = "txtSınavAdi";
            this.txtSınavAdi.Size = new System.Drawing.Size(100, 20);
            this.txtSınavAdi.TabIndex = 5;
            // 
            // txtSinavYeri
            // 
            this.txtSinavYeri.Location = new System.Drawing.Point(100, 108);
            this.txtSinavYeri.Name = "txtSinavYeri";
            this.txtSinavYeri.Size = new System.Drawing.Size(100, 20);
            this.txtSinavYeri.TabIndex = 6;
            // 
            // txtGözetmen
            // 
            this.txtGözetmen.Location = new System.Drawing.Point(100, 141);
            this.txtGözetmen.Name = "txtGözetmen";
            this.txtGözetmen.Size = new System.Drawing.Size(100, 20);
            this.txtGözetmen.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(13, 377);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "EKLE";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(125, 377);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "SİL";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridControl1.Location = new System.Drawing.Point(382, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(419, 497);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // soruBankasıDataSet
            // 
            this.soruBankasıDataSet.DataSetName = "SoruBankasıDataSet";
            this.soruBankasıDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategoriBindingSource
            // 
            this.kategoriBindingSource.DataMember = "Kategori";
            this.kategoriBindingSource.DataSource = this.soruBankasıDataSet;
            // 
            // kategoriTableAdapter
            // 
            this.kategoriTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(13, 183);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(73, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Zorluk Derecesi";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(13, 217);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(51, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Soru Oranı";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(13, 253);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(61, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Toplam Puan";
            // 
            // cmbSeviye
            // 
            this.cmbSeviye.Location = new System.Drawing.Point(100, 183);
            this.cmbSeviye.Name = "cmbSeviye";
            this.cmbSeviye.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSeviye.Properties.Items.AddRange(new object[] {
            "Kolay",
            "Orta",
            "Zor"});
            this.cmbSeviye.Size = new System.Drawing.Size(100, 20);
            this.cmbSeviye.TabIndex = 13;
            // 
            // SınavOlusturForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 497);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "SınavOlusturForm";
            this.Text = "SınavOlusturForm";
            this.Load += new System.EventHandler(this.SınavOlusturForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpKategori.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSınavAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSinavYeri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGözetmen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruBankasıDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSeviye.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.TextEdit txtGözetmen;
        private DevExpress.XtraEditors.TextEdit txtSinavYeri;
        private DevExpress.XtraEditors.TextEdit txtSınavAdi;
        private DevExpress.XtraEditors.LookUpEdit lookUpKategori;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private SoruBankasıDataSet soruBankasıDataSet;
        private System.Windows.Forms.BindingSource kategoriBindingSource;
        private SoruBankasıDataSetTableAdapters.KategoriTableAdapter kategoriTableAdapter;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSeviye;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}