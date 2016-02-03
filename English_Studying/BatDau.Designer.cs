namespace English_Studying
{
    partial class BatDau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BatDauButton = new System.Windows.Forms.Button();
            this.TaoTaiKhoanMoiButton = new System.Windows.Forms.Button();
            this.XoaTaiKhoanButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.QuayLaiButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DsNguoidungListbox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BatDauButton
            // 
            this.BatDauButton.Location = new System.Drawing.Point(331, 74);
            this.BatDauButton.Name = "BatDauButton";
            this.BatDauButton.Size = new System.Drawing.Size(135, 60);
            this.BatDauButton.TabIndex = 1;
            this.BatDauButton.Text = "Bắt đầu học";
            this.BatDauButton.UseVisualStyleBackColor = true;
            this.BatDauButton.Click += new System.EventHandler(this.BatDauButton_Click);
            // 
            // TaoTaiKhoanMoiButton
            // 
            this.TaoTaiKhoanMoiButton.Location = new System.Drawing.Point(331, 164);
            this.TaoTaiKhoanMoiButton.Name = "TaoTaiKhoanMoiButton";
            this.TaoTaiKhoanMoiButton.Size = new System.Drawing.Size(135, 60);
            this.TaoTaiKhoanMoiButton.TabIndex = 1;
            this.TaoTaiKhoanMoiButton.Text = "Tạo tài khoản mới";
            this.TaoTaiKhoanMoiButton.UseVisualStyleBackColor = true;
            this.TaoTaiKhoanMoiButton.Click += new System.EventHandler(this.TaoTaiKhoanMoiButton_Click);
            // 
            // XoaTaiKhoanButton
            // 
            this.XoaTaiKhoanButton.Location = new System.Drawing.Point(331, 252);
            this.XoaTaiKhoanButton.Name = "XoaTaiKhoanButton";
            this.XoaTaiKhoanButton.Size = new System.Drawing.Size(135, 60);
            this.XoaTaiKhoanButton.TabIndex = 1;
            this.XoaTaiKhoanButton.Text = "Xoá tài khoản";
            this.XoaTaiKhoanButton.UseVisualStyleBackColor = true;
            this.XoaTaiKhoanButton.Click += new System.EventHandler(this.XoaTaiKhoanButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::English_Studying.Properties.Resources.User_Scroll;
            this.pictureBox1.Location = new System.Drawing.Point(468, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 389);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // QuayLaiButton
            // 
            this.QuayLaiButton.BackgroundImage = global::English_Studying.Properties.Resources.Return;
            this.QuayLaiButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QuayLaiButton.Location = new System.Drawing.Point(9, 8);
            this.QuayLaiButton.Name = "QuayLaiButton";
            this.QuayLaiButton.Size = new System.Drawing.Size(90, 40);
            this.QuayLaiButton.TabIndex = 3;
            this.QuayLaiButton.Text = "Quay lại";
            this.QuayLaiButton.UseVisualStyleBackColor = false;
            this.QuayLaiButton.Click += new System.EventHandler(this.QuayLaiButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::English_Studying.Properties.Resources.BatDau_Pic;
            this.pictureBox2.Location = new System.Drawing.Point(12, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(290, 335);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // DsNguoidungListbox
            // 
            this.DsNguoidungListbox.FormattingEnabled = true;
            this.DsNguoidungListbox.ItemHeight = 20;
            this.DsNguoidungListbox.Location = new System.Drawing.Point(523, 43);
            this.DsNguoidungListbox.Name = "DsNguoidungListbox";
            this.DsNguoidungListbox.Size = new System.Drawing.Size(223, 264);
            this.DsNguoidungListbox.TabIndex = 5;
            // 
            // BatDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::English_Studying.Properties.Resources.Blue_BackGround;
            this.ClientSize = new System.Drawing.Size(794, 396);
            this.ControlBox = false;
            this.Controls.Add(this.DsNguoidungListbox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.QuayLaiButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.XoaTaiKhoanButton);
            this.Controls.Add(this.TaoTaiKhoanMoiButton);
            this.Controls.Add(this.BatDauButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "BatDau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn tài khoản";
            this.Load += new System.EventHandler(this.BatDau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BatDauButton;
        private System.Windows.Forms.Button TaoTaiKhoanMoiButton;
        private System.Windows.Forms.Button XoaTaiKhoanButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button QuayLaiButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox DsNguoidungListbox;

    }
}