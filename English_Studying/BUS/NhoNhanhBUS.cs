using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using English_Studying.DAO;
using English_Studying.BO;
namespace English_Studying.BUS
{
    public class NhoNhanhBUS
    {
        TuVungDAO tuvungDAO = new TuVungDAO();
        Random rd = new Random();
        private int random(int max)
        {           
            return rd.Next(max);
        }      
        private List<TuVung> TaoDSNgauNhien(IEnumerable<TuVung> tuvunglambaitest)
        {
            List<TuVung> dsNgauNhien = new List<TuVung>();

            List<TuVung> dsNgauNhienLuu = tuvunglambaitest.ToList();
            int i = 0;
            while (i < 10)
            {
                int rd = random(dsNgauNhienLuu.ToList().Count);
                dsNgauNhien.Add(dsNgauNhienLuu.ToList()[rd]);
                dsNgauNhienLuu.Remove(dsNgauNhienLuu.ToList()[rd]);
                i++;
            }
            return dsNgauNhien;
        }
        private NhoNhanhCollection TaoDsONhoNhanh(List<TuVung> DSNgauNhien)
        {
            NhoNhanhCollection NhoNhanhColl = new NhoNhanhCollection();
            for (int i = 0; i < 10; i++)
            {
                NhoNhanhBO nnBO = new NhoNhanhBO();
                nnBO.STTEng = i;
                nnBO.NoiDungEng = DSNgauNhien[i].Tu;
                NhoNhanhColl.Add(nnBO);
                NhoNhanhBO nnBO1 = new NhoNhanhBO();
                nnBO1.STTEng = i;
                nnBO1.NoiDungEng = DSNgauNhien[i].NghiaTu;
                NhoNhanhColl.Add(nnBO1);
            }
            return NhoNhanhColl;
        }
        private NhoNhanhCollection HoanViONhoNhanh(NhoNhanhCollection nhonhanhColl)
        {
            NhoNhanhCollection nhonhanhCollCopy = nhonhanhColl;
            NhoNhanhCollection NhoNhanhColl = new NhoNhanhCollection();    
            int []kt= new int[20];
            for (int k = 0; k < 20; k++)
                kt[k] = -1;
            int i = 0;
            int j = 20;
            while (i < 20)
            {
                int rd = random(j);     
                NhoNhanhColl.Add(nhonhanhCollCopy.Index(rd));
                nhonhanhCollCopy.Remove(rd);               
                i++;
                j--;
            }
            return NhoNhanhColl;
        }
        public NhoNhanhCollection BaiTestNhoNhanh(IEnumerable<TuVung> tuvunglambaitest)
        {
            List<TuVung> taodsngaunhien = TaoDSNgauNhien(tuvunglambaitest);
            NhoNhanhCollection taodsonhonhanh = TaoDsONhoNhanh(taodsngaunhien);
            NhoNhanhCollection NhoNhanhColl = HoanViONhoNhanh(taodsonhonhanh);
            return NhoNhanhColl;
        }

    }
}
