using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace English_Studying.BO
{
    public class NhoNhanhBO
    {
        int sttEng;
        string noidungEng;   
        public NhoNhanhBO()
        {
            sttEng = -1;
            noidungEng = "";
        }
        public int STTEng
        {
            get {return sttEng ;}
            set { sttEng = value; }
        }
        public string NoiDungEng
        {
            get {return noidungEng ;}
            set {noidungEng=value ;}
        }
     /*   public int STTViet
        {
            get { return sttViet; }
            set { sttViet = value; }
        }
        public string NoiDungViet
        {
            get { return noidungViet; }
            set { noidungViet = value; }
        }*/
    }
    public class NhoNhanhCollection : System.Collections.CollectionBase
    {
        public void Add(NhoNhanhBO nhonhanh)
        {
            List.Add(nhonhanh);
        }
        public void Remove(int index)
        {
            List.RemoveAt(index);
        }
        public NhoNhanhBO Index(int index)
        {
            return (NhoNhanhBO)List[index];
        }
    }
}
