namespace TH04c
{
    partial class frmBaiTap5
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
            lblDSTC = new Label();
            lblNhapDaySo = new Label();
            txtThanhChu = new TextBox();
            txtNhapDaySo = new TextBox();
            btnThucHien = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lblDSTC
            // 
            lblDSTC.AutoSize = true;
            lblDSTC.Location = new Point(168, 36);
            lblDSTC.Name = "lblDSTC";
            lblDSTC.Size = new Size(131, 20);
            lblDSTC.TabIndex = 0;
            lblDSTC.Text = "Đọc Số Thành Chữ";
            // 
            // lblNhapDaySo
            // 
            lblNhapDaySo.AutoSize = true;
            lblNhapDaySo.Location = new Point(107, 93);
            lblNhapDaySo.Name = "lblNhapDaySo";
            lblNhapDaySo.Size = new Size(192, 20);
            lblNhapDaySo.TabIndex = 1;
            lblNhapDaySo.Text = "Nhập dãy số: (từ 1 dến 999)";
            // 
            // txtThanhChu
            // 
            txtThanhChu.Location = new Point(103, 227);
            txtThanhChu.Name = "txtThanhChu";
            txtThanhChu.Size = new Size(335, 27);
            txtThanhChu.TabIndex = 2;
            // 
            // txtNhapDaySo
            // 
            txtNhapDaySo.Location = new Point(305, 90);
            txtNhapDaySo.Name = "txtNhapDaySo";
            txtNhapDaySo.Size = new Size(133, 27);
            txtNhapDaySo.TabIndex = 3;
            // 
            // btnThucHien
            // 
            btnThucHien.Location = new Point(103, 153);
            btnThucHien.Name = "btnThucHien";
            btnThucHien.Size = new Size(94, 29);
            btnThucHien.TabIndex = 4;
            btnThucHien.Text = "Thực Hiện";
            btnThucHien.UseVisualStyleBackColor = true;
            btnThucHien.Click += btnThucHien_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(203, 153);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(122, 34);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(344, 156);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmBaiTap5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 345);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnThucHien);
            Controls.Add(txtNhapDaySo);
            Controls.Add(txtThanhChu);
            Controls.Add(lblNhapDaySo);
            Controls.Add(lblDSTC);
            Name = "frmBaiTap5";
            Text = "frmBaiTap5";
            FormClosing += frmBaiTap5_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDSTC;
        private Label lblNhapDaySo;
        private TextBox txtThanhChu;
        private TextBox txtNhapDaySo;
        private Button btnThucHien;
        private Button btnXoa;
        private Button button3;
        private Button btnThoat;
    }
}