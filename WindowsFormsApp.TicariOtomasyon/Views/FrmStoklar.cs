using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;
using WindowsFormsApp.TicariOtomasyon.Controller;
using WindowsFormsApp.TicariOtomasyon.Helper;
using WindowsFormsApp.TicariOtomasyon.Model;
using static WindowsFormsApp.TicariOtomasyon.Helper.Converter;

namespace WindowsFormsApp.TicariOtomasyon.Views
{
    public partial class FrmStoklar : XtraForm
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        TBLSTOKLAR stok = new TBLSTOKLAR();
        StokController cont = new StokController();

        public int StokId { get; set; }
        private object GetStokList()
        {
            var returnStokValues = tBLSTOKLARBindingSource.DataSource = cont.getList();
            gridControl1.DataSource = returnStokValues;
            return returnStokValues;
        }
        private bool ClearAll(bool status = true)
        {
            if (status == true)
            {
                txtStokAd.Text = "";
                txtStokAdet.Text = "";
            }
            return false;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            stok.STOCKTUR = txtStokAd.Text;
            stok.STOCKADET = short.Parse(txtStokAdet.Text);
            int i = cont.Add(stok);

            string message = i >= 1 ? "işlem Başarılı" : "işlem Başarısız";
            MessageBox.Show(message);
            GetStokList(); ClearAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            stok.ID = StokId;
            int i = cont.Remove(stok);

            string message = i >= 1 ? "işlem Başarılı" : "işlem Başarısız";
            MessageBox.Show(message);
            GetStokList(); ClearAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            stok.ID = StokId;
            stok.STOCKTUR = txtStokAd.Text;
            stok.STOCKADET = short.Parse(txtStokAdet.Text);
            int i = cont.Update(stok);
            string message = i >= 1 ? "işlem Başarılı" : "işlem Başarısız";
            MessageBox.Show(message);
            GetStokList(); ClearAll();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            GetStokList();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            Converter.ConvertDocument(gridControl1, ConvertType.pdf);
        }

        private void btnXls_Click(object sender, EventArgs e)
        {
            Converter.ConvertDocument(gridControl1, ConvertType.xls);
        }

        private void btnMht_Click(object sender, EventArgs e)
        {
            Converter.ConvertDocument(gridControl1, ConvertType.mht);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            StokId = int.Parse(gridView1.GetFocusedRowCellDisplayText(colID));
            txtStokAd.Text = gridView1.GetFocusedRowCellDisplayText(colSTOCKTUR);
            txtStokAdet.Text = gridView1.GetFocusedRowCellDisplayText(colSTOCKADET);
        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            GetStokList();
        }
    }
}
