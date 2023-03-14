using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp.TicariOtomasyon.Interface.BaseInterface;
using WindowsFormsApp.TicariOtomasyon.Model;

namespace WindowsFormsApp.TicariOtomasyon.Controller
{
    public class PersonelController : IRepository<TBLPERSONELLER>
    {
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        TBLPERSONELLER pers = new TBLPERSONELLER();

        public int Add(TBLPERSONELLER item)
        {
            db.TBLPERSONELLER.Add(item);
            return db.SaveChanges();
        }

        public List<TBLPERSONELLER> getList()
        {
            return db.TBLPERSONELLER.ToList();
        }

        public int Remove(TBLPERSONELLER item)
        {
            var values = db.TBLPERSONELLER.Where(x => x.ID == item.ID).FirstOrDefault();
            db.TBLPERSONELLER.Remove(values);
            return db.SaveChanges();
        }

        public int Update(TBLPERSONELLER item)
        {
            var pers = db.TBLPERSONELLER.Where(x => x.ID == item.ID).FirstOrDefault();
            pers.AD = item.AD;
            pers.SOYAD = item.SOYAD;
            pers.TELEFON = item.TELEFON;
            pers.TC = item.TC;
            pers.MAIL = item.MAIL;
            pers.IL = item.IL;
            pers.ILCE = item.ILCE;
            pers.ADRES = item.ADRES;
            pers.GOREV = item.GOREV;
            return db.SaveChanges();
        }
    }
}
