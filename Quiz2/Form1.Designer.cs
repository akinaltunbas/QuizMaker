namespace Quiz2
{
    partial class Form1
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnKategori = new DevExpress.XtraBars.BarButtonItem();
            this.seviyeEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnKlasikSoruEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnCoktanSecmeliSoruEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnDogruYanlısEkle = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnSoruListesi = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnKategori,
            this.seviyeEkle,
            this.btnKlasikSoruEkle,
            this.btnCoktanSecmeliSoruEkle,
            this.btnDogruYanlısEkle,
            this.barSubItem1,
            this.btnSoruListesi});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(886, 143);
            // 
            // btnKategori
            // 
            this.btnKategori.Caption = "KategoriEkle";
            this.btnKategori.Id = 1;
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnKategori.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKategori_ItemClick);
            // 
            // seviyeEkle
            // 
            this.seviyeEkle.Caption = "SeviyeEkle";
            this.seviyeEkle.Id = 2;
            this.seviyeEkle.Name = "seviyeEkle";
            this.seviyeEkle.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.seviyeEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.seviyeEkle_ItemClick);
            // 
            // btnKlasikSoruEkle
            // 
            this.btnKlasikSoruEkle.Caption = "Klasik Soru Ekle";
            this.btnKlasikSoruEkle.Id = 3;
            this.btnKlasikSoruEkle.Name = "btnKlasikSoruEkle";
            this.btnKlasikSoruEkle.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnKlasikSoruEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKlasikSoruEkle_ItemClick);
            // 
            // btnCoktanSecmeliSoruEkle
            // 
            this.btnCoktanSecmeliSoruEkle.Caption = "Çoktan Seçmeli Soru Ekle";
            this.btnCoktanSecmeliSoruEkle.Id = 4;
            this.btnCoktanSecmeliSoruEkle.Name = "btnCoktanSecmeliSoruEkle";
            this.btnCoktanSecmeliSoruEkle.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnCoktanSecmeliSoruEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCoktanSecmeliSoruEkle_ItemClick);
            // 
            // btnDogruYanlısEkle
            // 
            this.btnDogruYanlısEkle.ActAsDropDown = true;
            this.btnDogruYanlısEkle.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btnDogruYanlısEkle.Caption = "Doğru Yanlış Soru Ekle";
            this.btnDogruYanlısEkle.Id = 5;
            this.btnDogruYanlısEkle.Name = "btnDogruYanlısEkle";
            this.btnDogruYanlısEkle.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDogruYanlısEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDogruYanlısEkle_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 6;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnSoruListesi
            // 
            this.btnSoruListesi.Caption = "Soru Havuzu";
            this.btnSoruListesi.Id = 7;
            this.btnSoruListesi.Name = "btnSoruListesi";
            this.btnSoruListesi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSoruListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSoruListesi_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKategori);
            this.ribbonPageGroup1.ItemLinks.Add(this.seviyeEkle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKlasikSoruEkle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCoktanSecmeliSoruEkle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDogruYanlısEkle);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Soru Bankası İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSoruListesi);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 360);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnKategori;
        private DevExpress.XtraBars.BarButtonItem seviyeEkle;
        private DevExpress.XtraBars.BarButtonItem btnKlasikSoruEkle;
        private DevExpress.XtraBars.BarButtonItem btnCoktanSecmeliSoruEkle;
        private DevExpress.XtraBars.BarButtonItem btnDogruYanlısEkle;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnSoruListesi;
    }
}

