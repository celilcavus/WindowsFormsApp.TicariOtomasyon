using DevExpress.Data.WcfLinq.Helpers;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp.TicariOtomasyon.Interface.BaseInterface;
using WindowsFormsApp.TicariOtomasyon.Model;

namespace WindowsFormsApp.TicariOtomasyon.Controller
{

    public class UrunController : IRepository<TBLURUNLER>
    {
        private static DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private static TBLURUNLER urun = new TBLURUNLER();

        public int Add(TBLURUNLER item)
        {
            db.TBLURUNLER.Add(item);
            return db.SaveChanges();
        }

        public List<TBLURUNLER> getList()
        {
            return db.TBLURUNLER.ToList();
        }

        public int Remove(TBLURUNLER item)
        {
            var returnId = db.TBLURUNLER.Find(item.ID);
            db.TBLURUNLER.Remove(returnId);
            return db.SaveChanges();
        }

        public int Update(TBLURUNLER item)
        {
            var getlist = db.TBLURUNLER.Where(x => x.ID == item.ID).FirstOrDefault();
            getlist.URUNAD = item.URUNAD;
            getlist.MARKA = item.MARKA;
            getlist.MODEL = item.MODEL;
            getlist.YIL = item.YIL;
            getlist.ADET = item.ADET;
            getlist.ALISFIYAT = item.ALISFIYAT;
            getlist.SATISFIYAT = item.SATISFIYAT;
            getlist.DETAY = item.DETAY;
            return db.SaveChanges();

        }
    }
}
