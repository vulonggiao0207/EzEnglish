using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using English_Studying.DAO;
using English_Studying.BO;
namespace English_Studying.BUS
{
    public class OChuBUS
    {
        TuVungDAO tvDAO = new TuVungDAO();       
        private static int chieudaitu = 0;
        Random rd = new Random();
        private List<char> LayChuNgauNhien(IEnumerable<TuVung> tuvunglambaitest)
        {
            List<char> Tu= new List<char>();
            int len=tuvunglambaitest.ToList().Count;
            int rand = rd.Next(len);
            string temp = "";
            while (true)
            {
                rand = rd.Next(len);
                temp = tuvunglambaitest.ToList()[rand].Tu;
                if (temp.Length < 10)
                {
                    rand = rd.Next(len);
                //    temp = tuvunglambaitest.ToList()[rand].Tu;
                    break;
                }
            }
            char[] TuTemp = temp.ToCharArray();
            chieudaitu = TuTemp.Length;
            for (int i = 0; i < chieudaitu; i++)
                Tu.Add(TuTemp[i]);
            return Tu;
        }
        private TuVung LoadTuChoOChu(IEnumerable<TuVung> tuvunglambaitest,char tu)
        {
            var query = from p in tuvunglambaitest
                       where p.Tu.Contains(tu)
                       select p;
            int rand=rd.Next(query.ToList().Count());
            return query.ToList()[rand];
        }
        private bool KiemTraHopLe(string tu, char vitri)
        {
            int vitrikytu=tu.IndexOf(vitri);
            if (tu.Substring(0, vitrikytu).Length > 8)
                return false;
            if (tu.Substring(vitrikytu + 1, tu.Length - tu.Substring(0, vitrikytu).Length-1 ).Length> 8)
                return false;
            return true;
        }
        private bool KiemTraTrung(OChuCollection OChu,string tu)
        {
            foreach(OChuBO ochBO in OChu)
            {         
                // chuyển từ mảng ký tự List<char> thành 1 chuỗi
                StringBuilder builder = new StringBuilder();
                foreach (char ch in ochBO.Tu)
                {
                    builder.Append(ch);
                }
                string result = builder.ToString();
                //so sánh
                if (result == tu.ToString())
                    return false;
            }
            return true;
        }
        private bool KiemTraTrungTuDoc(string tuvung, List<char> TuDoc)
        {
            // chuyển từ mảng ký tự List<char> thành 1 chuỗi
            StringBuilder builder = new StringBuilder();
            foreach (char ch in TuDoc)
            {
                builder.Append(ch);
            }
            string result = builder.ToString();
            if (result == tuvung)
                return false;
            return true;
        }
        static int demsolanloop = 0;
        public OChuCollection TaoOChu(IEnumerable<TuVung> tuvunglambaitest,ref List<char> Tu)
        {
            demsolanloop = 0;
            try
            {
                OChuCollection OChu = new OChuCollection();
                //Lấy một chữ (n) chiều dọc ngẫu nhiên --> Tạo thành mảng ký tự
                Tu = new List<char>();
                Tu = LayChuNgauNhien(tuvunglambaitest);
                //Load từ cho n Ô chữ chiều ngang
                int i = 0;
                while (i < chieudaitu)
                {
                    TuVung temp = LoadTuChoOChu(tuvunglambaitest, Tu[i]);    
                    
                    while (true)
                    {
                        if (KiemTraHopLe(temp.Tu, Tu[i]) == true && KiemTraTrung(OChu, temp.Tu) == true && KiemTraTrungTuDoc(temp.Tu,Tu)==true)
                        {                          
                            break;
                        }
                        temp = LoadTuChoOChu(tuvunglambaitest, Tu[i]);
                        // nếu lặp 5 lần mà ko đựơc, coi như sai
                        demsolanloop++;
                        if (demsolanloop > 5)
                            return null;
                    }
                    OChuBO ochBO = new OChuBO();
                    ochBO.STT = i;
                    List<char>Tutemp = new List<char>();        
                    for (int k = 0; k < temp.Tu.Length; k++)
                    {
                       char _add =Convert.ToChar(temp.Tu.Substring(k, 1));
                       Tutemp.Add(_add);
                    }
                    ochBO.Tu = Tutemp;
                    ochBO.NghiaTu = temp.NghiaTu;
                    OChu.Add(ochBO);
                    i++;
                }
                return OChu;
            }
            catch
            {
                return null;
            }
        }

    }
}
