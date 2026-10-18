namespace bai6anangcao
{
    public partial class ChonBai : Form
    {
        public ChonBai()
        {
            InitializeComponent();
        }

        private void btnSinhVien_Click(object? sender, EventArgs e)
        {
            using (QuanLySinhVien form = new QuanLySinhVien())
                form.ShowDialog(this);
        }

        private void btnDiem_Click(object? sender, EventArgs e)
        {
            using (QuanLyDiem form = new QuanLyDiem())
                form.ShowDialog(this);
        }
    }
}
