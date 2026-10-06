namespace TH04d
{
    partial class fmrBaiTap1
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
            labgpt = new Label();
            lblKetQua = new Label();
            lblC = new Label();
            lblB = new Label();
            lblA = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            txtKetQua = new TextBox();
            btnThoat = new Button();
            btnGiai = new Button();
            rdoPTBN = new RadioButton();
            rdoPTBH = new RadioButton();
            grpbvlc = new GroupBox();
            grpbvlc.SuspendLayout();
            SuspendLayout();
            // 
            // labgpt
            // 
            labgpt.AutoSize = true;
            labgpt.Location = new Point(200, 9);
            labgpt.Name = "labgpt";
            labgpt.Size = new Size(150, 20);
            labgpt.TabIndex = 0;
            labgpt.Text = "GIẢI PHƯƠNG TRÌNH";
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Location = new Point(40, 298);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(60, 20);
            lblKetQua.TabIndex = 1;
            lblKetQua.Text = "Kết quả";
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Location = new Point(40, 251);
            lblC.Name = "lblC";
            lblC.Size = new Size(56, 20);
            lblC.TabIndex = 2;
            lblC.Text = "Nhập c";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(40, 211);
            lblB.Name = "lblB";
            lblB.Size = new Size(58, 20);
            lblB.TabIndex = 3;
            lblB.Text = "Nhập b";
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(40, 165);
            lblA.Name = "lblA";
            lblA.Size = new Size(57, 20);
            lblA.TabIndex = 4;
            lblA.Text = "Nhập a";
            // 
            // txtA
            // 
            txtA.Location = new Point(114, 168);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 27);
            txtA.TabIndex = 5;
            // 
            // txtB
            // 
            txtB.Location = new Point(114, 204);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 27);
            txtB.TabIndex = 6;
            // 
            // txtC
            // 
            txtC.Location = new Point(114, 251);
            txtC.Name = "txtC";
            txtC.Size = new Size(125, 27);
            txtC.TabIndex = 7;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(114, 295);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(125, 27);
            txtKetQua.TabIndex = 8;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(269, 207);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnGiai
            // 
            btnGiai.Location = new Point(269, 178);
            btnGiai.Name = "btnGiai";
            btnGiai.Size = new Size(94, 29);
            btnGiai.TabIndex = 10;
            btnGiai.Text = "Giải";
            btnGiai.UseVisualStyleBackColor = true;
            btnGiai.Click += btnGiai_Click;
            // 
            // rdoPTBN
            // 
            rdoPTBN.AutoSize = true;
            rdoPTBN.Location = new Point(28, 38);
            rdoPTBN.Name = "rdoPTBN";
            rdoPTBN.Size = new Size(207, 24);
            rdoPTBN.TabIndex = 11;
            rdoPTBN.TabStop = true;
            rdoPTBN.Text = "Giải phương trình Bậc nhất";
            rdoPTBN.UseVisualStyleBackColor = true;
            // 
            // rdoPTBH
            // 
            rdoPTBH.AutoSize = true;
            rdoPTBH.Location = new Point(28, 87);
            rdoPTBH.Name = "rdoPTBH";
            rdoPTBH.Size = new Size(198, 24);
            rdoPTBH.TabIndex = 12;
            rdoPTBH.TabStop = true;
            rdoPTBH.Text = "Giải phương trình Bậc hai";
            rdoPTBH.UseVisualStyleBackColor = true;
            // 
            // grpbvlc
            // 
            grpbvlc.Controls.Add(rdoPTBN);
            grpbvlc.Controls.Add(rdoPTBH);
            grpbvlc.Location = new Point(53, 37);
            grpbvlc.Name = "grpbvlc";
            grpbvlc.Size = new Size(250, 125);
            grpbvlc.TabIndex = 13;
            grpbvlc.TabStop = false;
            grpbvlc.Text = "Bạn vui lòng chọn";
            // 
            // fmrBaiTap1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpbvlc);
            Controls.Add(btnGiai);
            Controls.Add(btnThoat);
            Controls.Add(txtKetQua);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(lblA);
            Controls.Add(lblB);
            Controls.Add(lblC);
            Controls.Add(lblKetQua);
            Controls.Add(labgpt);
            Name = "fmrBaiTap1";
            Text = "fmrBaiTap1";
            grpbvlc.ResumeLayout(false);
            grpbvlc.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labgpt;
        private Label lblKetQua;
        private Label lblC;
        private Label lblB;
        private Label lblA;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private TextBox txtKetQua;
        private Button btnThoat;
        private Button btnGiai;
        private RadioButton rdoPTBN;
        private RadioButton rdoPTBH;
        private GroupBox grpbvlc;
    }
}