namespace TH04d
{
    partial class frmBaiTap2
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
            lblMSN = new Label();
            btnReset = new Button();
            btnNhapMang = new Button();
            txtNhapMang = new TextBox();
            btnKetQuaMang = new Button();
            btnThoat = new Button();
            txtKetQuaMang = new TextBox();
            btnThucHien = new Button();
            grpSapXep = new GroupBox();
            rdoXapXepGiam = new RadioButton();
            rdoXapXepTang = new RadioButton();
            grpTimKiem = new GroupBox();
            txtTGTCT = new TextBox();
            txtSTDL = new TextBox();
            lblSTDL = new Label();
            txtTVTCT = new TextBox();
            rdoTVTCT = new RadioButton();
            rdoTGTCT = new RadioButton();
            grpXoa = new GroupBox();
            txtTGTCX = new TextBox();
            lblCSXT = new Label();
            txtTVTCX = new TextBox();
            rdoTVTCX = new RadioButton();
            rdoTGTCX = new RadioButton();
            grpThem = new GroupBox();
            lblTVTCT = new Label();
            txtTGTCTH = new TextBox();
            lblCSXT1 = new Label();
            txtTVTCTH = new TextBox();
            rdoTimGiaTriCanThem = new RadioButton();
            grpTong = new GroupBox();
            btnTong = new Button();
            lblTongMang = new Label();
            txtTongLe = new TextBox();
            lblTongChan = new Label();
            txtTongMang = new TextBox();
            lblTongLe = new Label();
            txtTongChan = new TextBox();
            grpMaxMin = new GroupBox();
            txtGTLN = new TextBox();
            btnTim = new Button();
            lblGTLN = new Label();
            lblGTNN = new Label();
            txtGTNN = new TextBox();
            grpThayThe = new GroupBox();
            txtGTCTT = new TextBox();
            txtSTTL = new TextBox();
            lblSTTL = new Label();
            txtVTCTT = new TextBox();
            rdoVTCTT = new RadioButton();
            rdoGTCTT = new RadioButton();
            grpSapXep.SuspendLayout();
            grpTimKiem.SuspendLayout();
            grpXoa.SuspendLayout();
            grpThem.SuspendLayout();
            grpTong.SuspendLayout();
            grpMaxMin.SuspendLayout();
            grpThayThe.SuspendLayout();
            SuspendLayout();
            // 
            // lblMSN
            // 
            lblMSN.AutoSize = true;
            lblMSN.Location = new Point(244, 23);
            lblMSN.Name = "lblMSN";
            lblMSN.Size = new Size(123, 20);
            lblMSN.TabIndex = 1;
            lblMSN.Text = "Mảng Số Nguyên";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(442, 72);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnNhapMang
            // 
            btnNhapMang.Location = new Point(28, 70);
            btnNhapMang.Name = "btnNhapMang";
            btnNhapMang.Size = new Size(118, 29);
            btnNhapMang.TabIndex = 3;
            btnNhapMang.Text = "Nhập mảng";
            btnNhapMang.UseVisualStyleBackColor = true;
            btnNhapMang.Click += btnNhapMang_Click;
            // 
            // txtNhapMang
            // 
            txtNhapMang.Location = new Point(162, 72);
            txtNhapMang.Name = "txtNhapMang";
            txtNhapMang.Size = new Size(274, 27);
            txtNhapMang.TabIndex = 4;
            // 
            // btnKetQuaMang
            // 
            btnKetQuaMang.Location = new Point(28, 103);
            btnKetQuaMang.Name = "btnKetQuaMang";
            btnKetQuaMang.Size = new Size(118, 29);
            btnKetQuaMang.TabIndex = 5;
            btnKetQuaMang.Text = "Kết quả Mảng";
            btnKetQuaMang.UseVisualStyleBackColor = true;
            btnKetQuaMang.Click += btnKetQuaMang_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(442, 107);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtKetQuaMang
            // 
            txtKetQuaMang.Location = new Point(162, 105);
            txtKetQuaMang.Name = "txtKetQuaMang";
            txtKetQuaMang.Size = new Size(274, 27);
            txtKetQuaMang.TabIndex = 7;
            // 
            // btnThucHien
            // 
            btnThucHien.Location = new Point(28, 150);
            btnThucHien.Name = "btnThucHien";
            btnThucHien.Size = new Size(118, 61);
            btnThucHien.TabIndex = 8;
            btnThucHien.Text = "Thực Hiện";
            btnThucHien.UseVisualStyleBackColor = true;
            btnThucHien.Click += btnThucHien_Click;
            // 
            // grpSapXep
            // 
            grpSapXep.Controls.Add(rdoXapXepGiam);
            grpSapXep.Controls.Add(rdoXapXepTang);
            grpSapXep.Location = new Point(162, 150);
            grpSapXep.Name = "grpSapXep";
            grpSapXep.Size = new Size(374, 61);
            grpSapXep.TabIndex = 9;
            grpSapXep.TabStop = false;
            grpSapXep.Text = "Sắp Xếp";
            // 
            // rdoXapXepGiam
            // 
            rdoXapXepGiam.AutoSize = true;
            rdoXapXepGiam.Location = new Point(211, 26);
            rdoXapXepGiam.Name = "rdoXapXepGiam";
            rdoXapXepGiam.Size = new Size(121, 24);
            rdoXapXepGiam.TabIndex = 11;
            rdoXapXepGiam.TabStop = true;
            rdoXapXepGiam.Text = "Sắp xếp giảm";
            rdoXapXepGiam.UseVisualStyleBackColor = true;
            // 
            // rdoXapXepTang
            // 
            rdoXapXepTang.AutoSize = true;
            rdoXapXepTang.Location = new Point(16, 26);
            rdoXapXepTang.Name = "rdoXapXepTang";
            rdoXapXepTang.Size = new Size(117, 24);
            rdoXapXepTang.TabIndex = 10;
            rdoXapXepTang.TabStop = true;
            rdoXapXepTang.Text = "Sắp xếp tăng";
            rdoXapXepTang.UseVisualStyleBackColor = true;
            // 
            // grpTimKiem
            // 
            grpTimKiem.Controls.Add(txtTGTCT);
            grpTimKiem.Controls.Add(txtSTDL);
            grpTimKiem.Controls.Add(lblSTDL);
            grpTimKiem.Controls.Add(txtTVTCT);
            grpTimKiem.Controls.Add(rdoTVTCT);
            grpTimKiem.Controls.Add(rdoTGTCT);
            grpTimKiem.Location = new Point(28, 217);
            grpTimKiem.Name = "grpTimKiem";
            grpTimKiem.Size = new Size(224, 114);
            grpTimKiem.TabIndex = 10;
            grpTimKiem.TabStop = false;
            grpTimKiem.Text = "Tìm Kiếm";
            // 
            // txtTGTCT
            // 
            txtTGTCT.Location = new Point(173, 23);
            txtTGTCT.Name = "txtTGTCT";
            txtTGTCT.Size = new Size(37, 27);
            txtTGTCT.TabIndex = 17;
            // 
            // txtSTDL
            // 
            txtSTDL.Location = new Point(172, 82);
            txtSTDL.Name = "txtSTDL";
            txtSTDL.Size = new Size(37, 27);
            txtSTDL.TabIndex = 15;
            // 
            // lblSTDL
            // 
            lblSTDL.AutoSize = true;
            lblSTDL.Location = new Point(20, 82);
            lblSTDL.Name = "lblSTDL";
            lblSTDL.Size = new Size(104, 20);
            lblSTDL.TabIndex = 11;
            lblSTDL.Text = "số tìm đươc là";
            // 
            // txtTVTCT
            // 
            txtTVTCT.Location = new Point(172, 53);
            txtTVTCT.Name = "txtTVTCT";
            txtTVTCT.Size = new Size(38, 27);
            txtTVTCT.TabIndex = 14;
            // 
            // rdoTVTCT
            // 
            rdoTVTCT.AutoSize = true;
            rdoTVTCT.Location = new Point(20, 56);
            rdoTVTCT.Name = "rdoTVTCT";
            rdoTVTCT.Size = new Size(147, 24);
            rdoTVTCT.TabIndex = 12;
            rdoTVTCT.TabStop = true;
            rdoTVTCT.Text = "Tìm vị Trí cần tìm ";
            rdoTVTCT.UseVisualStyleBackColor = true;
            // 
            // rdoTGTCT
            // 
            rdoTGTCT.AutoSize = true;
            rdoTGTCT.Location = new Point(20, 26);
            rdoTGTCT.Name = "rdoTGTCT";
            rdoTGTCT.Size = new Size(148, 24);
            rdoTGTCT.TabIndex = 10;
            rdoTGTCT.TabStop = true;
            rdoTGTCT.Text = "tìm giá trị cần tìm";
            rdoTGTCT.UseVisualStyleBackColor = true;
            // 
            // grpXoa
            // 
            grpXoa.Controls.Add(txtTGTCX);
            grpXoa.Controls.Add(lblCSXT);
            grpXoa.Controls.Add(txtTVTCX);
            grpXoa.Controls.Add(rdoTVTCX);
            grpXoa.Controls.Add(rdoTGTCX);
            grpXoa.Location = new Point(312, 217);
            grpXoa.Name = "grpXoa";
            grpXoa.Size = new Size(224, 114);
            grpXoa.TabIndex = 17;
            grpXoa.TabStop = false;
            grpXoa.Text = "Xóa";
            // 
            // txtTGTCX
            // 
            txtTGTCX.Location = new Point(173, 23);
            txtTGTCX.Name = "txtTGTCX";
            txtTGTCX.Size = new Size(37, 27);
            txtTGTCX.TabIndex = 17;
            // 
            // lblCSXT
            // 
            lblCSXT.AutoSize = true;
            lblCSXT.Location = new Point(47, 83);
            lblCSXT.Name = "lblCSXT";
            lblCSXT.Size = new Size(123, 20);
            lblCSXT.TabIndex = 11;
            lblCSXT.Text = "Cần sắp xếp tăng";
            // 
            // txtTVTCX
            // 
            txtTVTCX.Location = new Point(172, 53);
            txtTVTCX.Name = "txtTVTCX";
            txtTVTCX.Size = new Size(38, 27);
            txtTVTCX.TabIndex = 14;
            // 
            // rdoTVTCX
            // 
            rdoTVTCX.AutoSize = true;
            rdoTVTCX.Location = new Point(20, 56);
            rdoTVTCX.Name = "rdoTVTCX";
            rdoTVTCX.Size = new Size(145, 24);
            rdoTVTCX.TabIndex = 12;
            rdoTVTCX.TabStop = true;
            rdoTVTCX.Text = "Tìm vị Trí cần xóa";
            rdoTVTCX.UseVisualStyleBackColor = true;
            // 
            // rdoTGTCX
            // 
            rdoTGTCX.AutoSize = true;
            rdoTGTCX.Location = new Point(20, 26);
            rdoTGTCX.Name = "rdoTGTCX";
            rdoTGTCX.Size = new Size(150, 24);
            rdoTGTCX.TabIndex = 10;
            rdoTGTCX.TabStop = true;
            rdoTGTCX.Text = "tìm giá trị cần xóa";
            rdoTGTCX.UseVisualStyleBackColor = true;
            // 
            // grpThem
            // 
            grpThem.Controls.Add(lblTVTCT);
            grpThem.Controls.Add(txtTGTCTH);
            grpThem.Controls.Add(lblCSXT1);
            grpThem.Controls.Add(txtTVTCTH);
            grpThem.Controls.Add(rdoTimGiaTriCanThem);
            grpThem.Location = new Point(28, 347);
            grpThem.Name = "grpThem";
            grpThem.Size = new Size(224, 114);
            grpThem.TabIndex = 18;
            grpThem.TabStop = false;
            grpThem.Text = "Thêm";
            // 
            // lblTVTCT
            // 
            lblTVTCT.AutoSize = true;
            lblTVTCT.Location = new Point(43, 56);
            lblTVTCT.Name = "lblTVTCT";
            lblTVTCT.Size = new Size(127, 20);
            lblTVTCT.TabIndex = 18;
            lblTVTCT.Text = "Tại vị trí cần thêm";
            // 
            // txtTGTCTH
            // 
            txtTGTCTH.Location = new Point(173, 23);
            txtTGTCTH.Name = "txtTGTCTH";
            txtTGTCTH.Size = new Size(37, 27);
            txtTGTCTH.TabIndex = 17;
            // 
            // lblCSXT1
            // 
            lblCSXT1.AutoSize = true;
            lblCSXT1.Location = new Point(47, 83);
            lblCSXT1.Name = "lblCSXT1";
            lblCSXT1.Size = new Size(123, 20);
            lblCSXT1.TabIndex = 11;
            lblCSXT1.Text = "Cần sắp xếp tăng";
            // 
            // txtTVTCTH
            // 
            txtTVTCTH.Location = new Point(172, 53);
            txtTVTCTH.Name = "txtTVTCTH";
            txtTVTCTH.Size = new Size(38, 27);
            txtTVTCTH.TabIndex = 14;
            // 
            // rdoTimGiaTriCanThem
            // 
            rdoTimGiaTriCanThem.AutoSize = true;
            rdoTimGiaTriCanThem.Location = new Point(20, 26);
            rdoTimGiaTriCanThem.Name = "rdoTimGiaTriCanThem";
            rdoTimGiaTriCanThem.Size = new Size(160, 24);
            rdoTimGiaTriCanThem.TabIndex = 10;
            rdoTimGiaTriCanThem.TabStop = true;
            rdoTimGiaTriCanThem.Text = "tìm giá trị cần thêm";
            rdoTimGiaTriCanThem.UseVisualStyleBackColor = true;
            // 
            // grpTong
            // 
            grpTong.Controls.Add(btnTong);
            grpTong.Controls.Add(lblTongMang);
            grpTong.Controls.Add(txtTongLe);
            grpTong.Controls.Add(lblTongChan);
            grpTong.Controls.Add(txtTongMang);
            grpTong.Controls.Add(lblTongLe);
            grpTong.Controls.Add(txtTongChan);
            grpTong.Location = new Point(312, 347);
            grpTong.Name = "grpTong";
            grpTong.Size = new Size(224, 114);
            grpTong.TabIndex = 19;
            grpTong.TabStop = false;
            grpTong.Text = "Tổng";
            // 
            // btnTong
            // 
            btnTong.Location = new Point(155, 20);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(60, 88);
            btnTong.TabIndex = 20;
            btnTong.Text = "Tổng";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // lblTongMang
            // 
            lblTongMang.AutoSize = true;
            lblTongMang.Location = new Point(6, 26);
            lblTongMang.Name = "lblTongMang";
            lblTongMang.Size = new Size(85, 20);
            lblTongMang.TabIndex = 21;
            lblTongMang.Text = "Tổng mảng";
            // 
            // txtTongLe
            // 
            txtTongLe.Location = new Point(95, 83);
            txtTongLe.Name = "txtTongLe";
            txtTongLe.Size = new Size(38, 27);
            txtTongLe.TabIndex = 20;
            // 
            // lblTongChan
            // 
            lblTongChan.AutoSize = true;
            lblTongChan.Location = new Point(6, 54);
            lblTongChan.Name = "lblTongChan";
            lblTongChan.Size = new Size(80, 20);
            lblTongChan.TabIndex = 18;
            lblTongChan.Text = "Tổng Chẵn";
            // 
            // txtTongMang
            // 
            txtTongMang.Location = new Point(96, 19);
            txtTongMang.Name = "txtTongMang";
            txtTongMang.Size = new Size(37, 27);
            txtTongMang.TabIndex = 17;
            // 
            // lblTongLe
            // 
            lblTongLe.AutoSize = true;
            lblTongLe.Location = new Point(3, 86);
            lblTongLe.Name = "lblTongLe";
            lblTongLe.Size = new Size(62, 20);
            lblTongLe.TabIndex = 11;
            lblTongLe.Text = "Tổng Lẻ";
            // 
            // txtTongChan
            // 
            txtTongChan.Location = new Point(96, 51);
            txtTongChan.Name = "txtTongChan";
            txtTongChan.Size = new Size(38, 27);
            txtTongChan.TabIndex = 14;
            // 
            // grpMaxMin
            // 
            grpMaxMin.Controls.Add(txtGTLN);
            grpMaxMin.Controls.Add(btnTim);
            grpMaxMin.Controls.Add(lblGTLN);
            grpMaxMin.Controls.Add(lblGTNN);
            grpMaxMin.Controls.Add(txtGTNN);
            grpMaxMin.Location = new Point(28, 488);
            grpMaxMin.Name = "grpMaxMin";
            grpMaxMin.Size = new Size(224, 114);
            grpMaxMin.TabIndex = 20;
            grpMaxMin.TabStop = false;
            grpMaxMin.Text = "Max-Min";
            // 
            // txtGTLN
            // 
            txtGTLN.Location = new Point(111, 27);
            txtGTLN.Multiline = true;
            txtGTLN.Name = "txtGTLN";
            txtGTLN.Size = new Size(38, 33);
            txtGTLN.TabIndex = 22;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(155, 20);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(60, 88);
            btnTim.TabIndex = 20;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // lblGTLN
            // 
            lblGTLN.AutoSize = true;
            lblGTLN.Location = new Point(6, 40);
            lblGTLN.Name = "lblGTLN";
            lblGTLN.Size = new Size(107, 20);
            lblGTLN.TabIndex = 21;
            lblGTLN.Text = "Giá trị lớn nhất";
            // 
            // lblGTNN
            // 
            lblGTNN.AutoSize = true;
            lblGTNN.Location = new Point(0, 79);
            lblGTNN.Name = "lblGTNN";
            lblGTNN.Size = new Size(111, 20);
            lblGTNN.TabIndex = 18;
            lblGTNN.Text = "Giá trị nhỏ nhất";
            // 
            // txtGTNN
            // 
            txtGTNN.Location = new Point(111, 66);
            txtGTNN.Multiline = true;
            txtGTNN.Name = "txtGTNN";
            txtGTNN.Size = new Size(38, 33);
            txtGTNN.TabIndex = 14;
            // 
            // grpThayThe
            // 
            grpThayThe.Controls.Add(txtGTCTT);
            grpThayThe.Controls.Add(txtSTTL);
            grpThayThe.Controls.Add(lblSTTL);
            grpThayThe.Controls.Add(txtVTCTT);
            grpThayThe.Controls.Add(rdoVTCTT);
            grpThayThe.Controls.Add(rdoGTCTT);
            grpThayThe.Location = new Point(312, 488);
            grpThayThe.Name = "grpThayThe";
            grpThayThe.Size = new Size(224, 114);
            grpThayThe.TabIndex = 21;
            grpThayThe.TabStop = false;
            grpThayThe.Text = "Thay thế";
            // 
            // txtGTCTT
            // 
            txtGTCTT.Location = new Point(173, 23);
            txtGTCTT.Name = "txtGTCTT";
            txtGTCTT.Size = new Size(37, 27);
            txtGTCTT.TabIndex = 17;
            // 
            // txtSTTL
            // 
            txtSTTL.Location = new Point(172, 82);
            txtSTTL.Name = "txtSTTL";
            txtSTTL.Size = new Size(37, 27);
            txtSTTL.TabIndex = 15;
            // 
            // lblSTTL
            // 
            lblSTTL.AutoSize = true;
            lblSTTL.Location = new Point(20, 82);
            lblSTTL.Name = "lblSTTL";
            lblSTTL.Size = new Size(97, 20);
            lblSTTL.TabIndex = 11;
            lblSTTL.Text = "số thay thế là";
            // 
            // txtVTCTT
            // 
            txtVTCTT.Location = new Point(172, 53);
            txtVTCTT.Name = "txtVTCTT";
            txtVTCTT.Size = new Size(38, 27);
            txtVTCTT.TabIndex = 14;
            // 
            // rdoVTCTT
            // 
            rdoVTCTT.AutoSize = true;
            rdoVTCTT.Location = new Point(20, 56);
            rdoVTCTT.Name = "rdoVTCTT";
            rdoVTCTT.Size = new Size(151, 24);
            rdoVTCTT.TabIndex = 12;
            rdoVTCTT.TabStop = true;
            rdoVTCTT.Text = "vị Trí cần Thay Thế";
            rdoVTCTT.UseVisualStyleBackColor = true;
            // 
            // rdoGTCTT
            // 
            rdoGTCTT.AutoSize = true;
            rdoGTCTT.Location = new Point(20, 26);
            rdoGTCTT.Name = "rdoGTCTT";
            rdoGTCTT.Size = new Size(154, 24);
            rdoGTCTT.TabIndex = 10;
            rdoGTCTT.TabStop = true;
            rdoGTCTT.Text = "Giá trị cần thay thế";
            rdoGTCTT.UseVisualStyleBackColor = true;
            // 
            // frmBaiTap2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 740);
            Controls.Add(grpThayThe);
            Controls.Add(grpMaxMin);
            Controls.Add(grpTong);
            Controls.Add(grpThem);
            Controls.Add(grpXoa);
            Controls.Add(grpTimKiem);
            Controls.Add(grpSapXep);
            Controls.Add(btnThucHien);
            Controls.Add(txtKetQuaMang);
            Controls.Add(btnThoat);
            Controls.Add(btnKetQuaMang);
            Controls.Add(txtNhapMang);
            Controls.Add(btnNhapMang);
            Controls.Add(btnReset);
            Controls.Add(lblMSN);
            Name = "frmBaiTap2";
            Text = "+";
            FormClosing += frmBaiTap2_FormClosing;
            grpSapXep.ResumeLayout(false);
            grpSapXep.PerformLayout();
            grpTimKiem.ResumeLayout(false);
            grpTimKiem.PerformLayout();
            grpXoa.ResumeLayout(false);
            grpXoa.PerformLayout();
            grpThem.ResumeLayout(false);
            grpThem.PerformLayout();
            grpTong.ResumeLayout(false);
            grpTong.PerformLayout();
            grpMaxMin.ResumeLayout(false);
            grpMaxMin.PerformLayout();
            grpThayThe.ResumeLayout(false);
            grpThayThe.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblMSN;
        private Button btnReset;
        private Button btnNhapMang;
        private TextBox txtNhapMang;
        private Button btnKetQuaMang;
        private Button btnThoat;
        private TextBox txtKetQuaMang;
        private Button btnThucHien;
        private GroupBox grpSapXep;
        private RadioButton rdoXapXepGiam;
        private RadioButton rdoXapXepTang;
        private GroupBox grpTimKiem;
        private RadioButton rdoTVTCT;
        private RadioButton rdoTGTCT;
        private Label lblSTDL;
        private TextBox txtTGTCT;
        private TextBox txtSTDL;
        private TextBox txtTVTCT;
        private GroupBox grpXoa;
        private TextBox txtTGTCX;
        private Label lblCSXT;
        private TextBox txtTVTCX;
        private RadioButton rdoTVTCX;
        private RadioButton rdoTGTCX;
        private GroupBox grpThem;
        private TextBox txtTGTCTH;
        private Label lblCSXT1;
        private TextBox txtTVTCTH;
        private RadioButton rdoTimGiaTriCanThem;
        private Label lblTVTCT;
        private GroupBox grpTong;
        private Label lblTongMang;
        private TextBox txtTongLe;
        private Label lblTongChan;
        private TextBox txtTongMang;
        private Label lblTongLe;
        private TextBox txtTongChan;
        private Button btnTong;
        private GroupBox grpMaxMin;
        private Button btnTim;
        private Label lblGTLN;
        private Label lblGTNN;
        private Label label3;
        private TextBox txtGTNN;
        private GroupBox grpThayThe;
        private TextBox txtGTCTT;
        private TextBox txtSTTL;
        private Label lblSTTL;
        private TextBox txtVTCTT;
        private RadioButton rdoVTCTT;
        private RadioButton rdoGTCTT;
        private TextBox txtGTLN;
    }
}