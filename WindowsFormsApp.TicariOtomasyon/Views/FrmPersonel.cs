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
    public partial class FrmPersonel : XtraForm
    {
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        TBLPERSONELLER pers = new TBLPERSONELLER();
        PersonelController cont = new PersonelController();
        public FrmPersonel()
        {
            InitializeComponent();
        }
        public int PersonelID { get; set; }
        private object GetPersonelList()
        {
            var returnPersonelValues = tBLPERSONELLERBindingSource.DataSource = cont.getList();
            return gridControl1.DataSource = returnPersonelValues;

        }
        private object GetPersonelIl()
        {
            var returnPersonelIl = illerBindingSource.DataSource = db.iller.ToList();
            return returnPersonelIl;
        }
        private object GetPersonelIlce()
        {
            var returnPersonelIlce = ilcelerBindingSource.DataSource = db.ilceler.ToList();
            return returnPersonelIlce;
        }

        private bool ClearAll(bool status = true)
        {
            if (status == true)
            {
                txtPersAd.Text = "";
                txtPersSoyad.Text = "";
                txtPersTel.Text = "";
                txtPersTc.Text = "";
                txtPersMail.Text = "";
                txtPersIl.EditValue = "";
                txtPersIlce.EditValue = "";
                txtPersAdres.Text = "";
                txtPersGorev.Text = "";
                return status;
            }
            return false;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            pers.AD = txtPersAd.Text;
            pers.SOYAD = txtPersSoyad.Text;
            pers.TELEFON = txtPersTel.Text;
            pers.TC = txtPersTc.Text;
            pers.MAIL = txtPersMail.Text;
            pers.IL = txtPersIl.Text;
            pers.ILCE = txtPersIlce.Text;
            pers.ADRES = txtPersAdres.Text;
            pers.GOREV = txtPersGorev.Text;
            int i = cont.Add(pers);
            string message = i >= 1 ? "işlem Başarılı" : "işlem Başarısız";
            MessageBox.Show(message);
            GetPersonelList();
            ClearAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            pers.ID = PersonelID;
            int i = cont.Remove(pers);
            string message = i >= 1 ? "işlem Başarılı" : "işlem Başarısız";
            GetPersonelList();
            ClearAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            pers.ID = PersonelID;
            pers.AD = txtPersAd.Text;
            pers.SOYAD = txtPersSoyad.Text;
            pers.TELEFON = txtPersTel.Text;
            pers.TC = txtPersTc.Text;
            pers.MAIL = txtPersMail.Text;
            pers.IL = txtPersIl.Text;
            pers.ILCE = txtPersIlce.Text;
            pers.ADRES = txtPersAdres.Text;
            pers.GOREV = txtPersGorev.Text;
            int i = cont.Update(pers);
            string message = i >= 1 ? "işlem Başarılı" : "işlem Başarısız";
            MessageBox.Show(message);
            GetPersonelList();
            ClearAll();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            GetPersonelIl();
            GetPersonelIlce();
            GetPersonelList();
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

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            GetPersonelIl();
            GetPersonelIlce();
            GetPersonelList();

        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            PersonelID = int.Parse(gridView1.GetFocusedRowCellDisplayText(colID));
            txtPersAd.Text = gridView1.GetFocusedRowCellDisplayText(colAD);
            txtPersSoyad.Text = gridView1.GetFocusedRowCellDisplayText(colSOYAD);
            txtPersTel.Text = gridView1.GetFocusedRowCellDisplayText(colTELEFON);
            txtPersTc.Text = gridView1.GetFocusedRowCellDisplayText(colTC);
            txtPersMail.EditValue = gridView1.GetFocusedRowCellDisplayText(colMAIL);
            txtPersIl.EditValue = gridView1.GetFocusedRowCellDisplayText(colIL);
            txtPersIlce.EditValue = gridView1.GetFocusedRowCellDisplayText(colILCE);
            txtPersAdres.Text = gridView1.GetFocusedRowCellDisplayText(colADRES);
            txtPersGorev.Text = gridView1.GetFocusedRowCellDisplayText(colGOREV);
        }
    }
}