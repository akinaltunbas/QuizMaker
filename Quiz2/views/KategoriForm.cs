using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Quiz2.models;
using Quiz2.presenters;
namespace Quiz2.views
{
    public partial class KategoriForm : DevExpress.XtraEditors.XtraForm,IKategoriView
    {
        private DevExpress.XtraGrid.GridControl kategoriGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private LabelControl labelControl1;
        private SimpleButton btnSil;
        private SimpleButton btnEkle;
        private TextEdit txtKategoriAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colAd;
        private GroupControl groupControl1;

        KategoriPresenter presenter;

        public KategoriForm()
        {
            InitializeComponent();
            presenter = new KategoriPresenter(this);
        }

        private void InitializeComponent()
        {
            this.kategoriGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtKategoriAdi = new DevExpress.XtraEditors.TextEdit();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAd = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKategoriAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // kategoriGridControl
            // 
            this.kategoriGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kategoriGridControl.Location = new System.Drawing.Point(0, 106);
            this.kategoriGridControl.MainView = this.gridView1;
            this.kategoriGridControl.Name = "kategoriGridControl";
            this.kategoriGridControl.Size = new System.Drawing.Size(618, 266);
            this.kategoriGridControl.TabIndex = 0;
            this.kategoriGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colAd});
            this.gridView1.GridControl = this.kategoriGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnEkle);
            this.groupControl1.Controls.Add(this.txtKategoriAdi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(618, 100);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(124, 43);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKategoriAdi.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(314, 50);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(415, 50);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Kategori Adı :";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // colAd
            // 
            this.colAd.Caption = "Ad";
            this.colAd.FieldName = "Ad";
            this.colAd.Name = "colAd";
            this.colAd.Visible = true;
            this.colAd.VisibleIndex = 0;
            // 
            // KategoriForm
            // 
            this.ClientSize = new System.Drawing.Size(618, 372);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.kategoriGridControl);
            this.Name = "KategoriForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KategoriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kategoriGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKategoriAdi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        private void KategoriForm_Load(object sender, EventArgs e)
        {
            presenter.yükle();
        }

        public void updateKategorilerGrid(IList<Kategori>liste)
        {
            kategoriGridControl.DataSource = null;
            kategoriGridControl.RefreshDataSource();
            kategoriGridControl.DataSource = liste;
            kategoriGridControl.Refresh();


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            presenter.kategoriEkle(txtKategoriAdi.Text);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            presenter.kategoriSil(int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString()));
        }
    }
}