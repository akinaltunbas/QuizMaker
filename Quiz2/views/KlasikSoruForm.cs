using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Quiz2.presenters;
using Quiz2.models;

namespace Quiz2.views
{
    public partial class KlasikSoruForm : DevExpress.XtraEditors.XtraForm,IKlasikSoruView
    {
        KlasikSoruPresenter presenter;

        public KlasikSoruForm()
        {
            InitializeComponent();
            presenter = new KlasikSoruPresenter(this);
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KlasikSoruForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'soruBankasıDataSet1.Seviye' table. You can move, or remove it, as needed.
            this.seviyeTableAdapter.Fill(this.soruBankasıDataSet1.Seviye);
            // TODO: This line of code loads data into the 'soruBankasıDataSet.Kategori' table. You can move, or remove it, as needed.
            this.kategoriTableAdapter.Fill(this.soruBankasıDataSet.Kategori);
            presenter.yükle();
        }

        public void updateKlasikSorularGrid(IList<KlasikSoru> liste)
        {
            klasikGridControl.DataSource = null;
            klasikGridControl.RefreshDataSource();
            klasikGridControl.DataSource = liste;
            klasikGridControl.Refresh();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            presenter.klasikSoruEkle((int)lookUpKategori.OldEditValue,(int)lookUpSeviye.OldEditValue,memoSoru.Text,memoCevap.Text,memoDoğruCevap.Text,Convert.ToInt16(txtPuan.Text));
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            presenter.klasikSoruSil(int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString()));
        }
    }
}