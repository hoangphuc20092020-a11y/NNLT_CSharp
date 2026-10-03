using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TH04c
{
    public partial class frmBaiTap3 : Form
    {
        public frmBaiTap3()
        {
            InitializeComponent();
        }


        // Nút Thực hiện
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            int a;
            int b;

            // Kiểm tra số a
            if (!int.TryParse(txtA.Text, out a))
            {
                MessageBox.Show(
                    "Vui lòng nhập số nguyên hợp lệ cho a!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtA.Focus();
                return;
            }

            // Kiểm tra số b
            if (!int.TryParse(txtB.Text, out b))
            {
                MessageBox.Show(
                    "Vui lòng nhập số nguyên hợp lệ cho b!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtB.Focus();
                return;
            }

            // Kiểm tra a và b khác 0
            if (a == 0 && b == 0)
            {
                MessageBox.Show(
                    "Không thể tính UCLN và BCNN của 0 và 0!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Tính UCLN
            int ucln = TinhUCLN(a, b);

            // Tính BCNN
            int bcnn = Math.Abs(a / ucln * b);

            // Xuất kết quả
            txtUCLN.Text = ucln.ToString();
            txtBCNN.Text = bcnn.ToString();
        }

        // Hàm tính UCLN bằng thuật toán Euclid
        private int TinhUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }

            return a;
        }

        // Nút Tiếp tục
        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtUCLN.Clear();
            txtBCNN.Clear();

            txtA.Focus();
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
        private void frmBaiTap3_FormClosing(
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