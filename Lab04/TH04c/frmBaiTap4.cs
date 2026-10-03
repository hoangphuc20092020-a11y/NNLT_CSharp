using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TH04c
{
    public partial class frmBaiTap4 : Form
    {
        // Danh sách lưu các số đã nhập
        private List<int> danhSach = new List<int>();

        public frmBaiTap4()
        {
            InitializeComponent();
        }

        // Nút Nhập
        private void btnNhap_Click(object sender, EventArgs e)
        {
            int so;

            // Kiểm tra dữ liệu nhập
            if (!int.TryParse(txtNhapSo.Text, out so))
            {
                MessageBox.Show(
                    "Vui lòng nhập một số nguyên hợp lệ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNhapSo.Focus();
                return;
            }

            // Thêm số vào danh sách
            danhSach.Add(so);

            // Xuất dãy vừa nhập
            txtDayVuaNhap.Text = string.Join(" ", danhSach);

            // Tính tổng
            int tong = 0;
            int tongChan = 0;
            int tongLe = 0;

            foreach (int x in danhSach)
            {
                tong += x;

                if (x % 2 == 0)
                {
                    tongChan += x;
                }
                else
                {
                    tongLe += x;
                }
            }

            // Xuất kết quả
            txtTCPTTD.Text = tong.ToString();
            txtTongChan.Text = tongChan.ToString();
            txtTongLe.Text = tongLe.ToString();

            // Xóa ô nhập để nhập số tiếp theo
            txtNhapSo.Clear();
            txtNhapSo.Focus();
        }

        // Nút Tiếp tục
        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            // Xóa danh sách
            danhSach.Clear();

            // Xóa các TextBox
            txtNhapSo.Clear();
            txtDayVuaNhap.Clear();
            txtTCPTTD.Clear();
            txtTongChan.Clear();
            txtTongLe.Clear();

            // Đưa con trỏ về ô Nhập số
            txtNhapSo.Focus();
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

        // Hỏi xác nhận trước khi đóng Form
        private void frmBaiTap4_FormClosing(
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