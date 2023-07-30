using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Quiz2.views
{
    public partial class SınavOlusturForm : DevExpress.XtraEditors.XtraForm
    {
        public SınavOlusturForm()
        {
            InitializeComponent();
        }

        private void SınavOlusturForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'soruBankasıDataSet.Kategori' table. You can move, or remove it, as needed.
            this.kategoriTableAdapter.Fill(this.soruBankasıDataSet.Kategori);

        }
    }
}