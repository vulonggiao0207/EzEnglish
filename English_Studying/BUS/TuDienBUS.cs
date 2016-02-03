using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using English_Studying.DAO;
namespace English_Studying.BUS
{
    public class TuDienBUS
    {
        TuDienDAO tudienDAO = new TuDienDAO();
        public IEnumerable<TuDien> LoadTuDien(string _IDnguoidung)
        {
            try
            {
                return tudienDAO.Load(_IDnguoidung);                
            }
            catch
            {
                return null;
            }
        }
        public bool ThemTuDien(string _IDNguoiDung, string _TenTuDien,string _MoTa)
        {
            try
            {
                TuDien td = new TuDien();
                td.IDNguoiDung = _IDNguoiDung;
                td.TenTuDien = _TenTuDien;            
                tudienDAO.Insert(td);
                return true;
           }
            catch
            {
                return false;
            }
        }
        public bool CapNhatTuDien(int _IDTuDien, string _TenTuDien)
        {
            try
            {
                TuDien td = new TuDien();
                td.IDTuDien = _IDTuDien;
                td.TenTuDien = _TenTuDien;               
                tudienDAO.Update(td);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaTuDien(int _IDTuDien)
        {
            try
            {
                TuDien td = new TuDien();
                td.IDTuDien = _IDTuDien;
                tudienDAO.Delete(td);
                return true;
           }
            catch
            {
                return false; 
            }
        }
    }
}
