namespace WinFormsApp1
{
    partial class ProductForm
    {
        private System.ComponentModel.IContainer? components = null;
        private Label nameLabel = null!;
        private Label codeLabel = null!;
        private TextBox productCodeTextBox = null!;
        private TextBox productNameTextBox = null!;
        private Button addButton = null!;
        private Button closeButton = null!;

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
            nameLabel = new Label();
            codeLabel = new Label();
            productCodeTextBox = new TextBox();
            productNameTextBox = new TextBox();
            addButton = new Button();
            closeButton = new Button();
            SuspendLayout();
            //
            // nameLabel
            //
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(30, 35);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(94, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Tên sản phẩm";
            //
            // productNameTextBox
            //
            // codeLabel
            //
            codeLabel.AutoSize = true;
            codeLabel.Location = new Point(30, 35);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new Size(91, 20);
            codeLabel.TabIndex = 1;
            codeLabel.Text = "Mã sản phẩm";
            //
            // productCodeTextBox
            //
            productCodeTextBox.Location = new Point(135, 30);
            productCodeTextBox.Name = "productCodeTextBox";
            productCodeTextBox.Size = new Size(220, 27);
            productCodeTextBox.TabIndex = 2;
            //
            // productNameTextBox
            //
            productNameTextBox.Location = new Point(135, 75);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.Size = new Size(220, 27);
            productNameTextBox.TabIndex = 3;
            nameLabel.Location = new Point(30, 80);
            //
            // addButton
            //
            addButton.Location = new Point(105, 125);
            addButton.Name = "addButton";
            addButton.Size = new Size(90, 32);
            addButton.TabIndex = 2;
            addButton.Text = "Thêm";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            //
            // closeButton
            //
            closeButton.Location = new Point(215, 125);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(90, 32);
            closeButton.TabIndex = 3;
            closeButton.Text = "Thoát";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += CloseButton_Click;
            //
            // ProductForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 200);
            Controls.Add(codeLabel);
            Controls.Add(productCodeTextBox);
            Controls.Add(nameLabel);
            Controls.Add(productNameTextBox);
            Controls.Add(addButton);
            Controls.Add(closeButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm sản phẩm mới";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
