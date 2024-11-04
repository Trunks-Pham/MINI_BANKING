namespace Mini_Banking
{
    partial class fContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fContact));
            pbBack = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            txbNameC = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            txbEmailC = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txbNumC = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            txbContentC = new TextBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            btnContact = new Button();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pbBack
            // 
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(388, 12);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(30, 35);
            pbBack.SizeMode = PictureBoxSizeMode.Zoom;
            pbBack.TabIndex = 0;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(406, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(txbNameC);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(59, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 53);
            panel1.TabIndex = 2;
            // 
            // txbNameC
            // 
            txbNameC.Location = new Point(3, 23);
            txbNameC.Name = "txbNameC";
            txbNameC.Size = new Size(315, 27);
            txbNameC.TabIndex = 1;
            txbNameC.KeyPress += Onlystring_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(66, 17);
            label1.TabIndex = 3;
            label1.Text = "Nhập Tên";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbEmailC);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(59, 122);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 53);
            panel2.TabIndex = 4;
            // 
            // txbEmailC
            // 
            txbEmailC.Location = new Point(3, 23);
            txbEmailC.Name = "txbEmailC";
            txbEmailC.Size = new Size(315, 27);
            txbEmailC.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 3;
            label2.Text = "Nhập Email";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbNumC);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(59, 181);
            panel3.Name = "panel3";
            panel3.Size = new Size(321, 53);
            panel3.TabIndex = 5;
            // 
            // txbNumC
            // 
            txbNumC.Location = new Point(3, 23);
            txbNumC.Name = "txbNumC";
            txbNumC.Size = new Size(315, 27);
            txbNumC.TabIndex = 3;
            txbNumC.TextAlign = HorizontalAlignment.Right;
            txbNumC.TextChanged += txbNumC_TextChanged;
            txbNumC.KeyPress += Onlynum_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(3, 3);
            label3.Name = "label3";
            label3.Size = new Size(128, 17);
            label3.TabIndex = 3;
            label3.Text = "Nhập Số Điện Thoại";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbContentC);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(59, 240);
            panel4.Name = "panel4";
            panel4.Size = new Size(321, 170);
            panel4.TabIndex = 6;
            // 
            // txbContentC
            // 
            txbContentC.Location = new Point(3, 23);
            txbContentC.Multiline = true;
            txbContentC.Name = "txbContentC";
            txbContentC.Size = new Size(315, 144);
            txbContentC.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(214, 17);
            label4.TabIndex = 3;
            label4.Text = "Mô Tả Vấn Đề Bạn Đang Gặp Phải";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-11, 510);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(358, 225);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // btnContact
            // 
            btnContact.BackColor = SystemColors.Window;
            btnContact.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnContact.ForeColor = SystemColors.Highlight;
            btnContact.Location = new Point(124, 461);
            btnContact.Name = "btnContact";
            btnContact.Size = new Size(182, 60);
            btnContact.TabIndex = 5;
            btnContact.Text = "Gửi Yêu Cầu Hỗ Trợ";
            btnContact.UseVisualStyleBackColor = false;
            btnContact.Click += btnContact_Click;
            // 
            // fContact
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(430, 732);
            ControlBox = false;
            Controls.Add(btnContact);
            Controls.Add(pictureBox2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(pbBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fContact";
            StartPosition = FormStartPosition.CenterScreen;
            Load += fContact_Load;
            Leave += fContact_Leave;
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbBack;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox txbNameC;
        private Label label1;
        private Panel panel2;
        private TextBox txbEmailC;
        private Label label2;
        private Panel panel3;
        private TextBox txbNumC;
        private Label label3;
        private Panel panel4;
        private TextBox txbContentC;
        private Label label4;
        private PictureBox pictureBox2;
        private Button btnContact;
    }
}