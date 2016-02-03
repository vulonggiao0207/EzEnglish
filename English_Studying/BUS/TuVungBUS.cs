using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using English_Studying.DAO;
using English_Studying.BO;
namespace English_Studying.BUS
{
    public class TuVungBUS
    {
        TuVungDAO tuvungDAO = new TuVungDAO();
        public IEnumerable<TuVung> LoadTuVung(int IDTuDien)
        {

            try
            {               
                return tuvungDAO.Load(IDTuDien);
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<TuVung> LoadTuVung(int IDtudien,string tuvung)
        {
            try
            {
                TuVung tv = new TuVung();
                tv.Tu = tuvung;
                tv.IDTuDien = IDtudien;
                return tuvungDAO.Load(tv);
            }
            catch
            {
                return null;
            }
        }      
        public bool ThemTuVung(int idtudien, string tu, string loai, string nghia,string hinhanh, string apdung)
        {
            try
            {
                TuVung tv = new TuVung();
                tv.IDTuDien = idtudien;
                tv.Tu = tu;
                tv.LoaiTu = loai;
                tv.NghiaTu = nghia;
                tv.HinhAnh = hinhanh;
                tv.ApDung = apdung;
                tuvungDAO.Insert(tv);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaTuVung(int idtuvung,string tu, string loai, string nghia,string hinhanh, string apdung)
        {
            try
            {
                TuVung tv = new TuVung();
                tv.IDTuVung = idtuvung;
                tv.Tu = tu;
                tv.LoaiTu = loai;
                tv.NghiaTu = nghia;
                tv.HinhAnh = hinhanh;
                tv.ApDung = apdung;
                tuvungDAO.Update(tv);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaTuVung(int IDTuvung)
        {
            try
            {
                TuVung tv= new TuVung();
                tv.IDTuVung=IDTuvung;
                tuvungDAO.Delete(tv);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public string LuuAnh(string DuongDanDenFile,string tenfile)
        {
            string duongdan = "EzEng_pics\\";
        //    string tenfile = System.IO.Path.GetFileName(Ofile.FileName);
            int i = 1;
            while (System.IO.File.Exists(duongdan + tenfile) == true)
                tenfile = tenfile.Split('.')[0] + (i++) + "." + tenfile.ToString().Split('.')[1];
            System.IO.File.Copy(DuongDanDenFile, duongdan + tenfile);
          //  HinhAnh = "C:\\Documents and Settings\\VanVan\\My Documents\\" + System.IO.Path.GetFileName(Ofile.FileName);
            return DuongDanDenFile = "EzEng_pics\\" + tenfile;
        }
      
    }
}
