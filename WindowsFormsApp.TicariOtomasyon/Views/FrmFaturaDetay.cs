using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp.TicariOtomasyon.Controller;
using WindowsFormsApp.TicariOtomasyon.Helper;
using WindowsFormsApp.TicariOtomasyon.Model;
using static WindowsFormsApp.TicariOtomasyon.Helper.Converter;

namespace WindowsFormsApp.TicariOtomasyon.Views
{
    public partial class FrmFaturaDetay : XtraForm
    {
        FaturaDetayController fat = new FaturaDetayController();
        TBLFATURADETAY fatdetay = new TBLFATURADETAY();
        private int GetFaturaId { get; set; }
        public int FaturaDetayId { get; set; }
        public FrmFaturaDetay(int id)
        {
            InitializeComponent();
            GetFaturaId = id;
        }
        private bool ClearAll(bool status = true)
        {
            if (status == true)
            {
                txtFatDetayTutar.Text = "";
                txtFatDetayMiktar.Text = "";
                txtFatDetayFiyat.Text = "";
                return status;
            }
            else return status;

        }
        private object GetFaturaDetayList()
        {
            var returnFaturaDetayValues = fat.getList().Where(x => x.FATURAID == GetFaturaId).ToList();
            return tBLFATURADETAYBindingSource.DataSource = returnFaturaDetayValues;
        }
        private void FrmFaturaDetay_Load(object sender, EventArgs e)
        {
            GetFaturaDetayList();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            fatdetay.FATURAID = GetFaturaId;
            fatdetay.TUTAR = decimal.Parse(txtFatDetayTutar.Text);
            fatdetay.MIKTAR = short.Parse(txtFatDetayMiktar.Text);
            fatdetay.FIYAT = decimal.Parse(txtFatDetayFiyat.Text);
            int i = fat.Add(fatdetay);
            string message = i >= 1 ? "işlem Başarılı" : "işlem Başarısız";
            MessageBox.Show(message);
            GetFaturaDetayList();ClearAll();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            fatdetay.ID = FaturaDetayId;
            int i = fat.Remove(fatdetay);
            string message = i >= 1 ? "işlem Başarılı" : "işlem Başarısız";
            MessageBox.Show(message);
            GetFaturaDetayList(); ClearAll();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            fatdetay.ID = FaturaDetayId;
            fatdetay.FATURAID = GetFaturaId;
            fatdetay.TUTAR = decimal.Parse(txtFatDetayTutar.Text);
            fatdetay.MIKTAR = short.Parse(txtFatDetayMiktar.Text);
            fatdetay.FIYAT = decimal.Parse(txtFatDetayFiyat.Text);
            int i = fat.Update(fatdetay);
            string message = i >= 1 ? "işlem Başarılı" : "işlem Başarısız";
            MessageBox.Show(message);
            GetFaturaDetayList(); ClearAll();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            GetFaturaDetayList();
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
            FaturaDetayId = int.Parse(gridView1.GetFocusedRowCellDisplayText(colID));
            txtFatDetayTutar.Text = gridView1.GetFocusedRowCellDisplayText(colTUTAR);
            txtFatDetayMiktar.Text = gridView1.GetFocusedRowCellDisplayText(colMIKTAR);
            txtFatDetayFiyat.Text = gridView1.GetFocusedRowCellDisplayText(colFIYAT);
        }
    }
}
