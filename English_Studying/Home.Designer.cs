namespace English_Studying
{
    partial class Home
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
            this.HuongDanButton = new System.Windows.Forms.Button();
            this.ThoatButton = new System.Windows.Forms.Button();
            this.BatDauButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HuongDanButton
            // 
            this.HuongDanButton.BackColor = System.Drawing.Color.Transparent;
            this.HuongDanButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HuongDanButton.Location = new System.Drawing.Point(278, 203);
            this.HuongDanButton.Margin = new System.Windows.Forms.Padding(5);
            this.HuongDanButton.Name = "HuongDanButton";
            this.HuongDanButton.Size = new System.Drawing.Size(500, 80);
            this.HuongDanButton.TabIndex = 2;
            this.HuongDanButton.Text = "Hướng dẫn";
            this.HuongDanButton.UseVisualStyleBackColor = false;
            this.HuongDanButton.Click += new System.EventHandler(this.HuongDanButton_Click);
            // 
            // ThoatButton
            // 
            this.ThoatButton.BackColor = System.Drawing.Color.Transparent;
            this.ThoatButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ThoatButton.Location = new System.Drawing.Point(278, 294);
            this.ThoatButton.Margin = new System.Windows.Forms.Padding(5);
            this.ThoatButton.Name = "ThoatButton";
            this.ThoatButton.Size = new System.Drawing.Size(500, 80);
            this.ThoatButton.TabIndex = 3;
            this.ThoatButton.Text = "Thoát";
            this.ThoatButton.UseVisualStyleBackColor = false;
            this.ThoatButton.Click += new System.EventHandler(this.ThoatButton_Click);
            // 
            // BatDauButton
            // 
            this.BatDauButton.BackColor = System.Drawing.Color.Transparent;
            this.BatDauButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BatDauButton.Location = new System.Drawing.Point(278, 113);
            this.BatDauButton.Margin = new System.Windows.Forms.Padding(5);
            this.BatDauButton.Name = "BatDauButton";
            this.BatDauButton.Size = new System.Drawing.Size(500, 80);
            this.BatDauButton.TabIndex = 4;
            this.BatDauButton.Text = "Bắt đầu";
            this.BatDauButton.UseVisualStyleBackColor = false;
            this.BatDauButton.Click += new System.EventHandler(this.BatDauButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::English_Studying.Properties.Resources.Banner1;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(266, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(512, 75);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::English_Studying.Properties.Resources.Banner;
            this.pictureBox1.Location = new System.Drawing.Point(6, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 350);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::English_Studying.Properties.Resources.Blue_BackGround;
            this.ClientSize = new System.Drawing.Size(790, 392);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BatDauButton);
            this.Controls.Add(this.ThoatButton);
            this.Controls.Add(this.HuongDanButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcom to EzEng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HuongDanButton;
        private System.Windows.Forms.Button ThoatButton;
        private System.Windows.Forms.Button BatDauButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

