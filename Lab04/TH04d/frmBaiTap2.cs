using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TH04d
{
    public partial class frmBaiTap2 : Form
    {
        private MangSoNguyen mang = new MangSoNguyen();
        public frmBaiTap2()
        {
            InitializeComponent();
        }
        private void btnNhapMang_Click(object sender, EventArgs e)
        {
            try
            {
                mang.NhapMang(txtNhapMang.Text);

                txtKetQuaMang.Text = mang.XuatMang();

                MessageBox.Show(
                    "Nhập mảng thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void btnKetQuaMang_Click(object sender, EventArgs e)
        {
            txtKetQuaMang.Text = mang.XuatMang();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNhapMang.Clear();
            txtKetQuaMang.Clear();

            txtTGTCT.Clear();
            txtTVTCT.Clear();
            txtSTDL.Clear();

            txtTGTCX.Clear();
            txtTVTCX.Clear();

            txtTGTCTH.Clear();
            txtTVTCTH.Clear();

            txtTongMang.Clear();
            txtTongChan.Clear();
            txtTongLe.Clear();

            txtGTLN.Clear();
            txtGTNN.Clear();

            txtGTCTT.Clear();
            txtVTCTT.Clear();
            txtSTTL.Clear();

            mang = new MangSoNguyen();

            rdoXapXepTang.Checked = false;
            rdoXapXepGiam.Checked = false;
            rdoTGTCT.Checked = false;
            rdoTVTCT.Checked = false;
            rdoTGTCX.Checked = false;
            rdoTVTCX.Checked = false;
            rdoTimGiaTriCanThem.Checked = false;
            rdoGTCTT.Checked = false;
            rdoVTCTT.Checked = false;
        }
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            try
            {
                // =========================
                // SẮP XẾP
                // =========================

                if (rdoXapXepTang.Checked)
                {
                    mang.SapXepTang();
                    txtKetQuaMang.Text = mang.XuatMang();
                    return;
                }

                if (rdoXapXepGiam.Checked)
                {
                    mang.SapXepGiam();
                    txtKetQuaMang.Text = mang.XuatMang();
                    return;
                }

                // =========================
                // TÌM KIẾM
                // =========================

                if (rdoTGTCT.Checked)
                {
                    if (!int.TryParse(txtTGTCT.Text, out int giaTri))
                    {
                        MessageBox.Show("Giá trị cần tìm không hợp lệ.");
                        return;
                    }

                    int viTri = mang.TimGiaTri(giaTri);

                    if (viTri == -1)
                    {
                        txtSTDL.Text = "Không tìm thấy";
                    }
                    else
                    {
                        txtSTDL.Text = viTri.ToString();
                    }

                    return;
                }

                if (rdoTVTCT.Checked)
                {
                    if (!int.TryParse(txtTVTCT.Text, out int viTri))
                    {
                        MessageBox.Show("Vị trí không hợp lệ.");
                        return;
                    }

                    txtSTDL.Text = mang.TimViTri(viTri).ToString();

                    return;
                }

                // =========================
                // XÓA
                // =========================

                if (rdoTGTCX.Checked)
                {
                    if (!int.TryParse(txtTGTCX.Text, out int giaTri))
                    {
                        MessageBox.Show("Giá trị cần xóa không hợp lệ.");
                        return;
                    }

                    if (!mang.XoaGiaTri(giaTri))
                    {
                        MessageBox.Show("Không tìm thấy giá trị cần xóa.");
                        return;
                    }

                    txtKetQuaMang.Text = mang.XuatMang();
                    return;
                }

                if (rdoTVTCX.Checked)
                {
                    if (!int.TryParse(txtTVTCX.Text, out int viTri))
                    {
                        MessageBox.Show("Vị trí cần xóa không hợp lệ.");
                        return;
                    }

                    mang.XoaViTri(viTri);

                    txtKetQuaMang.Text = mang.XuatMang();
                    return;
                }

                // =========================
                // THÊM
                // =========================

                if (rdoTimGiaTriCanThem.Checked)
                {
                    if (!int.TryParse(txtTGTCTH.Text, out int giaTri))
                    {
                        MessageBox.Show("Giá trị cần thêm không hợp lệ.");
                        return;
                    }

                    if (!int.TryParse(txtTVTCTH.Text, out int viTri))
                    {
                        MessageBox.Show("Vị trí cần thêm không hợp lệ.");
                        return;
                    }

                    mang.Them(giaTri, viTri);

                    txtKetQuaMang.Text = mang.XuatMang();
                    return;
                }

                // =========================
                // THAY THẾ
                // =========================

                if (rdoGTCTT.Checked)
                {
                    if (!int.TryParse(txtGTCTT.Text, out int giaTriCu))
                    {
                        MessageBox.Show("Giá trị cần thay thế không hợp lệ.");
                        return;
                    }

                    if (!int.TryParse(txtSTTL.Text, out int giaTriMoi))
                    {
                        MessageBox.Show("Số thay thế không hợp lệ.");
                        return;
                    }

                    if (!mang.ThayTheGiaTri(giaTriCu, giaTriMoi))
                    {
                        MessageBox.Show("Không tìm thấy giá trị cần thay thế.");
                        return;
                    }

                    txtKetQuaMang.Text = mang.XuatMang();
                    return;
                }

                if (rdoVTCTT.Checked)
                {
                    if (!int.TryParse(txtVTCTT.Text, out int viTri))
                    {
                        MessageBox.Show("Vị trí cần thay thế không hợp lệ.");
                        return;
                    }

                    if (!int.TryParse(txtSTTL.Text, out int giaTriMoi))
                    {
                        MessageBox.Show("Số thay thế không hợp lệ.");
                        return;
                    }

                    mang.ThayTheViTri(viTri, giaTriMoi);

                    txtKetQuaMang.Text = mang.XuatMang();
                    return;
                }

                MessageBox.Show(
                    "Vui lòng chọn một chức năng.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void btnTong_Click(object sender, EventArgs e)
        {
            try
            {
                txtTongMang.Text = mang.TongMang().ToString();
                txtTongChan.Text = mang.TongChan().ToString();
                txtTongLe.Text = mang.TongLe().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                txtGTLN.Text = mang.GiaTriLonNhat().ToString();
                txtGTNN.Text = mang.GiaTriNhoNhat().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
        private void frmBaiTap2_FormClosing(
    object sender,
    FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn đóng Form không?",
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
