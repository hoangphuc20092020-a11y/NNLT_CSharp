#nullable enable annotations
namespace bai6btrenlop
{
    partial class ChonBai
    {
        private System.ComponentModel.IContainer? components = null;
        private Button btnBai1;
        private Button btnBai2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            btnBai1 = new Button();
            btnBai1.Location = new Point(30, 25);
            btnBai1.Name = "btnBai1";
            btnBai1.Size = new Size(320, 40);
            btnBai1.TabIndex = 0;
            btnBai1.Text = "Bài 1 - Quản lý sinh viên";
            btnBai1.UseVisualStyleBackColor = true;
            btnBai1.Click += btnBai1_Click;
            Controls.Add(btnBai1);
            btnBai2 = new Button();
            btnBai2.Location = new Point(30, 80);
            btnBai2.Name = "btnBai2";
            btnBai2.Size = new Size(320, 40);
            btnBai2.TabIndex = 1;
            btnBai2.Text = "Bài 2 - Quản lý điểm";
            btnBai2.UseVisualStyleBackColor = true;
            btnBai2.Click += btnBai2_Click;
            Controls.Add(btnBai2);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 135);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ChonBai";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thực hành 6b - Bài tập trên lớp";
            ResumeLayout(false);
        }
    }
}
