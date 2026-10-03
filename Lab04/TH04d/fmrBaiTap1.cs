using System;
using System.Windows.Forms;

namespace TH04d
{
    public partial class fmrBaiTap1 : Form
    {
        public fmrBaiTap1()
        {
            InitializeComponent();
        }

        // Khi Form vừa mở
        private void frmBaiTap1_Load(object sender, EventArgs e)
        {
            btnGiai.Enabled = false;

            // Mặc định chọn phương trình bậc nhất
            rdoPTBN.Checked = true;

            // Ẩn c
            lblC.Visible = false;
            txtC.Visible = false;
        }

        // Chọn phương trình bậc nhất
        private void rdoPTBN_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPTBN.Checked)
            {
                lblC.Visible = false;
                txtC.Visible = false;

                txtC.Clear();

                KiemTraDuLieu();
            }
        }

        // Chọn phương trình bậc hai
        private void rdoPTBH_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPTBH.Checked)
            {
                lblC.Visible = true;
                txtC.Visible = true;

                KiemTraDuLieu();
            }
        }

        // Khi nhập a
        private void txtA_TextChanged(object sender, EventArgs e)
        {
            KiemTraDuLieu();
        }

        // Khi nhập b
        private void txtB_TextChanged(object sender, EventArgs e)
        {
            KiemTraDuLieu();
        }

        // Khi nhập c
        private void txtC_TextChanged(object sender, EventArgs e)
        {
            KiemTraDuLieu();
        }

        // Kiểm tra dữ liệu nhập
        private bool KiemTraDuLieu()
        {
            double a;
            double b;
            double c;

            // Kiểm tra a
            if (!double.TryParse(txtA.Text, out a))
            {
                btnGiai.Enabled = false;
                return false;
            }

            // Kiểm tra b
            if (!double.TryParse(txtB.Text, out b))
            {
                btnGiai.Enabled = false;
                return false;
            }

            // Nếu là phương trình bậc hai thì kiểm tra c
            if (rdoPTBH.Checked)
            {
                if (!double.TryParse(txtC.Text, out c))
                {
                    btnGiai.Enabled = false;
                    return false;
                }
            }

            // Đủ dữ liệu
            btnGiai.Enabled = true;

            return true;
        }

        // Nút Giải
        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            double c = 0;

            // Kiểm tra a
            if (!double.TryParse(txtA.Text, out a))
            {
                MessageBox.Show(
                    "Giá trị a không hợp lệ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtA.Focus();
                return;
            }

            // Kiểm tra b
            if (!double.TryParse(txtB.Text, out b))
            {
                MessageBox.Show(
                    "Giá trị b không hợp lệ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtB.Focus();
                return;
            }

            // Nếu là bậc hai thì kiểm tra c
            if (rdoPTBH.Checked)
            {
                if (!double.TryParse(txtC.Text, out c))
                {
                    MessageBox.Show(
                        "Giá trị c không hợp lệ!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtC.Focus();
                    return;
                }
            }

            // Tạo đối tượng PhuongTrinhBacHai
            PhuongTrinhBacHai pt =
                new PhuongTrinhBacHai(a, b, c);

            // Giải
            if (rdoPTBN.Checked)
            {
                txtKetQua.Text = pt.GiaiBacNhat();
            }
            else
            {
                txtKetQua.Text = pt.GiaiBacHai();
            }

            // Giải xong thì nút Giải mờ đi
            btnGiai.Enabled = false;
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

        // Khi Form đóng
        private void frmBaiTap1_FormClosing(
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