using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using English_Studying.BUS;
namespace English_Studying
{
    public partial class ChonTuDien1 : Form
    {
        public IEnumerable<TuVung> tuvunglambantest = null;
        public int []_TuDien;
        string nguoidung;
        public ChonTuDien1(string _nguoidung)
        {
            InitializeComponent();
            nguoidung = _nguoidung;
        }
        TuDienBUS tdBUS = new TuDienBUS();
        TracNghiemBUS tracnghiemBUS = new TracNghiemBUS();
        private void ChonTuDien_Load(object sender, EventArgs e)
        {
            foreach (TuDien td in tdBUS.LoadTuDien(nguoidung))
            {
                TuDienCaNhanListbox.Items.Add(td);                
            }
            TuDienCaNhanListbox.ValueMember = "IDTuDien";
            TuDienCaNhanListbox.DisplayMember = "TenTuDien";
        }


        private void ThoatButton_Click(object sender, EventArgs e)
        {

        }
     

        private void ThemButton_Click(object sender, EventArgs e)
        {
            if (TuDienCaNhanListbox.SelectedItems.Count != 0)
            {
                object tudien = TuDienCaNhanListbox.SelectedItem;
                TuDienCaNhanListbox.Items.Remove(tudien);
                TuDienSuDungListBox.Items.Add(tudien);
                if (TuDienSuDungListBox.Items.Count != 0)
                {
                    TuDienSuDungListBox.ValueMember = "IDTudien";
                    TuDienSuDungListBox.DisplayMember = "TenTuDien";
                }
            }
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            if (TuDienSuDungListBox.SelectedItems.Count != 0)
            {
                object tudien = TuDienSuDungListBox.SelectedItem;
                TuDienSuDungListBox.Items.Remove(tudien);
                TuDienCaNhanListbox.Items.Add(tudien);
                if (TuDienSuDungListBox.Items.Count != 0)
                {
                    TuDienSuDungListBox.ValueMember = "IDTudien";
                    TuDienSuDungListBox.DisplayMember = "TenTuDien";
                }
            }
            
        }

     
        bool cancel = true;
        private void DongYButton_Click_1(object sender, EventArgs e)
        {
            if (TuDienSuDungListBox.Items.Count == 0)
            {
                MessageBox.Show("Bạn hãy chọn từ điển để tạo bài");
                cancel = false;
                return;
            }
            _TuDien = new int[TuDienSuDungListBox.Items.Count];
            for (int i = 0; i < TuDienSuDungListBox.Items.Count; i++)
            {
                _TuDien[i] = ((TuDien)TuDienSuDungListBox.Items[i]).IDTuDien;
            }
            tuvunglambantest = tracnghiemBUS.LoadDSTuVung(_TuDien);           
        }

        private void ChonTuDien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cancel != true)
                e.Cancel=true;
            cancel = true;
        }

      
       
    }
}
