using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace English_Studying
{
    public partial class TaoTaiKhoanMoi : Form
    {
        public TaoTaiKhoanMoi()
        {
            InitializeComponent();
        }
        public string taikhoan;
        private void TaoTaiKhoanMoi_Load(object sender, EventArgs e)
        {

        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
              string taikhoanmoi = TenTaiKhoanTextBox.Text;
              if (taikhoanmoi.Trim() != "")
              {
                  EnglishLinqDataContext db = new EnglishLinqDataContext();
                  NguoiDung nd = new NguoiDung();
                  nd.IDNguoiDung = taikhoanmoi;
                  db.NguoiDungs.InsertOnSubmit(nd);
                  db.SubmitChanges();
              }
        }
    }
}
