namespace Quiz2.views
{
    partial class DogruYanlısSoruForm
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
            this.dogruYanlısGridControl = new DevExpress.XtraEditors.GroupControl();
            this.dogruGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpKategori = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpSeviye = new DevExpress.XtraEditors.LookUpEdit();
            this.memoSoru = new DevExpress.XtraEditors.MemoEdit();
            this.txtDogru = new DevExpress.XtraEditors.TextEdit();
            this.txtYanlıs = new DevExpress.XtraEditors.TextEdit();
            this.txtDogruCevap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtPuan = new DevExpress.XtraEditors.TextEdit();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.soruBankasıDataSet = new Quiz2.SoruBankasıDataSet();
            this.kategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategoriTableAdapter = new Quiz2.SoruBankasıDataSetTableAdapters.KategoriTableAdapter();
            this.soruBankasıDataSet1 = new Quiz2.SoruBankasıDataSet1();
            this.seviyeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seviyeTableAdapter = new Quiz2.SoruBankasıDataSet1TableAdapters.SeviyeTableAdapter();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKategori = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeviye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDogru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYanlıs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDogruCevap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPuan = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dogruYanlısGridControl)).BeginInit();
            this.dogruYanlısGridControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogruGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpKategori.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSeviye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoSoru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDogru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYanlıs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDogruCevap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruBankasıDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruBankasıDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seviyeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dogruYanlısGridControl
            // 
            this.dogruYanlısGridControl.Controls.Add(this.btnSil);
            this.dogruYanlısGridControl.Controls.Add(this.btnEkle);
            this.dogruYanlısGridControl.Controls.Add(this.txtPuan);
            this.dogruYanlısGridControl.Controls.Add(this.labelControl7);
            this.dogruYanlısGridControl.Controls.Add(this.txtDogruCevap);
            this.dogruYanlısGridControl.Controls.Add(this.txtYanlıs);
            this.dogruYanlısGridControl.Controls.Add(this.txtDogru);
            this.dogruYanlısGridControl.Controls.Add(this.memoSoru);
            this.dogruYanlısGridControl.Controls.Add(this.lookUpSeviye);
            this.dogruYanlısGridControl.Controls.Add(this.lookUpKategori);
            this.dogruYanlısGridControl.Controls.Add(this.labelControl6);
            this.dogruYanlısGridControl.Controls.Add(this.labelControl5);
            this.dogruYanlısGridControl.Controls.Add(this.labelControl4);
            this.dogruYanlısGridControl.Controls.Add(this.labelControl3);
            this.dogruYanlısGridControl.Controls.Add(this.labelControl2);
            this.dogruYanlısGridControl.Controls.Add(this.labelControl1);
            this.dogruYanlısGridControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.dogruYanlısGridControl.Location = new System.Drawing.Point(0, 0);
            this.dogruYanlısGridControl.Name = "dogruYanlısGridControl";
            this.dogruYanlısGridControl.Size = new System.Drawing.Size(340, 484);
            this.dogruYanlısGridControl.TabIndex = 0;
            this.dogruYanlısGridControl.Text = "groupControl1";
            // 
            // dogruGridControl
            // 
            this.dogruGridControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.dogruGridControl.Location = new System.Drawing.Point(341, 0);
            this.dogruGridControl.MainView = this.gridView1;
            this.dogruGridControl.Name = "dogruGridControl";
            this.dogruGridControl.Size = new System.Drawing.Size(580, 484);
            this.dogruGridControl.TabIndex = 1;
            this.dogruGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKategori,
            this.colSeviye,
            this.colSoru,
            this.colDogru,
            this.colYanlıs,
            this.colDogruCevap,
            this.colPuan});
            this.gridView1.GridControl = this.dogruGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kategori";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(30, 87);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Seviye";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(30, 131);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Soru Metni";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(30, 210);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(29, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Doğru";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(30, 238);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Yanlış";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(30, 280);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(63, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Doğru Cevap";
            // 
            // lookUpKategori
            // 
            this.lookUpKategori.Location = new System.Drawing.Point(136, 45);
            this.lookUpKategori.Name = "lookUpKategori";
            this.lookUpKategori.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpKategori.Properties.DataSource = this.kategoriBindingSource;
            this.lookUpKategori.Properties.DisplayMember = "Ad";
            this.lookUpKategori.Properties.ValueMember = "Id";
            this.lookUpKategori.Size = new System.Drawing.Size(100, 20);
            this.lookUpKategori.TabIndex = 6;
            // 
            // lookUpSeviye
            // 
            this.lookUpSeviye.Location = new System.Drawing.Point(136, 79);
            this.lookUpSeviye.Name = "lookUpSeviye";
            this.lookUpSeviye.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpSeviye.Properties.DataSource = this.seviyeBindingSource;
            this.lookUpSeviye.Properties.DisplayMember = "ZorlukDerecesi";
            this.lookUpSeviye.Properties.ValueMember = "Id";
            this.lookUpSeviye.Size = new System.Drawing.Size(100, 20);
            this.lookUpSeviye.TabIndex = 7;
            // 
            // memoSoru
            // 
            this.memoSoru.Location = new System.Drawing.Point(136, 130);
            this.memoSoru.Name = "memoSoru";
            this.memoSoru.Size = new System.Drawing.Size(199, 68);
            this.memoSoru.TabIndex = 8;
            // 
            // txtDogru
            // 
            this.txtDogru.Location = new System.Drawing.Point(136, 210);
            this.txtDogru.Name = "txtDogru";
            this.txtDogru.Size = new System.Drawing.Size(100, 20);
            this.txtDogru.TabIndex = 9;
            // 
            // txtYanlıs
            // 
            this.txtYanlıs.Location = new System.Drawing.Point(136, 236);
            this.txtYanlıs.Name = "txtYanlıs";
            this.txtYanlıs.Size = new System.Drawing.Size(100, 20);
            this.txtYanlıs.TabIndex = 10;
            // 
            // txtDogruCevap
            // 
            this.txtDogruCevap.Location = new System.Drawing.Point(136, 277);
            this.txtDogruCevap.Name = "txtDogruCevap";
            this.txtDogruCevap.Size = new System.Drawing.Size(100, 20);
            this.txtDogruCevap.TabIndex = 11;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(30, 325);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(24, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Puan";
            // 
            // txtPuan
            // 
            this.txtPuan.Location = new System.Drawing.Point(136, 322);
            this.txtPuan.Name = "txtPuan";
            this.txtPuan.Size = new System.Drawing.Size(100, 20);
            this.txtPuan.TabIndex = 13;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(40, 391);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(161, 391);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
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
            // soruBankasıDataSet1
            // 
            this.soruBankasıDataSet1.DataSetName = "SoruBankasıDataSet1";
            this.soruBankasıDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seviyeBindingSource
            // 
            this.seviyeBindingSource.DataMember = "Seviye";
            this.seviyeBindingSource.DataSource = this.soruBankasıDataSet1;
            // 
            // seviyeTableAdapter
            // 
            this.seviyeTableAdapter.ClearBeforeFill = true;
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
            // colSoru
            // 
            this.colSoru.Caption = "SoruMetni";
            this.colSoru.FieldName = "SoruMetni";
            this.colSoru.Name = "colSoru";
            this.colSoru.Visible = true;
            this.colSoru.VisibleIndex = 2;
            // 
            // colDogru
            // 
            this.colDogru.Caption = "Dogru";
            this.colDogru.FieldName = "Dogru";
            this.colDogru.Name = "colDogru";
            this.colDogru.Visible = true;
            this.colDogru.VisibleIndex = 3;
            // 
            // colYanlıs
            // 
            this.colYanlıs.Caption = "Yanlıs";
            this.colYanlıs.FieldName = "Yanlıs";
            this.colYanlıs.Name = "colYanlıs";
            this.colYanlıs.Visible = true;
            this.colYanlıs.VisibleIndex = 4;
            // 
            // colDogruCevap
            // 
            this.colDogruCevap.Caption = "DogruCevap";
            this.colDogruCevap.FieldName = "DogruCevap";
            this.colDogruCevap.Name = "colDogruCevap";
            this.colDogruCevap.Visible = true;
            this.colDogruCevap.VisibleIndex = 5;
            // 
            // colPuan
            // 
            this.colPuan.Caption = "Puan";
            this.colPuan.FieldName = "Puan";
            this.colPuan.Name = "colPuan";
            this.colPuan.Visible = true;
            this.colPuan.VisibleIndex = 6;
            // 
            // DogruYanlısSorularForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 484);
            this.Controls.Add(this.dogruGridControl);
            this.Controls.Add(this.dogruYanlısGridControl);
            this.Name = "DogruYanlısSorularForm";
            this.Text = "DogruYanlısSorularForm";
            this.Load += new System.EventHandler(this.DogruYanlısSorularForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dogruYanlısGridControl)).EndInit();
            this.dogruYanlısGridControl.ResumeLayout(false);
            this.dogruYanlısGridControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogruGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpKategori.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSeviye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoSoru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDogru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYanlıs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDogruCevap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruBankasıDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruBankasıDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seviyeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl dogruYanlısGridControl;
        private DevExpress.XtraGrid.GridControl dogruGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.TextEdit txtPuan;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtDogruCevap;
        private DevExpress.XtraEditors.TextEdit txtYanlıs;
        private DevExpress.XtraEditors.TextEdit txtDogru;
        private DevExpress.XtraEditors.MemoEdit memoSoru;
        private DevExpress.XtraEditors.LookUpEdit lookUpSeviye;
        private DevExpress.XtraEditors.LookUpEdit lookUpKategori;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private SoruBankasıDataSet soruBankasıDataSet;
        private System.Windows.Forms.BindingSource kategoriBindingSource;
        private SoruBankasıDataSetTableAdapters.KategoriTableAdapter kategoriTableAdapter;
        private SoruBankasıDataSet1 soruBankasıDataSet1;
        private System.Windows.Forms.BindingSource seviyeBindingSource;
        private SoruBankasıDataSet1TableAdapters.SeviyeTableAdapter seviyeTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colKategori;
        private DevExpress.XtraGrid.Columns.GridColumn colSeviye;
        private DevExpress.XtraGrid.Columns.GridColumn colSoru;
        private DevExpress.XtraGrid.Columns.GridColumn colDogru;
        private DevExpress.XtraGrid.Columns.GridColumn colYanlıs;
        private DevExpress.XtraGrid.Columns.GridColumn colDogruCevap;
        private DevExpress.XtraGrid.Columns.GridColumn colPuan;
    }
}