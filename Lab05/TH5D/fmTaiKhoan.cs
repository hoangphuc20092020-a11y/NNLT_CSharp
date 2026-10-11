using System.Globalization;

namespace TH5D;

public partial class fmTaiKhoan : LabForm
{
    private bool dangThem;
    private static readonly CultureInfo vanHoa = CultureInfo.GetCultureInfo("vi-VN");

    public fmTaiKhoan()
    {
        InitializeComponent();
        buttonAdd.Click += buttonAdd_Click;
        buttonSave.Click += buttonSave_Click;
        buttonDelete.Click += buttonDelete_Click;
        buttonExit.Click += (_, _) => Close();
        listViewAccounts.SelectedIndexChanged += (_, _) =>
        {
            buttonDelete.Enabled = !dangThem && listViewAccounts.SelectedItems.Count > 0;
            if (!dangThem) NapDongChon();
        };
        FormClosing += XacNhanDong;
        CapNhatTong();
    }

    private void buttonAdd_Click(object? sender, EventArgs e)
    {
        dangThem = !dangThem;
        buttonAdd.Text = dangThem ? "Hủy" : "Thêm";
        buttonSave.Enabled = dangThem;
        buttonDelete.Enabled = !dangThem && listViewAccounts.SelectedItems.Count > 0;
        listViewAccounts.Enabled = !dangThem;
        if (dangThem) { XoaNhap(); textBoxAccount.Focus(); }
        else { XoaNhap(); NapDongChon(); }
    }

    private void buttonSave_Click(object? sender, EventArgs e)
    {
        if (!dangThem) return;
        string soTK = textBoxAccount.Text.Trim(), ten = textBoxCustomer.Text.Trim(), diaChi = textBoxAddress.Text.Trim();
        if (soTK.Length == 0 || ten.Length == 0 || diaChi.Length == 0 || textBoxAmount.Text.Trim().Length == 0)
        { ThongBao("Nhập đủ số tài khoản, tên khách hàng, địa chỉ và số tiền."); return; }
        // Số tiền nhập không có dấu phân nhóm; dấu thập phân theo vi-VN.
        if (!decimal.TryParse(textBoxAmount.Text.Trim(), NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint,
            vanHoa, out decimal tien) || tien < 0 || decimal.Round(tien, 2) != tien)
        { ThongBao("Số tiền phải không âm, tối đa 2 chữ số thập phân; dùng dấu phẩy."); return; }
        if (listViewAccounts.Items.Cast<ListViewItem>().Any(i => string.Equals(i.SubItems[1].Text, soTK, StringComparison.OrdinalIgnoreCase)))
        { ThongBao("Số tài khoản đã tồn tại."); return; }
        decimal tong = listViewAccounts.Items.Cast<ListViewItem>().Sum(i => (decimal)i.Tag!);
        if (tien > decimal.MaxValue - tong) { ThongBao("Tổng tiền vượt phạm vi decimal."); return; }
        var item = new ListViewItem(new[] { "", soTK, ten, diaChi, tien.ToString("N2", vanHoa) }) { Tag = tien };
        listViewAccounts.Items.Add(item);
        CapNhatTong();
        buttonAdd_Click(sender, e);
    }

    private void buttonDelete_Click(object? sender, EventArgs e)
    {
        if (dangThem || listViewAccounts.SelectedItems.Count == 0) return;
        listViewAccounts.Items.Remove(listViewAccounts.SelectedItems[0]);
        XoaNhap(); CapNhatTong();
    }

    private void NapDongChon()
    {
        if (listViewAccounts.SelectedItems.Count == 0) return;
        ListViewItem item = listViewAccounts.SelectedItems[0];
        textBoxAccount.Text = item.SubItems[1].Text;
        textBoxCustomer.Text = item.SubItems[2].Text;
        textBoxAddress.Text = item.SubItems[3].Text;
        textBoxAmount.Text = ((decimal)item.Tag!).ToString(vanHoa);
    }

    private void XoaNhap()
    {
        textBoxAccount.Clear(); textBoxCustomer.Clear(); textBoxAddress.Clear(); textBoxAmount.Clear();
    }

    private void CapNhatTong()
    {
        decimal tong = 0;
        for (int i = 0; i < listViewAccounts.Items.Count; i++)
        {
            var item = listViewAccounts.Items[i]; item.Text = (i + 1).ToString();
            tong += (decimal)item.Tag!; // Không cộng lại từ chuỗi tiền đã định dạng.
        }
        textBoxTotal.Text = tong.ToString("N2", vanHoa);
    }
}
