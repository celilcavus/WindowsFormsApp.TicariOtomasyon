using DevExpress.Pdf.Native.BouncyCastle.Asn1;
using DevExpress.XtraGrid;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp.TicariOtomasyon.Helper
{
    public static class Converter
    {
        private static SaveFileDialog dialog = new SaveFileDialog();
        private static readonly string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public static void ConvertDocument(GridControl grid, ConvertType type)
        {

            dialog.Title = "CONVERT";
            dialog.OverwritePrompt = false;
            string name = dialog.FileName = "result";
            string yol = string.Concat(DesktopPath, "\\", string.Concat(name, ".", type));

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                switch (type)
                {
                    case ConvertType.pdf:
                        grid.ExportToPdf(yol);
                        break;
                    case ConvertType.xls:
                        grid.ExportToXls(yol);
                        break;
                    case ConvertType.mht:
                        grid.ExportToMht(yol);
                        break;
                }
            }
            else
            {
                MessageBox.Show("İşlem Başarısız");
            }
        }

        public enum ConvertType
        {
            pdf,
            xls,
            mht
        }
    }
}
