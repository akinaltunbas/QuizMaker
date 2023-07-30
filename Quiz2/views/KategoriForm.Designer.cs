namespace Quiz2.views
{
    partial class KategoriForm
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            this.kategoriGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
        
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAd = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
          
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // kategoriGridControl
            // 
            this.kategoriGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            gridLevelNode1.RelationName = "KlasikSorus";
            gridLevelNode2.RelationName = "DogruYanlısSorus";
            gridLevelNode3.RelationName = "CoktanSecmeliSorus";
            this.kategoriGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2,
            gridLevelNode3});
            this.kategoriGridControl.Location = new System.Drawing.Point(0, 140);
            this.kategoriGridControl.MainView = this.gridView1;
            this.kategoriGridControl.Name = "kategoriGridControl";
            this.kategoriGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
         
          
      
            // 
            // gridView1
            // 
          
            
           
            // silIttemButtonEdit
            // 
         
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(249, 134);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 200);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnEkle);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtAd);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(742, 134);
            this.groupControl1.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(317, 44);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(130, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(96, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Kategori Adı :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(188, 47);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 402);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.kategoriGridControl);
            this.Name = "KategoriForm";
            this.Text = "KategoriForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.kategoriGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silIttemButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl kategoriGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtAd;
   
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colAd;
    }
}