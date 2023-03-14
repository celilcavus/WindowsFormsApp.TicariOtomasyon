using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp.TicariOtomasyon.Controller;
using WindowsFormsApp.TicariOtomasyon.Helper;
using WindowsFormsApp.TicariOtomasyon.Model;
using static WindowsFormsApp.TicariOtomasyon.Helper.Converter;

namespace WindowsFormsApp.TicariOtomasyon.Views
{
    public partial class FrmBanka : XtraForm
    {
        public FrmBanka()
        {
            InitializeComponent();
        }
        BankaController cont = new BankaController();
        TBLBANKA bank = new TBLBANKA();
        public int BankId { get; set; }
        private object GetBankList()
        {
            var GetBankValues = tBLBANKABindingSource.DataSource = cont.getList();
            return gridControl1.DataSource = GetBankValues;
        }
        private object GetHesapTuruList()
        {
            List<HESAPTURU> tur = new List<HESAPTURU>();
            tur.Add(new HESAPTURU{ID = 1,Name = "KURUMSAL"});
            tur.Add(new HESAPTURU { ID = 1,Name = "BIREYSEL"});
            
            return bndBankaHesapTuru.DataSource = tur.ToList();
        }
        private bool ClearAll(bool status = true)
        {
            if (status == true)
            {
                txtBankaAdi.Text = "";
                txtBankaSube.Text = "";
                txtBankaIban.Text = "";
                txtBankaHesapNo.Text = "";
                txtBankaYetkili.Text = "";
                txtBankaIban.Text = "";
                txtBankaHesapTuru.Text = "";
                return status;
            }
            return status;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bank.BANKAADI = txtBankaAdi.Text;
            bank.SUBE = txtBankaSube.Text;
            bank.IBAN = txtBankaIban.Text;
            bank.HESAPNO = txtBankaHesapNo.Text;
            bank.YETKILI = txtBankaYetkili.Text;
            bank.IBAN = txtBankaIban.Text;
            bank.HESAPTURU = txtBankaHesapTuru.Text;
            int i = cont.Add(bank);
            string message = i >= 1 ? "işlem Başarılı" : "işlem Başarısız";
            MessageBox.Show(message);
            GetBankList(); ClearAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            bank.ID = BankId;
            int i = cont.Remove(bank);
            string message = i >= 1 ? "işlem Başarılı" : "işlem Başarısız";
            MessageBox.Show(message);
            GetBankList(); ClearAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bank.ID = BankId;
            bank.BANKAADI = txtBankaAdi.Text;
            bank.SUBE = txtBankaSube.Text;
            bank.IBAN = txtBankaIban.Text;
            bank.HESAPNO = txtBankaHesapNo.Text;
            bank.YETKILI = txtBankaYetkili.Text;
            bank.IBAN = txtBankaIban.Text;
            bank.HESAPTURU = txtBankaHesapTuru.Text;
            int i = cont.Update(bank);
            string message = i >= 1 ? "işlem Başarılı" : "işlem Başarısız";
            MessageBox.Show(message);
            GetBankList(); ClearAll();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            GetBankList();
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
            BankId = int.Parse(gridView1.GetFocusedRowCellDisplayText(colID));
            txtBankaAdi.Text = gridView1.GetFocusedRowCellDisplayText(colBANKAADI);
            txtBankaSube.Text = gridView1.GetFocusedRowCellDisplayText(colSUBE);
            txtBankaIban.Text = gridView1.GetFocusedRowCellDisplayText(colBANKAADI);
            txtBankaHesapNo.Text = gridView1.GetFocusedRowCellDisplayText(colHESAPNO);
            txtBankaYetkili.Text = gridView1.GetFocusedRowCellDisplayText(colYETKILI);
            txtBankaIban.Text = gridView1.GetFocusedRowCellDisplayText(colIBAN);
            txtBankaHesapTuru.Text = gridView1.GetFocusedRowCellDisplayText(colHESAPTURU);
        }

        private void FrmBanka_Load(object sender, EventArgs e)
        {
            GetBankList();
            GetHesapTuruList();
        }
    }

    class HESAPTURU
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

}
