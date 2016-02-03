using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace English_Studying.DAO
{
    public class TuDienDAO
    {
        EnglishLinqDataContext db = new EnglishLinqDataContext();
        public IEnumerable<TuDien> Load(string _IDnguoidung)
        {
            IEnumerable<TuDien> query= from p in db.TuDiens
                       where p.IDNguoiDung==_IDnguoidung 
                       orderby p.TenTuDien
                       select p;
            return query;
        }
        public void Insert(TuDien _tudien)
        {
            db.TuDiens.InsertOnSubmit(_tudien);
            db.SubmitChanges();
        }
        public void Update(TuDien _tudien)
        {
            TuDien _tudienedit = db.TuDiens.Single(p => p.IDTuDien == _tudien.IDTuDien);         
            _tudienedit.TenTuDien = _tudien.TenTuDien;
            db.SubmitChanges();
        }
        public void Delete(TuDien _tudien)
        {
            IEnumerable<TuDien> delquery = from p in db.TuDiens
                              where p.IDTuDien == (int)_tudien.IDTuDien
                              select p;         
            db.TuDiens.DeleteAllOnSubmit(delquery);
            db.SubmitChanges();
        }
    }
}
