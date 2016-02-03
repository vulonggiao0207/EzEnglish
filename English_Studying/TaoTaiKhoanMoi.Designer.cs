namespace English_Studying
{
    partial class TaoTaiKhoanMoi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TenTaiKhoanTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ThoatButton = new System.Windows.Forms.Button();
            this.ThemButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TenTaiKhoanTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(297, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tên tài khoản:";
            // 
            // TenTaiKhoanTextBox
            // 
            this.TenTaiKhoanTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TenTaiKhoanTextBox.Location = new System.Drawing.Point(5, 18);
            this.TenTaiKhoanTextBox.MaxLength = 30;
            this.TenTaiKhoanTextBox.Name = "TenTaiKhoanTextBox";
            this.TenTaiKhoanTextBox.Size = new System.Drawing.Size(287, 27);
            this.TenTaiKhoanTextBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 44);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ThoatButton);
            this.flowLayoutPanel1.Controls.Add(this.ThemButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(297, 44);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // ThoatButton
            // 
            this.ThoatButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ThoatButton.Location = new System.Drawing.Point(219, 3);
            this.ThoatButton.Name = "ThoatButton";
            this.ThoatButton.Size = new System.Drawing.Size(75, 33);
            this.ThoatButton.TabIndex = 2;
            this.ThoatButton.Text = "Thoát";
            this.ThoatButton.UseVisualStyleBackColor = true;
            // 
            // ThemButton
            // 
            this.ThemButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ThemButton.Location = new System.Drawing.Point(138, 3);
            this.ThemButton.Name = "ThemButton";
            this.ThemButton.Size = new System.Drawing.Size(75, 33);
            this.ThemButton.TabIndex = 4;
            this.ThemButton.Text = "Thêm";
            this.ThemButton.UseVisualStyleBackColor = true;
            this.ThemButton.Click += new System.EventHandler(this.ThemButton_Click);
            // 
            // TaoTaiKhoanMoi
            // 
            this.AcceptButton = this.ThemButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ThoatButton;
            this.ClientSize = new System.Drawing.Size(297, 101);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TaoTaiKhoanMoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tạo tài khoản mới";
            this.Load += new System.EventHandler(this.TaoTaiKhoanMoi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TenTaiKhoanTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ThoatButton;
        private System.Windows.Forms.Button ThemButton;
    }
}