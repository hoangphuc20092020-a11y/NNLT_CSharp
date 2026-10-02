using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TH04c
{
    public partial class frmBaiTap1 : Form
    {
        public frmBaiTap1()
        {
            InitializeComponent();
        }
        private void btnCong_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);

            txtKetQua.Text = (a + b).ToString();
        }
        private void btnTru_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);

            txtKetQua.Text = (a - b).ToString();
        }
        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);

            txtKetQua.Text = (a * b).ToString();
        }
        private void btnChia_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);

            if (b == 0)
            {
                MessageBox.Show("Không thể chia cho 0!");
                return;
            }

            txtKetQua.Text = (a / b).ToString();
        }
        private bool KiemTraDuLieu()
        {
            bool hopLe = true;

            errorProvider1.Clear();

            if (!double.TryParse(txtA.Text, out _))
            {
                errorProvider1.SetError(txtA, "Vui lòng nhập số hợp lệ.");
                hopLe = false;
            }

            if (!double.TryParse(txtB.Text, out _))
            {
                errorProvider1.SetError(txtB, "Vui lòng nhập số hợp lệ.");
                hopLe = false;
            }

            if (!hopLe)
            {
                MessageBox.Show("Dữ liệu nhập không phù hợp!");
            }

            return hopLe;
        }
        private void txtSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' &&
                e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát không?",
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
