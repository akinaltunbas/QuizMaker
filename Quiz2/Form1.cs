using Quiz2.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quiz2
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KategoriForm form =new KategoriForm();
            form.MdiParent = this;
            form.Show();
        }

        private void seviyeEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SeviyeForm form = new SeviyeForm();
            form.MdiParent = this;
            form.Show();
        }

        private void btnKlasikSoruEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KlasikSoruForm form = new KlasikSoruForm();
            form.MdiParent = this;
            form.Show();
        }

        private void btnCoktanSecmeliSoruEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CoktanSecmeliSoruForm form = new CoktanSecmeliSoruForm();
            form.MdiParent = this;
            form.Show();
        }

        private void btnSoruListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         
        }

        private void btnDogruYanlısEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DogruYanlısSoruForm form = new DogruYanlısSoruForm();
            form.MdiParent = this;
            form.Show();
        }
    }
}
