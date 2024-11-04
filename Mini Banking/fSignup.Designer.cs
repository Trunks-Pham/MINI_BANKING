namespace Mini_Banking
{
    partial class fSignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSignup));
            panel1 = new Panel();
            txbID = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            txbName = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            dtpDateOfBirth = new DateTimePicker();
            label3 = new Label();
            panel4 = new Panel();
            cbGender = new ComboBox();
            label4 = new Label();
            panel5 = new Panel();
            txbNumphone = new TextBox();
            label5 = new Label();
            panel6 = new Panel();
            txbAddress = new TextBox();
            label6 = new Label();
            panel7 = new Panel();
            btnOTP = new Button();
            txbEmail = new TextBox();
            label7 = new Label();
            panel8 = new Panel();
            txbOTP = new TextBox();
            label8 = new Label();
            TermsofService = new Label();
            ckbAgree = new CheckBox();
            btnSignInfor = new Button();
            panel9 = new Panel();
            pbView2 = new PictureBox();
            pbHide2 = new PictureBox();
            txbPasswordUp2 = new TextBox();
            label9 = new Label();
            panel10 = new Panel();
            pbView1 = new PictureBox();
            pbHide1 = new PictureBox();
            txbPasswordUp1 = new TextBox();
            label10 = new Label();
            panel11 = new Panel();
            xtbUsernameUp = new TextBox();
            label11 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHide2).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHide1).BeginInit();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txbID);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 244);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 38);
            panel1.TabIndex = 3;
            // 
            // txbID
            // 
            txbID.Location = new Point(120, 3);
            txbID.Name = "txbID";
            txbID.Size = new Size(246, 27);
            txbID.TabIndex = 3;
            txbID.KeyPress += Onlynum_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 8);
            label1.Name = "label1";
            label1.Size = new Size(63, 17);
            label1.TabIndex = 2;
            label1.Text = "Số CCCD:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(1, 280);
            panel2.Name = "panel2";
            panel2.Size = new Size(418, 35);
            panel2.TabIndex = 4;
            // 
            // txbName
            // 
            txbName.Location = new Point(120, 3);
            txbName.Name = "txbName";
            txbName.Size = new Size(246, 27);
            txbName.TabIndex = 4;
            txbName.KeyPress += Onlystring_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 8);
            label2.Name = "label2";
            label2.Size = new Size(72, 17);
            label2.TabIndex = 2;
            label2.Text = "Họ và Tên:";
            // 
            // panel3
            // 
            panel3.Controls.Add(dtpDateOfBirth);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(1, 316);
            panel3.Name = "panel3";
            panel3.Size = new Size(418, 37);
            panel3.TabIndex = 5;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(120, 4);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(246, 27);
            dtpDateOfBirth.TabIndex = 5;
            dtpDateOfBirth.Value = new DateTime(2023, 7, 23, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 11);
            label3.Name = "label3";
            label3.Size = new Size(73, 17);
            label3.TabIndex = 2;
            label3.Text = "Ngày Sinh:";
            // 
            // panel4
            // 
            panel4.Controls.Add(cbGender);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(1, 359);
            panel4.Name = "panel4";
            panel4.Size = new Size(418, 37);
            panel4.TabIndex = 6;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbGender.Location = new Point(120, 3);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(97, 28);
            cbGender.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 11);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 2;
            label4.Text = "Giới Tính:";
            // 
            // panel5
            // 
            panel5.Controls.Add(txbNumphone);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(1, 402);
            panel5.Name = "panel5";
            panel5.Size = new Size(418, 36);
            panel5.TabIndex = 7;
            // 
            // txbNumphone
            // 
            txbNumphone.Location = new Point(120, 4);
            txbNumphone.Name = "txbNumphone";
            txbNumphone.Size = new Size(246, 27);
            txbNumphone.TabIndex = 7;
            txbNumphone.KeyPress += Onlynum_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 4);
            label5.Name = "label5";
            label5.Size = new Size(94, 17);
            label5.TabIndex = 2;
            label5.Text = "Số Điện Thoại:";
            // 
            // panel6
            // 
            panel6.Controls.Add(txbAddress);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(0, 444);
            panel6.Name = "panel6";
            panel6.Size = new Size(418, 35);
            panel6.TabIndex = 8;
            // 
            // txbAddress
            // 
            txbAddress.Location = new Point(120, 5);
            txbAddress.Name = "txbAddress";
            txbAddress.Size = new Size(246, 27);
            txbAddress.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 10);
            label6.Name = "label6";
            label6.Size = new Size(106, 17);
            label6.TabIndex = 2;
            label6.Text = "Địa Chỉ Hiện Tại:";
            // 
            // panel7
            // 
            panel7.Controls.Add(btnOTP);
            panel7.Controls.Add(txbEmail);
            panel7.Controls.Add(label7);
            panel7.Location = new Point(1, 485);
            panel7.Name = "panel7";
            panel7.Size = new Size(418, 35);
            panel7.TabIndex = 9;
            // 
            // btnOTP
            // 
            btnOTP.BackColor = SystemColors.Window;
            btnOTP.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnOTP.ForeColor = SystemColors.Highlight;
            btnOTP.Location = new Point(325, 3);
            btnOTP.Name = "btnOTP";
            btnOTP.Size = new Size(82, 29);
            btnOTP.TabIndex = 11;
            btnOTP.Text = "Nhận OTP";
            btnOTP.UseVisualStyleBackColor = false;
            btnOTP.Click += btnOTP_Click;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(120, 3);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(199, 27);
            txbEmail.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 8);
            label7.Name = "label7";
            label7.Size = new Size(43, 17);
            label7.TabIndex = 2;
            label7.Text = "Email:";
            // 
            // panel8
            // 
            panel8.Controls.Add(txbOTP);
            panel8.Controls.Add(label8);
            panel8.Location = new Point(0, 526);
            panel8.Name = "panel8";
            panel8.Size = new Size(418, 33);
            panel8.TabIndex = 10;
            // 
            // txbOTP
            // 
            txbOTP.Location = new Point(120, 0);
            txbOTP.Name = "txbOTP";
            txbOTP.Size = new Size(199, 27);
            txbOTP.TabIndex = 12;
            txbOTP.KeyPress += Onlynum_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(9, 8);
            label8.Name = "label8";
            label8.Size = new Size(58, 17);
            label8.TabIndex = 2;
            label8.Text = "Mã OTP:";
            // 
            // TermsofService
            // 
            TermsofService.AutoSize = true;
            TermsofService.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            TermsofService.ForeColor = SystemColors.Highlight;
            TermsofService.Location = new Point(120, 562);
            TermsofService.Name = "TermsofService";
            TermsofService.Size = new Size(236, 17);
            TermsofService.TabIndex = 14;
            TermsofService.Text = "Điều Khoản Dịch Vụ của Mini Banking";
            // 
            // ckbAgree
            // 
            ckbAgree.AutoSize = true;
            ckbAgree.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            ckbAgree.Location = new Point(81, 604);
            ckbAgree.Name = "ckbAgree";
            ckbAgree.Size = new Size(308, 21);
            ckbAgree.TabIndex = 15;
            ckbAgree.Text = "Tôi Đã Đọc Và Đồng Ý Với Điều Khoản Dịch Vụ";
            ckbAgree.UseVisualStyleBackColor = true;
            // 
            // btnSignInfor
            // 
            btnSignInfor.BackColor = SystemColors.Window;
            btnSignInfor.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignInfor.ForeColor = SystemColors.Highlight;
            btnSignInfor.Location = new Point(81, 644);
            btnSignInfor.Name = "btnSignInfor";
            btnSignInfor.Size = new Size(268, 63);
            btnSignInfor.TabIndex = 16;
            btnSignInfor.Text = "Xác Nhận Thông Tin";
            btnSignInfor.UseVisualStyleBackColor = false;
            btnSignInfor.Click += btnSignInfor_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(pbView2);
            panel9.Controls.Add(pbHide2);
            panel9.Controls.Add(txbPasswordUp2);
            panel9.Controls.Add(label9);
            panel9.Location = new Point(0, 201);
            panel9.Name = "panel9";
            panel9.Size = new Size(418, 37);
            panel9.TabIndex = 2;
            // 
            // pbView2
            // 
            pbView2.Image = (Image)resources.GetObject("pbView2.Image");
            pbView2.Location = new Point(372, 4);
            pbView2.Name = "pbView2";
            pbView2.Size = new Size(35, 27);
            pbView2.SizeMode = PictureBoxSizeMode.Zoom;
            pbView2.TabIndex = 6;
            pbView2.TabStop = false;
            pbView2.Click += pbView2_Click;
            // 
            // pbHide2
            // 
            pbHide2.Image = (Image)resources.GetObject("pbHide2.Image");
            pbHide2.Location = new Point(372, 4);
            pbHide2.Name = "pbHide2";
            pbHide2.Size = new Size(35, 27);
            pbHide2.SizeMode = PictureBoxSizeMode.Zoom;
            pbHide2.TabIndex = 5;
            pbHide2.TabStop = false;
            pbHide2.Click += pbHide2_Click;
            // 
            // txbPasswordUp2
            // 
            txbPasswordUp2.Location = new Point(120, 4);
            txbPasswordUp2.Name = "txbPasswordUp2";
            txbPasswordUp2.Size = new Size(246, 27);
            txbPasswordUp2.TabIndex = 2;
            txbPasswordUp2.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Desktop;
            label9.Location = new Point(3, 9);
            label9.Name = "label9";
            label9.Size = new Size(111, 17);
            label9.TabIndex = 3;
            label9.Text = "Mật Khẩu (lần 2):";
            // 
            // panel10
            // 
            panel10.Controls.Add(pbView1);
            panel10.Controls.Add(pbHide1);
            panel10.Controls.Add(txbPasswordUp1);
            panel10.Controls.Add(label10);
            panel10.Location = new Point(0, 159);
            panel10.Name = "panel10";
            panel10.Size = new Size(418, 36);
            panel10.TabIndex = 1;
            // 
            // pbView1
            // 
            pbView1.Image = (Image)resources.GetObject("pbView1.Image");
            pbView1.Location = new Point(372, 5);
            pbView1.Name = "pbView1";
            pbView1.Size = new Size(35, 27);
            pbView1.SizeMode = PictureBoxSizeMode.Zoom;
            pbView1.TabIndex = 6;
            pbView1.TabStop = false;
            pbView1.Click += pbView1_Click;
            // 
            // pbHide1
            // 
            pbHide1.Image = (Image)resources.GetObject("pbHide1.Image");
            pbHide1.Location = new Point(372, 5);
            pbHide1.Name = "pbHide1";
            pbHide1.Size = new Size(35, 27);
            pbHide1.SizeMode = PictureBoxSizeMode.Zoom;
            pbHide1.TabIndex = 5;
            pbHide1.TabStop = false;
            pbHide1.Click += pbHide1_Click;
            // 
            // txbPasswordUp1
            // 
            txbPasswordUp1.Location = new Point(120, 5);
            txbPasswordUp1.Name = "txbPasswordUp1";
            txbPasswordUp1.Size = new Size(246, 27);
            txbPasswordUp1.TabIndex = 1;
            txbPasswordUp1.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Desktop;
            label10.Location = new Point(3, 10);
            label10.Name = "label10";
            label10.Size = new Size(109, 17);
            label10.TabIndex = 3;
            label10.Text = "Mật Khẩu (lần 1):";
            // 
            // panel11
            // 
            panel11.Controls.Add(xtbUsernameUp);
            panel11.Controls.Add(label11);
            panel11.Location = new Point(0, 115);
            panel11.Name = "panel11";
            panel11.Size = new Size(418, 38);
            panel11.TabIndex = 0;
            // 
            // xtbUsernameUp
            // 
            xtbUsernameUp.Location = new Point(120, 3);
            xtbUsernameUp.Name = "xtbUsernameUp";
            xtbUsernameUp.Size = new Size(246, 27);
            xtbUsernameUp.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Desktop;
            label11.Location = new Point(6, 10);
            label11.Name = "label11";
            label11.Size = new Size(105, 17);
            label11.TabIndex = 3;
            label11.Text = "Tên Đăng Nhập:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-9, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(463, 96);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // fSignup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(431, 733);
            ControlBox = false;
            Controls.Add(pictureBox2);
            Controls.Add(panel9);
            Controls.Add(panel10);
            Controls.Add(panel11);
            Controls.Add(btnSignInfor);
            Controls.Add(ckbAgree);
            Controls.Add(TermsofService);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fSignup";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHide2).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHide1).EndInit();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private TextBox txbID;
        private Panel panel2;
        private TextBox txbName;
        private Label label2;
        private Panel panel3;
        private DateTimePicker dtpDateOfBirth;
        private Label label3;
        private Panel panel4;
        private ComboBox cbGender;
        private Label label4;
        private Panel panel5;
        private Label label5;
        private TextBox txbNumphone;
        private Panel panel6;
        private TextBox txbAddress;
        private Label label6;
        private Panel panel7;
        private Button btnOTP;
        private TextBox txbEmail;
        private Label label7;
        private Panel panel8;
        private TextBox txbOTP;
        private Label label8;
        private Label TermsofService;
        private CheckBox ckbAgree;
        private Button btnSignInfor;
        private Panel panel9;
        private PictureBox pbView2;
        private PictureBox pbHide2;
        private TextBox txbPasswordUp2;
        private Label label9;
        private Panel panel10;
        private PictureBox pbView1;
        private PictureBox pbHide1;
        private TextBox txbPasswordUp1;
        private Label label10;
        private Panel panel11;
        private TextBox xtbUsernameUp;
        private Label label11;
        private PictureBox pictureBox2;
    }
}