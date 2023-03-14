using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp.TicariOtomasyon.Interface.BaseInterface;
using WindowsFormsApp.TicariOtomasyon.Model;

namespace WindowsFormsApp.TicariOtomasyon.Controller
{
    public class StokController : IRepository<TBLSTOKLAR>
    {
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();

        public int Add(TBLSTOKLAR item)
        {
            db.TBLSTOKLAR.Add(item);
            return db.SaveChanges();
        }

        public List<TBLSTOKLAR> getList()
        {
            return db.TBLSTOKLAR.ToList();
        }

        public int Remove(TBLSTOKLAR item)
        {
            var values = db.TBLSTOKLAR.Where(x => x.ID == item.ID).FirstOrDefault();
            db.TBLSTOKLAR.Remove(values);
            return db.SaveChanges();

        }

        public int Update(TBLSTOKLAR item)
        {
            var stok = db.TBLSTOKLAR.Find(item.ID);
            stok.STOCKTUR = item.STOCKTUR;
            stok.STOCKADET = item.STOCKADET;
            return db.SaveChanges();
        }
    }
}
