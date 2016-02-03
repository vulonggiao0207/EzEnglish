using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace English_Studying.BO
{
    public class OChuBO
    {
        int stt;
        List<char> tu;
        string nghiatu;
        public OChuBO()
        {
            stt = -1;
            tu = null;
            nghiatu = "";
        }
        public int STT
        {
            get { return stt;}
            set { stt=value;}
        }
        public List<char> Tu
        {
            get { return tu; }
            set { tu = value; }
        }
        public string NghiaTu
        {
            get { return nghiatu; }
            set { nghiatu = value; }
        }
    }
    public class OChuCollection : System.Collections.CollectionBase
    {
        public void Add(OChuBO ochuBO)
        {
            List.Add(ochuBO);
        }
        public void Remove(int index)
        {
            List.RemoveAt(index);
        }
        public OChuBO Index(int index)
        {
            return (OChuBO)List[index];
        }
    }
  
 

}
