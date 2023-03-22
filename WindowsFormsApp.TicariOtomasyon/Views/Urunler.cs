using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;
using WindowsFormsApp.TicariOtomasyon.Controller;
using WindowsFormsApp.TicariOtomasyon.Helper;
using WindowsFormsApp.TicariOtomasyon.Model;

using static WindowsFormsApp.TicariOtomasyon.Helper.Converter;

namespace WindowsFormsApp.TicariOtomasyon.Views
{
    public partial class Urunler : DevExpress.XtraEditors.XtraForm
    {
        public int ID { get; set; }

        UrunController urun = new UrunController();
        TBLURUNLER item = new TBLURUNLER();
        public Urunler()
        {
            InitializeComponent();
        }
        private void Getlist()
        {
            var returnList = urunBinding.DataSource = urun.getList();
            gridControl1.DataSource = returnList;
        }
        private bool clearAll(bool status = true)
        {
            if(status == true)
            {
                txtUrunAdi.Text = "";
                txtUrunMarka.Text = "";
                txtUrunModel.Text = "";
                txtUrunYili.Text = "";
                txtUrunAdet.Text = "";
                txtUrunAlisFiyat.Text = "";
                txtUrunSatisFiyat.Text = "";
                txtUrunDetay.Text = "";
                return true;
            }
            return false;
        }
        //ID, URUNAD, MARKA, MODEL, YIL, ADET, ALISFIYAT, SATISFIYAT, DETAY
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            item.URUNAD = txtUrunAdi.Text;
            item.MARKA = txtUrunMarka.Text;
            item.MODEL = txtUrunModel.Text;
            item.YIL = Convert.ToDateTime(txtUrunYili.Text);
            item.ADET = short.Parse(txtUrunAdet.Text);
            item.ALISFIYAT = decimal.Parse(txtUrunAlisFiyat.Text);
            item.SATISFIYAT = decimal.Parse(txtUrunSatisFiyat.Text);
            item.DETAY = txtUrunDetay.Text;
            int i = urun.Add(item);
            if (i >= 1)
            {
                MessageBox.Show("Başarıyla Kaydedildi.");
                Getlist();
                clearAll();
            }
            else
            {
                MessageBox.Show("Bi Hata Oluştu Lütfen tekrar deneyiniz.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            int i = urun.Remove(new TBLURUNLER { ID = this.ID });
            if (i >= 1)
            {
                MessageBox.Show("Başarıyla Silindi.");
                Getlist();
                clearAll();
            }
            else
            {
                MessageBox.Show("Bi Hata Oluştu Lütfen tekrar deneyiniz.");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            item.ID = ID;
            item.URUNAD = txtUrunAdi.Text;
            item.MARKA = txtUrunMarka.Text;
            item.MODEL = txtUrunModel.Text;
            item.YIL = Convert.ToDateTime(txtUrunYili.Text);
            item.ADET = short.Parse(txtUrunAdet.Text);
            item.ALISFIYAT = decimal.Parse(txtUrunAlisFiyat.Text);
            item.SATISFIYAT = decimal.Parse(txtUrunSatisFiyat.Text);
            item.DETAY = txtUrunDetay.Text;
            int i = urun.Update(item);
            if (i >= 1)
            {
                MessageBox.Show("Başarıyla Güncellendi.");
                Getlist();
                clearAll();
            }
            else
            {
                MessageBox.Show("Bi Hata Oluştu Lütfen tekrar deneyiniz.");
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Getlist();
            clearAll();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            Converter.ConvertDocument(gridControl1,ConvertType.pdf);
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

        private void Urunler_Load(object sender, EventArgs e)
        {
            Getlist();
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            ID = int.Parse(gridView1.GetFocusedRowCellValue(colID.ToString()).ToString());
            txtUrunAdi.Text = gridView1.GetFocusedRowCellValue(colURUNAD).ToString();
            txtUrunMarka.Text = gridView1.GetFocusedRowCellValue(colMARKA).ToString();
            txtUrunModel.Text = gridView1.GetFocusedRowCellValue(colMODEL).ToString();
            txtUrunYili.Text = gridView1.GetFocusedRowCellValue(colYIL).ToString();
            txtUrunAdet.Text = gridView1.GetFocusedRowCellValue(colADET).ToString();
            txtUrunAlisFiyat.Text = gridView1.GetFocusedRowCellValue(colALISFIYAT).ToString();
            txtUrunSatisFiyat.Text = gridView1.GetFocusedRowCellValue(colSATISFIYAT).ToString();
            txtUrunDetay.Text = gridView1.GetFocusedRowCellValue(colDETAY).ToString();
        }
    }
}