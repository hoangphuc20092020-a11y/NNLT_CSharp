namespace WinFormsApp1._6b
{
    partial class Form_3_1
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
            buttonThoat = new Button();
            buttonHienThi = new Button();
            columnHeaderSTT = new ColumnHeader();
            columnHeaderMaLop = new ColumnHeader();
            columnHeaderTenLop = new ColumnHeader();
            columnHeaderMaKhoa = new ColumnHeader();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // buttonThoat
            // 
            buttonThoat.Location = new Point(562, 450);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(100, 41);
            buttonThoat.TabIndex = 2;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = true;
            buttonThoat.Click += buttonThoat_Click;
            // 
            // buttonHienThi
            // 
            buttonHienThi.Location = new Point(58, 37);
            buttonHienThi.Name = "buttonHienThi";
            buttonHienThi.Size = new Size(157, 41);
            buttonHienThi.TabIndex = 0;
            buttonHienThi.Text = "Hiển thị dữ liệu";
            buttonHienThi.UseVisualStyleBackColor = true;
            buttonHienThi.Click += buttonHienThi_Click;
            // 
            // columnHeaderSTT
            // 
            columnHeaderSTT.Text = "STT";
            columnHeaderSTT.Width = 150;
            // 
            // columnHeaderMaLop
            // 
            columnHeaderMaLop.Text = "Mã Lớp";
            columnHeaderMaLop.Width = 150;
            // 
            // columnHeaderTenLop
            // 
            columnHeaderTenLop.Text = "Tên Lớp";
            columnHeaderTenLop.Width = 150;
            // 
            // columnHeaderMaKhoa
            // 
            columnHeaderMaKhoa.Text = "Mã Khoa";
            columnHeaderMaKhoa.Width = 150;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeaderSTT, columnHeaderMaLop, columnHeaderTenLop, columnHeaderMaKhoa });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(58, 102);
            listView1.Name = "listView1";
            listView1.Size = new Size(604, 319);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Form_3_1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 503);
            Controls.Add(buttonThoat);
            Controls.Add(listView1);
            Controls.Add(buttonHienThi);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form_3_1";
            Text = "Danh sách lớp";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonThoat;
        private Button buttonHienThi;
        private ColumnHeader columnHeaderSTT;
        private ColumnHeader columnHeaderMaLop;
        private ColumnHeader columnHeaderTenLop;
        private ColumnHeader columnHeaderMaKhoa;
        private ListView listView1;
    }
}