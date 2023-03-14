using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp.TicariOtomasyon.Interface.BaseInterface;
using WindowsFormsApp.TicariOtomasyon.Model;

namespace WindowsFormsApp.TicariOtomasyon.Controller
{
    public class BankaController : IRepository<TBLBANKA>
    {
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        public int Add(TBLBANKA item)
        {
            db.TBLBANKA.Add(item);
            return db.SaveChanges();
        }

        public List<TBLBANKA> getList()
        {
            return db.TBLBANKA.ToList();
        }

        public int Remove(TBLBANKA item)
        {
            var value = db.TBLBANKA.Where(x => x.ID == item.ID).FirstOrDefault();
            db.TBLBANKA.Remove(value);
            return db.SaveChanges();
        }

        public int Update(TBLBANKA item)
        {
            var value = db.TBLBANKA.Where(x => x.ID == item.ID).FirstOrDefault();
            value.ID = item.ID;
            value.BANKAADI = item.BANKAADI;
            value.SUBE = item.SUBE;
            value.IBAN = item.IBAN;
            value.HESAPNO = item.HESAPNO;
            value.YETKILI = item.YETKILI;
            value.IBAN = item.IBAN;
            value.HESAPTURU = item.HESAPTURU;
            return db.SaveChanges();
        }
    }
}
