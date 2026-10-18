namespace WinFormsApp1._6b
{
    partial class Form_2_1
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
            labelLop = new Label();
            labelMaSinhVien = new Label();
            labelHoTen = new Label();
            comboBoxLop = new ComboBox();
            labelNgaySinh = new Label();
            dateTimePickerNgaySinh = new DateTimePicker();
            textBoxMaSinhVien = new TextBox();
            textBoxHoTen = new TextBox();
            buttonThem = new Button();
            buttonXoaSua = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // labelLop
            // 
            labelLop.AutoSize = true;
            labelLop.Location = new Point(66, 56);
            labelLop.Name = "labelLop";
            labelLop.Size = new Size(34, 20);
            labelLop.TabIndex = 0;
            labelLop.Text = "Lớp";
            // 
            // labelMaSinhVien
            // 
            labelMaSinhVien.AutoSize = true;
            labelMaSinhVien.Location = new Point(66, 106);
            labelMaSinhVien.Name = "labelMaSinhVien";
            labelMaSinhVien.Size = new Size(51, 20);
            labelMaSinhVien.TabIndex = 1;
            labelMaSinhVien.Text = "Mã SV";
            // 
            // labelHoTen
            // 
            labelHoTen.AutoSize = true;
            labelHoTen.Location = new Point(66, 153);
            labelHoTen.Name = "labelHoTen";
            labelHoTen.Size = new Size(56, 20);
            labelHoTen.TabIndex = 2;
            labelHoTen.Text = "Họ Tên";
            // 
            // comboBoxLop
            // 
            comboBoxLop.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLop.FormattingEnabled = true;
            comboBoxLop.Location = new Point(146, 53);
            comboBoxLop.Name = "comboBoxLop";
            comboBoxLop.Size = new Size(250, 28);
            comboBoxLop.TabIndex = 3;
            // 
            // labelNgaySinh
            // 
            labelNgaySinh.AutoSize = true;
            labelNgaySinh.Location = new Point(66, 203);
            labelNgaySinh.Name = "labelNgaySinh";
            labelNgaySinh.Size = new Size(74, 20);
            labelNgaySinh.TabIndex = 4;
            labelNgaySinh.Text = "Ngày sinh";
            // 
            // dateTimePickerNgaySinh
            // 
            dateTimePickerNgaySinh.Location = new Point(146, 198);
            dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            dateTimePickerNgaySinh.Size = new Size(250, 27);
            dateTimePickerNgaySinh.TabIndex = 5;
            // 
            // textBoxMaSinhVien
            // 
            textBoxMaSinhVien.Location = new Point(146, 103);
            textBoxMaSinhVien.Name = "textBoxMaSinhVien";
            textBoxMaSinhVien.Size = new Size(250, 27);
            textBoxMaSinhVien.TabIndex = 6;
            // 
            // textBoxHoTen
            // 
            textBoxHoTen.Location = new Point(146, 150);
            textBoxHoTen.Name = "textBoxHoTen";
            textBoxHoTen.Size = new Size(250, 27);
            textBoxHoTen.TabIndex = 7;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(66, 258);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(94, 29);
            buttonThem.TabIndex = 8;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonXoaSua
            // 
            buttonXoaSua.Location = new Point(186, 258);
            buttonXoaSua.Name = "buttonXoaSua";
            buttonXoaSua.Size = new Size(94, 29);
            buttonXoaSua.TabIndex = 9;
            buttonXoaSua.Text = "Sửa";
            buttonXoaSua.UseVisualStyleBackColor = true;
            buttonXoaSua.Click += buttonXoaSua_Click;
            // 
            // button3
            // 
            button3.Location = new Point(302, 258);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 10;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonXoa_Click;
            // 
            // Form_2_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 340);
            Controls.Add(button3);
            Controls.Add(buttonXoaSua);
            Controls.Add(buttonThem);
            Controls.Add(textBoxHoTen);
            Controls.Add(textBoxMaSinhVien);
            Controls.Add(dateTimePickerNgaySinh);
            Controls.Add(labelNgaySinh);
            Controls.Add(comboBoxLop);
            Controls.Add(labelHoTen);
            Controls.Add(labelMaSinhVien);
            Controls.Add(labelLop);
            Name = "Form_2_1";
            Text = "frmSinhVien_Combo";
            Load += Form_2_1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLop;
        private Label labelMaSinhVien;
        private Label labelHoTen;
        private ComboBox comboBoxLop;
        private Label labelNgaySinh;
        private DateTimePicker dateTimePickerNgaySinh;
        private TextBox textBoxMaSinhVien;
        private TextBox textBoxHoTen;
        private Button buttonThem;
        private Button buttonXoaSua;
        private Button button3;
    }
}