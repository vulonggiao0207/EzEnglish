namespace English_Studying
{
    partial class HuongDan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HuongDan));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.QuayLaiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(108, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(672, 368);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // QuayLaiButton
            // 
            this.QuayLaiButton.BackgroundImage = global::English_Studying.Properties.Resources.Return;
            this.QuayLaiButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QuayLaiButton.Location = new System.Drawing.Point(12, 5);
            this.QuayLaiButton.Name = "QuayLaiButton";
            this.QuayLaiButton.Size = new System.Drawing.Size(90, 40);
            this.QuayLaiButton.TabIndex = 4;
            this.QuayLaiButton.Text = "Quay lại";
            this.QuayLaiButton.UseVisualStyleBackColor = false;
            this.QuayLaiButton.Click += new System.EventHandler(this.QuayLaiButton_Click);
            // 
            // HuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::English_Studying.Properties.Resources.Blue_BackGround;
            this.ClientSize = new System.Drawing.Size(792, 394);
            this.ControlBox = false;
            this.Controls.Add(this.QuayLaiButton);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "HuongDan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hướng dẫn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button QuayLaiButton;
    }
}