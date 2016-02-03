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
    public partial class TaoMoiTuVung : Form
    {
        int IDtudien = 0;
        public TaoMoiTuVung(int _idtudien)
        {
            InitializeComponent();
            IDtudien = _idtudien;
        }
        TuVungBUS tvBUS = new TuVungBUS();
        private void ThoatTuVungButton_Click(object sender, EventArgs e)
        {
            Application.OpenForms["TaiKhoanCaNhan"].Enabled = true;
      //      Application.OpenForms["TaiKhoanCaNhan"].Activate();
            //Clear
            Taikhoancanhan tkcn =(Taikhoancanhan) Application.OpenForms["TaiKhoanCaNhan"];
            tkcn.ClearControls();        
            this.Close();
        }
        OpenFileDialog Ofile = null;
        private void ThemTuVungButton_Click(object sender, EventArgs e)
        {
            int IDTuDien = IDtudien;
            string Tu = TuTextBox.Text;
            string LoaiTu = LoaiTuCmb.SelectedItem.ToString();
            string NghiaTu = NghiaTuTextBox.Text;
            //sử lý lưu hình

            string HinhAnh = "";
            if (HinhAnhTextBox.Text != "")
            {
                HinhAnh=tvBUS.LuuAnh(HinhAnhTextBox.Text, System.IO.Path.GetFileName(Ofile.FileName));        
            }
            //lưu các thông tin khác
            string ApDung = ApDungTextBox.Text;
            bool kq= tvBUS.ThemTuVung(IDTuDien, Tu, LoaiTu, NghiaTu, HinhAnh, ApDung);
            if (kq != true)
            {
                MessageBox.Show("Lỗi! Không thêm đựơc");
            }
            else
            {
                MessageBox.Show("Bạn vừa thêm vào từ "+Tu);  //     System.IO.File.Copy(Ofile.FileName, "~\\Pictures\\"+System.IO.Path.GetFileName(Ofile.FileName));
                TuTextBox.Text="";
                LoaiTuCmb.SelectedIndex=0;
                NghiaTuTextBox.Text="";
                HinhAnhTextBox.Text="";
                ApDungTextBox.Text="";

            }

        }

        private void ChonHinhButton_Click(object sender, EventArgs e)
        {
            Ofile = new OpenFileDialog();
            if (Ofile.ShowDialog() == DialogResult.OK)
            {
                HinhAnhTextBox.Text = Ofile.FileName;
            }
        }
    }
}
