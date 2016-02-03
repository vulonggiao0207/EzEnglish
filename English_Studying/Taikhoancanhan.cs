using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SpeechLib;
using System.IO;
using English_Studying.BUS;
using English_Studying.BO;

namespace English_Studying
{
    public partial class Taikhoancanhan : Form
    {

        string NguoiDung = "";
        TuDienBUS tudienBUS = new TuDienBUS();
        TuVungBUS tuvungBUS = new TuVungBUS();
        TracNghiemBUS tracnghiemBUS = new TracNghiemBUS();
        NhoNhanhBUS nhonhanhBUS = new NhoNhanhBUS();
        OChuBUS ochuBUS = new OChuBUS();
        CauHoiCollection BaiTest = null;
        //Dành cho trắc nghiệm
        IEnumerable<TuVung> tuvunglambantest = null;
        int socauhoilamban = 0;
        static int TracNghiem_Position = 0;
        //Dành cho nhớ nhanh và ô chữ
        NhoNhanhCollection tuvungtaodebai = null;
        //Dành cho ô chữ
        OChuCollection tuvungtaoochu = null;
        List<char> TuHangDoc = new List<char>();
        //Binding cho Thêm, Xóa, Sửa từ vựng
        CurrencyManager cm =null; 

        #region Form_Initialize
        bool active = true;
        private void Taikhoancanhan_Activated(object sender, EventArgs e)
        {
            if (active == false)
            {
                TuMuonTraTextBox.Text = "";
                ClearControls();
                TuVungTextBoxLoad();
                NghiaLabel.Text = "0/0";
                active = true;
            }
        }
        public Taikhoancanhan(string IDNguoiDung)
        {
            InitializeComponent();
            NguoiDung = IDNguoiDung;
        }
        private void Taikhoancanhan_Load(object sender, EventArgs e)
        {
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            TuVungButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Text = "Chào bạn " + NguoiDung;
            TuDienListBoxLoad();
            TuVungLoad();  
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.TabPages[tabControl1.SelectedIndex].Name == "TuVungTab")
            {
                TuMuonTraTextBox.Text = "";
                ClearControls();
                NghiaLabel.Text="0/0";
                TudangtraLable.Text = "";
      //          TuVungTextBoxLoad();
            }
            if (tabControl1.TabPages[tabControl1.SelectedIndex].Name == "TuDienTab")
            {
               
            }
            if (tabControl1.TabPages[tabControl1.SelectedIndex].Name == "TracNghiemHinhAnhTab")
            {
              
                tuvunglambantest = null;
                socauhoilamban = 0;
                TracNghiem_Position = 0;
                BatDau_HinhAnhButton.Text = "Bắt đầu";
                TraLoi_HinhAnhCheckList.Enabled = false;
                TraLoi_HinhAnhCheckList.Items.Clear();
                ChamDiem_HinhAnhButton.Enabled = false;
                ChonTuDien_HinhAnhButton.Enabled = true;
                HinhAnhPictureBox.Image = null;
                HinhSo_HinhAnhGroupbox.Text = "Hình số...";
                TongCauHoi_HinhAnhTextBox.Text = "/0";
                ThuTuCauHoi_HinhAnhTextBox.Text = "";
                ThuTuCauHoi_HinhAnhTextBox.Items.Clear();
              

            }
            if (tabControl1.TabPages[tabControl1.SelectedIndex].Name == "TracNghiemTab")
            {
                tuvunglambantest = null;
                socauhoilamban = 0;
                TracNghiem_Position = 0;
                BatDau_TracNghiemButton.Text = "Bắt đầu";
                TraLoi_TrachNghiemCheckList.Enabled = false;
                TraLoi_TrachNghiemCheckList.Items.Clear();
                ChamDiem_TracNghiemButton.Enabled = false;
                ChonTuDien_TracNghiemButton.Enabled = true;
                CauHoi_TracNghiemTextBox.Text = "";
                CauSo_TracNghiemGroupBox.Text = "Hình số...";
                TongCauHoi_TracNghiemTextBox.Text = "/0";
                ThuTuCauhoi_TracNghiemTextBox.Text = "";
                ThuTuCauhoi_TracNghiemTextBox.Items.Clear();
              
            }
            if (tabControl1.TabPages[tabControl1.SelectedIndex].Name == "LuyenNhoNhanhTab")
            {
                
            }
          
            if (tabControl1.TabPages[tabControl1.SelectedIndex].Name == "LuyenDanhMaytab")
            {
            }
            
        }
        #endregion
        #region Sidebar_Button       

