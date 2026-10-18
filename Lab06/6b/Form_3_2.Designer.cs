namespace WinFormsApp1._6b
{
    partial class Form_3_2
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
            listViewDiem = new ListView();
            columnHeaderSTT = new ColumnHeader();
            buttonHienThi = new Button();
            labelMonHoc = new Label();
            comboBoxMonHoc = new ComboBox();
            labelTongDiem = new Label();
            textBoxTongDiem = new TextBox();
            columnHeaderTen = new ColumnHeader();
            columnHeaderBOD = new ColumnHeader();
            columnHeaderTenMH = new ColumnHeader();
            columnHeaderDiem = new ColumnHeader();
            SuspendLayout();
            // 
            // listView1
            // 
            listViewDiem.Columns.AddRange(new ColumnHeader[] { columnHeaderSTT, columnHeaderTen, columnHeaderBOD, columnHeaderTenMH, columnHeaderDiem });
            listViewDiem.FullRowSelect = true;
            listViewDiem.GridLines = true;
            listViewDiem.Location = new Point(51, 96);
            listViewDiem.Name = "listViewDiem";
            listViewDiem.Size = new Size(752, 429);
            listViewDiem.TabIndex = 4;
            listViewDiem.UseCompatibleStateImageBehavior = false;
            listViewDiem.View = View.Details;
            // 
            // columnHeaderSTT
            // 
            columnHeaderSTT.Text = "STT";
            columnHeaderSTT.Width = 150;
            // 
            // buttonHienThi
            // 
            buttonHienThi.Location = new Point(513, 38);
            buttonHienThi.Name = "buttonHienThi";
            buttonHienThi.Size = new Size(125, 30);
            buttonHienThi.TabIndex = 3;
            buttonHienThi.Text = "Lọc dữ liệu";
            buttonHienThi.UseVisualStyleBackColor = true;
            buttonHienThi.Click += buttonHienThi_Click;
            // 
            // labelMonHoc
            // 
            labelMonHoc.AutoSize = true;
            labelMonHoc.Location = new Point(51, 43);
            labelMonHoc.Name = "labelMonHoc";
            labelMonHoc.Size = new Size(67, 20);
            labelMonHoc.TabIndex = 6;
            labelMonHoc.Text = "Môn học";
            // 
            // comboBoxMonHoc
            // 
            comboBoxMonHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMonHoc.FormattingEnabled = true;
            comboBoxMonHoc.Location = new Point(140, 38);
            comboBoxMonHoc.Name = "comboBoxMonHoc";
            comboBoxMonHoc.Size = new Size(279, 28);
            comboBoxMonHoc.TabIndex = 7;
            // 
            // labelTongDiem
            // 
            labelTongDiem.AutoSize = true;
            labelTongDiem.Location = new Point(440, 555);
            labelTongDiem.Name = "labelTongDiem";
            labelTongDiem.Size = new Size(81, 20);
            labelTongDiem.TabIndex = 8;
            labelTongDiem.Text = "Tổng điểm";
            // 
            // textBoxTongDiem
            // 
            textBoxTongDiem.Location = new Point(527, 552);
            textBoxTongDiem.Name = "textBoxTongDiem";
            textBoxTongDiem.ReadOnly = true;
            textBoxTongDiem.Size = new Size(276, 27);
            textBoxTongDiem.TabIndex = 9;
            // 
            // columnHeaderTen
            // 
            columnHeaderTen.Text = "Tên SV";
            columnHeaderTen.Width = 150;
            // 
            // columnHeaderBOD
            // 
            columnHeaderBOD.Text = "Ngày sinh";
            columnHeaderBOD.Width = 150;
            // 
            // columnHeaderTenMH
            // 
            columnHeaderTenMH.Text = "Tên MH";
            columnHeaderTenMH.Width = 150;
            // 
            // columnHeaderDiem
            // 
            columnHeaderDiem.Text = "Điểm";
            columnHeaderDiem.Width = 150;
            // 
            // Form_3_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 611);
            Controls.Add(textBoxTongDiem);
            Controls.Add(labelTongDiem);
            Controls.Add(comboBoxMonHoc);
            Controls.Add(labelMonHoc);
            Controls.Add(listViewDiem);
            Controls.Add(buttonHienThi);
            Name = "Form_3_2";
            Text = "Danh sách sinh viên";
            Load += Form_3_2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewDiem;
        private ColumnHeader columnHeaderSTT;
        private ColumnHeader columnHeaderMaLop;
        private ColumnHeader columnHeaderTenLop;
        private Button buttonHienThi;
        private Label labelMonHoc;
        private ComboBox comboBoxMonHoc;
        private Label labelTongDiem;
        private TextBox textBoxTongDiem;
        private ColumnHeader columnHeaderTen;
        private ColumnHeader columnHeaderBOD;
        private ColumnHeader columnHeaderTenMH;
        private ColumnHeader columnHeaderDiem;
    }
}