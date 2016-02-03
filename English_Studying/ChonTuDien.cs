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
    public partial class ChonTuDien : Form
    {
        public int socauhoi;
        public IEnumerable<TuVung> tuvunglambantest = null;
        public int []_TuDien;
        string nguoidung;
        bool _loaitracnghiem = false;
        public ChonTuDien(string _nguoidung,bool LoaiTracNghiem)
        {
            InitializeComponent();
            nguoidung = _nguoidung;
            _loaitracnghiem = LoaiTracNghiem;
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

        private void SoCauHoiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }


        }
        bool cancel = true;
        private void DongYButton_Click_1(object sender, EventArgs e)
        {
            if (SoCauHoiTextBox.Text == "" || TuDienSuDungListBox.Items.Count == 0)
            {
                MessageBox.Show("Bạn hãy chọn từ điển và số câu hỏi làm bài");
                cancel = false;
                return;
            }

            socauhoi = int.Parse(SoCauHoiTextBox.Text.Trim());
            _TuDien = new int[TuDienSuDungListBox.Items.Count];
            for (int i = 0; i < TuDienSuDungListBox.Items.Count; i++)
            {
                _TuDien[i] = ((TuDien)TuDienSuDungListBox.Items[i]).IDTuDien;
            }
            tuvunglambantest = tracnghiemBUS.LoadDSTuVung(_TuDien);
            //nếu là trắc nghiệm hình ảnh
            if (_loaitracnghiem == false)
            {
                if (socauhoi > tracnghiemBUS.socauhoi_hinhanh)
                {
                    MessageBox.Show("Chỉ có khả năng tạo ra " + tracnghiemBUS.socauhoi_hinhanh + " câu hỏi hình ảnh\r\nBạn hãy chọn số câu hỏi khác");
                    SoCauHoiTextBox.Focus();
                    socauhoi = 0;
                    cancel = false;
                }
            }
            //nếu là trắc nghiệm áp dụng
            else
            {
                if (socauhoi > tracnghiemBUS.socauhoi_apdung)
                {
                    MessageBox.Show("Chỉ có khả năng tạo ra " + tracnghiemBUS.socauhoi_apdung + " câu hỏi áp dụng\r\nBạn hãy chọn số câu hỏi khác");
                    SoCauHoiTextBox.Focus();
                    socauhoi = 0;
                    cancel = false;
                }
            }
        }

        private void ChonTuDien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cancel != true)
                e.Cancel=true;
            cancel = true;
        }

      
       
    }
}
