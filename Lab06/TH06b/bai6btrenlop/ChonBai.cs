namespace bai6btrenlop
{
    public partial class ChonBai : Form
    {
        public ChonBai()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            using var form = new QuanLySinhVien();
            form.ShowDialog(this);
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            using var form = new QuanLyDiem();
            form.ShowDialog(this);
        }
    }
}
