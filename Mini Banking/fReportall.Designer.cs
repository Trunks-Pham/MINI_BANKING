namespace Mini_Banking
{
    partial class fReportall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fReportall));
            pbBack = new PictureBox();
            groupBox1 = new GroupBox();
            dgvReportall = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pbBack).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportall).BeginInit();
            SuspendLayout();
            // 
            // pbBack
            // 
            pbBack.Image = (Image)resources.GetObject("pbBack.Image");
            pbBack.Location = new Point(390, 12);
            pbBack.Name = "pbBack";
            pbBack.Size = new Size(29, 30);
            pbBack.SizeMode = PictureBoxSizeMode.Zoom;
            pbBack.TabIndex = 1;
            pbBack.TabStop = false;
            pbBack.Click += pbBack_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvReportall);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.Highlight;
            groupBox1.Location = new Point(0, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(431, 693);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Báo Cáo Thu Chi Tổng Hợp";
            // 
            // dgvReportall
            // 
            dgvReportall.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvReportall.BackgroundColor = SystemColors.Window;
            dgvReportall.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportall.Location = new Point(6, 24);
            dgvReportall.Name = "dgvReportall";
            dgvReportall.RowHeadersWidth = 51;
            dgvReportall.RowTemplate.Height = 29;
            dgvReportall.Size = new Size(419, 658);
            dgvReportall.TabIndex = 0;
            // 
            // fReportall
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(431, 730);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(pbBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fReportall";
            StartPosition = FormStartPosition.CenterScreen;
            Load += fReportall_Load;
            ((System.ComponentModel.ISupportInitialize)pbBack).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReportall).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbBack;
        private GroupBox groupBox1;
        private DataGridView dgvReportall;
    }
}