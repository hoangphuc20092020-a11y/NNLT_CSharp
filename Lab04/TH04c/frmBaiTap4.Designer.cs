namespace TH04c
{
    partial class frmBaiTap4
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
            lblNDSVTT = new Label();
            lblNhapSo = new Label();
            lblDayVuaNhap = new Label();
            lblTCPTTD = new Label();
            lblTongChan = new Label();
            lblTongLe = new Label();
            txtDayVuaNhap = new TextBox();
            txtNhapSo = new TextBox();
            txtTCPTTD = new TextBox();
            txtTongLe = new TextBox();
            txtTongChan = new TextBox();
            btnTiepTuc = new Button();
            btnThoat = new Button();
            btnNhap = new Button();
            SuspendLayout();
            // 
            // lblNDSVTT
            // 
            lblNDSVTT.AutoSize = true;
            lblNDSVTT.Location = new Point(178, 31);
            lblNDSVTT.Name = "lblNDSVTT";
            lblNDSVTT.Size = new Size(177, 20);
            lblNDSVTT.TabIndex = 0;
            lblNDSVTT.Text = "Nhập Dãy số và tính tổng";
            // 
            // lblNhapSo
            // 
            lblNhapSo.AutoSize = true;
            lblNhapSo.Location = new Point(143, 80);
            lblNhapSo.Name = "lblNhapSo";
            lblNhapSo.Size = new Size(67, 20);
            lblNhapSo.TabIndex = 1;
            lblNhapSo.Text = "Nhập số:";
            // 
            // lblDayVuaNhap
            // 
            lblDayVuaNhap.AutoSize = true;
            lblDayVuaNhap.Location = new Point(143, 118);
            lblDayVuaNhap.Name = "lblDayVuaNhap";
            lblDayVuaNhap.Size = new Size(100, 20);
            lblDayVuaNhap.TabIndex = 2;
            lblDayVuaNhap.Text = "Dãy vừa nhập";
            // 
            // lblTCPTTD
            // 
            lblTCPTTD.AutoSize = true;
            lblTCPTTD.Location = new Point(143, 160);
            lblTCPTTD.Name = "lblTCPTTD";
            lblTCPTTD.Size = new Size(192, 20);
            lblTCPTTD.TabIndex = 3;
            lblTCPTTD.Text = "Tổng các phần tử trong dãy";
            // 
            // lblTongChan
            // 
            lblTongChan.AutoSize = true;
            lblTongChan.Location = new Point(143, 195);
            lblTongChan.Name = "lblTongChan";
            lblTongChan.Size = new Size(75, 20);
            lblTongChan.TabIndex = 4;
            lblTongChan.Text = "tổng chẵn";
            // 
            // lblTongLe
            // 
            lblTongLe.AutoSize = true;
            lblTongLe.Location = new Point(290, 195);
            lblTongLe.Name = "lblTongLe";
            lblTongLe.Size = new Size(59, 20);
            lblTongLe.TabIndex = 5;
            lblTongLe.Text = "Tổng lẻ";
            // 
            // txtDayVuaNhap
            // 
            txtDayVuaNhap.Location = new Point(249, 110);
            txtDayVuaNhap.Name = "txtDayVuaNhap";
            txtDayVuaNhap.Size = new Size(148, 27);
            txtDayVuaNhap.TabIndex = 6;
            // 
            // txtNhapSo
            // 
            txtNhapSo.Location = new Point(249, 77);
            txtNhapSo.Name = "txtNhapSo";
            txtNhapSo.Size = new Size(71, 27);
            txtNhapSo.TabIndex = 7;
            // 
            // txtTCPTTD
            // 
            txtTCPTTD.Location = new Point(341, 153);
            txtTCPTTD.Name = "txtTCPTTD";
            txtTCPTTD.Size = new Size(56, 27);
            txtTCPTTD.TabIndex = 8;
            // 
            // txtTongLe
            // 
            txtTongLe.Location = new Point(355, 192);
            txtTongLe.Name = "txtTongLe";
            txtTongLe.Size = new Size(42, 27);
            txtTongLe.TabIndex = 9;
            // 
            // txtTongChan
            // 
            txtTongChan.Location = new Point(223, 192);
            txtTongChan.Name = "txtTongChan";
            txtTongChan.Size = new Size(47, 27);
            txtTongChan.TabIndex = 10;
            // 
            // btnTiepTuc
            // 
            btnTiepTuc.Location = new Point(166, 239);
            btnTiepTuc.Name = "btnTiepTuc";
            btnTiepTuc.Size = new Size(94, 29);
            btnTiepTuc.TabIndex = 11;
            btnTiepTuc.Text = "Tiếp Tục";
            btnTiepTuc.UseVisualStyleBackColor = true;
            btnTiepTuc.Click += btnTiepTuc_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(290, 239);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(326, 77);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(71, 29);
            btnNhap.TabIndex = 13;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // frmBaiTap4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 333);
            Controls.Add(btnNhap);
            Controls.Add(btnThoat);
            Controls.Add(btnTiepTuc);
            Controls.Add(txtTongChan);
            Controls.Add(txtTongLe);
            Controls.Add(txtTCPTTD);
            Controls.Add(txtNhapSo);
            Controls.Add(txtDayVuaNhap);
            Controls.Add(lblTongLe);
            Controls.Add(lblTongChan);
            Controls.Add(lblTCPTTD);
            Controls.Add(lblDayVuaNhap);
            Controls.Add(lblNhapSo);
            Controls.Add(lblNDSVTT);
            Name = "frmBaiTap4";
            Text = "frmBaiTap4";
            FormClosing += frmBaiTap4_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNDSVTT;
        private Label lblNhapSo;
        private Label lblDayVuaNhap;
        private Label lblTCPTTD;
        private Label lblTongChan;
        private Label lblTongLe;
        private TextBox txtDayVuaNhap;
        private TextBox txtNhapSo;
        private TextBox txtTCPTTD;
        private TextBox txtTongLe;
        private TextBox txtTongChan;
        private Button btnTiepTuc;
        private Button btnThoat;
        private Button btnNhap;
    }
}