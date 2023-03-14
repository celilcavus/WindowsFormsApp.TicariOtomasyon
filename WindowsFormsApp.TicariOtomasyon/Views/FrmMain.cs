using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using WindowsFormsApp.TicariOtomasyon.Controller;
using WindowsFormsApp.TicariOtomasyon.Views;

namespace WindowsFormsApp.TicariOtomasyon.WinForms
{
    public partial class FrmMain : RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnUrunler_ItemClick(object sender, ItemClickEventArgs e)
        {
            new Urunler().ShowDialog();
        }

        private void btnMusteriler_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FrmMusteriler().ShowDialog();
        }

        private void btnFirmalar_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FrmFirmalar().ShowDialog();
        }

        private void btnPersonel_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FrmPersonel().ShowDialog();
        }

        private void btnRehber_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FrmRehber().ShowDialog();
        }

        private void btnGiderler_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FrmGiderler().ShowDialog();
        }

        private void btnStoklar_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FrmStoklar().ShowDialog();
        }

        private void btnBankalar_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FrmBanka().ShowDialog();
        }

        private void btnNotlar_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FrmNotlar().ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FrmFaturalar().ShowDialog();
        }
    }
}