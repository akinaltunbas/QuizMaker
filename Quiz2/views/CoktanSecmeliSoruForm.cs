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
    public partial class CoktanSecmeliSoruForm : DevExpress.XtraEditors.XtraForm,ICoktanSecmeliSoruView
    {
        CoktanSecmeliSoruPresenter presenter;

        public CoktanSecmeliSoruForm()
        {
            InitializeComponent();
            presenter = new CoktanSecmeliSoruPresenter(this);
        }

        private void CoktanSecmeliSoruForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'soruBankasıDataSet1.Seviye' table. You can move, or remove it, as needed.
            this.seviyeTableAdapter.Fill(this.soruBankasıDataSet1.Seviye);
            // TODO: This line of code loads data into the 'soruBankasıDataSet.Kategori' table. You can move, or remove it, as needed.
            this.kategoriTableAdapter.Fill(this.soruBankasıDataSet.Kategori);

            presenter.yükle();
        }

        public void updateCoktanSecmeliSorularGrid(IList<CoktanSecmeliSoru>liste)
        {
            coktanSecmeliGridControl.DataSource = null;
            coktanSecmeliGridControl.RefreshDataSource();
            coktanSecmeliGridControl.DataSource = liste;
            coktanSecmeliGridControl.Refresh();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            presenter.coktanSecmeliSoruEkle((int)lookUpKategori.OldEditValue,(int)lookUpSeviye.OldEditValue,memoSoru.Text,checkA.Text,checkB.Text,checkC.Text,checkD.Text,textDogruCevap.Text,Convert.ToInt16(textPuan.Text));
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            presenter.coktanSecmeliSoruSil(int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString()));
        }

        private void checkC_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }
}