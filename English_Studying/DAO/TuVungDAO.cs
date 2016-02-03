using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace English_Studying.DAO
{
    public class TuVungDAO
    {
        EnglishLinqDataContext db = new EnglishLinqDataContext();
        public IEnumerable<TuVung> Load(TuVung _tuvung)
        {
            IEnumerable<TuVung> query = from p in db.TuVungs
                                        where p.IDTuDien == _tuvung.IDTuDien && p.Tu == _tuvung.Tu
                                        select p;
            return query;
        }
        public IEnumerable<TuVung> Load(int IDTuDien)
        {
            IEnumerable<TuVung> query;
            if (IDTuDien != 0)
            {
                query = from p in db.TuVungs
                        where p.IDTuDien == IDTuDien
                        select p;
            }
            else
            {
                query = from p in db.TuVungs
                        select p;
            }
            return query;
        }      
       
        public void Insert(TuVung _tuvung)
        {
            db.TuVungs.InsertOnSubmit(_tuvung);
            db.SubmitChanges();
        }
        public void Update(TuVung _tuvung)
        {
            TuVung _tudienedit = db.TuVungs.Single(p => p.IDTuVung == _tuvung.IDTuVung);
            _tudienedit.Tu = _tuvung.Tu;
            _tudienedit.LoaiTu = _tuvung.LoaiTu;
            _tudienedit.NghiaTu = _tuvung.NghiaTu;
            _tudienedit.HinhAnh = _tuvung.HinhAnh;
            _tudienedit.ApDung = _tuvung.ApDung;
            db.SubmitChanges();
        }
        public void Delete(TuVung _tuvung)
        {
            IEnumerable<TuVung> delquery = from p in db.TuVungs
                                           where p.IDTuVung == (int)_tuvung.IDTuVung
                                           select p;
            db.TuVungs.DeleteAllOnSubmit(delquery);
            db.SubmitChanges();
        }
     
    }
}