        private void TuVungButton_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 0;
            TuVungButton.BackColor = System.Drawing.Color.LightSkyBlue;
            TuDienButton.BackColor = System.Drawing.Color.Transparent;
            TracNghiemHinhAnhButton.BackColor = System.Drawing.Color.Transparent;
            LuyenNhoNhanhButoon.BackColor = System.Drawing.Color.Transparent;
            TracNghiemButton.BackColor = System.Drawing.Color.Transparent;
            GiaiOChuButton.BackColor = System.Drawing.Color.Transparent;
        }

        private void TuDienButton_Click(object sender, EventArgs e)
        {
           
            this.tabControl1.SelectedIndex = 1;    
            TuVungButton.BackColor = System.Drawing.Color.Transparent;
            TuDienButton.BackColor = System.Drawing.Color.LightSkyBlue;
            TracNghiemButton.BackColor = System.Drawing.Color.Transparent;
            LuyenNhoNhanhButoon.BackColor = System.Drawing.Color.Transparent;
            TracNghiemHinhAnhButton.BackColor = System.Drawing.Color.Transparent;
            GiaiOChuButton.BackColor = System.Drawing.Color.Transparent;
          
        }

        private void TracNghiemHinhAnhButton_Click(object sender, EventArgs e)
        {          
            this.tabControl1.SelectedIndex = 2;
            TuVungButton.BackColor = System.Drawing.Color.Transparent;
            TuDienButton.BackColor = System.Drawing.Color.Transparent;
            TracNghiemHinhAnhButton.BackColor = System.Drawing.Color.LightSkyBlue;
            LuyenNhoNhanhButoon.BackColor = System.Drawing.Color.Transparent;
            TracNghiemButton.BackColor = System.Drawing.Color.Transparent;
            GiaiOChuButton.BackColor = System.Drawing.Color.Transparent;
         
            //reset lại
            
        }

        private void LuyenNhoNhanhButoon_Click(object sender, EventArgs e)
        {          
            this.tabControl1.SelectedIndex = 3;
            TuVungButton.BackColor = System.Drawing.Color.Transparent;
            TuDienButton.BackColor = System.Drawing.Color.Transparent;
            TracNghiemHinhAnhButton.BackColor = System.Drawing.Color.Transparent;
            LuyenNhoNhanhButoon.BackColor = System.Drawing.Color.LightSkyBlue;
            TracNghiemButton.BackColor = System.Drawing.Color.Transparent;
            GiaiOChuButton.BackColor = System.Drawing.Color.Transparent;

            //reload nhớ nhanh
            foreach(Control ct in DeBai_NhoNhanhLayout.Controls)
            {
                ct.BackgroundImage = (System.Drawing.Bitmap)(English_Studying.Properties.Resources.Dice_Question);
            }
            BatDau_NhoNhanhButton.Text = "Bắt đầu";
            ChonTuDien_NhoNhanhButton.Enabled = true;
            tuvungtaodebai = null;
            NhoNhanhGroupBox.Enabled = false;
           
        }

        private void TracNghiemButton_Click(object sender, EventArgs e)
        {
          
            this.tabControl1.SelectedIndex = 4;
            TuVungButton.BackColor = System.Drawing.Color.Transparent;
            TuDienButton.BackColor = System.Drawing.Color.Transparent;
            TracNghiemHinhAnhButton.BackColor = System.Drawing.Color.Transparent;
            LuyenNhoNhanhButoon.BackColor = System.Drawing.Color.Transparent;
            TracNghiemButton.BackColor = System.Drawing.Color.LightSkyBlue;
            GiaiOChuButton.BackColor = System.Drawing.Color.Transparent;
             
        }

        private void LuyenDanhMayNhanhButton_Click(object sender, EventArgs e)
        {
       /*     if (tabControl1.SelectedIndex != 5)
            {
                DialogResult dr = MessageBox.Show("Bạn hãy hòan tất công việc trứơc khi chọn chức năng khác, nếu không khi quay lại tòan bộ sẽ mất hết\r\nBạn có muốn chọn chức năng khác không", "Chú ý!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Cancel)
                    return;
            }*/
            this.tabControl1.SelectedIndex = 5;   
            TuVungButton.BackColor = System.Drawing.Color.Transparent;
            TuDienButton.BackColor = System.Drawing.Color.Transparent;
            TracNghiemHinhAnhButton.BackColor = System.Drawing.Color.Transparent;
            LuyenNhoNhanhButoon.BackColor = System.Drawing.Color.Transparent;
            TracNghiemButton.BackColor = System.Drawing.Color.Transparent;
            GiaiOChuButton.BackColor = System.Drawing.Color.LightSkyBlue;
            //reload
            tuvungtaoochu = null;
      //      TuHangDoc = null;
            tuvungtaoochu = null;
            ChonTuDien_OChuButton.Enabled = true;
            foreach (Control ct in OChuFowLayout.Controls)
            {
                ct.Text = "";
                ct.BackColor = Color.White;
            }
            OChuPanel.Enabled = false;
            BatDau_OChuButton.Text = "Bắt đầu";
            
        }

        private void QuayLaiButton_Click(object sender, EventArgs e)
        {
            Application.OpenForms["BatDau"].Visible = true;
            this.Close();
        } 
        #endregion
        #region TuDienTab
        private void TuDienListBoxLoad()
        {
         //   DanhSach_TuDienListBox.DataSource = null;
            DanhSach_TuDienListBox.DataSource = tudienBUS.LoadTuDien(NguoiDung);
            DanhSach_TuDienListBox.ValueMember = "IDTuDien";
            DanhSach_TuDienListBox.DisplayMember = "TenTuDien";
            
        }
        private void TuDienCmbLoad()
        {
            //Load TuDien
            SudungTudienCombobox.Items.Clear();
            foreach (TuDien td in tudienBUS.LoadTuDien(NguoiDung))
            {
                SudungTudienCombobox.Items.Add(td);
            }         
            SudungTudienCombobox.DisplayMember = "TenTuDien";
            SudungTudienCombobox.ValueMember = "IDTuDien";
        }       
        private void ThemTuDienButton_Click(object sender, EventArgs e)
        {
            TaoTuDienMoi ttdm = new TaoTuDienMoi(NguoiDung);
            if (ttdm.ShowDialog() == DialogResult.OK)
            {
                TuDienListBoxLoad();
                TuDienCmbLoad();
            }            
        }
        private void XoaTudienButton_Click(object sender, EventArgs e)
        {
            if (DanhSach_TuDienListBox.SelectedItems.Count!=0)
            {
                
                int idTuDien = Convert.ToInt32(DanhSach_TuDienListBox.SelectedValue);
                string DeletingTuDien=((TuDien)DanhSach_TuDienListBox.SelectedItem).TenTuDien;
                DialogResult dr= MessageBox.Show("Bạn có muốn xóa từ điển "+DeletingTuDien+" không?","Xóa",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                bool kq = false;
                if (dr == DialogResult.Yes)
                {
                    kq = tudienBUS.XoaTuDien(idTuDien);
                    if (kq != true)
                        MessageBox.Show("Lỗi! Không xóa đựơc");
                    else
                    {
                        TuDienListBoxLoad();
                        TuDienCmbLoad();
                        if (SudungTudienCombobox.Text == DeletingTuDien)
                            SudungTudienCombobox.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn hãy chọn từ điển để xoá");
            }
                
        }
      
        #endregion
        #region TuVungTab
        private void TuVungTextBoxLoad()
        {
            AutoCompleteStringCollection atstring = new AutoCompleteStringCollection();
            int IDtudien = 0;
            if (SudungTudienCombobox.Text != "" && SudungTudienCombobox.Text!="Tất cả")
                IDtudien=(int)((TuDien)SudungTudienCombobox.SelectedItem).IDTuDien;
            foreach (TuVung tv in tuvungBUS.LoadTuVung(IDtudien))
                atstring.Add(tv.Tu);
            TuMuonTraTextBox.AutoCompleteCustomSource=atstring ;
        }
        private void TuVungLoad()
        {
            //Load TuDien cho Su dung tu dien
            TuDienCmbLoad();
            //Load TuVung cho AutoComplete TextBox
         //   TuVungVungTextBoxLoad();                
        }
        public void ClearControls()
        {
            //Clear binding
            NghiaTuTextBox.DataBindings.Clear();
            LoaiTuComboBox.DataBindings.Clear();
            HinhAnhTextBox.DataBindings.Clear();
            ApDungTextBox.DataBindings.Clear();
            //clear text
         
            NghiaTuTextBox.Text = "";
            LoaiTuComboBox.SelectedIndex = 4;
            HinhAnhTextBox.Text = "";
            ApDungTextBox.Text = "";

        }
        IEnumerable<TuVung> tuvungsource = null;
        private void Tra_TuVungButton_Click(object sender, EventArgs e)
        {
            if (TuMuonTraTextBox.Text != "")
            {
                int IDtudien = 0;
                if (SudungTudienCombobox.Text != "" && SudungTudienCombobox.Text != "Tất cả")
                    IDtudien = (int)((TuDien)SudungTudienCombobox.SelectedItem).IDTuDien;
                tuvungsource = tuvungBUS.LoadTuVung(IDtudien, TuMuonTraTextBox.Text);
                //Clear
                ClearControls();

                //add Binding
                NghiaTuTextBox.DataBindings.Add("Text", tuvungsource, "NghiaTu");
                LoaiTuComboBox.DataBindings.Add("Text", tuvungsource, "LoaiTu");
                HinhAnhTextBox.DataBindings.Add("Text", tuvungsource, "HinhAnh");
                ApDungTextBox.DataBindings.Add("Text", tuvungsource, "ApDung");
                cm = (CurrencyManager)this.BindingContext[tuvungsource];
                //gán thứ tự câu hỏi
                NghiaLabel.Text = (cm.Position + 1).ToString()+"/" + cm.Count.ToString();
                TudangtraLable.Text = TuMuonTraTextBox.Text;
            }
        }
        private void ThemTuButton_Click(object sender, EventArgs e)
        {
            active = false;
            if (SudungTudienCombobox.Text == "")
                MessageBox.Show("Bạn hãy chọn từ điển muốn thêm từ vào");
            else if (SudungTudienCombobox.Text != "Tất cả")
            {
                int IDtudien = (int)((TuDien)SudungTudienCombobox.SelectedItem).IDTuDien;
                TaoMoiTuVung tmtv = new TaoMoiTuVung(IDtudien);
                this.Enabled = false;
              //  tmtv.Show();
                if (tmtv.ShowDialog() == DialogResult.Cancel)
                {
                    TuVungTextBoxLoad();
                    TudangtraLable.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Bạn không thể thêm từ vào 'Tất cả' các từ điển");
            }
        }
        OpenFileDialog Ofile = null;
        private void ChonHinhButton_Click(object sender, EventArgs e)
        {
            Ofile = new OpenFileDialog();
            if (Ofile.ShowDialog() == DialogResult.OK)
            {
                HinhAnhTextBox.Text = Ofile.FileName;
            }
        }
        private void XoaTuButton_Click(object sender, EventArgs e)
        {
            if (cm.Count != 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa nghĩa " + (cm.Position + 1).ToString() + " của từ " + tuvungsource.ElementAt<TuVung>(cm.Position).Tu + " không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    bool kq = tuvungBUS.XoaTuVung(tuvungsource.ElementAt<TuVung>(cm.Position).IDTuVung);
                    if (kq == true)
                    {
                        if (TudangtraLable.Text != "")
                        {
                            TuVungTextBoxLoad();
                            int IDtudien = 0;
                            if (SudungTudienCombobox.Text != "" && SudungTudienCombobox.Text != "Tất cả")
                                IDtudien = (int)((TuDien)SudungTudienCombobox.SelectedItem).IDTuDien;
                            tuvungsource = tuvungBUS.LoadTuVung(IDtudien, TudangtraLable.Text);
                            //clearBinding
                            ClearControls();
                            TuMuonTraTextBox.Text = "";

                            //add Binding
                            NghiaTuTextBox.DataBindings.Add("Text", tuvungsource, "NghiaTu");
                            LoaiTuComboBox.DataBindings.Add("Text", tuvungsource, "LoaiTu");
                            HinhAnhTextBox.DataBindings.Add("Text", tuvungsource, "HinhAnh");
                            ApDungTextBox.DataBindings.Add("Text", tuvungsource, "ApDung");
                            cm = (CurrencyManager)this.BindingContext[tuvungsource];
                            NghiaLabel.Text = (cm.Position + 1).ToString() + "/" + cm.Count.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi! Không thể xóa đựơc");
                    }
                }
            }
            if(cm.Count == 0)
            {
                TudangtraLable.Text = "";
           //     TuVungTextBoxLoad();
            }
        }
        private void LuuTuButton_Click(object sender, EventArgs e)
        {
            if (cm.Count != 0)
            {
                foreach (TuVung tv in tuvungsource)
                {
                    string HinhAnh = HinhAnhTextBox.Text;
                    if (HinhAnhTextBox.Text != "")
                    {
                        if(Ofile!=null)
                            HinhAnh = tuvungBUS.LuuAnh(HinhAnhTextBox.Text, System.IO.Path.GetFileName(Ofile.FileName));
                    }
                    bool kq = tuvungBUS.SuaTuVung(tv.IDTuVung, tv.Tu, tv.LoaiTu, tv.NghiaTu,HinhAnh, tv.ApDung);
                }
            }
        }

        private void NghiaSauButton_Click(object sender, EventArgs e)
        {
            if(cm.Position<cm.Count-1)
                cm.Position++;
            NghiaLabel.Text = (cm.Position + 1).ToString() + "/" + cm.Count.ToString();
        }
        private void NghiaTruocButton_Click(object sender, EventArgs e)
        {
            if(cm.Position>0)
                cm.Position--;
            NghiaLabel.Text = (cm.Position+1).ToString() + "/" + cm.Count.ToString();
        }
        private void SudungTudienCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TuVungTextBoxLoad();
            NghiaLabel.Text = "0/0";
            TuMuonTraTextBox.Text = "";
            NghiaTuTextBox.Text = "";
            HinhAnhTextBox.Text = "";
            ApDungTextBox.Text = "";
        }    
        private void Chinhsua_TuVungCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Chinhsua_TuVungCheckBox.Checked == true)
            {
                NghiaTuTextBox.Enabled = true;
                LoaiTuComboBox.Enabled = true;
                HinhAnhTextBox.Enabled = true;
                ApDungTextBox.Enabled = true;
                XoaTuButton.Enabled = true;
                LuuTuButton.Enabled = true;
                ChonHinhButton.Enabled = true;
            }
            else
            {
                NghiaTuTextBox.Enabled = false;
                LoaiTuComboBox.Enabled = false;
                HinhAnhTextBox.Enabled = false;
                ApDungTextBox.Enabled = false;
                XoaTuButton.Enabled = false;
                LuuTuButton.Enabled = false;
                ChonHinhButton.Enabled = false;
            }
        } 
        #endregion
        #region TracNghiem_HinhAnhTab
        void LoadCauTraLoi_HinhAnh()
        {
            TraLoi_HinhAnhCheckList.Items.Clear();
            for (int i = 0; i < 4; i++)
            {
                TraLoi_HinhAnhCheckList.Items.Add(BaiTest.Index(TracNghiem_Position).Choices[i].Tu);
            }

            if (BaiTest.Index(TracNghiem_Position).CauTraLoi != -1)
            {
                TraLoi_HinhAnhCheckList.SetItemChecked(BaiTest.Index(TracNghiem_Position).CauTraLoi, true);
            }
        }
        private void ChonTuDien_HinhAnhButton_Click(object sender, EventArgs e)
        {
            ChonTuDien ctd = new ChonTuDien(NguoiDung,false);
            if (ctd.ShowDialog() == DialogResult.OK)
            {
                socauhoilamban = ctd.socauhoi;
                int[] tudien = ctd._TuDien;
                tuvunglambantest = ctd.tuvunglambantest;
                TongCauHoi_HinhAnhTextBox.Text = "/" + socauhoilamban.ToString();               
                //Clear Control
                TracNghiem_Position = 0;
                ThuTuCauHoi_HinhAnhTextBox.Text = "";
                TongCauHoi_HinhAnhTextBox.Text = "/0";
                HinhAnhPictureBox.Image=null;
                TraLoi_HinhAnhCheckList.Items.Clear();
            }
        }

        private void CauTiep_HinhAnhButton_Click(object sender, EventArgs e)
        {
            if (TracNghiem_Position < socauhoilamban - 1 && HinhAnhPictureBox.Image != null)
            {
                TracNghiem_Position++;
                HinhSo_HinhAnhGroupbox.Text = "Hình ảnh số " + (TracNghiem_Position + 1).ToString();
          //      HinhAnhPictureBox.Load(BaiTest.Index(TracNghiem_Position).Choices[BaiTest.Index(TracNghiem_Position).CauTraLoiDung].HinhAnh);
                try
                {
                    HinhAnhPictureBox.Load(BaiTest.Index(TracNghiem_Position).Choices[BaiTest.Index(TracNghiem_Position).CauTraLoiDung].HinhAnh);
                }
                catch
                {
                    HinhAnhPictureBox.Image = ((System.Drawing.Bitmap)(English_Studying.Properties.Resources.error_pic));
                }
                LoadCauTraLoi_HinhAnh();
                ThuTuCauHoi_HinhAnhTextBox.Text = (TracNghiem_Position + 1).ToString();
            }
        }

        private void CauTruoc_HinhAnhButton_Click(object sender, EventArgs e)
        {
            if (TracNghiem_Position > 0)
            {               
                TracNghiem_Position--;
                HinhSo_HinhAnhGroupbox.Text = "Hình ảnh số " + (TracNghiem_Position + 1).ToString();
       //         HinhAnhPictureBox.Load(BaiTest.Index(TracNghiem_Position).Choices[BaiTest.Index(TracNghiem_Position).CauTraLoiDung].HinhAnh);
                try
                {
                    HinhAnhPictureBox.Load(BaiTest.Index(TracNghiem_Position).Choices[BaiTest.Index(TracNghiem_Position).CauTraLoiDung].HinhAnh);
                }
                catch
                {
                    HinhAnhPictureBox.Image = ((System.Drawing.Bitmap)(English_Studying.Properties.Resources.error_pic));
                }
                LoadCauTraLoi_HinhAnh();
                ThuTuCauHoi_HinhAnhTextBox.Text = (TracNghiem_Position + 1).ToString();
            }
        }

        private void ThuTuCauHoi_HinhAnhTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TracNghiem_Position = int.Parse(ThuTuCauHoi_HinhAnhTextBox.Text)-1;
            HinhSo_HinhAnhGroupbox.Text = "Hình ảnh số " + ThuTuCauHoi_HinhAnhTextBox.Text;
     //       HinhAnhPictureBox.Load();
     //       HinhAnhPictureBox.Load(BaiTest.Index(TracNghiem_Position).Choices[BaiTest.Index(TracNghiem_Position).CauTraLoiDung].HinhAnh);
            try
            {
                HinhAnhPictureBox.Load(BaiTest.Index(TracNghiem_Position).Choices[BaiTest.Index(TracNghiem_Position).CauTraLoiDung].HinhAnh);
            }
            catch
            {
                HinhAnhPictureBox.Image = ((System.Drawing.Bitmap)(English_Studying.Properties.Resources.error_pic));
            }
            LoadCauTraLoi_HinhAnh();
        }

        private void ChamDiem_HinhAnhButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < socauhoilamban; i++)
            {
                if (BaiTest.Index(i).CauTraLoi == BaiTest.Index(i).CauTraLoiDung)
                    count++;
            }
            MessageBox.Show("Bạn đã làm đúng "+count.ToString()+"/"+socauhoilamban.ToString()+" câu hỏi \n Bạn có thể xem lại bài làm của mình");
            //Show kết quả
            BangKetQua bkq = new BangKetQua(BaiTest,false);
            bkq.Show();
            //reload control
            BatDau_HinhAnhButton.Text = "Bắt đầu";   
            TraLoi_HinhAnhCheckList.Enabled = false;
            ChamDiem_HinhAnhButton.Enabled = false;
            ChonTuDien_HinhAnhButton.Enabled = true;
      
        }

        private void BatDau_HinhAnhButton_Click(object sender, EventArgs e)
        {
            if (BatDau_HinhAnhButton.Text == "Bắt đầu")
            {
                //Load bài Test               
                BaiTest = tracnghiemBUS.TaoBaiTest_HinhAnh(tuvunglambantest, socauhoilamban);               
                if (BaiTest.Count == 0)
                {
                    MessageBox.Show("Bạn hãy chọn từ điển để tạo bài test");
                    return;
                }
                //Thao tác cho các Control hiển thị
                TracNghiem_Position = 0;
                HinhSo_HinhAnhGroupbox.Text = "Hình ảnh số 1";
                TraLoi_HinhAnhCheckList.Enabled = true;
                ChamDiem_HinhAnhButton.Enabled = true;
                ChonTuDien_HinhAnhButton.Enabled = false;
                BatDau_HinhAnhButton.Text = "Kết thúc";
                ThuTuCauHoi_HinhAnhTextBox.Items.Clear();
                TongCauHoi_HinhAnhTextBox.Text = "/" + (socauhoilamban).ToString();
                for (int i = 0; i < socauhoilamban; i++)
                {
                    ThuTuCauHoi_HinhAnhTextBox.Items.Add((i + 1).ToString());
                }
                ThuTuCauHoi_HinhAnhTextBox.Text = "1";
                //Load bài Hình ảnh và câu trả lời
                try
                {
                    HinhAnhPictureBox.Load(BaiTest.Index(TracNghiem_Position).Choices[BaiTest.Index(TracNghiem_Position).CauTraLoiDung].HinhAnh);
                }
                catch
                {
                    HinhAnhPictureBox.Image=((System.Drawing.Bitmap)(English_Studying.Properties.Resources.error_pic));
                }
                LoadCauTraLoi_HinhAnh();
                if (Application.OpenForms["BangKetQua"]!=null)
                    Application.OpenForms["BangKetQua"].Close();               
            }
            else
            {
                BatDau_HinhAnhButton.Text = "Bắt đầu";              
                TraLoi_HinhAnhCheckList.Enabled = false;
                ChamDiem_HinhAnhButton.Enabled = false;
                ChonTuDien_HinhAnhButton.Enabled = true;
            }

        }

        private void TraLoi_HinhAnhCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (TraLoi_HinhAnhCheckList.GetItemCheckState(e.Index) == CheckState.Unchecked)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (TraLoi_HinhAnhCheckList.GetItemCheckState(i) == CheckState.Checked)
                        TraLoi_HinhAnhCheckList.SetItemCheckState(i, CheckState.Unchecked);
                    
                }
            }
          
        }
        private void TraLoi_HinhAnhCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int j = 0; j < 4; j++)
            {
                if (TraLoi_HinhAnhCheckList.GetItemCheckState(j) == CheckState.Checked)
                {
                    BaiTest.Index(TracNghiem_Position).CauTraLoi = j;
                    return;
                }
            }
            BaiTest.Index(TracNghiem_Position).CauTraLoi = -1;
        }
        #endregion
        #region TracNghiemTab
        void LoadCauTraLoi_TracNghiem()
        {
            TraLoi_TrachNghiemCheckList.Items.Clear();
            for (int i = 0; i < 4; i++)
            {
                TraLoi_TrachNghiemCheckList.Items.Add(BaiTest.Index(TracNghiem_Position).Choices[i].NghiaTu);
            }

            if (BaiTest.Index(TracNghiem_Position).CauTraLoi != -1)
            {
                TraLoi_TrachNghiemCheckList.SetItemChecked(BaiTest.Index(TracNghiem_Position).CauTraLoi, true);
            }
        }
        void LoadCauHoi_TracNghiem()
        {
            CauSo_TracNghiemGroupBox.Text = "Câu số " + (TracNghiem_Position + 1).ToString();
            CauHoi_TracNghiemTextBox.Text = BaiTest.Index(TracNghiem_Position).Choices[BaiTest.Index(TracNghiem_Position).CauTraLoiDung].ApDung;
            CauHoi_TracNghiemTextBox.Text += "\r\n\r\nWhat does '" + BaiTest.Index(TracNghiem_Position).Choices[BaiTest.Index(TracNghiem_Position).CauTraLoiDung].Tu + "' mean?";
               
        }
   
        private void ChonTuDien_TracNghiemButton_Click(object sender, EventArgs e)
        {
            ChonTuDien ctd = new ChonTuDien(NguoiDung,true);
            if (ctd.ShowDialog() == DialogResult.OK)
            {
                socauhoilamban = ctd.socauhoi;
                int[] tudien = ctd._TuDien;
                tuvunglambantest = ctd.tuvunglambantest;
                TongCauHoi_TracNghiemTextBox.Text = "/" + socauhoilamban.ToString();
                //Clear Control
                TracNghiem_Position = 0;
                ThuTuCauhoi_TracNghiemTextBox.Text = "";
                TongCauHoi_TracNghiemTextBox.Text = "/0";
                TraLoi_HinhAnhCheckList.Items.Clear();
            }
        }

        private void CauTiep_TracNghiemButton_Click(object sender, EventArgs e)
        {
            if (TracNghiem_Position < socauhoilamban - 1 && CauHoi_TracNghiemTextBox.Text!="")
            {
                TracNghiem_Position++;
                LoadCauHoi_TracNghiem();
                LoadCauTraLoi_TracNghiem();
                ThuTuCauhoi_TracNghiemTextBox.Text = (TracNghiem_Position+1).ToString();
            }
        }

        private void CauTruoc_TracNghiemButton_Click(object sender, EventArgs e)
        {
            if (TracNghiem_Position > 0)
            {
                TracNghiem_Position--;
                LoadCauHoi_TracNghiem();
                LoadCauTraLoi_TracNghiem();
                ThuTuCauhoi_TracNghiemTextBox.Text = (TracNghiem_Position+1).ToString();
            }
        }

        private void ThuTuCauhoi_TracNghiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            TracNghiem_Position = int.Parse(ThuTuCauhoi_TracNghiemTextBox.Text) - 1;
            LoadCauHoi_TracNghiem();
            LoadCauTraLoi_TracNghiem();
        }

        private void ChamDiem_TracNghiemButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < socauhoilamban; i++)
            {
                if (BaiTest.Index(i).CauTraLoi == BaiTest.Index(i).CauTraLoiDung)
                    count++;
            }
            MessageBox.Show("Bạn đã làm đúng " + count.ToString() + "/" + socauhoilamban.ToString() + " câu hỏi \n Bạn có thể xem lại bài làm của mình");
            //Show kết quả
            BangKetQua bkq = new BangKetQua(BaiTest, true);
            bkq.Show();
            //reload control
            BatDau_TracNghiemButton.Text = "Bắt đầu";
            TraLoi_TrachNghiemCheckList.Enabled = false;
            ChamDiem_TracNghiemButton.Enabled = false;
            ChonTuDien_TracNghiemButton.Enabled = true;            
        }

        private void BatDau_TracNghiemButton_Click(object sender, EventArgs e)
        {
            if (BatDau_TracNghiemButton.Text == "Bắt đầu")
            {
                //Load bài Test               
                BaiTest = tracnghiemBUS.TaoBaiTest_TracNghiem(tuvunglambantest, socauhoilamban);               
                if (BaiTest.Count == 0)
                {
                    MessageBox.Show("Bạn hãy chọn từ điển để tạo bài test");
                    return;
                }
                //Thao tác cho các Control hiển thị
                TracNghiem_Position = 0;
                CauSo_TracNghiemGroupBox.Text = "Hình ảnh số 1";
                TraLoi_TrachNghiemCheckList.Enabled = true;
                ChamDiem_TracNghiemButton.Enabled = true;
                ChonTuDien_TracNghiemButton.Enabled = false;
                BatDau_TracNghiemButton.Text = "Kết thúc";
                ThuTuCauhoi_TracNghiemTextBox.Items.Clear();
                TongCauHoi_TracNghiemTextBox.Text = "/" + (socauhoilamban).ToString();
                for (int i = 0; i < socauhoilamban; i++)
                {
                    ThuTuCauhoi_TracNghiemTextBox.Items.Add((i + 1).ToString());
                }
                ThuTuCauhoi_TracNghiemTextBox.Text = "1";
                //Load Cau hỏi và câu trả lời
           //     HinhAnhPictureBox.Load(BaiTest.Index(TracNghiem_Position).Choices[BaiTest.Index(TracNghiem_Position).CauTraLoiDung].HinhAnh);
                LoadCauHoi_TracNghiem();
                LoadCauTraLoi_TracNghiem();
                if (Application.OpenForms["BangKetQua"] != null)
                    Application.OpenForms["BangKetQua"].Close();
               
            }
            else
            {
                BatDau_TracNghiemButton.Text = "Bắt đầu";              
                TraLoi_HinhAnhCheckList.Enabled = false;
                ChamDiem_HinhAnhButton.Enabled = false;
                ChonTuDien_HinhAnhButton.Enabled = true;
            }
        }

        private void TraLoi_TrachNghiemCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
             for (int j = 0; j < 4; j++)
            {
                if (TraLoi_TrachNghiemCheckList.GetItemCheckState(j) == CheckState.Checked)
                {
                    BaiTest.Index(TracNghiem_Position).CauTraLoi = j;
                    return;
                }
            }
            BaiTest.Index(TracNghiem_Position).CauTraLoi = -1;
        }

        private void TraLoi_TrachNghiemCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (TraLoi_TrachNghiemCheckList.GetItemCheckState(e.Index) == CheckState.Unchecked)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (TraLoi_TrachNghiemCheckList.GetItemCheckState(i) == CheckState.Checked)
                        TraLoi_TrachNghiemCheckList.SetItemCheckState(i, CheckState.Unchecked);
                    
                }
            }
        }
        
        #endregion
        #region NhoNhanhTab
        static int cautruoc = -1;
        static int causau = -1;
        Button oChontruoc = null;
        Button oChonSau = null;
        static int demcaudung = 0;

        private void ChonTuDien_NhoNhanhButton_Click(object sender, EventArgs e)
        {
            ChonTuDien1 ctd = new ChonTuDien1(NguoiDung);
            if (ctd.ShowDialog() == DialogResult.OK)
            {
                int[] tudien = ctd._TuDien;
                tuvunglambantest = ctd.tuvunglambantest;
                //Clear Control
                foreach (Control ct in DeBai_NhoNhanhLayout.Controls)
                {
                    ct.Text = "";
                }
            }
        }
        private void BatDau_NhoNhanhButton_Click(object sender, EventArgs e)
        {  
            if (tuvunglambantest.ToList().Count < 10)
            {
                MessageBox.Show("Từ điển chỉ có "+tuvunglambantest.ToList().Count+" từ không đủ tạo ô chữ. Bạn hãy chọn thêm từ điển" );
                return;
            }
            if (BatDau_NhoNhanhButton.Text == "Bắt đầu")
            {
                if (tuvunglambantest == null)
                {
                    MessageBox.Show("Bạn hãy chọn từ điển để tạo các ô nhớ nhanh");
                    return;
                }
                //Load bài Các ô nhớ
                tuvungtaodebai = nhonhanhBUS.BaiTestNhoNhanh(tuvunglambantest);

                //Thao tác cho các Control hiển thị    
                NhoNhanhGroupBox.Enabled = true;
                ChonTuDien_NhoNhanhButton.Enabled = false;
                BatDau_NhoNhanhButton.Text = "Kết thúc";
                //     //Load Ô nhớ nhanh    
                foreach (Control ct in DeBai_NhoNhanhLayout.Controls)
                {
                    ct.BackgroundImage = (System.Drawing.Bitmap)(English_Studying.Properties.Resources.Dice_Question);
                    ct.Enabled = true;
                }

            }
            else
            {
                ReloadNhoNhanh();
            }
        }
        static int timeLeft = 2;
        private void HienThiONhoNhanh_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
            }
            else
            {
                HienThiONhoNhanhTimer.Enabled = false;
                for (int i = 0; i < 20; i++)
                {
                    DeBai_NhoNhanhLayout.Controls[i].Text = "";
                }
                timeLeft = 2;
            }

        }
        private void ChonONhoNhanh(Button b)
        {
            //Chỉ hiển thị ô đang chọn
            int stt = int.Parse(b.Name.Substring(1, 2)) - 1;
            for (int i = 0; i < 20; i++)
            {
                DeBai_NhoNhanhLayout.Controls[i].Text = "";
            }
            b.Text = tuvungtaodebai.Index(stt).NoiDungEng;
           

            //Kiểm tra nút ô lập lại
            if (oChontruoc == null)
                oChontruoc = b;
            else
                oChonSau = b;
            if (oChontruoc == oChonSau)
            {
                return;
            }
            else
            {
                oChonSau = oChontruoc;
            }

            //Kiểm tra ô chữ trùng khớp
            if (cautruoc == -1)
            {
                cautruoc = stt;
            }
            else
            {
                causau = stt;
                if (tuvungtaodebai.Index(cautruoc).STTEng == tuvungtaodebai.Index(causau).STTEng)
                {
                    DeBai_NhoNhanhLayout.Controls[cautruoc].BackgroundImage = null;
                    DeBai_NhoNhanhLayout.Controls[causau].BackgroundImage = null;
                    DeBai_NhoNhanhLayout.Controls[cautruoc].Enabled = false;
                    DeBai_NhoNhanhLayout.Controls[causau].Enabled = false;
                    DeBai_NhoNhanhLayout.Controls[cautruoc].Text = tuvungtaodebai.Index(cautruoc).NoiDungEng;
                    DeBai_NhoNhanhLayout.Controls[causau].Text = tuvungtaodebai.Index(causau).NoiDungEng;
                    HienThiONhoNhanhTimer.Enabled = true;
                    demcaudung++;
                }
                cautruoc = -1;
                causau = -1;
                oChontruoc = null;
                oChonSau = null;
            }
            if (demcaudung == 10)
            {
                ThanhCong tc = new ThanhCong();
                ReloadNhoNhanh();
                tc.ShowDialog();
            }

        }
        private void ReloadNhoNhanh()
        {
            foreach (Control ct in DeBai_NhoNhanhLayout.Controls)
            {
                ct.BackgroundImage = (System.Drawing.Bitmap)(English_Studying.Properties.Resources.Dice_Question);
            }
            NhoNhanhGroupBox.Enabled = false;
            ChonTuDien_NhoNhanhButton.Enabled = true;
            BatDau_NhoNhanhButton.Text = "Bắt đầu";
            demcaudung = 0;
        }
        private void O01Button_Click(object sender, EventArgs e)
        {
            ChonONhoNhanh(O01Button);       
        }
        private void O02Button_Click(object sender, EventArgs e)
        {
            ChonONhoNhanh(O02Button);
        }
        private void O03Button_Click(object sender, EventArgs e)
        {
            ChonONhoNhanh(O03Button);
        }
        private void O04Button_Click(object sender, EventArgs e)
        {
            ChonONhoNhanh(O04Button);
        }
        private void O05Button_Click(object sender, EventArgs e)
        {
            ChonONhoNhanh(O05Button);
        }
        private void O06Button_Click(object sender, EventArgs e)
        {
            ChonONhoNhanh(O06Button);
        }
        private void O07Button_Click(object sender, EventArgs e)
        {
            ChonONhoNhanh(O07Button);
        }
        private void O08Button_Click(object sender, EventArgs e)
        {
            ChonONhoNhanh(O08Button);
        }
        private void O09Button_Click(object sender, EventArgs e)
        {
            ChonONhoNhanh(O09Button);
        }
        private void O10Button_Click(object sender, EventArgs e)
        {
            ChonONhoNhanh(O10Button);
        }
        private void O11Button_Click(object sender, EventArgs e)
        {
            ChonONhoNhanh(O11Button);
        }
        private void O12Button_Click(object sender, EventArgs e)
        {
            ChonONhoNhanh(O12Button);
        }
        private void O13Button_Click(object sender, EventArgs e)
        {
            ChonONhoNhanh(O13Button);
        }
        private void O14Button_Click(object sender, EventArgs e)
        {
            ChonONhoNhanh(O14Button);
        }
        private void O15Button_Click(object sender, EventArgs e)
        {
            ChonONhoNhanh(O15Button);
        }
        private void O16Button_Click(object sender, EventArgs e)
        {
            ChonONhoNhanh(O16Button);
        }
        private void O17Button_Click(object sender, EventArgs e)
        {
            ChonONhoNhanh(O17Button);
        }
        private void O18Button_Click(object sender, EventArgs e)
        {
            ChonONhoNhanh(O18Button);
        }
        private void O19Button_Click(object sender, EventArgs e)
        {
            ChonONhoNhanh(O19Button);
        }
        private void O20Button_Click(object sender, EventArgs e)
        {
            ChonONhoNhanh(O20Button);
        } 
        #endregion
        #region OChuTab
        private string TaoStringTuList(List<char> temp)
        {
            StringBuilder builder = new StringBuilder();
            foreach (char ch in temp)
            {
                builder.Append(ch);
            }
            return builder.ToString();
        }
        private static int STT = -1;
        private void LoadGoiY(int STT)
        {
            if (STT < tuvungtaoochu.Count)
            {
                string GoiY = tuvungtaoochu.Index(STT).NghiaTu;
                GoiY_OChuTextBox.Text = GoiY;
                GoiY_OChuGroupBox.Text = "Gợi ý hàng ngang số " + (STT + 1);
            }
        }
        private void ToMauOChu(int vitri, List<char> TuDienVao, char KyTudoc)
        {
            foreach (OChuBO oc in tuvungtaoochu)
            {
                int vitriODoc = ViTriOChuDoc(oc.STT);
                int mid = TuDienVao.IndexOf(KyTudoc);
                if (oc.STT == vitri)
                {
                    //điền từ hàng dọc qua trái
                    int batdautrai = vitriODoc;
                    int i = mid;
                    while (i >= 0)
                    {
                        OChuFowLayout.Controls["textBox" + batdautrai].BackColor = Color.GreenYellow;
                        batdautrai--;
                        i--;
                    }
                    //điền từ hàng dọc qua phải
                    int batdauphai = vitriODoc + 1;
                    int j = mid + 1;
                    while (j < TuDienVao.Count)
                    {
                        OChuFowLayout.Controls["textBox" + batdauphai].BackColor = Color.GreenYellow;
                        batdauphai++;
                        j++;
                    }
                }
            }
            for (int k = 0; k < TuHangDoc.Count; k++)
            {
                OChuFowLayout.Controls["textBox" + ViTriOChuDoc(k)].BackColor = Color.Yellow;
            }
        }
        private int ViTriOChuDoc(int i)
        {
            if (i == 0)
                return 8 + 1;
            return 8 + (17 * i) + 1;

        }
        private void DienVaoOChu(int vitri, List<char> TuDienVao, char KyTudoc)
        {
            foreach (OChuBO oc in tuvungtaoochu)
            {
                int vitriODoc = ViTriOChuDoc(oc.STT);
                int mid = TuDienVao.IndexOf(KyTudoc);
                if (oc.STT == vitri)
                {
                    //điền từ hàng dọc qua trái
                    int batdautrai = vitriODoc;
                    int i = mid;
                    while (i >= 0)
                    {
                        OChuFowLayout.Controls["textBox" + batdautrai].Text = TuDienVao[i].ToString();
                        batdautrai--;
                        i--;
                    }
                    //điền từ hàng dọc qua phải
                    int batdauphai = vitriODoc + 1;
                    int j = mid + 1;
                    while (j < TuDienVao.Count)
                    {
                        OChuFowLayout.Controls["textBox" + batdauphai].Text = TuDienVao[j].ToString();
                        batdauphai++;
                        j++;
                    }

                }
            }

        }
