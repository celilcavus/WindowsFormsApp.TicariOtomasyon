using DevExpress.Data.ODataLinq.Helpers;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp.TicariOtomasyon.Interface.BaseInterface;
using WindowsFormsApp.TicariOtomasyon.Model;

namespace WindowsFormsApp.TicariOtomasyon.Controller
{
    public class FaturaDetayController : IRepository<TBLFATURADETAY>
    {
        private DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        public int Add(TBLFATURADETAY item)
        {
            db.TBLFATURADETAY.Add(item);
            return db.SaveChanges();
        }

        public List<TBLFATURADETAY> getList()
        {
            return db.TBLFATURADETAY.ToList();
        }

        public int Remove(TBLFATURADETAY item)
        {
            var values = db.TBLFATURADETAY.Where(x => x.ID == item.ID).FirstOrDefault();
            db.TBLFATURADETAY.Remove(values);
            return db.SaveChanges();
        }

        public int Update(TBLFATURADETAY item)
        {
            var values = db.TBLFATURADETAY.Where(x => x.ID == item.ID).FirstOrDefault();
            values.FATURAID = item.FATURAID;
            values.MIKTAR = item.MIKTAR;
            values.FIYAT = item.FIYAT;
            values.TUTAR = item.TUTAR;
            return db.SaveChanges();
        }
    }
}
