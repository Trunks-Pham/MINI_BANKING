namespace Mini_Banking
{
    partial class fSavemoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSavemoney));
            pbBack = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txbSavemoneys = new TextBox();
            btnSavemoneys = new Button();
            pictureBox2 = new PictureBox();
            Inforsavemoneys = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            dgvListsavemoneys = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListsavemoneys).BeginInit();
            SuspendLayout();
            // 
            // pbBack
            // 
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(390, 12);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(29, 29);
            pbBack.SizeMode = PictureBoxSizeMode.Zoom;
            pbBack.TabIndex = 1;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(407, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(50, 114);
            label1.Name = "label1";
            label1.Size = new Size(156, 17);
            label1.TabIndex = 3;
            label1.Text = "Nhập Số Tiền Muốn Gửi:";
            // 
            // txbSavemoneys
            // 
            txbSavemoneys.Location = new Point(50, 134);
            txbSavemoneys.Name = "txbSavemoneys";
            txbSavemoneys.Size = new Size(318, 27);
            txbSavemoneys.TabIndex = 4;
            txbSavemoneys.TextAlign = HorizontalAlignment.Right;
            txbSavemoneys.TextChanged += txbSavemoneys_TextChanged;
            // 
            // btnSavemoneys
            // 
            btnSavemoneys.BackColor = SystemColors.Window;
            btnSavemoneys.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSavemoneys.ForeColor = SystemColors.Highlight;
            btnSavemoneys.Location = new Point(120, 192);
            btnSavemoneys.Name = "btnSavemoneys";
            btnSavemoneys.Size = new Size(167, 39);
            btnSavemoneys.TabIndex = 5;
            btnSavemoneys.Text = "Xác Nhận Gửi Tiền";
            btnSavemoneys.UseVisualStyleBackColor = false;
            btnSavemoneys.Click += btnSavemoneys_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-6, 519);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(325, 221);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Inforsavemoneys
            // 
            Inforsavemoneys.AutoSize = true;
            Inforsavemoneys.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            Inforsavemoneys.ForeColor = SystemColors.Highlight;
            Inforsavemoneys.Location = new Point(120, 705);
            Inforsavemoneys.Name = "Inforsavemoneys";
            Inforsavemoneys.Size = new Size(274, 17);
            Inforsavemoneys.TabIndex = 7;
            Inforsavemoneys.Text = "Ấn vào [ ĐÂY ] để biết thêm thông tin nhé !";
            Inforsavemoneys.Click += Inforsavemoneys_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 297);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(407, 178);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(35, 307);
            label2.Name = "label2";
            label2.Size = new Size(86, 17);
            label2.TabIndex = 9;
            label2.Text = "Sổ Tiết Kiệm:";
            // 
            // dgvListsavemoneys
            // 
            dgvListsavemoneys.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListsavemoneys.Location = new Point(35, 327);
            dgvListsavemoneys.Name = "dgvListsavemoneys";
            dgvListsavemoneys.RowHeadersWidth = 51;
            dgvListsavemoneys.RowTemplate.Height = 29;
            dgvListsavemoneys.Size = new Size(363, 129);
            dgvListsavemoneys.TabIndex = 10;
            // 
            // fSavemoney
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(431, 731);
            ControlBox = false;
            Controls.Add(dgvListsavemoneys);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(Inforsavemoneys);
            Controls.Add(pictureBox2);
            Controls.Add(btnSavemoneys);
            Controls.Add(txbSavemoneys);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pbBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fSavemoney";
            StartPosition = FormStartPosition.CenterScreen;
            Load += fSavemoney_Load;
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListsavemoneys).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbBack;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txbSavemoneys;
        private Button btnSavemoneys;
        private PictureBox pictureBox2;
        private Label Inforsavemoneys;
        private PictureBox pictureBox3;
        private Label label2;
        private DataGridView dgvListsavemoneys;
    }
}