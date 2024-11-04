namespace Mini_Banking
{
    partial class fWithMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fWithMoney));
            pbBack = new PictureBox();
            tcWithmoney = new TabControl();
            tLivebank = new TabPage();
            pbView1 = new PictureBox();
            pbHide1 = new PictureBox();
            txbPassword1 = new TextBox();
            label5 = new Label();
            btnOk = new Button();
            label1 = new Label();
            txbNumwmoney = new TextBox();
            pictureBox2 = new PictureBox();
            pbQR = new PictureBox();
            pictureBox1 = new PictureBox();
            tSaveInter = new TabPage();
            groupBox1 = new GroupBox();
            ckbBalance = new RadioButton();
            ckbFaceMoney = new RadioButton();
            pbQRcode = new PictureBox();
            pictureBox4 = new PictureBox();
            btnWithMoneySav = new Button();
            pbView = new PictureBox();
            pbHide = new PictureBox();
            txbPassword = new TextBox();
            label4 = new Label();
            txbMoney = new TextBox();
            label3 = new Label();
            cbxSavingsBook = new ComboBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            tcWithmoney.SuspendLayout();
            tLivebank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHide1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tSaveInter.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbQRcode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pbBack
            // 
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(394, 12);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(24, 26);
            pbBack.SizeMode = PictureBoxSizeMode.Zoom;
            pbBack.TabIndex = 2;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // tcWithmoney
            // 
            tcWithmoney.Controls.Add(tLivebank);
            tcWithmoney.Controls.Add(tSaveInter);
            tcWithmoney.Location = new Point(0, 37);
            tcWithmoney.Name = "tcWithmoney";
            tcWithmoney.SelectedIndex = 0;
            tcWithmoney.Size = new Size(434, 704);
            tcWithmoney.TabIndex = 3;
            // 
            // tLivebank
            // 
            tLivebank.Controls.Add(pbView1);
            tLivebank.Controls.Add(pbHide1);
            tLivebank.Controls.Add(txbPassword1);
            tLivebank.Controls.Add(label5);
            tLivebank.Controls.Add(btnOk);
            tLivebank.Controls.Add(label1);
            tLivebank.Controls.Add(txbNumwmoney);
            tLivebank.Controls.Add(pictureBox2);
            tLivebank.Controls.Add(pbQR);
            tLivebank.Controls.Add(pictureBox1);
            tLivebank.Location = new Point(4, 29);
            tLivebank.Name = "tLivebank";
            tLivebank.Padding = new Padding(3);
            tLivebank.Size = new Size(426, 671);
            tLivebank.TabIndex = 0;
            tLivebank.Text = "Rút Tiền Mặt Tại LiveBank";
            tLivebank.UseVisualStyleBackColor = true;
            // 
            // pbView1
            // 
            pbView1.Image = (Image)resources.GetObject("pbView1.Image");
            pbView1.Location = new Point(341, 536);
            pbView1.Name = "pbView1";
            pbView1.Size = new Size(31, 25);
            pbView1.SizeMode = PictureBoxSizeMode.Zoom;
            pbView1.TabIndex = 12;
            pbView1.TabStop = false;
            pbView1.Click += pbView1_Click;
            // 
            // pbHide1
            // 
            pbHide1.Image = (Image)resources.GetObject("pbHide1.Image");
            pbHide1.Location = new Point(341, 536);
            pbHide1.Name = "pbHide1";
            pbHide1.Size = new Size(31, 25);
            pbHide1.SizeMode = PictureBoxSizeMode.Zoom;
            pbHide1.TabIndex = 11;
            pbHide1.TabStop = false;
            pbHide1.Click += pbHide1_Click;
            // 
            // txbPassword1
            // 
            txbPassword1.Location = new Point(45, 534);
            txbPassword1.Name = "txbPassword1";
            txbPassword1.Size = new Size(288, 27);
            txbPassword1.TabIndex = 4;
            txbPassword1.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(45, 514);
            label5.Name = "label5";
            label5.Size = new Size(187, 17);
            label5.TabIndex = 7;
            label5.Text = "Nhập Mật Khẩu Để Xác Minh:";
            // 
            // btnOk
            // 
            btnOk.BackColor = SystemColors.Window;
            btnOk.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnOk.ForeColor = SystemColors.Highlight;
            btnOk.Location = new Point(119, 567);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(168, 50);
            btnOk.TabIndex = 6;
            btnOk.Text = "Xác Nhận Rút Tiền";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(45, 464);
            label1.Name = "label1";
            label1.Size = new Size(157, 17);
            label1.TabIndex = 4;
            label1.Text = "Nhập Số Tiền Muốn Rút:";
            // 
            // txbNumwmoney
            // 
            txbNumwmoney.Location = new Point(45, 484);
            txbNumwmoney.Name = "txbNumwmoney";
            txbNumwmoney.Size = new Size(327, 27);
            txbNumwmoney.TabIndex = 3;
            txbNumwmoney.TextAlign = HorizontalAlignment.Right;
            txbNumwmoney.TextChanged += txbNumwmoney_TextChanged;
            txbNumwmoney.KeyPress += Onlynum_KeyPress;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, 439);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(408, 195);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pbQR
            // 
            pbQR.Image = (Image)resources.GetObject("pbQR.Image");
            pbQR.Location = new Point(45, 41);
            pbQR.Name = "pbQR";
            pbQR.Size = new Size(327, 330);
            pbQR.SizeMode = PictureBoxSizeMode.Zoom;
            pbQR.TabIndex = 1;
            pbQR.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(414, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tSaveInter
            // 
            tSaveInter.Controls.Add(groupBox1);
            tSaveInter.Location = new Point(4, 29);
            tSaveInter.Name = "tSaveInter";
            tSaveInter.Padding = new Padding(3);
            tSaveInter.Size = new Size(426, 671);
            tSaveInter.TabIndex = 1;
            tSaveInter.Text = "Rút Tiền Từ Sổ Tiết Kiệm";
            tSaveInter.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ckbBalance);
            groupBox1.Controls.Add(ckbFaceMoney);
            groupBox1.Controls.Add(pbQRcode);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(btnWithMoneySav);
            groupBox1.Controls.Add(pbView);
            groupBox1.Controls.Add(pbHide);
            groupBox1.Controls.Add(txbPassword);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txbMoney);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbxSavingsBook);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.Highlight;
            groupBox1.Location = new Point(8, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(406, 649);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // ckbBalance
            // 
            ckbBalance.AutoSize = true;
            ckbBalance.Location = new Point(60, 173);
            ckbBalance.Name = "ckbBalance";
            ckbBalance.Size = new Size(200, 21);
            ckbBalance.TabIndex = 15;
            ckbBalance.TabStop = true;
            ckbBalance.Text = "Rút Tiền Về Tài Khoản Chính";
            ckbBalance.UseVisualStyleBackColor = true;
            ckbBalance.CheckedChanged += ckbBalance_CheckedChanged;
            // 
            // ckbFaceMoney
            // 
            ckbFaceMoney.AutoSize = true;
            ckbFaceMoney.Location = new Point(60, 146);
            ckbFaceMoney.Name = "ckbFaceMoney";
            ckbFaceMoney.Size = new Size(185, 21);
            ckbFaceMoney.TabIndex = 14;
            ckbFaceMoney.TabStop = true;
            ckbFaceMoney.Text = "Rút Tiền Mặt Tại LiveBank";
            ckbFaceMoney.UseVisualStyleBackColor = true;
            ckbFaceMoney.CheckedChanged += ckbFaceMoney_CheckedChanged;
            // 
            // pbQRcode
            // 
            pbQRcode.Image = (Image)resources.GetObject("pbQRcode.Image");
            pbQRcode.Location = new Point(81, 382);
            pbQRcode.Name = "pbQRcode";
            pbQRcode.Size = new Size(234, 230);
            pbQRcode.SizeMode = PictureBoxSizeMode.Zoom;
            pbQRcode.TabIndex = 13;
            pbQRcode.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(41, 353);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(317, 290);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // btnWithMoneySav
            // 
            btnWithMoneySav.BackColor = SystemColors.Window;
            btnWithMoneySav.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnWithMoneySav.Location = new Point(111, 286);
            btnWithMoneySav.Name = "btnWithMoneySav";
            btnWithMoneySav.Size = new Size(180, 61);
            btnWithMoneySav.TabIndex = 11;
            btnWithMoneySav.Text = "Xác Nhận Rút Tiền";
            btnWithMoneySav.UseVisualStyleBackColor = false;
            btnWithMoneySav.Click += btnWithMoneySav_Click;
            // 
            // pbView
            // 
            pbView.Image = (Image)resources.GetObject("pbView.Image");
            pbView.Location = new Point(314, 225);
            pbView.Name = "pbView";
            pbView.Size = new Size(31, 25);
            pbView.SizeMode = PictureBoxSizeMode.Zoom;
            pbView.TabIndex = 10;
            pbView.TabStop = false;
            pbView.Click += pbView_Click;
            // 
            // pbHide
            // 
            pbHide.Image = (Image)resources.GetObject("pbHide.Image");
            pbHide.Location = new Point(314, 225);
            pbHide.Name = "pbHide";
            pbHide.Size = new Size(31, 25);
            pbHide.SizeMode = PictureBoxSizeMode.Zoom;
            pbHide.TabIndex = 9;
            pbHide.TabStop = false;
            pbHide.Click += pbHide_Click;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(60, 225);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(248, 25);
            txbPassword.TabIndex = 8;
            txbPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 205);
            label4.Name = "label4";
            label4.Size = new Size(186, 17);
            label4.TabIndex = 7;
            label4.Text = "Nhập Mật Khẩu Để Xác Nhận";
            // 
            // txbMoney
            // 
            txbMoney.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txbMoney.Location = new Point(60, 113);
            txbMoney.Name = "txbMoney";
            txbMoney.Size = new Size(285, 27);
            txbMoney.TabIndex = 4;
            txbMoney.TextAlign = HorizontalAlignment.Right;
            txbMoney.TextChanged += txbMoney_TextChanged;
            txbMoney.KeyPress += Onlynum_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 93);
            label3.Name = "label3";
            label3.Size = new Size(154, 17);
            label3.TabIndex = 3;
            label3.Text = "Nhập Số Tiền Muốn Rút";
            // 
            // cbxSavingsBook
            // 
            cbxSavingsBook.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbxSavingsBook.FormattingEnabled = true;
            cbxSavingsBook.Location = new Point(60, 56);
            cbxSavingsBook.Name = "cbxSavingsBook";
            cbxSavingsBook.Size = new Size(285, 28);
            cbxSavingsBook.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 36);
            label2.Name = "label2";
            label2.Size = new Size(119, 17);
            label2.TabIndex = 1;
            label2.Text = "Chọn Sổ Tiết Kiệm";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(6, 24);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(394, 247);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // fWithMoney
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(430, 736);
            ControlBox = false;
            Controls.Add(tcWithmoney);
            Controls.Add(pbBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fWithMoney";
            StartPosition = FormStartPosition.CenterScreen;
            Load += fWithMoney_Load;
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            tcWithmoney.ResumeLayout(false);
            tLivebank.ResumeLayout(false);
            tLivebank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHide1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbQR).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tSaveInter.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbQRcode).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbBack;
        private TabControl tcWithmoney;
        private TabPage tLivebank;
        private TabPage tSaveInter;
        private PictureBox pbQR;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txbNumwmoney;
        private Label label1;
        private Button btnOk;
        private GroupBox groupBox1;
        private PictureBox pictureBox3;
        private ComboBox cbxSavingsBook;
        private Label label2;
        private Label label3;
        private TextBox txbMoney;
        private TextBox txbPassword;
        private Label label4;
        private PictureBox pbHide;
        private PictureBox pbView;
        private Button btnWithMoneySav;
        private PictureBox pictureBox4;
        private PictureBox pbQRcode;
        private TextBox txbPassword1;
        private Label label5;
        private PictureBox pbView1;
        private PictureBox pbHide1;
        private RadioButton ckbBalance;
        private RadioButton ckbFaceMoney;
    }
}