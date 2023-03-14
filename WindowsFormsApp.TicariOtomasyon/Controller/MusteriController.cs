using DevExpress.Data.WcfLinq.Helpers;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp.TicariOtomasyon.Interface.BaseInterface;
using WindowsFormsApp.TicariOtomasyon.Model;

namespace WindowsFormsApp.TicariOtomasyon.Controller
{
    public class MusteriController : IRepository<TBLMUSTERILER>
    {
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        TBLMUSTERILER musteri = new TBLMUSTERILER();
        //ID, AD, SOYAD, TELEFON, TELEFON2, TC, MAIL, IL, ILCE, ADRES, VERGIDAIRE
        public int Add(TBLMUSTERILER item)
        {
            //musteri.AD = item.AD;
            //musteri.SOYAD = item.SOYAD;
            //musteri.TELEFON = item.TELEFON;
            //musteri.TELEFON2 = item.TELEFON2;
            //musteri.TC = item.TC;
            //musteri.MAIL = item.MAIL;
            //musteri.IL = item.IL;
            //musteri.ILCE = item.ILCE;
            //musteri.ADRES = item.ADRES;
            //musteri.VERGIDAIRE = item.VERGIDAIRE;

            db.TBLMUSTERILER.Add(item);
            return db.SaveChanges();
        }

        public List<TBLMUSTERILER> getList()
        {
            return db.TBLMUSTERILER.ToList();
        }

        public int Remove(TBLMUSTERILER item)
        {
            var value = db.TBLMUSTERILER.Find(item.ID);
            db.TBLMUSTERILER.Remove(value);
            return db.SaveChanges();
        }

        public int Update(TBLMUSTERILER item)
        {
            var musteri = db.TBLMUSTERILER.Where(x => x.ID == item.ID).FirstOrDefault();
            musteri.AD = item.AD;
            musteri.SOYAD = item.SOYAD;
            musteri.TELEFON = item.TELEFON;
            musteri.TELEFON2 = item.TELEFON2;
            musteri.TC = item.TC;
            musteri.MAIL = item.MAIL;
            musteri.IL = item.IL;
            musteri.ILCE = item.ILCE;
            musteri.ADRES = item.ADRES;
            musteri.VERGIDAIRE = item.VERGIDAIRE;
            return db.SaveChanges();
        }
    }
}
