namespace Mini_Banking
{
    partial class fFeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fFeedback));
            pbBack = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            txbNameF = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            txbEmailF = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txbContentF = new TextBox();
            label3 = new Label();
            btnSendF = new Button();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pbBack
            // 
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(386, 12);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(32, 35);
            pbBack.SizeMode = PictureBoxSizeMode.Zoom;
            pbBack.TabIndex = 1;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(406, 395);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-7, 522);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(341, 216);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(txbNameF);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(58, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 51);
            panel1.TabIndex = 4;
            // 
            // txbNameF
            // 
            txbNameF.Location = new Point(3, 20);
            txbNameF.Name = "txbNameF";
            txbNameF.Size = new Size(318, 27);
            txbNameF.TabIndex = 1;
            txbNameF.KeyPress += Onlystring_KeyPress;
            txbNameF.Leave += txbEmailF_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 17);
            label1.TabIndex = 5;
            label1.Text = "Nhập Tên";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbEmailF);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(58, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(324, 51);
            panel2.TabIndex = 6;
            // 
            // txbEmailF
            // 
            txbEmailF.Location = new Point(3, 20);
            txbEmailF.Name = "txbEmailF";
            txbEmailF.Size = new Size(318, 27);
            txbEmailF.TabIndex = 2;
            txbEmailF.Leave += txbEmailF_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 5;
            label2.Text = "Nhập Email";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbContentF);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(58, 185);
            panel3.Name = "panel3";
            panel3.Size = new Size(324, 215);
            panel3.TabIndex = 7;
            // 
            // txbContentF
            // 
            txbContentF.Location = new Point(3, 20);
            txbContentF.Multiline = true;
            txbContentF.Name = "txbContentF";
            txbContentF.Size = new Size(318, 192);
            txbContentF.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(164, 17);
            label3.TabIndex = 5;
            label3.Text = "Nhập Phản Hồi Đánh Giá ";
            // 
            // btnSendF
            // 
            btnSendF.BackColor = SystemColors.Window;
            btnSendF.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSendF.ForeColor = SystemColors.Highlight;
            btnSendF.Location = new Point(138, 456);
            btnSendF.Name = "btnSendF";
            btnSendF.Size = new Size(171, 60);
            btnSendF.TabIndex = 4;
            btnSendF.Text = "Gửi Phản Hồi";
            btnSendF.UseVisualStyleBackColor = false;
            btnSendF.Click += btnSendF_Click;
            // 
            // fFeedback
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(430, 732);
            ControlBox = false;
            Controls.Add(btnSendF);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pbBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fFeedback";
            StartPosition = FormStartPosition.CenterScreen;
            Load += fFeedback_Load;
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbBack;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private TextBox txbNameF;
        private Label label1;
        private Panel panel2;
        private TextBox txbEmailF;
        private Label label2;
        private Panel panel3;
        private TextBox txbContentF;
        private Label label3;
        private Button btnSendF;
    }
}