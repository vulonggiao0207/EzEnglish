using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace English_Studying
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ThoatButton_Click(object sender, EventArgs e)
        {
            this.Close();       
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát không", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dl == DialogResult.Yes)
            {
                e.Cancel = false;
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void BatDauButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;            
            BatDau bdForm = new BatDau();
            bdForm.Show();
        }

        private void HuongDanButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HuongDan hdForm = new HuongDan();
            hdForm.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //try
            //{
            //        SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["EnglishConnectionString"].ToString());
            //        SqlCommand cmd= new SqlCommand("select * from nguoidung",cnn);
            //        cnn.Open();
            //        SqlDataReader dr = cmd.ExecuteReader();
            //        while(dr.Read())
            //        {
            //            string ten = dr["IDnguoidung"].ToString();
            //            MessageBox.Show(ten);
            //        }
            //        cnn.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
           
        }
    }
}
