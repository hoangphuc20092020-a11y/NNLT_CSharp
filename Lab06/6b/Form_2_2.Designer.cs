namespace WinFormsApp1._6b
{
    partial class Form_2_2
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
            buttonXoa = new Button();
            buttonSua = new Button();
            buttonThem = new Button();
            labelDiem = new Label();
            labelMonHoc = new Label();
            labelSinhVien = new Label();
            comboBoxSinhVien = new ComboBox();
            comboBoxMonHoc = new ComboBox();
            textBoxDiem = new TextBox();
            SuspendLayout();
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(319, 196);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(94, 29);
            buttonXoa.TabIndex = 21;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(203, 196);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(94, 29);
            buttonSua.TabIndex = 20;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            buttonSua.Click += buttonSua_Click;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(83, 196);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(94, 29);
            buttonThem.TabIndex = 19;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // labelDiem
            // 
            labelDiem.AutoSize = true;
            labelDiem.Location = new Point(83, 141);
            labelDiem.Name = "labelDiem";
            labelDiem.Size = new Size(45, 20);
            labelDiem.TabIndex = 15;
            labelDiem.Text = "Điểm";
            // 
            // labelMonHoc
            // 
            labelMonHoc.AutoSize = true;
            labelMonHoc.Location = new Point(83, 91);
            labelMonHoc.Name = "labelMonHoc";
            labelMonHoc.Size = new Size(67, 20);
            labelMonHoc.TabIndex = 13;
            labelMonHoc.Text = "Môn học";
            // 
            // labelSinhVien
            // 
            labelSinhVien.AutoSize = true;
            labelSinhVien.Location = new Point(83, 44);
            labelSinhVien.Name = "labelSinhVien";
            labelSinhVien.Size = new Size(68, 20);
            labelSinhVien.TabIndex = 12;
            labelSinhVien.Text = "Sinh viên";
            // 
            // comboBoxSinhVien
            // 
            comboBoxSinhVien.FormattingEnabled = true;
            comboBoxSinhVien.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSinhVien.Location = new Point(167, 41);
            comboBoxSinhVien.Name = "comboBoxSinhVien";
            comboBoxSinhVien.Size = new Size(246, 28);
            comboBoxSinhVien.TabIndex = 22;
            // 
            // comboBoxMonHoc
            // 
            comboBoxMonHoc.FormattingEnabled = true;
            comboBoxMonHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMonHoc.Location = new Point(167, 88);
            comboBoxMonHoc.Name = "comboBoxMonHoc";
            comboBoxMonHoc.Size = new Size(246, 28);
            comboBoxMonHoc.TabIndex = 23;
            // 
            // textBoxDiem
            // 
            textBoxDiem.Location = new Point(167, 138);
            textBoxDiem.Name = "textBoxDiem";
            textBoxDiem.Size = new Size(246, 27);
            textBoxDiem.TabIndex = 24;
            // 
            // Form_2_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 278);
            Controls.Add(textBoxDiem);
            Controls.Add(comboBoxMonHoc);
            Controls.Add(comboBoxSinhVien);
            Controls.Add(buttonXoa);
            Controls.Add(buttonSua);
            Controls.Add(buttonThem);
            Controls.Add(labelDiem);
            Controls.Add(labelMonHoc);
            Controls.Add(labelSinhVien);
            Name = "Form_2_2";
            Text = "frm_Diem_combo";
            Load += Form_2_2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonXoa;
        private Button buttonSua;
        private Button buttonThem;
        private Label labelDiem;
        private Label labelMonHoc;
        private Label labelSinhVien;
        private ComboBox comboBoxSinhVien;
        private ComboBox comboBoxMonHoc;
        private TextBox textBoxDiem;
    }
}