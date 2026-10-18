namespace WinFormsApp1
{
    partial class SalesForm
    {
        private System.ComponentModel.IContainer? components = null;
        private TextBox invoiceTextBox = null!;
        private ComboBox productComboBox = null!;
        private NumericUpDown quantityInput = null!;
        private Button newInvoiceButton = null!;
        private Button addButton = null!;
        private Button cancelButton = null!;
        private Button paymentButton = null!;
        private ListView detailsListView = null!;
        private GroupBox detailsGroup = null!;
        private Label invoiceLabel = null!;
        private Label productLabel = null!;
        private Label quantityLabel = null!;
        private ColumnHeader productIdColumn = null!;
        private ColumnHeader productNameColumn = null!;
        private ColumnHeader quantityColumn = null!;

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
            invoiceTextBox = new TextBox();
            productComboBox = new ComboBox();
            quantityInput = new NumericUpDown();
            newInvoiceButton = new Button();
            addButton = new Button();
            cancelButton = new Button();
            paymentButton = new Button();
            detailsListView = new ListView();
            detailsGroup = new GroupBox();
            invoiceLabel = new Label();
            productLabel = new Label();
            quantityLabel = new Label();
            productIdColumn = new ColumnHeader();
            productNameColumn = new ColumnHeader();
            quantityColumn = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)quantityInput).BeginInit();
            detailsGroup.SuspendLayout();
            SuspendLayout();
            //
            // newInvoiceButton
            //
            newInvoiceButton.Location = new Point(455, 25);
            newInvoiceButton.Name = "newInvoiceButton";
            newInvoiceButton.Size = new Size(180, 35);
            newInvoiceButton.TabIndex = 0;
            newInvoiceButton.Text = "Tạo hóa đơn mới";
            newInvoiceButton.UseVisualStyleBackColor = true;
            newInvoiceButton.Click += NewInvoiceButton_Click;
            //
            // detailsGroup
            //
            detailsGroup.Controls.Add(invoiceLabel);
            detailsGroup.Controls.Add(invoiceTextBox);
            detailsGroup.Controls.Add(productLabel);
            detailsGroup.Controls.Add(productComboBox);
            detailsGroup.Controls.Add(quantityLabel);
            detailsGroup.Controls.Add(quantityInput);
            detailsGroup.Controls.Add(addButton);
            detailsGroup.Controls.Add(cancelButton);
            detailsGroup.Location = new Point(30, 80);
            detailsGroup.Name = "detailsGroup";
            detailsGroup.Size = new Size(605, 215);
            detailsGroup.TabIndex = 1;
            detailsGroup.TabStop = false;
            detailsGroup.Text = "Chi tiết hóa đơn";
            //
            // invoiceLabel
            //
            invoiceLabel.AutoSize = true;
            invoiceLabel.Location = new Point(25, 35);
            invoiceLabel.Name = "invoiceLabel";
            invoiceLabel.Size = new Size(85, 20);
            invoiceLabel.TabIndex = 0;
            invoiceLabel.Text = "Mã hóa đơn";
            //
            // invoiceTextBox
            //
            invoiceTextBox.Location = new Point(135, 30);
            invoiceTextBox.Name = "invoiceTextBox";
            invoiceTextBox.ReadOnly = true;
            invoiceTextBox.Size = new Size(250, 27);
            invoiceTextBox.TabIndex = 1;
            //
            // productLabel
            //
            productLabel.AutoSize = true;
            productLabel.Location = new Point(25, 80);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(99, 20);
            productLabel.TabIndex = 2;
            productLabel.Text = "Mã sản phẩm";
            //
            // productComboBox
            //
            productComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            productComboBox.FormattingEnabled = true;
            productComboBox.Location = new Point(135, 75);
            productComboBox.Name = "productComboBox";
            productComboBox.Size = new Size(250, 28);
            productComboBox.TabIndex = 3;
            //
            // quantityLabel
            //
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new Point(25, 125);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(66, 20);
            quantityLabel.TabIndex = 4;
            quantityLabel.Text = "Số lượng";
            //
            // quantityInput
            //
            quantityInput.Location = new Point(135, 120);
            quantityInput.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            quantityInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            quantityInput.Name = "quantityInput";
            quantityInput.Size = new Size(250, 27);
            quantityInput.TabIndex = 5;
            quantityInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // addButton
            //
            addButton.Location = new Point(405, 75);
            addButton.Name = "addButton";
            addButton.Size = new Size(90, 32);
            addButton.TabIndex = 6;
            addButton.Text = "Thêm";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            //
            // cancelButton
            //
            cancelButton.Location = new Point(405, 120);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(90, 32);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Hủy";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            //
            // detailsListView
            //
            detailsListView.Columns.AddRange(new ColumnHeader[] { productIdColumn, productNameColumn, quantityColumn });
            detailsListView.FullRowSelect = true;
            detailsListView.GridLines = true;
            detailsListView.Location = new Point(30, 315);
            detailsListView.Name = "detailsListView";
            detailsListView.Size = new Size(605, 150);
            detailsListView.TabIndex = 2;
            detailsListView.UseCompatibleStateImageBehavior = false;
            detailsListView.View = View.Details;
            //
            // productIdColumn
            //
            productIdColumn.Text = "Mã SP";
            productIdColumn.Width = 170;
            //
            // productNameColumn
            //
            productNameColumn.Text = "Tên sản phẩm";
            productNameColumn.Width = 260;
            //
            // quantityColumn
            //
            quantityColumn.Text = "Số lượng";
            quantityColumn.Width = 120;
            //
            // paymentButton
            //
            paymentButton.Location = new Point(480, 490);
            paymentButton.Name = "paymentButton";
            paymentButton.Size = new Size(155, 35);
            paymentButton.TabIndex = 3;
            paymentButton.Text = "Thanh toán";
            paymentButton.UseVisualStyleBackColor = true;
            paymentButton.Click += PaymentButton_Click;
            //
            // SalesForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 560);
            Controls.Add(newInvoiceButton);
            Controls.Add(detailsGroup);
            Controls.Add(detailsListView);
            Controls.Add(paymentButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SalesForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bán hàng";
            Load += SalesForm_Load;
            ((System.ComponentModel.ISupportInitialize)quantityInput).EndInit();
            detailsGroup.ResumeLayout(false);
            detailsGroup.PerformLayout();
            ResumeLayout(false);
        }
    }
}
