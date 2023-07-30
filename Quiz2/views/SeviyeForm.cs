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
    public partial class SeviyeForm : DevExpress.XtraEditors.XtraForm,ISeviyeView
    {
        SeviyePresenter presenter;

        public SeviyeForm()
        {
            InitializeComponent();
            presenter = new SeviyePresenter(this);
        }


        private void btnZorlukDerecesi_Click(object sender, EventArgs e)
        {
            presenter.seviyeEkle(txtZorluk.Text);
        }
      

        private void SeviyeForm_Load(object sender, EventArgs e)
        {
            presenter.yükle();
        }

        public void updateSeviyelerGrid(IList<Seviye> liste)
        {
            seviyeGridControl.DataSource = null;
            seviyeGridControl.RefreshDataSource();
            seviyeGridControl.DataSource = liste;
            seviyeGridControl.Refresh();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            presenter.seviyeSil(int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString()));
        }

       
    }
}