namespace Mini_Banking
{
    partial class fReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fReport));
            pbBack = new PictureBox();
            tcReport = new TabControl();
            tabPage1 = new TabPage();
            btnOK = new Button();
            dtpTo = new DateTimePicker();
            label2 = new Label();
            dtpFrom = new DateTimePicker();
            label1 = new Label();
            dgvReport = new DataGridView();
            tabPage2 = new TabPage();
            btnOutputJar = new Button();
            dgvJar = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            dtpOut = new DateTimePicker();
            dtpIn = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            tcReport.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJar).BeginInit();
            SuspendLayout();
            // 
            // pbBack
            // 
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(393, 12);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(25, 32);
            pbBack.SizeMode = PictureBoxSizeMode.Zoom;
            pbBack.TabIndex = 1;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // tcReport
            // 
            tcReport.Controls.Add(tabPage1);
            tcReport.Controls.Add(tabPage2);
            tcReport.Location = new Point(2, 39);
            tcReport.Name = "tcReport";
            tcReport.SelectedIndex = 0;
            tcReport.Size = new Size(427, 688);
            tcReport.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnOK);
            tabPage1.Controls.Add(dtpTo);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(dtpFrom);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dgvReport);
            tabPage1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.ForeColor = SystemColors.Highlight;
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(419, 655);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Phân Tích Thu Chi";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.BackColor = SystemColors.HighlightText;
            btnOK.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOK.ForeColor = SystemColors.Highlight;
            btnOK.Location = new Point(339, 6);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(73, 60);
            btnOK.TabIndex = 5;
            btnOK.Text = "Xuất";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(83, 39);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(250, 27);
            dtpTo.TabIndex = 4;
            dtpTo.ValueChanged += btnOK_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(6, 46);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 3;
            label2.Text = "Đến Ngày:";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(83, 6);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(250, 27);
            dtpFrom.TabIndex = 2;
            dtpFrom.ValueChanged += btnOK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(6, 13);
            label1.Name = "label1";
            label1.Size = new Size(62, 17);
            label1.TabIndex = 1;
            label1.Text = "Từ Ngày:";
            // 
            // dgvReport
            // 
            dgvReport.BackgroundColor = SystemColors.Window;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(3, 72);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 51;
            dgvReport.RowTemplate.Height = 29;
            dgvReport.Size = new Size(413, 576);
            dgvReport.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnOutputJar);
            tabPage2.Controls.Add(dgvJar);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(dtpOut);
            tabPage2.Controls.Add(dtpIn);
            tabPage2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage2.ForeColor = SystemColors.Highlight;
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(419, 655);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Giao Dịch Hủ Chi Tiêu";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnOutputJar
            // 
            btnOutputJar.BackColor = SystemColors.Window;
            btnOutputJar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOutputJar.Location = new Point(330, 18);
            btnOutputJar.Name = "btnOutputJar";
            btnOutputJar.Size = new Size(82, 56);
            btnOutputJar.TabIndex = 5;
            btnOutputJar.Text = "Xuất";
            btnOutputJar.UseVisualStyleBackColor = false;
            // 
            // dgvJar
            // 
            dgvJar.BackgroundColor = SystemColors.Window;
            dgvJar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJar.Location = new Point(3, 80);
            dgvJar.Name = "dgvJar";
            dgvJar.RowHeadersWidth = 51;
            dgvJar.RowTemplate.Height = 29;
            dgvJar.Size = new Size(409, 572);
            dgvJar.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 55);
            label4.Name = "label4";
            label4.Size = new Size(71, 17);
            label4.TabIndex = 3;
            label4.Text = "Đến Ngày:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 26);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 2;
            label3.Text = "Từ Ngày:";
            // 
            // dtpOut
            // 
            dtpOut.Location = new Point(74, 49);
            dtpOut.Name = "dtpOut";
            dtpOut.Size = new Size(250, 27);
            dtpOut.TabIndex = 1;
            // 
            // dtpIn
            // 
            dtpIn.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpIn.Location = new Point(74, 18);
            dtpIn.Name = "dtpIn";
            dtpIn.Size = new Size(250, 27);
            dtpIn.TabIndex = 0;
            // 
            // fReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(430, 728);
            ControlBox = false;
            Controls.Add(tcReport);
            Controls.Add(pbBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fReport";
            StartPosition = FormStartPosition.CenterScreen;
            Load += fReport_Load;
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            tcReport.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbBack;
        private TabControl tcReport;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvReport;
        private DateTimePicker dtpFrom;
        private Label label1;
        private DateTimePicker dtpTo;
        private Label label2;
        private Button btnOK;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpOut;
        private DateTimePicker dtpIn;
        private DataGridView dgvJar;
        private Button btnOutputJar;
    }
}