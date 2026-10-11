using Microsoft.VisualBasic;

namespace TH5C;

// Các hộp thoại dùng chung. Form con có thể ghi đè khi kiểm tra tự động.
public class LabForm : Form
{
    protected virtual void ThongBao(string noiDung)
        => MessageBox.Show(this, noiDung, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

    protected virtual bool XacNhan(string noiDung)
        => MessageBox.Show(this, noiDung, "Xác nhận", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;

    protected virtual string NhapChuoi(string noiDung, string giaTriCu)
        => Interaction.InputBox(noiDung, "Sửa họ tên", giaTriCu);

    protected void XacNhanDong(object? sender, FormClosingEventArgs e)
    {
        if (e.CloseReason == CloseReason.UserClosing)
            e.Cancel = !XacNhan("Bạn có muốn đóng bài này?");
    }
}
