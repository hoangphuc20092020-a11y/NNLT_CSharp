namespace TH04c
{
    partial class frmBaiTap3
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
            lblUocBoi = new Label();
            lblA = new Label();
            lblB = new Label();
            lblBCNN = new Label();
            lblUCLN = new Label();
            btnTiepTuc = new Button();
            btnThucHien = new Button();
            txtUCLN = new TextBox();
            txtBCNN = new TextBox();
            txtA = new TextBox();
            txtB = new TextBox();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lblUocBoi
            // 
            lblUocBoi.AutoSize = true;
            lblUocBoi.Location = new Point(40, 31);
            lblUocBoi.Name = "lblUocBoi";
            lblUocBoi.Size = new Size(200, 20);
            lblUocBoi.TabIndex = 0;
            lblUocBoi.Text = "Ước số Chung - Bôi số chung";
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(13, 103);
            lblA.Name = "lblA";
            lblA.Size = new Size(79, 20);
            lblA.TabIndex = 1;
            lblA.Text = "Nhập số a:";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(12, 149);
            lblB.Name = "lblB";
            lblB.Size = new Size(80, 20);
            lblB.TabIndex = 2;
            lblB.Text = "Nhập số b:";
            // 
            // lblBCNN
            // 
            lblBCNN.AutoSize = true;
            lblBCNN.Location = new Point(12, 239);
            lblBCNN.Name = "lblBCNN";
            lblBCNN.Size = new Size(137, 20);
            lblBCNN.TabIndex = 3;
            lblBCNN.Text = "Bội chung nhỏ nhất";
            // 
            // lblUCLN
            // 
            lblUCLN.AutoSize = true;
            lblUCLN.Location = new Point(12, 200);
            lblUCLN.Name = "lblUCLN";
            lblUCLN.Size = new Size(138, 20);
            lblUCLN.TabIndex = 4;
            lblUCLN.Text = "Ước chung lớn nhất";
            // 
            // btnTiepTuc
            // 
            btnTiepTuc.Location = new Point(128, 290);
            btnTiepTuc.Name = "btnTiepTuc";
            btnTiepTuc.Size = new Size(94, 29);
            btnTiepTuc.TabIndex = 5;
            btnTiepTuc.Text = "Tiếp tục";
            btnTiepTuc.UseVisualStyleBackColor = true;
            btnTiepTuc.Click += btnTiepTuc_Click;
            // 
            // btnThucHien
            // 
            btnThucHien.Location = new Point(13, 290);
            btnThucHien.Name = "btnThucHien";
            btnThucHien.Size = new Size(94, 29);
            btnThucHien.TabIndex = 6;
            btnThucHien.Text = "Thực hiện";
            btnThucHien.UseVisualStyleBackColor = true;
            btnThucHien.Click += btnThucHien_Click;
            // 
            // txtUCLN
            // 
            txtUCLN.Location = new Point(161, 193);
            txtUCLN.Name = "txtUCLN";
            txtUCLN.Size = new Size(125, 27);
            txtUCLN.TabIndex = 7;
            // 
            // txtBCNN
            // 
            txtBCNN.Location = new Point(161, 232);
            txtBCNN.Name = "txtBCNN";
            txtBCNN.Size = new Size(125, 27);
            txtBCNN.TabIndex = 8;
            // 
            // txtA
            // 
            txtA.Location = new Point(161, 103);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 27);
            txtA.TabIndex = 9;
            // 
            // txtB
            // 
            txtB.Location = new Point(161, 142);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 27);
            txtB.TabIndex = 10;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(242, 290);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmBaiTap3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 379);
            Controls.Add(btnThoat);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(txtBCNN);
            Controls.Add(txtUCLN);
            Controls.Add(btnThucHien);
            Controls.Add(btnTiepTuc);
            Controls.Add(lblUCLN);
            Controls.Add(lblBCNN);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(lblUocBoi);
            Name = "frmBaiTap3";
            Text = "frmBaiTap3";
            FormClosing += frmBaiTap3_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUocBoi;
        private Label lblA;
        private Label lblB;
        private Label lblBCNN;
        private Label lblUCLN;
        private Button btnTiepTuc;
        private Button btnThucHien;
        private TextBox txtUCLN;
        private TextBox txtBCNN;
        private TextBox txtA;
        private TextBox txtB;
        private Button btnThoat;
    }
}