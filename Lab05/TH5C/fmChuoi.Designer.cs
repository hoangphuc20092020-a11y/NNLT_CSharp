#nullable enable
namespace TH5C;

partial class fmChuoi
{
    private System.ComponentModel.IContainer? components;
    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        Font = new Font("Tahoma", 11F);
        btnNgauNhien = new Button();
        lblSuaTen = new Label();
        lstTen = new ListBox();
        btnXoaChon = new Button();
        btnXoaSon = new Button();
        btnXoaLe = new Button();
        btnHoa = new Button();
        btnThuong = new Button();
        btnHoaDau = new Button();
        btnXoaTatCa = new Button();
        SuspendLayout();
        // btnNgauNhien
        btnNgauNhien.Name = "btnNgauNhien";
        btnNgauNhien.Location = new Point(20, 20);
        btnNgauNhien.Size = new Size(300, 38);
        btnNgauNhien.TabIndex = 0;
        btnNgauNhien.Text = "Nhập 50 tên ngẫu nhiên";
        btnNgauNhien.UseVisualStyleBackColor = true;
        // lblSuaTen
        lblSuaTen.Name = "lblSuaTen";
        lblSuaTen.Location = new Point(350, 25);
        lblSuaTen.Size = new Size(480, 32);
        lblSuaTen.TabIndex = 1;
        lblSuaTen.Text = "Nhấp đúp vào một tên để sửa.";
        lblSuaTen.AutoSize = false;
        lblSuaTen.TextAlign = ContentAlignment.MiddleLeft;
        // lstTen
        lstTen.Name = "lstTen";
        lstTen.Location = new Point(20, 75);
        lstTen.Size = new Size(300, 425);
        lstTen.TabIndex = 2;
        lstTen.IntegralHeight = false;
        lstTen.HorizontalScrollbar = true;
        lstTen.SelectionMode = SelectionMode.MultiExtended;
        lstTen.Sorted = false;
        // btnXoaChon
        btnXoaChon.Name = "btnXoaChon";
        btnXoaChon.Location = new Point(350, 75);
        btnXoaChon.Size = new Size(480, 44);
        btnXoaChon.TabIndex = 3;
        btnXoaChon.Text = "Xóa phần tử đang chọn";
        btnXoaChon.UseVisualStyleBackColor = true;
        // btnXoaSon
        btnXoaSon.Name = "btnXoaSon";
        btnXoaSon.Location = new Point(350, 131);
        btnXoaSon.Size = new Size(480, 44);
        btnXoaSon.TabIndex = 4;
        btnXoaSon.Text = "Xóa phần tử có tên là Sơn";
        btnXoaSon.UseVisualStyleBackColor = true;
        // btnXoaLe
        btnXoaLe.Name = "btnXoaLe";
        btnXoaLe.Location = new Point(350, 187);
        btnXoaLe.Size = new Size(480, 44);
        btnXoaLe.TabIndex = 5;
        btnXoaLe.Text = "Xóa phần tử có họ là Lê";
        btnXoaLe.UseVisualStyleBackColor = true;
        // btnHoa
        btnHoa.Name = "btnHoa";
        btnHoa.Location = new Point(350, 243);
        btnHoa.Size = new Size(480, 44);
        btnHoa.TabIndex = 6;
        btnHoa.Text = "Chuyển phần tử đang chọn thành chữ HOA";
        btnHoa.UseVisualStyleBackColor = true;
        // btnThuong
        btnThuong.Name = "btnThuong";
        btnThuong.Location = new Point(350, 299);
        btnThuong.Size = new Size(480, 44);
        btnThuong.TabIndex = 7;
        btnThuong.Text = "Chuyển phần tử đang chọn thành chữ thường";
        btnThuong.UseVisualStyleBackColor = true;
        // btnHoaDau
        btnHoaDau.Name = "btnHoaDau";
        btnHoaDau.Location = new Point(350, 355);
        btnHoaDau.Size = new Size(480, 58);
        btnHoaDau.TabIndex = 8;
        btnHoaDau.Text = "Viết hoa đầu mỗi từ của phần tử đang chọn";
        btnHoaDau.UseVisualStyleBackColor = true;
        // btnXoaTatCa
        btnXoaTatCa.Name = "btnXoaTatCa";
        btnXoaTatCa.Location = new Point(350, 429);
        btnXoaTatCa.Size = new Size(480, 44);
        btnXoaTatCa.TabIndex = 9;
        btnXoaTatCa.Text = "Xóa tất cả các phần tử";
        btnXoaTatCa.UseVisualStyleBackColor = true;
        Controls.Add(btnXoaTatCa);
        Controls.Add(btnHoaDau);
        Controls.Add(btnThuong);
        Controls.Add(btnHoa);
        Controls.Add(btnXoaLe);
        Controls.Add(btnXoaSon);
        Controls.Add(btnXoaChon);
        Controls.Add(lstTen);
        Controls.Add(lblSuaTen);
        Controls.Add(btnNgauNhien);
        ClientSize = new Size(850, 520);
        AutoScaleDimensions = new SizeF(96F, 96F);
        Name = "fmChuoi";
        Text = "Nâng cao - Xử lý họ tên";
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        ResumeLayout(false);
        PerformLayout();
    }

    private Button btnNgauNhien = null!;
    private Label lblSuaTen = null!;
    private ListBox lstTen = null!;
    private Button btnXoaChon = null!;
    private Button btnXoaSon = null!;
    private Button btnXoaLe = null!;
    private Button btnHoa = null!;
    private Button btnThuong = null!;
    private Button btnHoaDau = null!;
    private Button btnXoaTatCa = null!;
}
