using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp.TicariOtomasyon.Controller;
using WindowsFormsApp.TicariOtomasyon.Helper;
using WindowsFormsApp.TicariOtomasyon.Model;
using static WindowsFormsApp.TicariOtomasyon.Helper.Converter;

namespace WindowsFormsApp.TicariOtomasyon.Views
{
    public partial class FrmFirmalar : XtraForm
    {
        private DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private TBLFIRMALAR firma = new TBLFIRMALAR();
        private FirmaController cont = new FirmaController();
        //ID, AD, YETKILISTATUS, YETKILIADSOYAD, TELEFON1, TELEFON2, MAIL, FAX, IL, ILCE, ADRES, VERGIDAIRESI
        public FrmFirmalar()
        {
            InitializeComponent();
        }
        public int FirmaId { get; set; }

        private bool ClearAll(bool status = true)
        {
            if (status == true)
            {
                txtFirmaAdi.Text = "";
                txtFirmaStatus.Text = "";
                txtFirmaYetkiliAdSoyad.Text = "";
                txtFirmaTel1.Text = "";
                txtFirmaTel2.Text = "";
                txtFirmaMail.Text = "";
                txtFirmaFax.Text = "";
                txtFirmaIl.Text = "";
                txtFirmaiIlce.Text = "";
                txtFirmaAdres.Text = "";
                txtFirmaVergiDaire.Text = "";
                return status;
            }
            else return false;

        }

        private object GetFirmaList()
        {
            var returnGetFirmaList = tBLFIRMALARBindingSource.DataSource = cont.getList();
            return gridControl1.DataSource = returnGetFirmaList;
        }
        private object GetIlList()
        {
            var returnGetIlList = illerBindingSource.DataSource = db.iller.ToList();
            return returnGetIlList;
        }
        private object GetIlceList()
        {
            var returnGetIlceList = ilcelerBindingSource.DataSource = db.ilceler.ToList();
            return returnGetIlceList;
        }
        private void FrmFirmalar_Load(object sender, System.EventArgs e)
        {
            GetFirmaList();
            GetIlList();
            GetIlceList();
        }

        private void btnKaydet_Click(object sender, System.EventArgs e)
        {
            firma.AD = txtFirmaAdi.Text;
            firma.YETKILISTATUS = txtFirmaStatus.Text;
            firma.YETKILIADSOYAD = txtFirmaYetkiliAdSoyad.Text;
            firma.TELEFON1 = txtFirmaTel1.Text;
            firma.TELEFON2 = txtFirmaTel2.Text;
            firma.MAIL = txtFirmaMail.Text;
            firma.FAX = txtFirmaFax.Text;
            firma.IL = txtFirmaIl.Text;
            firma.ILCE = txtFirmaiIlce.Text;
            firma.ADRES = txtFirmaAdres.Text;
            firma.VERGIDAIRESI = txtFirmaVergiDaire.Text;

            int i = cont.Add(firma);
            string message = i >= 1 ? "işlem Başarılı" : "işlem Başarısız";
            MessageBox.Show(message);
            ClearAll();
            GetFirmaList();
        }

        private void btnSil_Click(object sender, System.EventArgs e)
        {
            firma.ID = FirmaId;
            int i = cont.Remove(firma);
            string message = i >= 1 ? "işlem Başarılı" : "işlem Başarısız";
            MessageBox.Show(message);
            ClearAll();
            GetFirmaList();
        }

        private void btnGuncelle_Click(object sender, System.EventArgs e)
        {
            firma.ID = FirmaId;
            firma.AD = txtFirmaAdi.Text;
            firma.YETKILISTATUS = txtFirmaStatus.Text;
            firma.YETKILIADSOYAD = txtFirmaYetkiliAdSoyad.Text;
            firma.TELEFON1 = txtFirmaTel1.Text;
            firma.TELEFON2 = txtFirmaTel2.Text;
            firma.MAIL = txtFirmaMail.Text;
            firma.FAX = txtFirmaFax.Text;
            firma.IL = txtFirmaIl.Text;
            firma.ILCE = txtFirmaiIlce.Text;
            firma.ADRES = txtFirmaAdres.Text;
            firma.VERGIDAIRESI = txtFirmaVergiDaire.Text;

            int i = cont.Update(firma);
            string message = i >= 1 ? "işlem Başarılı" : "işlem Başarısız";
            MessageBox.Show(message);
            ClearAll();
            GetFirmaList();
        }

        private void btnYenile_Click(object sender, System.EventArgs e)
        {
            GetFirmaList();
            GetIlList();
            GetIlceList();
            this.Refresh();
        }

        private void btnPdf_Click(object sender, System.EventArgs e)
        {
            Converter.ConvertDocument(gridControl1, ConvertType.pdf);
        }

        private void btnXls_Click(object sender, System.EventArgs e)
        {
            Converter.ConvertDocument(gridControl1, ConvertType.xls);
        }

        private void btnMht_Click(object sender, System.EventArgs e)
        {
            Converter.ConvertDocument(gridControl1, ConvertType.mht);
        }

        private void btnCikis_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            FirmaId = int.Parse(gridView1.GetFocusedRowCellDisplayText(colID));
            txtFirmaAdi.Text = gridView1.GetFocusedRowCellDisplayText(colAD);
            txtFirmaStatus.Text = gridView1.GetFocusedRowCellDisplayText(colYETKILISTATUS);
            txtFirmaYetkiliAdSoyad.Text = gridView1.GetFocusedRowCellDisplayText(colYETKILIADSOYAD);
            txtFirmaTel1.Text = gridView1.GetFocusedRowCellDisplayText(colTELEFON1);
            txtFirmaTel2.Text = gridView1.GetFocusedRowCellDisplayText(colTELEFON2);
            txtFirmaMail.Text = gridView1.GetFocusedRowCellDisplayText(colMAIL);
            txtFirmaFax.Text = gridView1.GetFocusedRowCellDisplayText(colFAX);
            txtFirmaIl.Text = gridView1.GetFocusedRowCellDisplayText(colIL);
            txtFirmaiIlce.Text = gridView1.GetFocusedRowCellDisplayText(colILCE);
            txtFirmaAdres.Text = gridView1.GetFocusedRowCellDisplayText(colADRES);
            txtFirmaVergiDaire.Text = gridView1.GetFocusedRowCellDisplayText(colVERGIDAIRESI);
        }
    }
}
