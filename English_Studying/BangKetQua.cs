using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using English_Studying.DAO;
using English_Studying.BO;
namespace English_Studying
{
    public partial class BangKetQua : Form
    {
        CauHoiCollection chColl = new CauHoiCollection();
        bool _hienthi = false;
        public BangKetQua(CauHoiCollection coll,bool hienthi)
        {
            InitializeComponent();
            chColl = coll;
            _hienthi = hienthi;
        }
        private void BangKetQua_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("CauTraLoi");
            dt.Columns.Add("CauTraLoiDung");         
            for (int i = 0; i < chColl.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = i + 1;
                if (_hienthi == false)
                {
                    if (chColl.Index(i).CauTraLoi != -1)
                    {
                        dr[1] = chColl.Index(i).Choices[chColl.Index(i).CauTraLoi].Tu;
                    }
                    else
                    {
                        dr[1] = "no answer";
                    }
                    if (chColl.Index(i).CauTraLoiDung != -1)
                    {
                        dr[2] = chColl.Index(i).Choices[chColl.Index(i).CauTraLoiDung].Tu;
                    }
                    else
                    {
                        dr[2] = "no answer";
                    }
                }
                else
                {
                    if (chColl.Index(i).CauTraLoi != -1)
                    {
                        dr[1] = chColl.Index(i).Choices[chColl.Index(i).CauTraLoi].NghiaTu;
                    }
                    else
                    {
                        dr[1] = "chưa trả lời";
                    }
                    if (chColl.Index(i).CauTraLoiDung != -1)
                    {
                        dr[2] = chColl.Index(i).Choices[chColl.Index(i).CauTraLoiDung].NghiaTu;
                    }
                    else
                    {
                        dr[2] = "chưa trả lời";
                    }
                }            
                dt.Rows.Add(dr);
            }
            KetQuaGridView.DataSource = dt;
            for (int j = 0; j < KetQuaGridView.Rows.Count;j++ )
            {
                if (KetQuaGridView.Rows[j].Cells[1].Value.ToString() == KetQuaGridView.Rows[j].Cells[2].Value.ToString())
                    KetQuaGridView.Rows[j].DefaultCellStyle.BackColor = Color.Yellow;
                else
                    KetQuaGridView.Rows[j].DefaultCellStyle.BackColor = Color.Green;

            }

            try { }
            catch (Exception ex)
            { 
                //Log file
                //ex.
                //Messafe("asdfasdfadfasdfa")

            }
        }
      
        private void DongButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn hãy xem kỹ kết quả trứơc khi thóat. Hệ thống sẽ tự động tạo lại bài kiểm tra mới","Thóat", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
                this.Close();
        }
    }
}
