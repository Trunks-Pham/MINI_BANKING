namespace Mini_Banking
{
    partial class fSiginIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSiginIn));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            txbUserName = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            pbView = new PictureBox();
            pbHide = new PictureBox();
            txbPassword = new TextBox();
            label2 = new Label();
            btnSignin = new Button();
            panel3 = new Panel();
            btnExit = new Button();
            btnSignup = new Button();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHide).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 533);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(432, 209);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(402, 119);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(txbUserName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(30, 225);
            panel1.Name = "panel1";
            panel1.Size = new Size(351, 49);
            panel1.TabIndex = 1;
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(30, 20);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(290, 27);
            txbUserName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(30, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 17);
            label1.TabIndex = 3;
            label1.Text = "Tên Đăng Nhập:";
            // 
            // panel2
            // 
            panel2.Controls.Add(pbView);
            panel2.Controls.Add(pbHide);
            panel2.Controls.Add(txbPassword);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(30, 280);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 52);
            panel2.TabIndex = 2;
            // 
            // pbView
            // 
            pbView.Image = (Image)resources.GetObject("pbView.Image");
            pbView.Location = new Point(326, 20);
            pbView.Name = "pbView";
            pbView.Size = new Size(35, 27);
            pbView.SizeMode = PictureBoxSizeMode.Zoom;
            pbView.TabIndex = 8;
            pbView.TabStop = false;
            pbView.Click += pbView_Click;
            // 
            // pbHide
            // 
            pbHide.Image = (Image)resources.GetObject("pbHide.Image");
            pbHide.Location = new Point(326, 20);
            pbHide.Name = "pbHide";
            pbHide.Size = new Size(35, 27);
            pbHide.SizeMode = PictureBoxSizeMode.Zoom;
            pbHide.TabIndex = 7;
            pbHide.TabStop = false;
            pbHide.Click += pbHide_Click;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(30, 20);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(290, 27);
            txbPassword.TabIndex = 4;
            txbPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(30, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 3;
            label2.Text = "Mật Khẩu:";
            // 
            // btnSignin
            // 
            btnSignin.BackColor = SystemColors.Window;
            btnSignin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignin.ForeColor = SystemColors.Highlight;
            btnSignin.Location = new Point(60, 367);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(290, 57);
            btnSignin.TabIndex = 3;
            btnSignin.Text = "Đăng Nhập";
            btnSignin.UseVisualStyleBackColor = false;
            btnSignin.Click += btnSignin_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnExit);
            panel3.Controls.Add(btnSignup);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(43, 430);
            panel3.Name = "panel3";
            panel3.Size = new Size(325, 97);
            panel3.TabIndex = 4;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.Window;
            btnExit.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.Highlight;
            btnExit.Location = new Point(196, 56);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(111, 37);
            btnExit.TabIndex = 10;
            btnExit.Text = "Thoát\r\n";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = SystemColors.Window;
            btnSignup.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignup.ForeColor = SystemColors.Highlight;
            btnSignup.Location = new Point(196, 12);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(111, 38);
            btnSignup.TabIndex = 8;
            btnSignup.Text = "Đăng Ký Ngay";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(38, 23);
            label3.Name = "label3";
            label3.Size = new Size(152, 17);
            label3.TabIndex = 7;
            label3.Text = "Bạn chưa có tài khoản ?";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-930, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(314, 140);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // fSiginIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(430, 734);
            ControlBox = false;
            Controls.Add(pictureBox3);
            Controls.Add(panel3);
            Controls.Add(btnSignin);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fSiginIn";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += fSiginIn_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHide).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private TextBox txbUserName;
        private Label label1;
        private Panel panel2;
        private TextBox txbPassword;
        private Label label2;
        private Button btnSignin;
        private Panel panel3;
        private Label label3;
        private Button btnExit;
        private Button btnSignup;
        private PictureBox pbHide;
        private PictureBox pbView;
        private PictureBox pictureBox3;
    }
}