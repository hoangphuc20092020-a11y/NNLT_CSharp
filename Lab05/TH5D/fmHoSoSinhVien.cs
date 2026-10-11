using System;
using System.Windows.Forms;

namespace TH5D
{
    public partial class fmHoSoSinhVien : LabForm
    {
        public fmHoSoSinhVien()
        {
            InitializeComponent();
            Load += fmHoSoSinhVien_Load;
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            lstv1.MouseDown += lstv1_MouseDown;
            lstv1.SelectedIndexChanged += lstv1_SelectedIndexChanged;
            FormClosing += fmHoSoSinhVien_FormClosing;
        }

        private void fmHoSoSinhVien_Load(object? sender, EventArgs e)
        {
            comboBoxEth.Items.Clear();
            comboBoxEth.Items.AddRange(new object[] { "Kinh", "Tày", "Thái", "Hoa", "Khmer", "Chăm" });
            comboBoxEth.SelectedIndex = 0;
            radioButtonMale.Checked = true;
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            if (FindStudent(textBoxId.Text.Trim()) != null)
            {
                ThongBao("Mã sinh viên đã tồn tại.");
                textBoxId.Focus();
                return;
            }

            ListViewItem item = new ListViewItem(textBoxName.Text.Trim());
            item.SubItems.Add(textBoxId.Text.Trim());
            item.SubItems.Add(radioButtonMale.Checked ? "Nam" : "Nữ");
            item.SubItems.Add(GetLanguages());
            item.SubItems.Add(comboBoxEth.Text);
            lstv1.Items.Add(item);
            ClearInputs();
        }

        private void btnEdit_Click(object? sender, EventArgs e)
        {
            if (lstv1.SelectedItems.Count == 0)
            {
                ThongBao("Vui lòng chọn sinh viên cần sửa.");
                return;
            }

            if (!ValidateInput())
            {
                return;
            }

            ListViewItem item = lstv1.SelectedItems[0];
            item.SubItems[0].Text = textBoxName.Text.Trim();
            item.SubItems[2].Text = radioButtonMale.Checked ? "Nam" : "Nữ";
            item.SubItems[3].Text = GetLanguages();
            item.SubItems[4].Text = comboBoxEth.Text;
            ClearInputs();
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            DeleteSelectedItem();
        }

        private void deleteToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            DeleteSelectedItem();
        }

        private void lstv1_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem? item = lstv1.GetItemAt(e.X, e.Y);
                lstv1.SelectedItems.Clear();
                if (item != null)
                {
                    item.Selected = true;
                }
            }
        }

        private void lstv1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (lstv1.SelectedItems.Count == 0)
            {
                textBoxId.ReadOnly = false;
                return;
            }

            ListViewItem item = lstv1.SelectedItems[0];
            textBoxName.Text = item.SubItems[0].Text;
            textBoxId.Text = item.SubItems[1].Text;
            textBoxId.ReadOnly = true;
            radioButtonMale.Checked = item.SubItems[2].Text == "Nam";
            radioButtonFemale.Checked = !radioButtonMale.Checked;
            checkBoxEng.Checked = item.SubItems[3].Text.Contains("Anh");
            checkBoxFra.Checked = item.SubItems[3].Text.Contains("Pháp");
            checkBoxChi.Checked = item.SubItems[3].Text.Contains("Hoa");
            comboBoxEth.SelectedItem = item.SubItems[4].Text;
        }

        private ListViewItem? FindStudent(string id)
        {
            foreach (ListViewItem item in lstv1.Items)
            {
                if (string.Equals(item.SubItems[1].Text, id, StringComparison.OrdinalIgnoreCase))
                {
                    return item;
                }
            }

            return null;
        }

        private string GetLanguages()
        {
            List<string> languages = new List<string>();
            if (checkBoxEng.Checked) languages.Add("Anh");
            if (checkBoxFra.Checked) languages.Add("Pháp");
            if (checkBoxChi.Checked) languages.Add("Hoa");
            return string.Join(", ", languages);
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                ThongBao("Vui lòng nhập đầy đủ họ tên và mã sinh viên.");
                return false;
            }

            if (!radioButtonMale.Checked && !radioButtonFemale.Checked)
            {
                ThongBao("Vui lòng chọn giới tính.");
                return false;
            }

            if (comboBoxEth.SelectedIndex < 0)
            {
                ThongBao("Vui lòng chọn dân tộc.");
                return false;
            }
            return true;
        }

        private void DeleteSelectedItem()
        {
            if (lstv1.SelectedItems.Count == 0)
            {
                ThongBao("Vui lòng chọn sinh viên cần xóa.");
                return;
            }

            if (XacNhan("Bạn có chắc muốn xóa sinh viên đã chọn không?"))
            {
                lstv1.Items.Remove(lstv1.SelectedItems[0]);
                ClearInputs();
            }
        }

        private void ClearInputs()
        {
            textBoxName.Clear();
            textBoxId.Clear();
            textBoxId.ReadOnly = false;
            radioButtonMale.Checked = true;
            radioButtonFemale.Checked = false;
            checkBoxEng.Checked = false;
            checkBoxFra.Checked = false;
            checkBoxChi.Checked = false;
            if (comboBoxEth.Items.Count > 0) comboBoxEth.SelectedIndex = 0;
            lstv1.SelectedItems.Clear();
        }

        private void fmHoSoSinhVien_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !XacNhan("Bạn có chắc muốn đóng form không?"))
            {
                e.Cancel = true;
            }
        }
    }
}
