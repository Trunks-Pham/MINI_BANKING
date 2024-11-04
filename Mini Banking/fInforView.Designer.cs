namespace Mini_Banking
{
    partial class fInforView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fInforView));
            pictureBox2 = new PictureBox();
            pbBack = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            labelName = new Label();
            label3 = new Label();
            labelUsername = new Label();
            label4 = new Label();
            labelId = new Label();
            label5 = new Label();
            labelEmail = new Label();
            label6 = new Label();
            labelNumphone = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            labelDateOfBirth = new Label();
            labelGender = new Label();
            labelAddress = new Label();
            label7 = new Label();
            labelAccNum = new Label();
            pbCopyNum = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCopyNum).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-2, 535);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(433, 199);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pbBack
            // 
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(387, 12);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(30, 35);
            pbBack.SizeMode = PictureBoxSizeMode.Zoom;
            pbBack.TabIndex = 2;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(105, 69);
            label1.Name = "label1";
            label1.Size = new Size(244, 24);
            label1.TabIndex = 3;
            label1.Text = "Thông Tin Khách Hàng";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(405, 408);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 123);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 5;
            label2.Text = "Tên Khách Hàng: ";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(170, 123);
            labelName.Name = "labelName";
            labelName.Size = new Size(109, 20);
            labelName.TabIndex = 6;
            labelName.Text = "[ Hiển Thị Tên ]";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 196);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 7;
            label3.Text = "Tên Đăng Nhập:";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(170, 196);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(189, 20);
            labelUsername.TabIndex = 8;
            labelUsername.Text = "[ Hiển Thị Tên Đăng Nhập ]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 233);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 9;
            label4.Text = "Số CCCD:";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(170, 233);
            labelId.Name = "labelId";
            labelId.Size = new Size(145, 20);
            labelId.TabIndex = 10;
            labelId.Text = "[ Hiển Thị Số CCCD ]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 273);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 11;
            label5.Text = "Email Cá Nhân:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(170, 273);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(123, 20);
            labelEmail.TabIndex = 12;
            labelEmail.Text = "[ Hiển Thị Email ]";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 314);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 13;
            label6.Text = "Số Điện Thoại:";
            // 
            // labelNumphone
            // 
            labelNumphone.AutoSize = true;
            labelNumphone.Location = new Point(170, 314);
            labelNumphone.Name = "labelNumphone";
            labelNumphone.Size = new Size(179, 20);
            labelNumphone.TabIndex = 14;
            labelNumphone.Text = "[ Hiển Thị Số Điện Thoại ]";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 391);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 15;
            label8.Text = "Giới Tính:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 351);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 16;
            label9.Text = "Ngày Sinh:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(41, 426);
            label10.Name = "label10";
            label10.Size = new Size(119, 20);
            label10.TabIndex = 17;
            label10.Text = "Địa Chỉ Hiện Tại:";
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Location = new Point(170, 351);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(153, 20);
            labelDateOfBirth.TabIndex = 18;
            labelDateOfBirth.Text = "[ Hiển Thị Ngày Sinh ]";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Location = new Point(170, 391);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(145, 20);
            labelGender.TabIndex = 19;
            labelGender.Text = "[ Hiển Thị Giới Tính ]";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(170, 426);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(193, 20);
            labelAddress.TabIndex = 20;
            labelAddress.Text = "[ Hiển Thị Địa Chỉ Hiện Tại ]";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 160);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 21;
            label7.Text = "Số Tài Khoản:";
            // 
            // labelAccNum
            // 
            labelAccNum.AutoSize = true;
            labelAccNum.Location = new Point(170, 160);
            labelAccNum.Name = "labelAccNum";
            labelAccNum.Size = new Size(112, 20);
            labelAccNum.TabIndex = 22;
            labelAccNum.Text = "[ Số Tài Khoản ]";
            // 
            // pbCopyNum
            // 
            pbCopyNum.Image = (Image)resources.GetObject("pbCopyNum.Image");
            pbCopyNum.Location = new Point(368, 155);
            pbCopyNum.Name = "pbCopyNum";
            pbCopyNum.Size = new Size(20, 25);
            pbCopyNum.SizeMode = PictureBoxSizeMode.Zoom;
            pbCopyNum.TabIndex = 23;
            pbCopyNum.TabStop = false;
            pbCopyNum.Click += pbCopyNum_Click;
            // 
            // fInforView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(429, 731);
            ControlBox = false;
            Controls.Add(pbCopyNum);
            Controls.Add(labelAccNum);
            Controls.Add(label7);
            Controls.Add(labelAddress);
            Controls.Add(labelGender);
            Controls.Add(labelDateOfBirth);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(labelNumphone);
            Controls.Add(label6);
            Controls.Add(labelEmail);
            Controls.Add(label5);
            Controls.Add(labelId);
            Controls.Add(label4);
            Controls.Add(labelUsername);
            Controls.Add(label3);
            Controls.Add(labelName);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pbBack);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fInforView";
            StartPosition = FormStartPosition.CenterScreen;
            Load += fInforView_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCopyNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private PictureBox pbBack;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label labelName;
        private Label label3;
        private Label labelUsername;
        private Label label4;
        private Label labelId;
        private Label label5;
        private Label labelEmail;
        private Label label6;
        private Label labelNumphone;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label labelDateOfBirth;
        private Label labelGender;
        private Label labelAddress;
        private Label label7;
        private Label labelAccNum;
        private PictureBox pbCopyNum;
    }
}