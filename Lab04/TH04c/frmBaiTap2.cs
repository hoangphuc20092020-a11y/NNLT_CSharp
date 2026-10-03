using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TH04c
{
    public partial class frmBaiTap2 : Form
    {
        public frmBaiTap2()
        {
            InitializeComponent();
        }

        // Kiểm tra email khi rời khỏi TextBox
        private void txtDiaChiEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDiaChiEmail.Text))
            {
                return;
            }

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(txtDiaChiEmail.Text, pattern))
            {
                MessageBox.Show(
                    "Địa chỉ email không hợp lệ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtDiaChiEmail.Focus();
            }
        }

        // Xử lý khi bấm nút Đăng ký
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            HienThiThongTin();
        }

        // Kiểm tra các TextBox bắt buộc nhập
        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên đăng nhập!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtTenDangNhap.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDiaChiEmail.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập địa chỉ email!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtDiaChiEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập mật khẩu!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtMatKhau.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtXacNhanMatKhau.Text))
            {
                MessageBox.Show(
                    "Vui lòng xác nhận mật khẩu!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtXacNhanMatKhau.Focus();
                return false;
            }

            if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                MessageBox.Show(
                    "Mật khẩu xác nhận không trùng khớp!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtXacNhanMatKhau.Focus();
                return false;
            }

            return true;
        }

        // Hiển thị thông tin lên MessageBox
        private void HienThiThongTin()
        {
            string thongTin =
                "Tên đăng nhập: " + txtTenDangNhap.Text +
                "\nĐịa chỉ email: " + txtDiaChiEmail.Text +
                "\nMật khẩu: " + txtMatKhau.Text +
                "\nXác nhận mật khẩu: " + txtXacNhanMatKhau.Text;

            MessageBox.Show(
                thongTin,
                "Thông tin đăng ký",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // Nhấn Enter ở TextBox Xác nhận mật khẩu
        private void txtXacNhanMatKhau_KeyDown(
            object sender,
            KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangKy.PerformClick();
            }
        }

        // Hỏi xác nhận trước khi đóng Form
        private void frmBaiTap2_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn đóng Form không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frmBaiTap2_Load(object sender, EventArgs e)
        {

        }
    }
}
