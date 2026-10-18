namespace bai6bnangcao
{
    public partial class ChonBai : Form
    {
        public ChonBai()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            using var form = new DanhSachLop();
            form.ShowDialog(this);
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            using var form = new DanhSachDiem();
            form.ShowDialog(this);
        }
    }
}
