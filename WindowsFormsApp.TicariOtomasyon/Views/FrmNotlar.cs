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
    public partial class FrmNotlar : XtraForm
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        private NotlarController db = new NotlarController();
        private TBLNOTLAR not = new TBLNOTLAR();
        public int NotId { get; set; }
        private object GetNotlarList()
        {
            var getNotlarList = tBLNOTLARBindingSource.DataSource = db.getList();
            return getNotlarList;
        }
        private bool ClearAll(bool status = true)
        {
            if (status == true)
            {
                txtNotBaslik.Text = "";
                txtNotDetay.Text = "";
                txtNotOlusturan.Text = "";
                txtNotTarih.Text = "";
                return status;
            }
            return status;
        }
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            GetNotlarList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            not.NOTBASLIK = txtNotBaslik.Text;
            not.NOTDETAY = txtNotDetay.Text;
            not.NOTOLUSTURAN = txtNotOlusturan.Text;
            not.NOTTARIH = txtNotTarih.Text;
            int i = db.Add(not);
            string message = i >= 1 ? "işlem Başarılı" : "işlem Başarısız";
            MessageBox.Show(message);
            GetNotlarList();ClearAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            not.ID = NotId;
            int i = db.Remove(not);
            string message = i >= 1 ? "işlem Başarılı" : "işlem Başarısız";
            MessageBox.Show(message);
            GetNotlarList(); ClearAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            not.ID = NotId;
            not.NOTBASLIK = txtNotBaslik.Text;
            not.NOTDETAY = txtNotDetay.Text;
            not.NOTOLUSTURAN = txtNotOlusturan.Text;
            not.NOTTARIH = txtNotTarih.Text;
            int i = db.Update(not);
            string message = i >= 1 ? "işlem Başarılı" : "işlem Başarısız";
            MessageBox.Show(message);
            GetNotlarList(); ClearAll();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            GetNotlarList();
            this.Refresh();
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
            NotId = int.Parse(gridView1.GetFocusedRowCellDisplayText(colID));
            txtNotBaslik.Text = gridView1.GetFocusedRowCellDisplayText(colNOTBASLIK);
            txtNotDetay.Text = gridView1.GetFocusedRowCellDisplayText(colNOTDETAY);
            txtNotOlusturan.Text = gridView1.GetFocusedRowCellDisplayText(colNOTOLUSTURAN);
            txtNotTarih.Text = gridView1.GetFocusedRowCellDisplayText(colNOTTARIH);
        }
    }
}
