#nullable enable annotations
namespace bai6bvenha
{
    partial class ChonBai
    {
        private System.ComponentModel.IContainer? components = null;
        private Button btnBai1;
        private Button btnBai2;
        private Button btnBai3;
        private Button btnBai4;

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
            btnBai1.Text = "Bài 1 - Quản lý sản phẩm";
            btnBai1.UseVisualStyleBackColor = true;
            btnBai1.Click += btnBai1_Click;
            Controls.Add(btnBai1);
            btnBai2 = new Button();
            btnBai2.Location = new Point(30, 80);
            btnBai2.Name = "btnBai2";
            btnBai2.Size = new Size(320, 40);
            btnBai2.TabIndex = 1;
            btnBai2.Text = "Bài 2 - Tạo tồn kho";
            btnBai2.UseVisualStyleBackColor = true;
            btnBai2.Click += btnBai2_Click;
            Controls.Add(btnBai2);
            btnBai3 = new Button();
            btnBai3.Location = new Point(30, 135);
            btnBai3.Name = "btnBai3";
            btnBai3.Size = new Size(320, 40);
            btnBai3.TabIndex = 2;
            btnBai3.Text = "Bài 3 - Nhập hàng";
            btnBai3.UseVisualStyleBackColor = true;
            btnBai3.Click += btnBai3_Click;
            Controls.Add(btnBai3);
            btnBai4 = new Button();
            btnBai4.Location = new Point(30, 190);
            btnBai4.Name = "btnBai4";
            btnBai4.Size = new Size(320, 40);
            btnBai4.TabIndex = 3;
            btnBai4.Text = "Bài 4 - Bán hàng";
            btnBai4.UseVisualStyleBackColor = true;
            btnBai4.Click += btnBai4_Click;
            Controls.Add(btnBai4);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 245);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ChonBai";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thực hành 6b - Bài tập về nhà";
            ResumeLayout(false);
        }
    }
}
