#nullable enable
namespace bai6anangcao
{
    partial class ChonBai
    {
        private System.ComponentModel.IContainer? components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing)
                components?.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            btnSinhVien = new Button();
            btnDiem = new Button();
            SuspendLayout();
            lblTieuDe.AutoSize = true;
            lblTieuDe.Location = new Point(40, 28);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Text = "Thực hành 6a - Bài tập nâng cao";
            btnSinhVien.Location = new Point(40, 75);
            btnSinhVien.Name = "btnSinhVien";
            btnSinhVien.Size = new Size(360, 44);
            btnSinhVien.TabIndex = 0;
            btnSinhVien.Text = "Bài 1 - Quản lý sinh viên";
            btnSinhVien.UseVisualStyleBackColor = true;
            btnSinhVien.Click += btnSinhVien_Click;
            btnDiem.Location = new Point(40, 140);
            btnDiem.Name = "btnDiem";
            btnDiem.Size = new Size(360, 44);
            btnDiem.TabIndex = 1;
            btnDiem.Text = "Bài 2 - Quản lý điểm";
            btnDiem.UseVisualStyleBackColor = true;
            btnDiem.Click += btnDiem_Click;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 225);
            Controls.Add(lblTieuDe);
            Controls.Add(btnSinhVien);
            Controls.Add(btnDiem);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Name = "ChonBai";
            Text = "Thực hành 6a - Bài tập nâng cao";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTieuDe = null!;
        private Button btnSinhVien = null!;
        private Button btnDiem = null!;
    }
}
