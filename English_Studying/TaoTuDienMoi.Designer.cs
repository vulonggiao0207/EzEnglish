namespace English_Studying
{
    partial class TaoTuDienMoi
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
            this.TenTuDienTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ThoatTuDienButton = new System.Windows.Forms.Button();
            this.ThemTuDienButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TenTuDienTextBox);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tên từ điển:";
            // 
            // TenTuDienTextBox
            // 
            this.TenTuDienTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TenTuDienTextBox.Location = new System.Drawing.Point(3, 16);
            this.TenTuDienTextBox.MaxLength = 50;
            this.TenTuDienTextBox.Name = "TenTuDienTextBox";
            this.TenTuDienTextBox.Size = new System.Drawing.Size(291, 27);
            this.TenTuDienTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ThoatTuDienButton);
            this.flowLayoutPanel1.Controls.Add(this.ThemTuDienButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 56);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(291, 42);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ThoatTuDienButton
            // 
            this.ThoatTuDienButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ThoatTuDienButton.Location = new System.Drawing.Point(213, 3);
            this.ThoatTuDienButton.Name = "ThoatTuDienButton";
            this.ThoatTuDienButton.Size = new System.Drawing.Size(75, 33);
            this.ThoatTuDienButton.TabIndex = 0;
            this.ThoatTuDienButton.Text = "Thoát";
            this.ThoatTuDienButton.UseVisualStyleBackColor = true;
            // 
            // ThemTuDienButton
            // 
            this.ThemTuDienButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ThemTuDienButton.Location = new System.Drawing.Point(132, 3);
            this.ThemTuDienButton.Name = "ThemTuDienButton";
            this.ThemTuDienButton.Size = new System.Drawing.Size(75, 33);
            this.ThemTuDienButton.TabIndex = 1;
            this.ThemTuDienButton.Text = "Thêm";
            this.ThemTuDienButton.UseVisualStyleBackColor = true;
            this.ThemTuDienButton.Click += new System.EventHandler(this.ThemTuDienButton_Click);
            // 
            // TaoTuDienMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 101);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TaoTuDienMoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tạo từ điển mới:";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaoTuDienMoi_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TenTuDienTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ThoatTuDienButton;
        private System.Windows.Forms.Button ThemTuDienButton;
    }
}