using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;
using WindowsFormsApp.TicariOtomasyon.Helper;
using WindowsFormsApp.TicariOtomasyon.Model;
using WindowsFormsApp.TicariOtomasyon.Views;
using static WindowsFormsApp.TicariOtomasyon.Helper.Converter;

namespace WindowsFormsApp.TicariOtomasyon.Controller
{
    public partial class FrmFaturalar : XtraForm
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }
        FaturaController db = new FaturaController();
        TBLFATURALAR fat = new TBLFATURALAR();
        public int FaturaId { get; set; }
        private object GetFaturaList()
        {
            var returnFaturaList = tBLFATURALARBindingSource.DataSource = db.getList();
            return returnFaturaList;
        }

        private bool ClearAll(bool status = true)
        {
            if (status == true)
            {
                txtFatSeri.Text = "";
                txtFatSeriNo.Text = "";
                txtFatVergiDairesi.Text = "";
                txtFatAlici.Text = "";
                txtFatTeslimEden.Text = "";
                txtFatTeslimAlan.Text = "";
                txtFatTarih.Text = "";
                return status;
            }
            else
                return status;
        }
        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            GetFaturaList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            fat.SERI = txtFatSeri.Text;
            fat.SIRANO = txtFatSeriNo.Text;
            fat.VERGIDAIRESI = txtFatVergiDairesi.Text;
            fat.ALICI = txtFatAlici.Text;
            fat.TESLIMEDEN = txtFatTeslimEden.Text;
            fat.TESLIMALAN = txtFatTeslimAlan.Text;
            fat.TARIH = DateTime.Parse(txtFatTarih.Text);
            int i = db.Add(fat);
            string message = i >= 1 ? "işlem Başarılı" : "işlem Başarısız";
            GetFaturaList(); ClearAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            fat.ID = FaturaId;
            int i = db.Remove(fat);
            string message = i >= 1 ? "işlem Başarılı" : "işlem Başarısız";
            GetFaturaList(); ClearAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            fat.ID = FaturaId;
            fat.SERI = txtFatSeri.Text;
            fat.SIRANO = txtFatSeriNo.Text;
            fat.VERGIDAIRESI = txtFatVergiDairesi.Text;
            fat.ALICI = txtFatAlici.Text;
            fat.TESLIMEDEN = txtFatTeslimEden.Text;
            fat.TESLIMALAN = txtFatTeslimAlan.Text;
            fat.TARIH = DateTime.Parse(txtFatTarih.Text);
            int i = db.Update(fat);
            string message = i >= 1 ? "işlem Başarılı" : "işlem Başarısız";
            MessageBox.Show(message);
            GetFaturaList(); ClearAll();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            this.Refresh();
            GetFaturaList();
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
            FaturaId = int.Parse(gridView1.GetFocusedRowCellDisplayText(colID));
            txtFatSeri.Text = gridView1.GetFocusedRowCellDisplayText(colSERI);
            txtFatSeriNo.Text = gridView1.GetFocusedRowCellDisplayText(colSIRANO);
            txtFatVergiDairesi.Text = gridView1.GetFocusedRowCellDisplayText(colVERGIDAIRESI);
            txtFatAlici.Text = gridView1.GetFocusedRowCellDisplayText(colALICI);
            txtFatTeslimEden.Text = gridView1.GetFocusedRowCellDisplayText(colTESLIMEDEN);
            txtFatTeslimAlan.Text = gridView1.GetFocusedRowCellDisplayText(colTESLIMALAN);
            txtFatTarih.Text = gridView1.GetFocusedRowCellDisplayText(colTARIH);
        }
        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            new FrmFaturaDetay(FaturaId).ShowDialog();
        }
    }
}

