namespace bai6atrenlop
{
    partial class QuanLyMonHoc
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
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            lblMaMonHoc = new Label();
            lblTenMonHoc = new Label();
            txtMaMonHoc = new TextBox();
            txtTenMonHoc = new TextBox();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.Location = new Point(113, 294);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(349, 294);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(236, 294);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // lblMaMonHoc
            // 
            lblMaMonHoc.AutoSize = true;
            lblMaMonHoc.Location = new Point(82, 146);
            lblMaMonHoc.Name = "lblMaMonHoc";
            lblMaMonHoc.Size = new Size(92, 20);
            lblMaMonHoc.TabIndex = 3;
            lblMaMonHoc.Text = "Mã môn học";
            // 
            // lblTenMonHoc
            // 
            lblTenMonHoc.AutoSize = true;
            lblTenMonHoc.Location = new Point(82, 208);
            lblTenMonHoc.Name = "lblTenMonHoc";
            lblTenMonHoc.Size = new Size(97, 20);
            lblTenMonHoc.TabIndex = 4;
            lblTenMonHoc.Text = "Tên Môn Học";
            // 
            // txtMaMonHoc
            // 
            txtMaMonHoc.Location = new Point(185, 143);
            txtMaMonHoc.Name = "txtMaMonHoc";
            txtMaMonHoc.Size = new Size(125, 27);
            txtMaMonHoc.TabIndex = 5;
            // 
            // txtTenMonHoc
            // 
            txtTenMonHoc.Location = new Point(185, 201);
            txtTenMonHoc.Name = "txtTenMonHoc";
            txtTenMonHoc.Size = new Size(125, 27);
            txtTenMonHoc.TabIndex = 6;
            // 
            // QuanLyMonHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTenMonHoc);
            Controls.Add(txtMaMonHoc);
            Controls.Add(lblTenMonHoc);
            Controls.Add(lblMaMonHoc);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Name = "QuanLyMonHoc";
            Text = "QuanLyMonHoc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Label lblMaMonHoc;
        private Label lblTenMonHoc;
        private TextBox txtMaMonHoc;
        private TextBox txtTenMonHoc;
    }
}