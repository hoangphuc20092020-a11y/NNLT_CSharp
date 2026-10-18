namespace WinFormsApp1
{
    partial class InventoryForm
    {
        private System.ComponentModel.IContainer? components = null;
        private Label descriptionLabel = null!;
        private Button createButton = null!;
        private Label statusLabel = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            descriptionLabel = new Label();
            createButton = new Button();
            statusLabel = new Label();
            SuspendLayout();
            //
            // descriptionLabel
            //
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(30, 30);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(359, 20);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Tạo tồn kho cho tất cả sản phẩm theo ngày hiện tại.";
            //
            // createButton
            //
            createButton.Location = new Point(145, 70);
            createButton.Name = "createButton";
            createButton.Size = new Size(180, 35);
            createButton.TabIndex = 1;
            createButton.Text = "Tạo tồn kho hôm nay";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += CreateButton_Click;
            //
            // statusLabel
            //
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(30, 125);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(0, 20);
            statusLabel.TabIndex = 2;
            //
            // InventoryForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 180);
            Controls.Add(descriptionLabel);
            Controls.Add(createButton);
            Controls.Add(statusLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InventoryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tạo tồn kho";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
