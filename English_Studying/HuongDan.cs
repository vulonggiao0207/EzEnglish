﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace English_Studying
{
    public partial class HuongDan : Form
    {
        public HuongDan()
        {
            InitializeComponent();
        }

        private void QuayLaiButton_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Home"].Visible = true;
            this.Close();
        }
    }
}
