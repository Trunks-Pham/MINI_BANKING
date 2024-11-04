namespace Mini_Banking
{
    partial class fInterest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fInterest));
            pbBack = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            txbNameTKTK = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            txbMoneyTKTK = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            cmbMonth = new ComboBox();
            label3 = new Label();
            btnTKTK = new Button();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            dgvTKTK = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTKTK).BeginInit();
            SuspendLayout();
            // 
            // pbBack
            // 
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(390, 12);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(28, 35);
            pbBack.SizeMode = PictureBoxSizeMode.Zoom;
            pbBack.TabIndex = 1;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(406, 260);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(txbNameTKTK);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(35, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 51);
            panel1.TabIndex = 3;
            // 
            // txbNameTKTK
            // 
            txbNameTKTK.Location = new Point(34, 20);
            txbNameTKTK.Name = "txbNameTKTK";
            txbNameTKTK.Size = new Size(296, 27);
            txbNameTKTK.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(34, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 17);
            label1.TabIndex = 4;
            label1.Text = "Tên Tài Khoản Tiết Kiệm";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbMoneyTKTK);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(35, 153);
            panel2.Name = "panel2";
            panel2.Size = new Size(358, 51);
            panel2.TabIndex = 5;
            // 
            // txbMoneyTKTK
            // 
            txbMoneyTKTK.Location = new Point(34, 20);
            txbMoneyTKTK.Name = "txbMoneyTKTK";
            txbMoneyTKTK.Size = new Size(296, 27);
            txbMoneyTKTK.TabIndex = 2;
            txbMoneyTKTK.TextAlign = HorizontalAlignment.Right;
            txbMoneyTKTK.TextChanged += txbMoneyTKTK_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(34, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 17);
            label2.TabIndex = 4;
            label2.Text = "Số Tiền Tiết Kiệm";
            // 
            // panel3
            // 
            panel3.Controls.Add(cmbMonth);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(35, 206);
            panel3.Name = "panel3";
            panel3.Size = new Size(358, 51);
            panel3.TabIndex = 6;
            // 
            // cmbMonth
            // 
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Items.AddRange(new object[] { " 1 Tháng          Lãi Suất 4,8% / Năm", " 3 Tháng          Lãi Suất 5,0% / Năm", " 6 Tháng          Lãi Suất 7,4% / Năm", "12 Tháng         Lãi Suất 8,0% / Năm", "18 Tháng         Lãi Suất 8,3% / Năm" });
            cmbMonth.Location = new Point(35, 20);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(295, 28);
            cmbMonth.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(34, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 17);
            label3.TabIndex = 4;
            label3.Text = "Kỳ Hạn Tiết Kiệm";
            // 
            // btnTKTK
            // 
            btnTKTK.BackColor = SystemColors.Window;
            btnTKTK.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTKTK.ForeColor = SystemColors.Highlight;
            btnTKTK.Location = new Point(140, 280);
            btnTKTK.Name = "btnTKTK";
            btnTKTK.Size = new Size(150, 50);
            btnTKTK.TabIndex = 7;
            btnTKTK.Text = "Gửi Tiết Kiệm";
            btnTKTK.UseVisualStyleBackColor = false;
            btnTKTK.Click += btnTKTK_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 427);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(406, 257);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(104, 407);
            label4.Name = "label4";
            label4.Size = new Size(195, 17);
            label4.TabIndex = 9;
            label4.Text = "Danh Sách Tài Khoản Tiết Kiệm";
            // 
            // dgvTKTK
            // 
            dgvTKTK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTKTK.Location = new Point(35, 449);
            dgvTKTK.Name = "dgvTKTK";
            dgvTKTK.RowHeadersWidth = 51;
            dgvTKTK.RowTemplate.Height = 29;
            dgvTKTK.Size = new Size(358, 211);
            dgvTKTK.TabIndex = 10;
            // 
            // fInterest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(430, 731);
            ControlBox = false;
            Controls.Add(dgvTKTK);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(btnTKTK);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(pbBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fInterest";
            StartPosition = FormStartPosition.CenterScreen;
            Load += fInterest_Load;
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTKTK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbBack;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox txbNameTKTK;
        private Label label1;
        private Panel panel2;
        private TextBox txbMoneyTKTK;
        private Label label2;
        private Panel panel3;
        private ComboBox cmbMonth;
        private Label label3;
        private Button btnTKTK;
        private PictureBox pictureBox2;
        private Label label4;
        private DataGridView dgvTKTK;
    }
}