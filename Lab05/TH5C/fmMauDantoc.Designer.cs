namespace TH5C
{
    partial class fmMauDantoc
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
            lblDanToc = new Label();
            btnLoad = new Button();
            btnHienThi = new Button();
            cboDanToc = new ComboBox();
            lblKetQua = new Label();
            SuspendLayout();
            // 
            // lblDanToc
            // 
            lblDanToc.AutoSize = true;
            lblDanToc.Location = new Point(83, 92);
            lblDanToc.Name = "lblDanToc";
            lblDanToc.Size = new Size(64, 20);
            lblDanToc.TabIndex = 0;
            lblDanToc.Text = "Dân Tộc";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(108, 38);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(379, 29);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load dữ liệu ComboBox";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(251, 137);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(94, 29);
            btnHienThi.TabIndex = 2;
            btnHienThi.Text = "Hiển thị";
            btnHienThi.UseVisualStyleBackColor = true;
            // 
            // cboDanToc
            // 
            cboDanToc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDanToc.FormattingEnabled = true;
            cboDanToc.Location = new Point(175, 89);
            cboDanToc.Name = "cboDanToc";
            cboDanToc.Size = new Size(237, 28);
            cboDanToc.TabIndex = 3;
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Location = new Point(28, 207);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(133, 20);
            lblKetQua.TabIndex = 4;
            lblKetQua.Text = "Chưa chọn dân tộc";
            // 
            // fmMauDantoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 280);
            Controls.Add(lblKetQua);
            Controls.Add(cboDanToc);
            Controls.Add(btnHienThi);
            Controls.Add(btnLoad);
            Controls.Add(lblDanToc);
            Name = "fmMauDantoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ComboBox dân tộc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDanToc;
        private Button btnLoad;
        private Button btnHienThi;
        private ComboBox cboDanToc;
        private Label lblKetQua;
    }
}