using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp.TicariOtomasyon.Controller;
using WindowsFormsApp.TicariOtomasyon.Helper;
using WindowsFormsApp.TicariOtomasyon.Model;

using static WindowsFormsApp.TicariOtomasyon.Helper.Converter;

namespace WindowsFormsApp.TicariOtomasyon.Views
{
    public partial class FrmMusteriler : XtraForm
    {
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        TBLMUSTERILER musteri = new TBLMUSTERILER();
        MusteriController cont = new MusteriController();
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        public int MusteriId { get; set; }

        private bool ClearAll(bool status = true)
        {
            if (status == true)
            {
                txtMusteriAdi.Text = "";
                txtMusteriSoyadi.Text  = "";
                txtMusteriTel1.Text = "";
                txtMusteriTel2.Text = "";
                txtMusteriTc.Text = "";
                txtMusteriMail.Text = "";
                txtMusteriIl.Clear();
                txtMusteriIlce.Clear();
                txtMusteriAdres.Text = "";
                txtMusteriVergiDaire.Text = "";
                return status;
            }
            return false;
        }
        private object GetMusteriList()
        {
            var returnMusteriList = MusteriBindingSource.DataSource = cont.getList();
            return gridControl1.DataSource = returnMusteriList;
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
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            GetMusteriList();
            GetIlList();
            GetIlceList();
        }
       
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            musteri.AD = txtMusteriAdi.Text;
            musteri.SOYAD = txtMusteriSoyadi.Text;
            musteri.TELEFON = txtMusteriTel1.Text;
            musteri.TELEFON2 = txtMusteriTel2.Text;
            musteri.TC = txtMusteriTc.Text;
            musteri.MAIL = txtMusteriMail.Text;
            musteri.IL = txtMusteriIl.EditValue.ToString();
            musteri.ILCE = txtMusteriIlce.EditValue.ToString();
            musteri.ADRES = txtMusteriAdres.Text;
            musteri.VERGIDAIRE = txtMusteriVergiDaire.Text;
            var i = cont.Add(musteri);
            string message = i >= 1 ? "işlem Başarılı" : "işlem başarısız";
            MessageBox.Show(message);
            ClearAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            musteri.ID = MusteriId;
            int i = cont.Remove(musteri);
            string message = i >= 1 ? "işlem Başarılı" : "işlem Başarısız";
            MessageBox.Show(message);
            ClearAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            musteri.ID = MusteriId;
            musteri.AD = txtMusteriAdi.Text;
            musteri.SOYAD = txtMusteriSoyadi.Text;
            musteri.TELEFON = txtMusteriTel1.Text;
            musteri.TELEFON2 = txtMusteriTel2.Text;
            musteri.TC = txtMusteriTc.Text;
            musteri.MAIL = txtMusteriMail.Text;
            musteri.IL = txtMusteriIl.EditValue.ToString();
            musteri.ILCE = txtMusteriIlce.EditValue.ToString();
            musteri.ADRES = txtMusteriAdres.Text;
            musteri.VERGIDAIRE = txtMusteriVergiDaire.Text;
            int i = cont.Update(musteri);
            string message = i >= 1 ? "işlem Başarılı" : "işlem Başarısız";
            MessageBox.Show(message);
            ClearAll();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            this.Refresh();
            GetMusteriList();
            GetIlList();
            GetIlceList();
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
            MusteriId = int.Parse(gridView1.GetFocusedRowCellDisplayText(colID.ToString()));
            txtMusteriAdi.Text = gridView1.GetFocusedRowCellDisplayText(colAD);
            txtMusteriSoyadi.Text = gridView1.GetFocusedRowCellDisplayText(colSOYAD);
            txtMusteriTel1.Text = gridView1.GetFocusedRowCellDisplayText(colTELEFON);
            txtMusteriTel2.Text = gridView1.GetFocusedRowCellDisplayText(colTELEFON2);
            txtMusteriTc.Text = gridView1.GetFocusedRowCellDisplayText(colTC);
            txtMusteriMail.Text = gridView1.GetFocusedRowCellDisplayText(colMAIL);
            txtMusteriIl.EditValue = gridView1.GetFocusedRowCellDisplayText(colIL);
            txtMusteriIlce.EditValue = gridView1.GetFocusedRowCellDisplayText(colILCE);
            txtMusteriAdres.Text = gridView1.GetFocusedRowCellDisplayText(colADRES);
            txtMusteriVergiDaire.Text = gridView1.GetFocusedRowCellDisplayText(colVERGIDAIRE);
        }
    }
}
