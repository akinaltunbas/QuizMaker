namespace Quiz2.views
{
    partial class SeviyeForm
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
            this.seviyeGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colZorlukDerecesi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnZorlukDerecesi = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.txtZorluk = new DevExpress.XtraEditors.TextEdit();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.seviyeGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtZorluk.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // seviyeGridControl
            // 
            this.seviyeGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.seviyeGridControl.Location = new System.Drawing.Point(0, 109);
            this.seviyeGridControl.MainView = this.gridView1;
            this.seviyeGridControl.Name = "seviyeGridControl";
            this.seviyeGridControl.Size = new System.Drawing.Size(944, 307);
            this.seviyeGridControl.TabIndex = 0;
            this.seviyeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colZorlukDerecesi,
            this.colId});
            this.gridView1.GridControl = this.seviyeGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colZorlukDerecesi
            // 
            this.colZorlukDerecesi.Caption = "ZorlukDerecesi";
            this.colZorlukDerecesi.FieldName = "ZorlukDerecesi";
            this.colZorlukDerecesi.Name = "colZorlukDerecesi";
            this.colZorlukDerecesi.Visible = true;
            this.colZorlukDerecesi.VisibleIndex = 0;
            // 
            // btnZorlukDerecesi
            // 
            this.btnZorlukDerecesi.Location = new System.Drawing.Point(264, 43);
            this.btnZorlukDerecesi.Name = "btnZorlukDerecesi";
            this.btnZorlukDerecesi.Size = new System.Drawing.Size(108, 23);
            this.btnZorlukDerecesi.TabIndex = 3;
            this.btnZorlukDerecesi.Text = "EKLE";
            this.btnZorlukDerecesi.Click += new System.EventHandler(this.btnZorlukDerecesi_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(20, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Zorluk Derecesi :";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnSil);
            this.groupControl2.Controls.Add(this.txtZorluk);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.btnZorlukDerecesi);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(944, 97);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "groupControl2";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(404, 45);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(119, 23);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtZorluk
            // 
            this.txtZorluk.Location = new System.Drawing.Point(123, 45);
            this.txtZorluk.Name = "txtZorluk";
            this.txtZorluk.Size = new System.Drawing.Size(100, 20);
            this.txtZorluk.TabIndex = 5;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // SeviyeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 416);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.seviyeGridControl);
            this.Name = "SeviyeForm";
            this.Text = "SeviyeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SeviyeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seviyeGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtZorluk.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl seviyeGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        
        private DevExpress.XtraGrid.Columns.GridColumn colZorlukDerecesi;
        private DevExpress.XtraEditors.SimpleButton btnZorlukDerecesi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtZorluk;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}