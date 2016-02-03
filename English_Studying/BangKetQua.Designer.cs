namespace English_Studying
{
    partial class BangKetQua
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DongButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.KetQuaGridView = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CauTraLoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CauTraLoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KetQuaGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.DongButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 341);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 38);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "sai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "đúng";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Location = new System.Drawing.Point(169, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(23, 23);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Location = new System.Drawing.Point(19, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(23, 23);
            this.panel2.TabIndex = 1;
            // 
            // DongButton
            // 
            this.DongButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DongButton.Location = new System.Drawing.Point(325, 3);
            this.DongButton.Name = "DongButton";
            this.DongButton.Size = new System.Drawing.Size(82, 31);
            this.DongButton.TabIndex = 0;
            this.DongButton.Text = "Đóng";
            this.DongButton.UseVisualStyleBackColor = true;
            this.DongButton.Click += new System.EventHandler(this.DongButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.KetQuaGridView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 341);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả";
            // 
            // KetQuaGridView
            // 
            this.KetQuaGridView.AllowUserToAddRows = false;
            this.KetQuaGridView.AllowUserToDeleteRows = false;
            this.KetQuaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KetQuaGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.CauTraLoi,
            this.CauTraLoiDung});
            this.KetQuaGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KetQuaGridView.Location = new System.Drawing.Point(3, 23);
            this.KetQuaGridView.Name = "KetQuaGridView";
            this.KetQuaGridView.ReadOnly = true;
            this.KetQuaGridView.Size = new System.Drawing.Size(413, 315);
            this.KetQuaGridView.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.STT.Width = 50;
            // 
            // CauTraLoi
            // 
            this.CauTraLoi.DataPropertyName = "CauTraLoi";
            this.CauTraLoi.HeaderText = "Câu trả lời";
            this.CauTraLoi.Name = "CauTraLoi";
            this.CauTraLoi.ReadOnly = true;
            this.CauTraLoi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CauTraLoi.Width = 160;
            // 
            // CauTraLoiDung
            // 
            this.CauTraLoiDung.DataPropertyName = "CauTraLoiDung";
            this.CauTraLoiDung.HeaderText = "Câu trả lời đúng";
            this.CauTraLoiDung.Name = "CauTraLoiDung";
            this.CauTraLoiDung.ReadOnly = true;
            this.CauTraLoiDung.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CauTraLoiDung.Width = 160;
            // 
            // BangKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DongButton;
            this.ClientSize = new System.Drawing.Size(419, 379);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "BangKetQua";
            this.Text = "Bảng kết quả";
            this.Load += new System.EventHandler(this.BangKetQua_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KetQuaGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DongButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView KetQuaGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CauTraLoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CauTraLoiDung;
    }
}