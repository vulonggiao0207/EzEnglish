namespace English_Studying
{
    partial class TaoMoiTuVung
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ThoatTuVungButton = new System.Windows.Forms.Button();
            this.ThemTuVungButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChonHinhButton = new System.Windows.Forms.Button();
            this.HinhAnhTextBox = new System.Windows.Forms.TextBox();
            this.NghiaTuTextBox = new System.Windows.Forms.TextBox();
            this.LoaiTuCmb = new System.Windows.Forms.ComboBox();
            this.TuTextBox = new System.Windows.Forms.TextBox();
            this.ApDungTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ThoatTuVungButton);
            this.panel1.Controls.Add(this.ThemTuVungButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 44);
            this.panel1.TabIndex = 0;
            // 
            // ThoatTuVungButton
            // 
            this.ThoatTuVungButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ThoatTuVungButton.Location = new System.Drawing.Point(399, 5);
            this.ThoatTuVungButton.Name = "ThoatTuVungButton";
            this.ThoatTuVungButton.Size = new System.Drawing.Size(101, 36);
            this.ThoatTuVungButton.TabIndex = 1;
            this.ThoatTuVungButton.Text = "Thóat";
            this.ThoatTuVungButton.UseVisualStyleBackColor = true;
            this.ThoatTuVungButton.Click += new System.EventHandler(this.ThoatTuVungButton_Click);
            // 
            // ThemTuVungButton
            // 
            this.ThemTuVungButton.Location = new System.Drawing.Point(288, 5);
            this.ThemTuVungButton.Name = "ThemTuVungButton";
            this.ThemTuVungButton.Size = new System.Drawing.Size(101, 36);
            this.ThemTuVungButton.TabIndex = 0;
            this.ThemTuVungButton.Text = "Thêm";
            this.ThemTuVungButton.UseVisualStyleBackColor = true;
            this.ThemTuVungButton.Click += new System.EventHandler(this.ThemTuVungButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChonHinhButton);
            this.groupBox1.Controls.Add(this.HinhAnhTextBox);
            this.groupBox1.Controls.Add(this.NghiaTuTextBox);
            this.groupBox1.Controls.Add(this.LoaiTuCmb);
            this.groupBox1.Controls.Add(this.TuTextBox);
            this.groupBox1.Controls.Add(this.ApDungTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 261);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Từ muốn thêm";
            // 
            // ChonHinhButton
            // 
            this.ChonHinhButton.Location = new System.Drawing.Point(395, 94);
            this.ChonHinhButton.Name = "ChonHinhButton";
            this.ChonHinhButton.Size = new System.Drawing.Size(105, 35);
            this.ChonHinhButton.TabIndex = 10;
            this.ChonHinhButton.Text = "Chọn...";
            this.ChonHinhButton.UseVisualStyleBackColor = true;
            this.ChonHinhButton.Click += new System.EventHandler(this.ChonHinhButton_Click);
            // 
            // HinhAnhTextBox
            // 
            this.HinhAnhTextBox.Location = new System.Drawing.Point(103, 96);
            this.HinhAnhTextBox.Name = "HinhAnhTextBox";
            this.HinhAnhTextBox.ReadOnly = true;
            this.HinhAnhTextBox.Size = new System.Drawing.Size(286, 27);
            this.HinhAnhTextBox.TabIndex = 9;
            // 
            // NghiaTuTextBox
            // 
            this.NghiaTuTextBox.Location = new System.Drawing.Point(103, 60);
            this.NghiaTuTextBox.Name = "NghiaTuTextBox";
            this.NghiaTuTextBox.Size = new System.Drawing.Size(208, 27);
            this.NghiaTuTextBox.TabIndex = 8;
            // 
            // LoaiTuCmb
            // 
            this.LoaiTuCmb.FormattingEnabled = true;
            this.LoaiTuCmb.Items.AddRange(new object[] {
            "Noun",
            "Verb",
            "Adjective",
            "Adverb",
            "Others..."});
            this.LoaiTuCmb.Location = new System.Drawing.Point(395, 60);
            this.LoaiTuCmb.Name = "LoaiTuCmb";
            this.LoaiTuCmb.Size = new System.Drawing.Size(105, 28);
            this.LoaiTuCmb.TabIndex = 7;
            this.LoaiTuCmb.Text = "Others...";
            // 
            // TuTextBox
            // 
            this.TuTextBox.Location = new System.Drawing.Point(103, 23);
            this.TuTextBox.Name = "TuTextBox";
            this.TuTextBox.Size = new System.Drawing.Size(208, 27);
            this.TuTextBox.TabIndex = 6;
            // 
            // ApDungTextBox
            // 
            this.ApDungTextBox.Location = new System.Drawing.Point(103, 139);
            this.ApDungTextBox.Multiline = true;
            this.ApDungTextBox.Name = "ApDungTextBox";
            this.ApDungTextBox.Size = new System.Drawing.Size(397, 111);
            this.ApDungTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Áp dụng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nghĩa từ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hình ảnh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lọai từ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ:";
            // 
            // TaoMoiTuVung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ThoatTuVungButton;
            this.ClientSize = new System.Drawing.Size(512, 305);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TaoMoiTuVung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tạo mới từ vựng";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ThoatTuVungButton;
        private System.Windows.Forms.Button ThemTuVungButton;
        private System.Windows.Forms.TextBox NghiaTuTextBox;
        private System.Windows.Forms.ComboBox LoaiTuCmb;
        private System.Windows.Forms.TextBox TuTextBox;
        private System.Windows.Forms.TextBox ApDungTextBox;
        private System.Windows.Forms.TextBox HinhAnhTextBox;
        private System.Windows.Forms.Button ChonHinhButton;
    }
}