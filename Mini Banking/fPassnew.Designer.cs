namespace Mini_Banking
{
    partial class fPassnew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPassnew));
            pbBack = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pbOldview = new PictureBox();
            txbOldPass = new TextBox();
            pbOldhide = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            pbNewview1 = new PictureBox();
            txbNewpass1 = new TextBox();
            pbNewhide1 = new PictureBox();
            label2 = new Label();
            panel3 = new Panel();
            pbNewview2 = new PictureBox();
            txbNewpass2 = new TextBox();
            pbNewhide2 = new PictureBox();
            label3 = new Label();
            panel4 = new Panel();
            btnSendotp = new Button();
            txbEmail = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            txbOTP = new TextBox();
            label5 = new Label();
            cbAgree = new CheckBox();
            btnUpdatepass = new Button();
            pictureBox2 = new PictureBox();
            labelInforPass = new Label();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbOldview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOldhide).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbNewview1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNewhide1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbNewview2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNewhide2).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pbBack
            // 
            pbBack.BackColor = SystemColors.Window;
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(388, 12);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(27, 35);
            pbBack.SizeMode = PictureBoxSizeMode.Zoom;
            pbBack.TabIndex = 1;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(403, 382);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pbOldview);
            panel1.Controls.Add(txbOldPass);
            panel1.Controls.Add(pbOldhide);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(63, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 54);
            panel1.TabIndex = 3;
            // 
            // pbOldview
            // 
            pbOldview.Image = (Image)resources.GetObject("pbOldview.Image");
            pbOldview.Location = new Point(265, 20);
            pbOldview.Name = "pbOldview";
            pbOldview.Size = new Size(32, 27);
            pbOldview.SizeMode = PictureBoxSizeMode.Zoom;
            pbOldview.TabIndex = 5;
            pbOldview.TabStop = false;
            pbOldview.Click += pbOldview_Click;
            // 
            // txbOldPass
            // 
            txbOldPass.Location = new Point(12, 20);
            txbOldPass.Name = "txbOldPass";
            txbOldPass.Size = new Size(250, 27);
            txbOldPass.TabIndex = 1;
            txbOldPass.UseSystemPasswordChar = true;
            // 
            // pbOldhide
            // 
            pbOldhide.Image = (Image)resources.GetObject("pbOldhide.Image");
            pbOldhide.Location = new Point(265, 20);
            pbOldhide.Name = "pbOldhide";
            pbOldhide.Size = new Size(32, 27);
            pbOldhide.SizeMode = PictureBoxSizeMode.Zoom;
            pbOldhide.TabIndex = 4;
            pbOldhide.TabStop = false;
            pbOldhide.Click += pbOldhide_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(12, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 17);
            label1.TabIndex = 4;
            label1.Text = "Nhập Mật Khẩu Cũ";
            // 
            // panel2
            // 
            panel2.Controls.Add(pbNewview1);
            panel2.Controls.Add(txbNewpass1);
            panel2.Controls.Add(pbNewhide1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(63, 157);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 54);
            panel2.TabIndex = 6;
            // 
            // pbNewview1
            // 
            pbNewview1.Image = (Image)resources.GetObject("pbNewview1.Image");
            pbNewview1.Location = new Point(265, 20);
            pbNewview1.Name = "pbNewview1";
            pbNewview1.Size = new Size(32, 27);
            pbNewview1.SizeMode = PictureBoxSizeMode.Zoom;
            pbNewview1.TabIndex = 5;
            pbNewview1.TabStop = false;
            pbNewview1.Click += pbNewview1_Click;
            // 
            // txbNewpass1
            // 
            txbNewpass1.Location = new Point(12, 20);
            txbNewpass1.Name = "txbNewpass1";
            txbNewpass1.Size = new Size(250, 27);
            txbNewpass1.TabIndex = 2;
            txbNewpass1.UseSystemPasswordChar = true;
            // 
            // pbNewhide1
            // 
            pbNewhide1.Image = (Image)resources.GetObject("pbNewhide1.Image");
            pbNewhide1.Location = new Point(265, 20);
            pbNewhide1.Name = "pbNewhide1";
            pbNewhide1.Size = new Size(32, 27);
            pbNewhide1.SizeMode = PictureBoxSizeMode.Zoom;
            pbNewhide1.TabIndex = 4;
            pbNewhide1.TabStop = false;
            pbNewhide1.Click += pbNewhide1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(12, 0);
            label2.Name = "label2";
            label2.Size = new Size(170, 17);
            label2.TabIndex = 4;
            label2.Text = "Nhập Mật Khẩu Mới (lần 1)";
            // 
            // panel3
            // 
            panel3.Controls.Add(pbNewview2);
            panel3.Controls.Add(txbNewpass2);
            panel3.Controls.Add(pbNewhide2);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(63, 217);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 54);
            panel3.TabIndex = 7;
            // 
            // pbNewview2
            // 
            pbNewview2.Image = (Image)resources.GetObject("pbNewview2.Image");
            pbNewview2.Location = new Point(265, 20);
            pbNewview2.Name = "pbNewview2";
            pbNewview2.Size = new Size(32, 27);
            pbNewview2.SizeMode = PictureBoxSizeMode.Zoom;
            pbNewview2.TabIndex = 5;
            pbNewview2.TabStop = false;
            pbNewview2.Click += pbNewview2_Click;
            // 
            // txbNewpass2
            // 
            txbNewpass2.Location = new Point(12, 20);
            txbNewpass2.Name = "txbNewpass2";
            txbNewpass2.Size = new Size(250, 27);
            txbNewpass2.TabIndex = 3;
            txbNewpass2.UseSystemPasswordChar = true;
            // 
            // pbNewhide2
            // 
            pbNewhide2.Image = (Image)resources.GetObject("pbNewhide2.Image");
            pbNewhide2.Location = new Point(265, 20);
            pbNewhide2.Name = "pbNewhide2";
            pbNewhide2.Size = new Size(32, 27);
            pbNewhide2.SizeMode = PictureBoxSizeMode.Zoom;
            pbNewhide2.TabIndex = 4;
            pbNewhide2.TabStop = false;
            pbNewhide2.Click += pbNewhide2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(12, 0);
            label3.Name = "label3";
            label3.Size = new Size(172, 17);
            label3.TabIndex = 4;
            label3.Text = "Nhập Mật Khẩu Mới (lần 2)";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnSendotp);
            panel4.Controls.Add(txbEmail);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(63, 277);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 54);
            panel4.TabIndex = 8;
            // 
            // btnSendotp
            // 
            btnSendotp.BackColor = SystemColors.Window;
            btnSendotp.ForeColor = SystemColors.Highlight;
            btnSendotp.Location = new Point(215, 18);
            btnSendotp.Name = "btnSendotp";
            btnSendotp.Size = new Size(85, 29);
            btnSendotp.TabIndex = 5;
            btnSendotp.Text = "Nhận OTP";
            btnSendotp.UseVisualStyleBackColor = false;
            btnSendotp.Click += btnSendotp_Click;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(12, 20);
            txbEmail.Name = "txbEmail";
            txbEmail.ReadOnly = true;
            txbEmail.Size = new Size(197, 27);
            txbEmail.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(12, 0);
            label4.Name = "label4";
            label4.Size = new Size(230, 17);
            label4.TabIndex = 4;
            label4.Text = "Nhập Email đang dùng để nhận OTP";
            // 
            // panel5
            // 
            panel5.Controls.Add(txbOTP);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(63, 337);
            panel5.Name = "panel5";
            panel5.Size = new Size(300, 54);
            panel5.TabIndex = 10;
            // 
            // txbOTP
            // 
            txbOTP.Location = new Point(12, 20);
            txbOTP.Name = "txbOTP";
            txbOTP.Size = new Size(197, 27);
            txbOTP.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(12, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 17);
            label5.TabIndex = 4;
            label5.Text = "Nhập OTP";
            // 
            // cbAgree
            // 
            cbAgree.AutoSize = true;
            cbAgree.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            cbAgree.ForeColor = SystemColors.Highlight;
            cbAgree.Location = new Point(75, 397);
            cbAgree.Name = "cbAgree";
            cbAgree.Size = new Size(196, 21);
            cbAgree.TabIndex = 7;
            cbAgree.Text = "Tôi Xác Nhận Đổi Mật Khẩu";
            cbAgree.UseVisualStyleBackColor = true;
            // 
            // btnUpdatepass
            // 
            btnUpdatepass.BackColor = SystemColors.Window;
            btnUpdatepass.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdatepass.ForeColor = SystemColors.Highlight;
            btnUpdatepass.Location = new Point(138, 450);
            btnUpdatepass.Name = "btnUpdatepass";
            btnUpdatepass.Size = new Size(167, 52);
            btnUpdatepass.TabIndex = 12;
            btnUpdatepass.Text = "Đổi Mật Khẩu";
            btnUpdatepass.UseVisualStyleBackColor = false;
            btnUpdatepass.Click += btnUpdatepass_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-12, 508);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(363, 229);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // labelInforPass
            // 
            labelInforPass.AutoSize = true;
            labelInforPass.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelInforPass.ForeColor = SystemColors.Highlight;
            labelInforPass.Location = new Point(148, 703);
            labelInforPass.Name = "labelInforPass";
            labelInforPass.Size = new Size(177, 17);
            labelInforPass.TabIndex = 14;
            labelInforPass.Text = "Ấn vào [ ĐÂY ] để tìm hiểu !";
            labelInforPass.Click += labelInforPass_Click;
            // 
            // fPassnew
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(427, 729);
            ControlBox = false;
            Controls.Add(labelInforPass);
            Controls.Add(pictureBox2);
            Controls.Add(btnUpdatepass);
            Controls.Add(cbAgree);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(pbBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fPassnew";
            StartPosition = FormStartPosition.CenterScreen;
            Load += fPassnew_Load;
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbOldview).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOldhide).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbNewview1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNewhide1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbNewview2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNewhide2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbBack;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox txbOldPass;
        private Label label1;
        private PictureBox pbOldhide;
        private PictureBox pbOldview;
        private Panel panel2;
        private TextBox txbNewpass1;
        private PictureBox pbNewhide1;
        private Label label2;
        private PictureBox pbNewview1;
        private Panel panel3;
        private PictureBox pbNewview2;
        private TextBox txbNewpass2;
        private PictureBox pbNewhide2;
        private Label label3;
        private Panel panel4;
        private TextBox txbEmail;
        private Label label4;
        private Button btnSendotp;
        private Panel panel5;
        private TextBox txbOTP;
        private Label label5;
        private CheckBox cbAgree;
        private Button btnUpdatepass;
        private PictureBox pictureBox2;
        private Label labelInforPass;
    }
}