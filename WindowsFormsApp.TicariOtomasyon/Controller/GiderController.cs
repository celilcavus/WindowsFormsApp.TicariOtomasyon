using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp.TicariOtomasyon.Interface.BaseInterface;
using WindowsFormsApp.TicariOtomasyon.Model;

namespace WindowsFormsApp.TicariOtomasyon.Controller
{


    public class GiderController : IRepository<TBLGIDERLER>
    {
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
      
        public int Add(TBLGIDERLER item)
        {
            db.TBLGIDERLER.Add(item);
            return db.SaveChanges();
        }

        public List<TBLGIDERLER> getList()
        {
            return db.TBLGIDERLER.ToList();
        }

        public int Remove(TBLGIDERLER item)
        {
            var value = db.TBLGIDERLER.Find(item.ID);
            db.TBLGIDERLER.Remove(value);
            return db.SaveChanges();
        }

        public int Update(TBLGIDERLER item)
        {
            var gider = db.TBLGIDERLER.Find(item.ID);
            gider.ELEKTIRIK = item.ELEKTIRIK;
            gider.SU = item.SU;
            gider.DOGALGAZ = item.DOGALGAZ;
            gider.INTERNET = item.INTERNET;
            gider.MAASLAR = item.MAASLAR;
            gider.EKSTRA = item.EKSTRA;
            gider.EKSTRADETAY = item.EKSTRADETAY;
            gider.TARIH = item.TARIH;
            return db.SaveChanges();
        }
    }
}
