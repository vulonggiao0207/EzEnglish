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
    public partial class TaoTuDienMoi : Form
    {
        public TaoTuDienMoi(string _nguoidung)
        {
            InitializeComponent();
            idnguoidung = _nguoidung;
        }
        string idnguoidung = "";
        TuDienBUS tdBUS = new TuDienBUS();
        private void ThemTuDienButton_Click(object sender, EventArgs e)
        {
            if(TenTuDienTextBox.Text!="")
                tdBUS.ThemTuDien(idnguoidung, TenTuDienTextBox.Text, "");          
            Application.OpenForms["TaiKhoanCaNhan"].Activate();
        }

        private void TaoTuDienMoi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["TaiKhoanCaNhan"].Activate();
        }
    }
}
