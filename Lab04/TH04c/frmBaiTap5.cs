using System;
using System.Windows.Forms;

namespace TH04c
{
    public partial class frmBaiTap5 : Form
    {
        public frmBaiTap5()
        {
            InitializeComponent();
        }

        // Nút Thực hiện
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            int so;

            // Kiểm tra dữ liệu có phải số nguyên hay không
            if (!int.TryParse(txtNhapDaySo.Text, out so))
            {
                MessageBox.Show(
                    "Vui lòng nhập số nguyên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNhapDaySo.Focus();
                return;
            }

            // Kiểm tra số từ 1 đến 999
            if (so < 1 || so > 999)
            {
                MessageBox.Show(
                    "Vui lòng nhập số từ 1 đến 999!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNhapDaySo.Focus();
                return;
            }

            // Đọc số thành chữ
            txtThanhChu.Text = DocSo(so);
        }

        // Hàm đọc số
        private string DocSo(int so)
        {
            string[] donVi =
            {
                "không",
                "một",
                "hai",
                "ba",
                "bốn",
                "năm",
                "sáu",
                "bảy",
                "tám",
                "chín"
            };

            // Số có 1 chữ số
            if (so < 10)
            {
                return donVi[so];
            }

            // Số có 2 chữ số
            if (so < 100)
            {
                int hangChuc = so / 10;
                int hangDonVi = so % 10;

                string ketQua = donVi[hangChuc] + " mươi";

                if (hangDonVi == 0)
                {
                    return ketQua;
                }

                if (hangDonVi == 1)
                {
                    return ketQua + " mốt";
                }

                if (hangDonVi == 5)
                {
                    return ketQua + " lăm";
                }

                return ketQua + " " + donVi[hangDonVi];
            }

            // Số có 3 chữ số
            int hangTram = so / 100;
            int hangChuc3 = (so / 10) % 10;
            int hangDonVi3 = so % 10;

            string ketQua3 = donVi[hangTram] + " trăm";

            // Ví dụ 100, 200, 300...
            if (hangChuc3 == 0 && hangDonVi3 == 0)
            {
                return ketQua3;
            }

            // Ví dụ 101, 102, 105...
            if (hangChuc3 == 0)
            {
                string ketQua = ketQua3 + " lẻ";

                if (hangDonVi3 == 5)
                {
                    return ketQua + " năm";
                }

                return ketQua + " " + donVi[hangDonVi3];
            }

            // Có hàng chục
            string ketQua4 = ketQua3 + " " + donVi[hangChuc3] + " mươi";

            if (hangDonVi3 == 0)
            {
                return ketQua4;
            }

            if (hangDonVi3 == 1)
            {
                return ketQua4 + " mốt";
            }

            if (hangDonVi3 == 5)
            {
                return ketQua4 + " lăm";
            }

            return ketQua4 + " " + donVi[hangDonVi3];
        }

        // Nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNhapDaySo.Clear();
            txtThanhChu.Clear();

            txtNhapDaySo.Focus();
        }

        // Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Xác nhận trước khi đóng Form
        private void frmBaiTap5_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn đóng Form không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}