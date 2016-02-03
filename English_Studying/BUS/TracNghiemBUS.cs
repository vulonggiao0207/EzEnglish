using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using English_Studying.BO;
using English_Studying.DAO;

namespace English_Studying.BUS
{
    public class TracNghiemBUS
    {
        TuVungDAO tuvungDAO = new TuVungDAO();
   //     CauHoiCollection cauhoiColl_temp= new CauHoiCollection();
        public int socauhoi_hinhanh=0;
        public int socauhoi_apdung = 0;
        Random rd = new Random();
        public IEnumerable<TuVung> LoadDSTuVung(int[] IDtudien)
        {
            List<TuVung> tuvungTest= new List<TuVung>();            
            for (int i = 0; i < IDtudien.ToList().Count; i++)
            {
                foreach (TuVung tv in tuvungDAO.Load(IDtudien[i]))
                {
                    tuvungTest.Add(tv);
                    if (tv.HinhAnh.Trim() != "")
                        socauhoi_hinhanh++;
                    if (tv.ApDung.Trim() != "")
                        socauhoi_apdung++;
                }
            }
            return tuvungTest;
        }
        private int RandomTuVung(int max)
        {         
            return rd.Next(0, max);        
        }
        private bool KiemTraTrungCauHoi(CauHoiCollection cauhoiColl,TuVung tv)
        {
            foreach (TracNghiemBO tn in cauhoiColl)
            {
                if (tv.IDTuVung == tn.Choices[0].IDTuVung)
                    return true;
            }
            return false;
        }
        private bool KiemTraTrungCauTraLoi(TuVung[] tuvung, TuVung temp,int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (temp == tuvung[i])
                    return true;
            }
            return false;
        }
        private CauHoiCollection TaoDanhSachCauHoi_HinhAnh(IEnumerable<TuVung> tuvunglambantest, int socauhoilambai)
        {
            CauHoiCollection CauHoiColl = new CauHoiCollection();
            int i = 0;
            while (i < socauhoilambai)
            {
                //Chọn ngẫu nhiên 1 câu hỏi trong tuvunglambaitest
                int stt= RandomTuVung(tuvunglambantest.ToList().Count);
                TuVung temp = tuvunglambantest.ToList()[stt];
                //Kiểm tra câu hỏi đã có trong danh sách chưa
                //Nếu có rồi: Tạo lại -->Kiểm tra
                //Nếu chưa: Add vào --> i++
                while(KiemTraTrungCauHoi(CauHoiColl,temp)==true ||temp.HinhAnh.Trim()=="")
                {
                    stt = RandomTuVung(tuvunglambantest.ToList().Count);
                    temp=tuvunglambantest.ToList()[stt];
                }
                TracNghiemBO tnBO= new TracNghiemBO();
                tnBO.Choices[0] = temp;
                CauHoiColl.Add(tnBO);
                i++;
            }
            return CauHoiColl;
        }
        private CauHoiCollection TaoDanhSachCauHoi_TracNghiem(IEnumerable<TuVung> tuvunglambantest, int socauhoilambai)
        {
            CauHoiCollection CauHoiColl = new CauHoiCollection();
            int i = 0;
            while (i < socauhoilambai)
            {
                //Chọn ngẫu nhiên 1 câu hỏi trong tuvunglambaitest
                int stt = RandomTuVung(tuvunglambantest.ToList().Count);
                TuVung temp = tuvunglambantest.ToList()[stt];
                //Kiểm tra câu hỏi đã có trong danh sách chưa
                //Nếu có rồi: Tạo lại -->Kiểm tra
                //Nếu chưa: Add vào --> i++
                while (KiemTraTrungCauHoi(CauHoiColl, temp) == true ||temp.ApDung.Trim()=="")
                {
                    stt = RandomTuVung(tuvunglambantest.ToList().Count);
                    temp = tuvunglambantest.ToList()[stt];
                }
                TracNghiemBO tnBO = new TracNghiemBO();
                tnBO.Choices[0] = temp;
                CauHoiColl.Add(tnBO);
                i++;
            }
            return CauHoiColl;
        }        
        private CauHoiCollection TaoDanhSachCauTraLoi(IEnumerable<TuVung> tuvunglambantest, CauHoiCollection CauHoicoll)
        {
            int i = 0;
            while (i < CauHoicoll.Count)
            {
                int ques_pos=1;
                while (ques_pos < 4)
                {
                    //Chọn ngẫu nhiên 1 câu hỏi trong tuvunglambaitest
                    int stt = RandomTuVung(tuvunglambantest.ToList().Count);
                    TuVung temp = tuvunglambantest.ToList()[stt];
                    //Kiểm tra câu trả lời đã có trong danh sách trả lời chưa
                    //Nếu có rồi: Tạo lại -->Kiểm tra
                    //Nếu chưa: Add vào --> i++
                    while (KiemTraTrungCauTraLoi(CauHoicoll.Index(i).Choices, temp,ques_pos) == true)
                    {
                        stt = RandomTuVung(tuvunglambantest.ToList().Count);
                        temp = tuvunglambantest.ToList()[stt];
                    }
                    CauHoicoll.Index(i).Choices[ques_pos] = temp;
                    ques_pos++;
                }
                i++;
            }
            return CauHoicoll;
        }     
        private CauHoiCollection SapXepNgauNhien(CauHoiCollection CauTraLoiColl)
        {
            CauHoiCollection BaiTest = new CauHoiCollection();
           
            for (int i = 0; i < CauTraLoiColl.Count; i++)
            {
                int new_pos = -1;
                new_pos = RandomTuVung(4);
                if(i>1)
                {
                    while(new_pos==CauTraLoiColl.Index(i-2).CauTraLoiDung)
                    {
                         new_pos = RandomTuVung(4);
                    }
                }
                CauTraLoiColl.Index(i).CauTraLoiDung = new_pos;
                //Hóan vị câu trả lới đúng với câu trả lời bất kỳ
                TuVung oldtv = CauTraLoiColl.Index(i).Choices[0];
                TuVung newtv = CauTraLoiColl.Index(i).Choices[new_pos];
                CauTraLoiColl.Index(i).Choices[0]= newtv;
                CauTraLoiColl.Index(i).Choices[new_pos]=oldtv;                
               
            }
            BaiTest = CauTraLoiColl;
            return BaiTest;
          
        }
        public CauHoiCollection TaoBaiTest_HinhAnh(IEnumerable<TuVung> tuvunglambantest, int socauhoilambai)
        {
        //    if(socauhoilambai
            CauHoiCollection DanhsachCauHoi = new CauHoiCollection();
            CauHoiCollection DanhsachCauTraLoi = new CauHoiCollection();
            CauHoiCollection BaiTest = new CauHoiCollection();
            DanhsachCauHoi = TaoDanhSachCauHoi_HinhAnh(tuvunglambantest, socauhoilambai);
            DanhsachCauTraLoi = TaoDanhSachCauTraLoi(tuvunglambantest, DanhsachCauHoi);
            BaiTest = SapXepNgauNhien(DanhsachCauTraLoi);
            return BaiTest;
        }
        public CauHoiCollection TaoBaiTest_TracNghiem(IEnumerable<TuVung> tuvunglambantest, int socauhoilambai)
        {
            CauHoiCollection DanhsachCauHoi = new CauHoiCollection();
            CauHoiCollection DanhsachCauTraLoi = new CauHoiCollection();
            CauHoiCollection BaiTest = new CauHoiCollection();
            DanhsachCauHoi = TaoDanhSachCauHoi_TracNghiem(tuvunglambantest, socauhoilambai);
            DanhsachCauTraLoi = TaoDanhSachCauTraLoi(tuvunglambantest, DanhsachCauHoi);
            BaiTest = SapXepNgauNhien(DanhsachCauTraLoi);
            return BaiTest;
        }
     
    }
}
