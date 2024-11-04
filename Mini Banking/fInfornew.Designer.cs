namespace Mini_Banking
{
    partial class fInfornew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fInfornew));
            pbBack = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            txbAddress = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            btnOTP = new Button();
            txbEmail = new TextBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            txbOTP = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            pbView = new PictureBox();
            txbPassword = new TextBox();
            pbHide = new PictureBox();
            label5 = new Label();
            ckbAgree = new CheckBox();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHide).BeginInit();
            SuspendLayout();
            // 
            // pbBack
            // 
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(388, 12);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(29, 35);
            pbBack.SizeMode = PictureBoxSizeMode.Zoom;
            pbBack.TabIndex = 1;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(405, 366);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(txbAddress);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(56, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 51);
            panel2.TabIndex = 1;
            // 
            // txbAddress
            // 
            txbAddress.Location = new Point(23, 20);
            txbAddress.Name = "txbAddress";
            txbAddress.Size = new Size(277, 27);
            txbAddress.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(23, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 17);
            label2.TabIndex = 4;
            label2.Text = "Nhập Địa Chỉ Mới";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnOTP);
            panel3.Controls.Add(txbEmail);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(56, 138);
            panel3.Name = "panel3";
            panel3.Size = new Size(321, 51);
            panel3.TabIndex = 2;
            // 
            // btnOTP
            // 
            btnOTP.BackColor = SystemColors.Window;
            btnOTP.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnOTP.ForeColor = SystemColors.Highlight;
            btnOTP.Location = new Point(214, 18);
            btnOTP.Name = "btnOTP";
            btnOTP.Size = new Size(86, 29);
            btnOTP.TabIndex = 3;
            btnOTP.Text = "Nhận OTP";
            btnOTP.UseVisualStyleBackColor = false;
            btnOTP.Click += btnOTP_Click;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(23, 20);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(185, 27);
            txbEmail.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(23, 0);
            label3.Name = "label3";
            label3.Size = new Size(201, 17);
            label3.TabIndex = 4;
            label3.Text = "Email Hiện Tại Để Nhận Mã OTP";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, 531);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(434, 201);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(txbOTP);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(56, 195);
            panel4.Name = "panel4";
            panel4.Size = new Size(321, 51);
            panel4.TabIndex = 3;
            // 
            // txbOTP
            // 
            txbOTP.Location = new Point(23, 20);
            txbOTP.Name = "txbOTP";
            txbOTP.Size = new Size(185, 27);
            txbOTP.TabIndex = 4;
            txbOTP.TextChanged += txbOTP_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(23, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 17);
            label4.TabIndex = 4;
            label4.Text = "Mã OTP";
            // 
            // panel5
            // 
            panel5.Controls.Add(pbView);
            panel5.Controls.Add(txbPassword);
            panel5.Controls.Add(pbHide);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(56, 252);
            panel5.Name = "panel5";
            panel5.Size = new Size(321, 51);
            panel5.TabIndex = 4;
            // 
            // pbView
            // 
            pbView.Image = (Image)resources.GetObject("pbView.Image");
            pbView.Location = new Point(276, 20);
            pbView.Name = "pbView";
            pbView.Size = new Size(42, 27);
            pbView.SizeMode = PictureBoxSizeMode.Zoom;
            pbView.TabIndex = 11;
            pbView.TabStop = false;
            pbView.Click += pbView_Click;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(23, 20);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(247, 27);
            txbPassword.TabIndex = 5;
            txbPassword.UseSystemPasswordChar = true;
            // 
            // pbHide
            // 
            pbHide.Image = (Image)resources.GetObject("pbHide.Image");
            pbHide.Location = new Point(276, 21);
            pbHide.Name = "pbHide";
            pbHide.Size = new Size(42, 27);
            pbHide.SizeMode = PictureBoxSizeMode.Zoom;
            pbHide.TabIndex = 10;
            pbHide.TabStop = false;
            pbHide.Click += pbHide_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(23, 0);
            label5.Name = "label5";
            label5.Size = new Size(104, 17);
            label5.TabIndex = 4;
            label5.Text = "Nhập Mật Khẩu";
            // 
            // ckbAgree
            // 
            ckbAgree.AutoSize = true;
            ckbAgree.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            ckbAgree.ForeColor = SystemColors.Highlight;
            ckbAgree.Location = new Point(79, 309);
            ckbAgree.Name = "ckbAgree";
            ckbAgree.Size = new Size(218, 21);
            ckbAgree.TabIndex = 6;
            ckbAgree.Text = "Tôi Đồng Ý Thay Đổi Thông Tin";
            ckbAgree.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Window;
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.Highlight;
            btnUpdate.Location = new Point(121, 336);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(194, 61);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Xác Nhận Đổi Thông Tin";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // fInfornew
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(429, 731);
            ControlBox = false;
            Controls.Add(btnUpdate);
            Controls.Add(ckbAgree);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(pbBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fInfornew";
            StartPosition = FormStartPosition.CenterScreen;
            Load += fInfornew_Load;
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHide).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbBack;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox txbAddress;
        private Label label2;
        private Panel panel3;
        private Button btnOTP;
        private TextBox txbEmail;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel panel4;
        private TextBox txbOTP;
        private Label label4;
        private Panel panel5;
        private TextBox txbPassword;
        private Label label5;
        private PictureBox pbHide;
        private PictureBox pbView;
        private CheckBox ckbAgree;
        private Button btnUpdate;
    }
}