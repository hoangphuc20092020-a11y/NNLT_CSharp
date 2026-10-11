using System;
using System.Windows.Forms;

namespace TH5C
{
    public partial class fmMauDantoc : LabForm
    {
        public fmMauDantoc()
        {
            InitializeComponent();

            // Nối sự kiện
            btnLoad.Click += btnLoad_Click;
            btnHienThi.Click += btnHienThi_Click;

            cboDanToc.SelectedIndexChanged +=
                cboDanToc_SelectedIndexChanged;
        }

        private void btnLoad_Click(object? sender, EventArgs e)
        {
            // Xóa danh sách cũ để tránh thêm trùng khi nạp lại
            cboDanToc.Items.Clear();

            // Nạp danh sách dân tộc
            cboDanToc.Items.AddRange(new object[]
            {
                "Kinh",
                "Hoa",
                "K’Me",
                "H’Mong",
                "Khác"
            });

            // Nạp lại dữ liệu thì đặt lại thông báo kết quả
            lblKetQua.Text = "Chưa chọn dân tộc";
        }

        private void btnHienThi_Click(object? sender, EventArgs e)
        {
            // -1 nghĩa là chưa chọn mục nào
            if (cboDanToc.SelectedIndex < 0)
            {
                lblKetQua.Text = "Bạn chưa chọn dân tộc";
                return;
            }

            lblKetQua.Text =
                $"Dân tộc được chọn: {cboDanToc.SelectedItem}";
        }

        private void cboDanToc_SelectedIndexChanged(
            object? sender,
            EventArgs e)
        {
            // Bỏ qua khi chưa có lựa chọn
            if (cboDanToc.SelectedIndex < 0)
            {
                return;
            }

            ThongBao($"Dân tộc được chọn: {cboDanToc.SelectedItem}");
        }
    }
}