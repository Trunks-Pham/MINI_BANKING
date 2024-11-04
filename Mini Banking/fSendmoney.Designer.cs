namespace Mini_Banking
{
    partial class fSendmoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSendmoney));
            pbBack = new PictureBox();
            tSendmoney = new TabControl();
            tabPage1 = new TabPage();
            pbSearchInfor = new PictureBox();
            rdbQR1 = new RadioButton();
            rdbNumAcc1 = new RadioButton();
            pbQR1 = new PictureBox();
            pictureBox4 = new PictureBox();
            txbMoney1 = new TextBox();
            label9 = new Label();
            btnSendmoney = new Button();
            pbView = new PictureBox();
            pbHide = new PictureBox();
            txbPassword = new TextBox();
            label5 = new Label();
            txbContent = new TextBox();
            label4 = new Label();
            txbNameUser = new TextBox();
            label3 = new Label();
            txbNumAccount = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txbBankName = new TextBox();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            pbSearchName = new PictureBox();
            txbUserName = new TextBox();
            labelUseName = new Label();
            rdbNumAcc = new RadioButton();
            rdbQR = new RadioButton();
            pbQRcode = new PictureBox();
            pictureBox3 = new PictureBox();
            btnSendOK = new Button();
            txbNumAcc = new TextBox();
            label8 = new Label();
            txbMoney = new TextBox();
            label7 = new Label();
            cbxJar = new ComboBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            tSendmoney.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearchInfor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQR1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearchName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQRcode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pbBack
            // 
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(393, 12);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(25, 30);
            pbBack.SizeMode = PictureBoxSizeMode.Zoom;
            pbBack.TabIndex = 1;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // tSendmoney
            // 
            tSendmoney.Controls.Add(tabPage1);
            tSendmoney.Controls.Add(tabPage2);
            tSendmoney.Location = new Point(1, 37);
            tSendmoney.Name = "tSendmoney";
            tSendmoney.SelectedIndex = 0;
            tSendmoney.Size = new Size(427, 691);
            tSendmoney.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pbSearchInfor);
            tabPage1.Controls.Add(rdbQR1);
            tabPage1.Controls.Add(rdbNumAcc1);
            tabPage1.Controls.Add(pbQR1);
            tabPage1.Controls.Add(pictureBox4);
            tabPage1.Controls.Add(txbMoney1);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(btnSendmoney);
            tabPage1.Controls.Add(pbView);
            tabPage1.Controls.Add(pbHide);
            tabPage1.Controls.Add(txbPassword);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txbContent);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txbNameUser);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txbNumAccount);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txbBankName);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage1.ForeColor = SystemColors.Highlight;
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(419, 658);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sử Dụng Tài Khoản Chính";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pbSearchInfor
            // 
            pbSearchInfor.Cursor = Cursors.Hand;
            pbSearchInfor.Image = (Image)resources.GetObject("pbSearchInfor.Image");
            pbSearchInfor.Location = new Point(320, 90);
            pbSearchInfor.Name = "pbSearchInfor";
            pbSearchInfor.Size = new Size(29, 25);
            pbSearchInfor.SizeMode = PictureBoxSizeMode.Zoom;
            pbSearchInfor.TabIndex = 3;
            pbSearchInfor.TabStop = false;
            pbSearchInfor.Click += pbSearchInfor_Click;
            // 
            // rdbQR1
            // 
            rdbQR1.AutoSize = true;
            rdbQR1.Location = new Point(233, 353);
            rdbQR1.Name = "rdbQR1";
            rdbQR1.Size = new Size(147, 21);
            rdbQR1.TabIndex = 7;
            rdbQR1.TabStop = true;
            rdbQR1.Text = "Chuyển qua mã QR";
            rdbQR1.UseVisualStyleBackColor = true;
            rdbQR1.CheckedChanged += rdbQR1_CheckedChanged;
            // 
            // rdbNumAcc1
            // 
            rdbNumAcc1.AutoSize = true;
            rdbNumAcc1.Location = new Point(64, 353);
            rdbNumAcc1.Name = "rdbNumAcc1";
            rdbNumAcc1.Size = new Size(163, 21);
            rdbNumAcc1.TabIndex = 6;
            rdbNumAcc1.TabStop = true;
            rdbNumAcc1.Text = "Chuyển qua tài khoản";
            rdbNumAcc1.UseVisualStyleBackColor = true;
            rdbNumAcc1.CheckedChanged += rdbNumAcc1_CheckedChanged;
            // 
            // pbQR1
            // 
            pbQR1.Image = (Image)resources.GetObject("pbQR1.Image");
            pbQR1.Location = new Point(152, 510);
            pbQR1.Name = "pbQR1";
            pbQR1.Size = new Size(116, 115);
            pbQR1.SizeMode = PictureBoxSizeMode.Zoom;
            pbQR1.TabIndex = 18;
            pbQR1.TabStop = false;
            pbQR1.Visible = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(124, 496);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(173, 142);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // txbMoney1
            // 
            txbMoney1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txbMoney1.Location = new Point(64, 194);
            txbMoney1.Name = "txbMoney1";
            txbMoney1.Size = new Size(284, 27);
            txbMoney1.TabIndex = 4;
            txbMoney1.TextAlign = HorizontalAlignment.Right;
            txbMoney1.TextChanged += txbMoney1_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(64, 174);
            label9.Name = "label9";
            label9.Size = new Size(92, 17);
            label9.TabIndex = 16;
            label9.Text = "Nhập Số Tiền:";
            // 
            // btnSendmoney
            // 
            btnSendmoney.BackColor = SystemColors.Window;
            btnSendmoney.Enabled = false;
            btnSendmoney.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSendmoney.Location = new Point(124, 439);
            btnSendmoney.Name = "btnSendmoney";
            btnSendmoney.Size = new Size(173, 51);
            btnSendmoney.TabIndex = 9;
            btnSendmoney.Text = "Xác Nhận Chuyển Tiền";
            btnSendmoney.UseVisualStyleBackColor = false;
            btnSendmoney.Click += btnSendmoney_Click;
            // 
            // pbView
            // 
            pbView.Image = (Image)resources.GetObject("pbView.Image");
            pbView.Location = new Point(319, 408);
            pbView.Name = "pbView";
            pbView.Size = new Size(29, 25);
            pbView.SizeMode = PictureBoxSizeMode.Zoom;
            pbView.TabIndex = 13;
            pbView.TabStop = false;
            pbView.Click += pbView_Click;
            // 
            // pbHide
            // 
            pbHide.Image = (Image)resources.GetObject("pbHide.Image");
            pbHide.Location = new Point(319, 408);
            pbHide.Name = "pbHide";
            pbHide.Size = new Size(29, 25);
            pbHide.SizeMode = PictureBoxSizeMode.Zoom;
            pbHide.TabIndex = 12;
            pbHide.TabStop = false;
            pbHide.Click += pbHide_Click;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(64, 408);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(249, 25);
            txbPassword.TabIndex = 8;
            txbPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 388);
            label5.Name = "label5";
            label5.Size = new Size(107, 17);
            label5.TabIndex = 10;
            label5.Text = "Nhập Mật Khẩu:";
            // 
            // txbContent
            // 
            txbContent.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txbContent.ForeColor = SystemColors.ScrollBar;
            txbContent.Location = new Point(64, 242);
            txbContent.Multiline = true;
            txbContent.Name = "txbContent";
            txbContent.Size = new Size(284, 105);
            txbContent.TabIndex = 5;
            txbContent.Text = "Giao dịch chuyển tiền";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 222);
            label4.Name = "label4";
            label4.Size = new Size(185, 17);
            label4.TabIndex = 7;
            label4.Text = "Nhập Nội Dung Chuyển Tiền:";
            // 
            // txbNameUser
            // 
            txbNameUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txbNameUser.Location = new Point(64, 137);
            txbNameUser.Name = "txbNameUser";
            txbNameUser.Size = new Size(284, 27);
            txbNameUser.TabIndex = 3;
            txbNameUser.KeyPress += Onlystring_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 117);
            label3.Name = "label3";
            label3.Size = new Size(147, 17);
            label3.TabIndex = 5;
            label3.Text = "Nhập Tên Người Nhận:";
            // 
            // txbNumAccount
            // 
            txbNumAccount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txbNumAccount.Location = new Point(64, 89);
            txbNumAccount.Name = "txbNumAccount";
            txbNumAccount.Size = new Size(249, 27);
            txbNumAccount.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 69);
            label2.Name = "label2";
            label2.Size = new Size(126, 17);
            label2.TabIndex = 3;
            label2.Text = "Nhập Số Tài Khoản:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 21);
            label1.Name = "label1";
            label1.Size = new Size(143, 17);
            label1.TabIndex = 2;
            label1.Text = "Nhập Tên Ngân Hàng:";
            // 
            // txbBankName
            // 
            txbBankName.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txbBankName.ForeColor = SystemColors.ScrollBar;
            txbBankName.Location = new Point(64, 41);
            txbBankName.Name = "txbBankName";
            txbBankName.Size = new Size(284, 25);
            txbBankName.TabIndex = 1;
            txbBankName.Text = "Mini Bank";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(424, 655);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pbSearchName);
            tabPage2.Controls.Add(txbUserName);
            tabPage2.Controls.Add(labelUseName);
            tabPage2.Controls.Add(rdbNumAcc);
            tabPage2.Controls.Add(rdbQR);
            tabPage2.Controls.Add(pbQRcode);
            tabPage2.Controls.Add(pictureBox3);
            tabPage2.Controls.Add(btnSendOK);
            tabPage2.Controls.Add(txbNumAcc);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(txbMoney);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(cbxJar);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage2.ForeColor = SystemColors.Highlight;
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(419, 658);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sử Dụng Hũ Chi Tiêu";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pbSearchName
            // 
            pbSearchName.Cursor = Cursors.Hand;
            pbSearchName.Image = (Image)resources.GetObject("pbSearchName.Image");
            pbSearchName.Location = new Point(328, 239);
            pbSearchName.Name = "pbSearchName";
            pbSearchName.Size = new Size(29, 25);
            pbSearchName.SizeMode = PictureBoxSizeMode.Zoom;
            pbSearchName.TabIndex = 16;
            pbSearchName.TabStop = false;
            // 
            // txbUserName
            // 
            txbUserName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txbUserName.Location = new Point(75, 289);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(247, 27);
            txbUserName.TabIndex = 15;
            // 
            // labelUseName
            // 
            labelUseName.AutoSize = true;
            labelUseName.Location = new Point(75, 269);
            labelUseName.Name = "labelUseName";
            labelUseName.Size = new Size(107, 17);
            labelUseName.TabIndex = 14;
            labelUseName.Text = "Tên Người Nhận";
            // 
            // rdbNumAcc
            // 
            rdbNumAcc.AutoSize = true;
            rdbNumAcc.Location = new Point(75, 175);
            rdbNumAcc.Name = "rdbNumAcc";
            rdbNumAcc.Size = new Size(214, 21);
            rdbNumAcc.TabIndex = 13;
            rdbNumAcc.TabStop = true;
            rdbNumAcc.Text = "Chuyển Tiền Đến Số Tài Khoản";
            rdbNumAcc.UseVisualStyleBackColor = true;
            rdbNumAcc.CheckedChanged += rdbNumAcc_CheckedChanged;
            // 
            // rdbQR
            // 
            rdbQR.AutoSize = true;
            rdbQR.Location = new Point(75, 148);
            rdbQR.Name = "rdbQR";
            rdbQR.Size = new Size(228, 21);
            rdbQR.TabIndex = 12;
            rdbQR.TabStop = true;
            rdbQR.Text = "Sử Dụng Bằng Cách Quét Mã QR";
            rdbQR.UseVisualStyleBackColor = true;
            rdbQR.CheckedChanged += rdbQR_CheckedChanged;
            // 
            // pbQRcode
            // 
            pbQRcode.Image = (Image)resources.GetObject("pbQRcode.Image");
            pbQRcode.Location = new Point(116, 448);
            pbQRcode.Name = "pbQRcode";
            pbQRcode.Size = new Size(183, 180);
            pbQRcode.SizeMode = PictureBoxSizeMode.Zoom;
            pbQRcode.TabIndex = 11;
            pbQRcode.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(95, 425);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(227, 227);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // btnSendOK
            // 
            btnSendOK.BackColor = SystemColors.Window;
            btnSendOK.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSendOK.Location = new Point(116, 336);
            btnSendOK.Name = "btnSendOK";
            btnSendOK.Size = new Size(174, 64);
            btnSendOK.TabIndex = 9;
            btnSendOK.Text = "Xác Nhận Giao Dịch";
            btnSendOK.UseVisualStyleBackColor = false;
            btnSendOK.Click += btnSendOK_Click;
            // 
            // txbNumAcc
            // 
            txbNumAcc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txbNumAcc.Location = new Point(75, 239);
            txbNumAcc.Name = "txbNumAcc";
            txbNumAcc.Size = new Size(247, 27);
            txbNumAcc.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(75, 219);
            label8.Name = "label8";
            label8.Size = new Size(200, 17);
            label8.TabIndex = 7;
            label8.Text = "Nhập Số Tài Khoản Cần Chuyển";
            // 
            // txbMoney
            // 
            txbMoney.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txbMoney.Location = new Point(75, 115);
            txbMoney.Name = "txbMoney";
            txbMoney.RightToLeft = RightToLeft.Yes;
            txbMoney.Size = new Size(260, 27);
            txbMoney.TabIndex = 4;
            txbMoney.TextAlign = HorizontalAlignment.Right;
            txbMoney.TextChanged += txbMoney_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(75, 95);
            label7.Name = "label7";
            label7.Size = new Size(89, 17);
            label7.TabIndex = 3;
            label7.Text = "Nhập Số Tiền";
            // 
            // cbxJar
            // 
            cbxJar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbxJar.FormattingEnabled = true;
            cbxJar.Location = new Point(75, 55);
            cbxJar.Name = "cbxJar";
            cbxJar.Size = new Size(260, 28);
            cbxJar.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 35);
            label6.Name = "label6";
            label6.Size = new Size(114, 17);
            label6.TabIndex = 1;
            label6.Text = "Chọn Hũ Chi Tiêu";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(7, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(406, 402);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // fSendmoney
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(430, 731);
            ControlBox = false;
            Controls.Add(tSendmoney);
            Controls.Add(pbBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fSendmoney";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            tSendmoney.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearchInfor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbQR1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearchName).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbQRcode).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbBack;
        private TabControl tSendmoney;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PictureBox pictureBox1;
        private TextBox txbBankName;
        private Label label1;
        private Label label2;
        private TextBox txbNumAccount;
        private Label label3;
        private TextBox txbNameUser;
        private Label label4;
        private TextBox txbContent;
        private Label label5;
        private TextBox txbPassword;
        private PictureBox pbHide;
        private PictureBox pbView;
        private PictureBox pictureBox2;
        private ComboBox cbxJar;
        private Label label6;
        private Label label7;
        private TextBox txbMoney;
        private TextBox txbNumAcc;
        private Label label8;
        private Button btnSendOK;
        private PictureBox pictureBox3;
        private PictureBox pbQRcode;
        private Button btnSendmoney;
        private Label label9;
        private TextBox txbMoney1;
        private PictureBox pictureBox4;
        private PictureBox pbQR1;
        private RadioButton rdbQR1;
        private RadioButton rdbNumAcc1;
        private RadioButton rdbNumAcc;
        private RadioButton rdbQR;
        private PictureBox pbSearchInfor;
        private Label labelUseName;
        private PictureBox pbSearchName;
        private TextBox txbUserName;
    }
}