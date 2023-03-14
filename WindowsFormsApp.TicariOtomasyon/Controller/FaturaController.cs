using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp.TicariOtomasyon.Interface.BaseInterface;
using WindowsFormsApp.TicariOtomasyon.Model;

namespace WindowsFormsApp.TicariOtomasyon.Controller
{
    public class FaturaController : IRepository<TBLFATURALAR>
    {
        DbTicariOtomasyonEntities db = new DbTicariOtomasyonEntities();
        TBLFATURALAR fat = new TBLFATURALAR();
        public int Add(TBLFATURALAR item)
        {
            db.TBLFATURALAR.Add(item);
            return db.SaveChanges();
        }

        public List<TBLFATURALAR> getList()
        {
            return db.TBLFATURALAR.ToList();
        }

        public int Remove(TBLFATURALAR item)
        {
            var value = db.TBLFATURALAR.Where(x => x.ID == item.ID).FirstOrDefault();
            db.TBLFATURALAR.Remove(value);
            return db.SaveChanges();
        }

        public int Update(TBLFATURALAR item)
        {
            var val = db.TBLFATURALAR.Where(x => x.ID == item.ID).FirstOrDefault();
            val.SERI = item.SERI;
            val.SIRANO = item.SIRANO;
            val.VERGIDAIRESI = item.VERGIDAIRESI;
            val.ALICI = item.ALICI;
            val.TESLIMEDEN = item.TESLIMEDEN;
            val.TESLIMALAN = item.TESLIMALAN;
            val.TARIH = item.TARIH;
            return db.SaveChanges();
        }
    }
}
