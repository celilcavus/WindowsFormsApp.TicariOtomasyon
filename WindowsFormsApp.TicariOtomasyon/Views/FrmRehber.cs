using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Linq;
using WindowsFormsApp.TicariOtomasyon.Model;

namespace WindowsFormsApp.TicariOtomasyon.Views
{
    public partial class FrmRehber : XtraForm
    {
        public FrmRehber()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();

        private object GetFirmaList()
        {
            var FirmaList = tBLFIRMALARBindingSource.DataSource = db.TBLFIRMALAR.ToList();
            return FirmaList;
        }
        private object GetMusteriList()
        {
            var MusteriList = tBLMUSTERILERBindingSource.DataSource = db.TBLMUSTERILER.ToList();
            return MusteriList;
        }

        private void FrmRehber_Load(object sender, EventArgs e)
        {
            GetFirmaList();
            GetMusteriList();
        }
        FrmMail mail = new FrmMail();
        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            
            mail.Mail = gridView1.GetFocusedRowCellDisplayText(colMAIL).ToString();
            mail.ShowDialog();
        }

        private void gridView2_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            mail.Mail = gridView2.GetFocusedRowCellDisplayText(colMAIL1).ToString();
            mail.ShowDialog();
        }
    }
}
