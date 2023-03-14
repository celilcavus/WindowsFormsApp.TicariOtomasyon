using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp.TicariOtomasyon.Interface.BaseInterface;
using WindowsFormsApp.TicariOtomasyon.Model;

namespace WindowsFormsApp.TicariOtomasyon.Controller
{
    public class NotlarController : IRepository<TBLNOTLAR>
    {
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        public int Add(TBLNOTLAR item)
        {
            db.TBLNOTLAR.Add(item);
            return db.SaveChanges();
        }

        public List<TBLNOTLAR> getList()
        {
            return db.TBLNOTLAR.ToList();
        }

        public int Remove(TBLNOTLAR item)
        {
            var values = db.TBLNOTLAR.Where(x => x.ID == item.ID).FirstOrDefault();
            db.TBLNOTLAR.Remove(values);
            return db.SaveChanges();
        }

        public int Update(TBLNOTLAR item)
        {
            var values = db.TBLNOTLAR.Where(x => x.ID == item.ID).FirstOrDefault();
            values.NOTBASLIK = item.NOTBASLIK;
            values.NOTDETAY = item.NOTDETAY;
            values.NOTOLUSTURAN = item.NOTOLUSTURAN;
            values.NOTTARIH = item.NOTTARIH;
            return db.SaveChanges();
        }
    }
}
