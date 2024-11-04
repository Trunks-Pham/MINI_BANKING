namespace Mini_Banking
{
    partial class fJar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fJar));
            pbBack = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            dgvJar = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txbNameJar = new TextBox();
            label3 = new Label();
            txbAmountJar = new TextBox();
            label4 = new Label();
            txbContentJar = new TextBox();
            label5 = new Label();
            btnJarOK = new Button();
            btnUpdateJar = new Button();
            btnDel = new Button();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvJar).BeginInit();
            SuspendLayout();
            // 
            // pbBack
            // 
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(387, 12);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(30, 35);
            pbBack.SizeMode = PictureBoxSizeMode.Zoom;
            pbBack.TabIndex = 1;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(405, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 404);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(405, 250);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // dgvJar
            // 
            dgvJar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJar.Location = new Point(43, 442);
            dgvJar.Name = "dgvJar";
            dgvJar.RowHeadersWidth = 51;
            dgvJar.RowTemplate.Height = 29;
            dgvJar.Size = new Size(346, 167);
            dgvJar.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(43, 422);
            label1.Name = "label1";
            label1.Size = new Size(132, 17);
            label1.TabIndex = 5;
            label1.Text = "Hủ Chi Tiêu Của Bạn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(68, 78);
            label2.Name = "label2";
            label2.Size = new Size(103, 17);
            label2.TabIndex = 6;
            label2.Text = "Tên Hủ Chi Tiêu";
            // 
            // txbNameJar
            // 
            txbNameJar.Location = new Point(68, 98);
            txbNameJar.Name = "txbNameJar";
            txbNameJar.Size = new Size(298, 27);
            txbNameJar.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(68, 137);
            label3.Name = "label3";
            label3.Size = new Size(126, 17);
            label3.TabIndex = 8;
            label3.Text = "Số Tiền Hủ Chi Tiêu";
            // 
            // txbAmountJar
            // 
            txbAmountJar.Location = new Point(68, 157);
            txbAmountJar.Name = "txbAmountJar";
            txbAmountJar.Size = new Size(298, 27);
            txbAmountJar.TabIndex = 2;
            txbAmountJar.TextAlign = HorizontalAlignment.Right;
            txbAmountJar.TextChanged += txbAmountJar_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(68, 197);
            label4.Name = "label4";
            label4.Size = new Size(140, 17);
            label4.TabIndex = 10;
            label4.Text = "Nội Dung Hủ Chi Tiêu";
            // 
            // txbContentJar
            // 
            txbContentJar.ForeColor = SystemColors.ScrollBar;
            txbContentJar.Location = new Point(68, 217);
            txbContentJar.Multiline = true;
            txbContentJar.Name = "txbContentJar";
            txbContentJar.Size = new Size(298, 72);
            txbContentJar.TabIndex = 3;
            txbContentJar.Text = "Ăn uống tiết kiệm để dành tiền in đồ án";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(252, 263);
            label5.Name = "label5";
            label5.Size = new Size(103, 17);
            label5.TabIndex = 12;
            label5.Text = "(Không bắt buộc)";
            // 
            // btnJarOK
            // 
            btnJarOK.BackColor = SystemColors.Window;
            btnJarOK.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnJarOK.ForeColor = SystemColors.Highlight;
            btnJarOK.Location = new Point(123, 330);
            btnJarOK.Name = "btnJarOK";
            btnJarOK.Size = new Size(185, 59);
            btnJarOK.TabIndex = 4;
            btnJarOK.Text = "Xác Nhận Tạo Hủ";
            btnJarOK.UseVisualStyleBackColor = false;
            btnJarOK.Click += btnJarOK_Click;
            // 
            // btnUpdateJar
            // 
            btnUpdateJar.BackColor = SystemColors.Window;
            btnUpdateJar.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateJar.ForeColor = SystemColors.Highlight;
            btnUpdateJar.Location = new Point(195, 615);
            btnUpdateJar.Name = "btnUpdateJar";
            btnUpdateJar.Size = new Size(94, 29);
            btnUpdateJar.TabIndex = 14;
            btnUpdateJar.Text = "Sửa Hủ";
            btnUpdateJar.UseVisualStyleBackColor = false;
            // 
            // btnDel
            // 
            btnDel.BackColor = SystemColors.Window;
            btnDel.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDel.ForeColor = SystemColors.Highlight;
            btnDel.Location = new Point(295, 615);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 29);
            btnDel.TabIndex = 15;
            btnDel.Text = "Xóa Hủ";
            btnDel.UseVisualStyleBackColor = false;
            // 
            // fJar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(429, 732);
            ControlBox = false;
            Controls.Add(btnDel);
            Controls.Add(btnUpdateJar);
            Controls.Add(btnJarOK);
            Controls.Add(label5);
            Controls.Add(txbContentJar);
            Controls.Add(label4);
            Controls.Add(txbAmountJar);
            Controls.Add(label3);
            Controls.Add(txbNameJar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvJar);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pbBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fJar";
            StartPosition = FormStartPosition.CenterScreen;
            Load += fJar_Load;
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvJar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbBack;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridView dgvJar;
        private Label label1;
        private Label label2;
        private TextBox txbNameJar;
        private Label label3;
        private TextBox txbAmountJar;
        private Label label4;
        private TextBox txbContentJar;
        private Label label5;
        private Button btnJarOK;
        private Button btnUpdateJar;
        private Button btnDel;
    }
}