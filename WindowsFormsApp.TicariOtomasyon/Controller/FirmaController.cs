using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp.TicariOtomasyon.Interface.BaseInterface;
using WindowsFormsApp.TicariOtomasyon.Model;

namespace WindowsFormsApp.TicariOtomasyon.Controller
{
    public class FirmaController : IRepository<TBLFIRMALAR>
    {
        private DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        private TBLFIRMALAR firma = new TBLFIRMALAR();
        //ID, AD, YETKILISTATUS, YETKILIADSOYAD, TELEFON1, TELEFON2, MAIL, FAX, IL, ILCE, ADRES, VERGIDAIRESI
        public int Add(TBLFIRMALAR item)
        {
            firma.AD = item.AD;
            firma.YETKILISTATUS = item.YETKILISTATUS;
            firma.YETKILIADSOYAD = item.YETKILIADSOYAD;
            firma.TELEFON1 = item.TELEFON1;
            firma.TELEFON2 = item.TELEFON2;
            firma.MAIL = item.MAIL;
            firma.FAX = item.FAX;
            firma.IL = item.IL;
            firma.ILCE = item.ILCE;
            firma.ADRES = item.ADRES;
            firma.VERGIDAIRESI = item.VERGIDAIRESI;
            db.TBLFIRMALAR.Add(firma);
            return db.SaveChanges();
        }

        public List<TBLFIRMALAR> getList()
        {
            return db.TBLFIRMALAR.ToList();
        }

        public int Remove(TBLFIRMALAR item)
        {
            var FindValue = db.TBLFIRMALAR.Find(item.ID);
            db.TBLFIRMALAR.Remove(FindValue);
            return db.SaveChanges();
        }

        public int Update(TBLFIRMALAR item)
        {
            var FindValue = db.TBLFIRMALAR.Where(x=>x.ID == item.ID).FirstOrDefault();
            FindValue.AD = item.AD;
            FindValue.YETKILISTATUS = item.YETKILISTATUS;
            FindValue.YETKILIADSOYAD = item.YETKILIADSOYAD;
            FindValue.TELEFON1 = item.TELEFON1;
            FindValue.TELEFON2 = item.TELEFON2;
            FindValue.MAIL = item.MAIL;
            FindValue.FAX = item.FAX;
            FindValue.IL = item.IL;
            FindValue.ILCE = item.ILCE;
            FindValue.ADRES = item.ADRES;
            FindValue.VERGIDAIRESI = item.VERGIDAIRESI;
            return db.SaveChanges();
        }
    }
}
