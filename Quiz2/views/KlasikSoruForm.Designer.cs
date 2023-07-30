namespace Quiz2.views
{
    partial class KlasikSoruForm
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
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpSeviye = new DevExpress.XtraEditors.LookUpEdit();
            this.seviyeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soruBankasıDataSet1 = new Quiz2.SoruBankasıDataSet1();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.memoDoğruCevap = new DevExpress.XtraEditors.MemoEdit();
            this.memoCevap = new DevExpress.XtraEditors.MemoEdit();
            this.memoSoru = new DevExpress.XtraEditors.MemoEdit();
            this.lookUpKategori = new DevExpress.XtraEditors.LookUpEdit();
            this.kategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soruBankasıDataSet = new Quiz2.SoruBankasıDataSet();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPuan = new DevExpress.XtraEditors.TextEdit();
            this.kategoriTableAdapter = new Quiz2.SoruBankasıDataSetTableAdapters.KategoriTableAdapter();
            this.klasikGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKategori = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeviye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoruMetni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCevapMetni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoğruCevap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.seviyeTableAdapter = new Quiz2.SoruBankasıDataSet1TableAdapters.SeviyeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSeviye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seviyeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruBankasıDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDoğruCevap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoCevap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoSoru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpKategori.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruBankasıDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klasikGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.lookUpSeviye);
            this.groupControl1.Controls.Add(this.btnEkle);
            this.groupControl1.Controls.Add(this.memoDoğruCevap);
            this.groupControl1.Controls.Add(this.memoCevap);
            this.groupControl1.Controls.Add(this.memoSoru);
            this.groupControl1.Controls.Add(this.lookUpKategori);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtPuan);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(419, 458);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(155, 393);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(93, 23);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lookUpSeviye
            // 
            this.lookUpSeviye.Location = new System.Drawing.Point(125, 68);
            this.lookUpSeviye.Name = "lookUpSeviye";
            this.lookUpSeviye.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpSeviye.Properties.DataSource = this.seviyeBindingSource;
            this.lookUpSeviye.Properties.DisplayMember = "ZorlukDerecesi";
            this.lookUpSeviye.Properties.ValueMember = "Id";
            this.lookUpSeviye.Size = new System.Drawing.Size(123, 20);
            this.lookUpSeviye.TabIndex = 14;
            // 
            // seviyeBindingSource
            // 
            this.seviyeBindingSource.DataMember = "Seviye";
            this.seviyeBindingSource.DataSource = this.soruBankasıDataSet1;
            // 
            // soruBankasıDataSet1
            // 
            this.soruBankasıDataSet1.DataSetName = "SoruBankasıDataSet1";
            this.soruBankasıDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(32, 393);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(93, 23);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // memoDoğruCevap
            // 
            this.memoDoğruCevap.Location = new System.Drawing.Point(125, 273);
            this.memoDoğruCevap.Name = "memoDoğruCevap";
            this.memoDoğruCevap.Size = new System.Drawing.Size(184, 56);
            this.memoDoğruCevap.TabIndex = 11;
            // 
            // memoCevap
            // 
            this.memoCevap.Location = new System.Drawing.Point(125, 189);
            this.memoCevap.Name = "memoCevap";
            this.memoCevap.Size = new System.Drawing.Size(184, 58);
            this.memoCevap.TabIndex = 10;
            // 
            // memoSoru
            // 
            this.memoSoru.Location = new System.Drawing.Point(125, 105);
            this.memoSoru.Name = "memoSoru";
            this.memoSoru.Size = new System.Drawing.Size(184, 62);
            this.memoSoru.TabIndex = 9;
            // 
            // lookUpKategori
            // 
            this.lookUpKategori.EditValue = "";
            this.lookUpKategori.Location = new System.Drawing.Point(125, 33);
            this.lookUpKategori.Name = "lookUpKategori";
            this.lookUpKategori.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpKategori.Properties.DataSource = this.kategoriBindingSource;
            this.lookUpKategori.Properties.DisplayMember = "Ad";
            this.lookUpKategori.Properties.ValueMember = "Id";
            this.lookUpKategori.Size = new System.Drawing.Size(123, 20);
            this.lookUpKategori.TabIndex = 8;
            // 
            // kategoriBindingSource
            // 
            this.kategoriBindingSource.DataMember = "Kategori";
            this.kategoriBindingSource.DataSource = this.soruBankasıDataSet;
            // 
            // soruBankasıDataSet
            // 
            this.soruBankasıDataSet.DataSetName = "SoruBankasıDataSet";
            this.soruBankasıDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(32, 346);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(31, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Puan :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(32, 275);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(70, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Doğru Cevap :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(32, 191);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Cevap Metni :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(32, 107);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Soru Metni :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(32, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Zorluk Derecesi :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kategori :";
            // 
            // txtPuan
            // 
            this.txtPuan.Location = new System.Drawing.Point(125, 346);
            this.txtPuan.Name = "txtPuan";
            this.txtPuan.Size = new System.Drawing.Size(184, 20);
            this.txtPuan.TabIndex = 12;
            // 
            // kategoriTableAdapter
            // 
            this.kategoriTableAdapter.ClearBeforeFill = true;
            // 
            // klasikGridControl
            // 
            this.klasikGridControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.klasikGridControl.Location = new System.Drawing.Point(425, 0);
            this.klasikGridControl.MainView = this.gridView1;
            this.klasikGridControl.Name = "klasikGridControl";
            this.klasikGridControl.Size = new System.Drawing.Size(496, 458);
            this.klasikGridControl.TabIndex = 1;
            this.klasikGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKategori,
            this.colSeviye,
            this.colSoruMetni,
            this.colCevapMetni,
            this.colDoğruCevap,
            this.colPuan});
            this.gridView1.GridControl = this.klasikGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colKategori
            // 
            this.colKategori.Caption = "KategoriId";
            this.colKategori.FieldName = "KategoriId";
            this.colKategori.Name = "colKategori";
            this.colKategori.Visible = true;
            this.colKategori.VisibleIndex = 0;
            // 
            // colSeviye
            // 
            this.colSeviye.Caption = "SeviyeId";
            this.colSeviye.FieldName = "SeviyeId";
            this.colSeviye.Name = "colSeviye";
            this.colSeviye.Visible = true;
            this.colSeviye.VisibleIndex = 1;
            // 
            // colSoruMetni
            // 
            this.colSoruMetni.Caption = "SoruMetni";
            this.colSoruMetni.FieldName = "SoruMetni";
            this.colSoruMetni.Name = "colSoruMetni";
            this.colSoruMetni.Visible = true;
            this.colSoruMetni.VisibleIndex = 2;
            // 
            // colCevapMetni
            // 
            this.colCevapMetni.Caption = "CevapMetni";
            this.colCevapMetni.FieldName = "CevapMetni";
            this.colCevapMetni.Name = "colCevapMetni";
            this.colCevapMetni.Visible = true;
            this.colCevapMetni.VisibleIndex = 3;
            // 
            // colDoğruCevap
            // 
            this.colDoğruCevap.Caption = "Doğrucevap";
            this.colDoğruCevap.FieldName = "Doğrucevap";
            this.colDoğruCevap.Name = "colDoğruCevap";
            this.colDoğruCevap.Visible = true;
            this.colDoğruCevap.VisibleIndex = 4;
            // 
            // colPuan
            // 
            this.colPuan.Caption = "Puan";
            this.colPuan.FieldName = "Puan";
            this.colPuan.Name = "colPuan";
            this.colPuan.Visible = true;
            this.colPuan.VisibleIndex = 5;
            // 
            // seviyeTableAdapter
            // 
            this.seviyeTableAdapter.ClearBeforeFill = true;
            // 
            // KlasikSoruForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 458);
            this.Controls.Add(this.klasikGridControl);
            this.Controls.Add(this.groupControl1);
            this.Name = "KlasikSoruForm";
            this.Text = "KlasikSoruForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KlasikSoruForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSeviye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seviyeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruBankasıDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDoğruCevap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoCevap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoSoru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpKategori.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruBankasıDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klasikGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpKategori;
        private SoruBankasıDataSet soruBankasıDataSet;
        private System.Windows.Forms.BindingSource kategoriBindingSource;
        private SoruBankasıDataSetTableAdapters.KategoriTableAdapter kategoriTableAdapter;
        private DevExpress.XtraEditors.MemoEdit memoDoğruCevap;
        private DevExpress.XtraEditors.MemoEdit memoCevap;
        private DevExpress.XtraEditors.MemoEdit memoSoru;
        private DevExpress.XtraEditors.TextEdit txtPuan;
        private DevExpress.XtraGrid.GridControl klasikGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colKategori;
        private DevExpress.XtraGrid.Columns.GridColumn colSeviye;
        private DevExpress.XtraGrid.Columns.GridColumn colSoruMetni;
        private DevExpress.XtraGrid.Columns.GridColumn colCevapMetni;
        private DevExpress.XtraGrid.Columns.GridColumn colDoğruCevap;
        private DevExpress.XtraGrid.Columns.GridColumn colPuan;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.LookUpEdit lookUpSeviye;
        private SoruBankasıDataSet1 soruBankasıDataSet1;
        private System.Windows.Forms.BindingSource seviyeBindingSource;
        private SoruBankasıDataSet1TableAdapters.SeviyeTableAdapter seviyeTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnSil;
    }
}