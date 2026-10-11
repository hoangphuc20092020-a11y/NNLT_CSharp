using System;
using System.Linq;
using System.Windows.Forms;

namespace TH5C
{
    public partial class fmMauListBox : Form
    {
        public fmMauListBox()
        {
            InitializeComponent();

            // Dữ liệu ban đầu của ListBox bên trái
            lstTrai.Items.AddRange(new object[]
            {
                "Cóc", "Ổi", "Xoài", "Me", "Bưởi", "Cam"
            });

            // Nối sự kiện cho các nút
            btnPhai.Click += btnPhai_Click;
            btnPhaiAll.Click += btnPhaiAll_Click;
            btnTrai.Click += btnTrai_Click;
            btnTraiAll.Click += btnTraiAll_Click;
            btnTuyY.Click += btnTuyY_Click;

            // Nối sự kiện xác nhận khi đóng form
            FormClosing += fmMauListBox_FormClosing;
        }

        // Chuyển một phần tử đang chọn
        private void ChuyenMot(ListBox nguon, ListBox dich)
        {
            int viTri = nguon.SelectedIndex;

            if (viTri < 0)
            {
                MessageBox.Show("Bạn chưa chọn phần tử.");
                return;
            }

            object phanTu = nguon.Items[viTri];

            dich.Items.Add(phanTu);
            nguon.Items.RemoveAt(viTri);
        }

        // Chuyển toàn bộ phần tử
        private void ChuyenTatCa(ListBox nguon, ListBox dich)
        {
            object[] danhSach = nguon.Items
                .Cast<object>()
                .ToArray();

            dich.Items.AddRange(danhSach);
            nguon.Items.Clear();
        }

        // > : trái sang phải
        private void btnPhai_Click(object? sender, EventArgs e)
        {
            ChuyenMot(lstTrai, lstPhai);
        }

        // >> : tất cả bên trái sang phải
        private void btnPhaiAll_Click(object? sender, EventArgs e)
        {
            ChuyenTatCa(lstTrai, lstPhai);
        }

        // < : phải sang trái
        private void btnTrai_Click(object? sender, EventArgs e)
        {
            ChuyenMot(lstPhai, lstTrai);
        }

        // << : tất cả bên phải sang trái
        private void btnTraiAll_Click(object? sender, EventArgs e)
        {
            ChuyenTatCa(lstPhai, lstTrai);
        }

        // Chuyển các phần tử được chọn bên trái sang phải
        private void btnTuyY_Click(object? sender, EventArgs e)
        {
            int[] cacViTri = lstTrai.SelectedIndices
                .Cast<int>()
                .ToArray();

            if (cacViTri.Length == 0)
            {
                MessageBox.Show("Hãy chọn các phần tử cần chuyển.");
                return;
            }

            // Thêm sang phải theo thứ tự ban đầu
            foreach (int i in cacViTri)
            {
                lstPhai.Items.Add(lstTrai.Items[i]);
            }

            // Xóa từ cuối về đầu để không bị lệch chỉ số
            foreach (int i in cacViTri.OrderByDescending(x => x))
            {
                lstTrai.Items.RemoveAt(i);
            }
        }

        private void fmMauListBox_FormClosing(
            object? sender,
            FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing)
                return;

            DialogResult ketQua = MessageBox.Show(
                "Bạn có muốn đóng chương trình không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            e.Cancel = ketQua != DialogResult.Yes;
        }
    }
}