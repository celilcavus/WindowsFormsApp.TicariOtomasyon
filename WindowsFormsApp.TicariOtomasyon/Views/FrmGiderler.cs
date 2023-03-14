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
    public partial class FrmGiderler : XtraForm
    {
        GiderController cont = new GiderController();
        TBLGIDERLER gider = new TBLGIDERLER();
        public int GiderId { get; set; }

        public FrmGiderler()
        {
            InitializeComponent();
        }
        private object GetGiderList()
        {
            var returnGiderListValues = tBLGIDERLERBindingSource.DataSource = cont.getList();
            return returnGiderListValues;
        }
        private bool ClearAll(bool status = true)
        {
            if (status == true)
            {
                txtGiderElektrik.Text = "";
                txtGiderSu.Text = "";
                txtGiderDogalgaz.Text = "";
                txtGiderInternet.Text = "";
                txtGiderMaaslar.Text = "";
                txtGiderEkstra.Text = "";
                txtGiderEkstraAciklama.Text = "";
                txtGiderTarih.Text = "";
                return status;
            }
            else
                return status;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            gider.ELEKTIRIK = decimal.Parse(txtGiderElektrik.Text);
            gider.SU = decimal.Parse(txtGiderSu.Text);
            gider.DOGALGAZ = decimal.Parse(txtGiderDogalgaz.Text);
            gider.INTERNET = decimal.Parse(txtGiderInternet.Text);
            gider.MAASLAR = decimal.Parse(txtGiderMaaslar.Text);
            gider.EKSTRA = decimal.Parse(txtGiderEkstra.Text);
            gider.EKSTRADETAY = txtGiderEkstraAciklama.Text;
            gider.TARIH = txtGiderTarih.Text;
            int i = cont.Add(gider);
            string message = i >= 1 ? "işlem Başarılı" : "işlem Başarısız";
            MessageBox.Show(message);
            GetGiderList();
            ClearAll();

        }

        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            GetGiderList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            gider.ID = GiderId;
            int i = cont.Remove(gider);
            string message = i >= 1 ? "işlem Başarılı" : "işlem Başarısız";
            MessageBox.Show(message);
            GetGiderList();
            ClearAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            gider.ID = GiderId;
            gider.ELEKTIRIK = decimal.Parse(txtGiderElektrik.Text);
            gider.SU = decimal.Parse(txtGiderSu.Text);
            gider.DOGALGAZ = decimal.Parse(txtGiderDogalgaz.Text);
            gider.INTERNET = decimal.Parse(txtGiderInternet.Text);
            gider.MAASLAR = decimal.Parse(txtGiderMaaslar.Text);
            gider.EKSTRA = decimal.Parse(txtGiderEkstra.Text);
            gider.EKSTRADETAY = txtGiderEkstraAciklama.Text;
            gider.TARIH = txtGiderTarih.Text;
            int i = cont.Update(gider);
            string message = i >= 1 ? "işlem Başarılı" : "işlem Başarısız";
            MessageBox.Show(message);
            GetGiderList();
            ClearAll();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            GetGiderList();
            this.Refresh();
            this.gridView1.RefreshData();
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
            GiderId = int.Parse(gridView1.GetFocusedRowCellDisplayText(colID));
            txtGiderElektrik.Text = gridView1.GetFocusedRowCellDisplayText(colELEKTIRIK);
            txtGiderSu.Text = gridView1.GetFocusedRowCellDisplayText(colSU);
            txtGiderDogalgaz.Text = gridView1.GetFocusedRowCellDisplayText(colDOGALGAZ);
            txtGiderInternet.Text = gridView1.GetFocusedRowCellDisplayText(colINTERNET);
            txtGiderMaaslar.Text = gridView1.GetFocusedRowCellDisplayText(colMAASLAR);
            txtGiderEkstra.Text = gridView1.GetFocusedRowCellDisplayText(colEKSTRA);
            txtGiderEkstraAciklama.Text = gridView1.GetFocusedRowCellDisplayText(colEKSTRADETAY);
            txtGiderTarih.Text = gridView1.GetFocusedRowCellDisplayText(colTARIH);
        }
    }
}
