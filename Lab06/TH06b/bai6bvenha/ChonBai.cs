namespace bai6bvenha
{
    public partial class ChonBai : Form
    {
        public ChonBai()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            using var form = new QuanLySanPham();
            form.ShowDialog(this);
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            using var form = new TaoTonKho();
            form.ShowDialog(this);
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            using var form = new NhapHang();
            form.ShowDialog(this);
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            using var form = new BanHang();
            form.ShowDialog(this);
        }
    }
}
