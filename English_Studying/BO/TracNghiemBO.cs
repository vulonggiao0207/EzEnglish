using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace English_Studying.BO
{
    public class TracNghiemBO
    {
        private int cautraloidung;
        private int cautraloi;
        private TuVung []choices;    
        public TracNghiemBO()
        {
            cautraloidung=-1;
            cautraloi=-1;
            choices=new TuVung[4];
        }  
        public int CauTraLoiDung
        {
            get { return cautraloidung; }
            set { cautraloidung=value;}
        }
        public int CauTraLoi
        {
            get { return cautraloi; }
            set { cautraloi = value; }
        }
        public TuVung []Choices
        {
            get { return choices; }
            set { choices = value; }
        }
    }
    public class CauHoiCollection : System.Collections.CollectionBase
    {
        public void Add(TracNghiemBO tracnghiemBO)
        {
            List.Add(tracnghiemBO);
        }
        public void Remove(int index)
        {
            List.RemoveAt(index);
        }
        public TracNghiemBO Index(int index)
        {
            return (TracNghiemBO)List[index];
        }


    }
}