/// <summary>
/// ////////////////////////////////Xử lý ô chữ////////////////////////////////////*
/// </summary>

        private void ChonTuDien_OChuButton_Click(object sender, EventArgs e)
        {
            ChonTuDien1 ctd = new ChonTuDien1(NguoiDung);
            if (ctd.ShowDialog() == DialogResult.OK)
            {
                int[] tudien = ctd._TuDien;
                tuvunglambantest = ctd.tuvunglambantest;
            }
        }
        private void BatDau_OChuButton_Click(object sender, EventArgs e)
        {
            if (BatDau_OChuButton.Text == "Bắt đầu")
            {
                if (tuvunglambantest == null)
                {
                    MessageBox.Show("Bạn hãy chọn từ điển để tạo các ô nhớ nhanh");
                    return;
                }
                tuvungtaoochu = ochuBUS.TaoOChu(tuvunglambantest, ref TuHangDoc);


                if (tuvungtaoochu == null)
                {
                    OChuPanel.Enabled = false;
                    MessageBox.Show("Không đủ từ vựng để tạo ra từ hàng dọc ngẫu nhiên '" + TaoStringTuList(TuHangDoc) + "'\r\nBạn hãy nhập thêm nhiều từ vựng để có thể tạo nhiều ô chữ\r\nBấm 'bắt đầu' để tạo ô chữ mới");
                    return;
                }
                DemCauDung = 0;
                OChuCollection ochucoll = new OChuCollection();
                //Load control
                GoiY_OChuTextBox.Text = "";
                TraLoi_OChuTextBox.Text = "";
                foreach (Control cl in OChuFowLayout.Controls)
                {
                    cl.Text = "";
                    cl.BackColor = Color.White;
                }

                OChuPanel.Enabled = true;
                ChonTuDien_OChuButton.Enabled = false;

                for (int i = 0; i < TuHangDoc.Count; i++)
                    ToMauOChu(i, tuvungtaoochu.Index(i).Tu, TuHangDoc[i]);
                BatDau_OChuButton.Text = "Kết thúc";
            }
            else
            {
                ChonTuDien_OChuButton.Enabled = true;
                for (int i = 0; i < TuHangDoc.Count; i++)
                {
                    DienVaoOChu(i, tuvungtaoochu.Index(i).Tu, TuHangDoc[i]);
                }
                OChuPanel.Enabled = false;
                BatDau_OChuButton.Text = "Bắt đầu";
            }


        }

        private void OChuDong1_Click(object sender, EventArgs e)
        {
            STT = 0;
            LoadGoiY(STT);
        }

        private void OChuDong2_Click(object sender, EventArgs e)
        {
            STT = 1;
            LoadGoiY(STT);
        }

        private void OChuDong3_Click(object sender, EventArgs e)
        {
            STT = 2;
            LoadGoiY(STT);
        }

        private void OChuDong4_Click(object sender, EventArgs e)
        {
            STT = 3;
            LoadGoiY(STT);
        }

        private void OChuDong5_Click(object sender, EventArgs e)
        {
            STT = 4;
            LoadGoiY(STT);
        }

        private void OChuDong6_Click(object sender, EventArgs e)
        {
            STT = 5;
            LoadGoiY(STT);
        }

        private void OChuDong7_Click(object sender, EventArgs e)
        {
            STT = 6;
            LoadGoiY(STT);
        }

        private void OChuDong8_Click(object sender, EventArgs e)
        {
            STT = 7;
            LoadGoiY(STT);
        }

        private void OChuDong9_Click(object sender, EventArgs e)
        {
            STT = 8;
            LoadGoiY(STT);
        }

        private void OChuDong10_Click(object sender, EventArgs e)
        {
            STT = 9;
            LoadGoiY(STT);
        }
        private int DemCauDung = 0;
        private void DienVaoOTrong_OChuButton_Click(object sender, EventArgs e)
        {
            if (STT != -1 && STT < TuHangDoc.ToList().Count)
            {
                string result = TaoStringTuList(tuvungtaoochu.Index(STT).Tu);
                if (TraLoi_OChuTextBox.Text == result)
                {
                    DienVaoOChu(STT, tuvungtaoochu.Index(STT).Tu, TuHangDoc[STT]);
                    TraLoi_OChuTextBox.Text = "";
                    DemCauDung++;
                }         
            }
            if (DemCauDung == tuvungtaoochu.Count)
            {
                ThanhCong tc = new ThanhCong();
                tc.ShowDialog();
                DemCauDung = 0;
                //Load control
                GoiY_OChuTextBox.Text = "";
                TraLoi_OChuTextBox.Text = "";
                foreach (Control cl in OChuFowLayout.Controls)
                {
                    cl.Text = "";
                    cl.BackColor = Color.White;
                }
                BatDau_OChuButton.Text = "Bắt đầu";
                ChonTuDien_OChuButton.Enabled = true;
            }
        } 
        #endregion

        // Creates a new instance of SpVoice   
        SpVoice voice = new SpVoice();
        // Tells the program to speak everything in the textbox using Default settings   
        private void SpeechButton_Click(object sender, EventArgs e)
        {
            int Volume;
            int Rate;
            Volume = 100;
            Rate = 0;
            voice.Rate = Rate;
            voice.Volume = Volume;
            voice.Speak(TudangtraLable.Text, SpeechVoiceSpeakFlags.SVSFDefault);  
        }


    }
}
