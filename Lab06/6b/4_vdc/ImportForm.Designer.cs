namespace WinFormsApp1
{
    partial class ImportForm
    {
        private System.ComponentModel.IContainer? components = null;
        private Label productLabel = null!;
        private ComboBox productComboBox = null!;
        private Label quantityLabel = null!;
        private NumericUpDown quantityInput = null!;
        private Button importButton = null!;

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
            productLabel = new Label();
            productComboBox = new ComboBox();
            quantityLabel = new Label();
            quantityInput = new NumericUpDown();
            importButton = new Button();
            ((System.ComponentModel.ISupportInitialize)quantityInput).BeginInit();
            SuspendLayout();
            //
            // productLabel
            //
            productLabel.AutoSize = true;
            productLabel.Location = new Point(35, 35);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(71, 20);
            productLabel.TabIndex = 0;
            productLabel.Text = "Sản phẩm";
            //
            // productComboBox
            //
            productComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            productComboBox.FormattingEnabled = true;
            productComboBox.Location = new Point(145, 30);
            productComboBox.Name = "productComboBox";
            productComboBox.Size = new Size(240, 28);
            productComboBox.TabIndex = 1;
            //
            // quantityLabel
            //
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new Point(35, 85);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(104, 20);
            quantityLabel.TabIndex = 2;
            quantityLabel.Text = "Số lượng nhập";
            //
            // quantityInput
            //
            quantityInput.Location = new Point(145, 80);
            quantityInput.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            quantityInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            quantityInput.Name = "quantityInput";
            quantityInput.Size = new Size(240, 27);
            quantityInput.TabIndex = 3;
            quantityInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // importButton
            //
            importButton.Location = new Point(160, 135);
            importButton.Name = "importButton";
            importButton.Size = new Size(120, 35);
            importButton.TabIndex = 4;
            importButton.Text = "Nhập hàng";
            importButton.UseVisualStyleBackColor = true;
            importButton.Click += ImportButton_Click;
            //
            // ImportForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 220);
            Controls.Add(productLabel);
            Controls.Add(productComboBox);
            Controls.Add(quantityLabel);
            Controls.Add(quantityInput);
            Controls.Add(importButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ImportForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nhập hàng";
            Load += ImportForm_Load;
            ((System.ComponentModel.ISupportInitialize)quantityInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
