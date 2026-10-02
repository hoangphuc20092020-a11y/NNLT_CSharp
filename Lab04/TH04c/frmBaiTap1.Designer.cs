namespace TH04c
{
    partial class frmBaiTap1
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
            components = new System.ComponentModel.Container();
            lblA = new Label();
            lblB = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            lblKetQua = new Label();
            txtKetQua = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(30, 48);
            lblA.Name = "lblA";
            lblA.Size = new Size(46, 20);
            lblA.TabIndex = 0;
            lblA.Text = "số a=";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(212, 41);
            lblB.Name = "lblB";
            lblB.Size = new Size(49, 20);
            lblB.TabIndex = 1;
            lblB.Text = "Số b=";
            // 
            // txtA
            // 
            txtA.Location = new Point(82, 41);
            txtA.Name = "txtA";
            txtA.Size = new Size(108, 27);
            txtA.TabIndex = 2;
            // 
            // txtB
            // 
            txtB.Location = new Point(251, 41);
            txtB.Name = "txtB";
            txtB.Size = new Size(119, 27);
            txtB.TabIndex = 3;
            // 
            // btnCong
            // 
            btnCong.Location = new Point(12, 113);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(94, 29);
            btnCong.TabIndex = 4;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // btnTru
            // 
            btnTru.Location = new Point(112, 113);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(94, 29);
            btnTru.TabIndex = 5;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            // 
            // btnNhan
            // 
            btnNhan.Location = new Point(212, 113);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(94, 29);
            btnNhan.TabIndex = 6;
            btnNhan.Text = "x";
            btnNhan.UseVisualStyleBackColor = true;
            // 
            // btnChia
            // 
            btnChia.Location = new Point(312, 113);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(94, 29);
            btnChia.TabIndex = 7;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Location = new Point(16, 77);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(60, 20);
            lblKetQua.TabIndex = 8;
            lblKetQua.Text = "Kết quả";
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(82, 77);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(288, 27);
            txtKetQua.TabIndex = 9;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmBaiTap1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 305);
            Controls.Add(txtKetQua);
            Controls.Add(lblKetQua);
            Controls.Add(btnChia);
            Controls.Add(btnNhan);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Name = "frmBaiTap1";
            Text = "frmBaiTap1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblA;
        private Label lblB;
        private TextBox txtA;
        private TextBox txtB;
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
        private Label lblKetQua;
        private TextBox txtKetQua;
        private ErrorProvider errorProvider1;
    }
}