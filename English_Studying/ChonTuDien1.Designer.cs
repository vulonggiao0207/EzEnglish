namespace English_Studying
{
    partial class ChonTuDien1
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ThoatButton = new System.Windows.Forms.Button();
            this.DongYButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.XoaButton = new System.Windows.Forms.Button();
            this.ThemButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TuDienSuDungListBox = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TuDienCaNhanListbox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 64);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ThoatButton);
            this.groupBox3.Controls.Add(this.DongYButton);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(545, 64);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // ThoatButton
            // 
            this.ThoatButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ThoatButton.Location = new System.Drawing.Point(436, 21);
            this.ThoatButton.Name = "ThoatButton";
            this.ThoatButton.Size = new System.Drawing.Size(97, 37);
            this.ThoatButton.TabIndex = 3;
            this.ThoatButton.Text = "Thóat";
            this.ThoatButton.UseVisualStyleBackColor = true;
            // 
            // DongYButton
            // 
            this.DongYButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DongYButton.Location = new System.Drawing.Point(316, 21);
            this.DongYButton.Name = "DongYButton";
            this.DongYButton.Size = new System.Drawing.Size(97, 37);
            this.DongYButton.TabIndex = 2;
            this.DongYButton.Text = "Đồng ý";
            this.DongYButton.UseVisualStyleBackColor = true;
            this.DongYButton.Click += new System.EventHandler(this.DongYButton_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.XoaButton);
            this.panel2.Controls.Add(this.ThemButton);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 290);
            this.panel2.TabIndex = 1;
            // 
            // XoaButton
            // 
            this.XoaButton.Location = new System.Drawing.Point(244, 121);
            this.XoaButton.Name = "XoaButton";
            this.XoaButton.Size = new System.Drawing.Size(56, 28);
            this.XoaButton.TabIndex = 3;
            this.XoaButton.Text = "<<";
            this.XoaButton.UseVisualStyleBackColor = true;
            this.XoaButton.Click += new System.EventHandler(this.XoaButton_Click);
            // 
            // ThemButton
            // 
            this.ThemButton.Location = new System.Drawing.Point(244, 87);
            this.ThemButton.Name = "ThemButton";
            this.ThemButton.Size = new System.Drawing.Size(56, 28);
            this.ThemButton.TabIndex = 3;
            this.ThemButton.Text = ">>";
            this.ThemButton.UseVisualStyleBackColor = true;
            this.ThemButton.Click += new System.EventHandler(this.ThemButton_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(307, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(238, 290);
            this.panel5.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TuDienSuDungListBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 290);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Từ điển sử dụng làm bài";
            // 
            // TuDienSuDungListBox
            // 
            this.TuDienSuDungListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TuDienSuDungListBox.FormattingEnabled = true;
            this.TuDienSuDungListBox.HorizontalScrollbar = true;
            this.TuDienSuDungListBox.ItemHeight = 20;
            this.TuDienSuDungListBox.Location = new System.Drawing.Point(3, 23);
            this.TuDienSuDungListBox.Name = "TuDienSuDungListBox";
            this.TuDienSuDungListBox.Size = new System.Drawing.Size(232, 264);
            this.TuDienSuDungListBox.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(238, 290);
            this.panel4.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TuDienCaNhanListbox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Từ điển cá nhân";
            // 
            // TuDienCaNhanListbox
            // 
            this.TuDienCaNhanListbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TuDienCaNhanListbox.FormattingEnabled = true;
            this.TuDienCaNhanListbox.HorizontalScrollbar = true;
            this.TuDienCaNhanListbox.ItemHeight = 20;
            this.TuDienCaNhanListbox.Location = new System.Drawing.Point(3, 23);
            this.TuDienCaNhanListbox.Name = "TuDienCaNhanListbox";
            this.TuDienCaNhanListbox.Size = new System.Drawing.Size(232, 264);
            this.TuDienCaNhanListbox.TabIndex = 0;
            // 
            // ChonTuDien1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 354);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChonTuDien1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn từ điển:";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChonTuDien_FormClosing);
            this.Load += new System.EventHandler(this.ChonTuDien_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button XoaButton;
        private System.Windows.Forms.Button ThemButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox TuDienSuDungListBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox TuDienCaNhanListbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ThoatButton;
        private System.Windows.Forms.Button DongYButton;
    }
}