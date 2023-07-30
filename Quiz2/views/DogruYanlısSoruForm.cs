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
    public partial class DogruYanlısSoruForm : DevExpress.XtraEditors.XtraForm,IDogruYanlısSoruView
    {
        DogruYanlısSoruPresenter presenter;

        public DogruYanlısSoruForm()
        {
            InitializeComponent();
            presenter = new DogruYanlısSoruPresenter(this);
        }

        private void DogruYanlısSorularForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'soruBankasıDataSet1.Seviye' table. You can move, or remove it, as needed.
            this.seviyeTableAdapter.Fill(this.soruBankasıDataSet1.Seviye);
            // TODO: This line of code loads data into the 'soruBankasıDataSet.Kategori' table. You can move, or remove it, as needed.
            this.kategoriTableAdapter.Fill(this.soruBankasıDataSet.Kategori);
            presenter.yükle();
        }

        public void uptadeDogruYanlısSorularGrid(IList<DogruYanlısSoru>liste)
        {
            dogruGridControl.DataSource = null;
            dogruGridControl.RefreshDataSource();
            dogruGridControl.DataSource = liste;
            dogruGridControl.Refresh();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            presenter.dySoruSil(int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString()));
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            presenter.dySoruEkle((int)lookUpKategori.OldEditValue,(int)lookUpSeviye.OldEditValue,memoSoru.Text,txtDogru.Text,txtYanlıs.Text,txtDogruCevap.Text,Convert.ToInt16(txtPuan.Text));
        }
    }
}