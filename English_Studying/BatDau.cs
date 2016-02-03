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
    public partial class BatDau : Form
    {
        public BatDau()
        {
            InitializeComponent();           
        }

        private void QuayLaiButton_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Home"].Visible = true;            
            this.Close();
        }

        private void BatDauButton_Click(object sender, EventArgs e)
        {
            if (DsNguoidungListbox.SelectedItems.Count > 0)
            {
                Taikhoancanhan tkcn = new Taikhoancanhan(DsNguoidungListbox.SelectedValue.ToString());
                tkcn.Show();
                this.Visible = false;
            }
        }
        private void BatDau_Load(object sender, EventArgs e)
        {
            EnglishLinqDataContext db = new EnglishLinqDataContext();
            var query = from p in db.NguoiDungs
                        select p;
            DsNguoidungListbox.DisplayMember = "IDNguoiDung";
            DsNguoidungListbox.ValueMember = "IDNguoiDung";
            DsNguoidungListbox.DataSource = query;
       
        }

        private void TaoTaiKhoanMoiButton_Click(object sender, EventArgs e)
        {
            EnglishLinqDataContext db = new EnglishLinqDataContext();
            TaoTaiKhoanMoi ttkm = new TaoTaiKhoanMoi();
            if (ttkm.ShowDialog() == DialogResult.OK)
            {               
                //reload
                var query = from p in db.NguoiDungs
                            select p;
                DsNguoidungListbox.DisplayMember = "IDNguoiDung";
                DsNguoidungListbox.ValueMember = "IDNguoiDung"; 
                DsNguoidungListbox.DataSource = query;              
            }
            db.SubmitChanges();
        }

        private void XoaTaiKhoanButton_Click(object sender, EventArgs e)
        {
            if (DsNguoidungListbox.SelectedItems.Count != 0)
            {               
                string selecttodl= DsNguoidungListbox.SelectedValue.ToString();
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa tài khỏan '" + selecttodl + "' không? \r\nTòan bộ từ điển và từ vựng trong tài khỏan sẽ bị xóa theo\r\nBạn cân nhắc kỹ trứơc khi xóa ", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    EnglishLinqDataContext db = new EnglishLinqDataContext();
                    var delNguoiDung = from p in db.NguoiDungs
                                       where p.IDNguoiDung.Contains(selecttodl)
                                       select p;

                    foreach (NguoiDung nd in delNguoiDung)
                        db.NguoiDungs.DeleteOnSubmit(nd);

                    db.SubmitChanges();

                    //reload
                    var query = from p1 in db.NguoiDungs
                                select p1;
                    DsNguoidungListbox.DisplayMember = "IDNguoiDung";
                    DsNguoidungListbox.ValueMember = "IDNguoiDung";
                    DsNguoidungListbox.DataSource = query;
                }
            }
          
        }
    }
}
