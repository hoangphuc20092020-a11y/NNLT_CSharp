using System.Diagnostics;
namespace TH5D;
public partial class fmDemNguoc : LabForm
{
    private readonly Stopwatch dongHo = new();
    private TimeSpan thoiLuong = TimeSpan.FromMinutes(30);
    public fmDemNguoc()
    {
        InitializeComponent();
        timer1.Tick += (_, _) => CapNhatDongHo();
        btnBatDau.Click += (_, _) =>
        {
            if (dongHo.IsRunning) return;
            thoiLuong = TimeSpan.FromMinutes((double)nudPhut.Value);
            dongHo.Restart(); timer1.Start();
            btnBatDau.Enabled = false; nudPhut.Enabled = false; CapNhatDongHo();
        };
        btnDung.Click += (_, _) => { timer1.Stop(); dongHo.Stop(); btnBatDau.Enabled = true; nudPhut.Enabled = true; };
        FormClosed += (_, _) => { timer1.Stop(); dongHo.Stop(); };
        HienThi(thoiLuong);
    }
    protected virtual TimeSpan ThoiGianDaQua() => dongHo.Elapsed;
    private void CapNhatDongHo()
    {
        TimeSpan conLai = thoiLuong - ThoiGianDaQua();
        if (conLai <= TimeSpan.Zero)
        {
            HienThi(TimeSpan.Zero); timer1.Stop(); dongHo.Stop();
            btnBatDau.Enabled = true; nudPhut.Enabled = true; ThongBao("Đã hết thời gian.");
            return;
        }
        HienThi(conLai);
    }
    private void HienThi(TimeSpan conLai)
    {
        int giay = (int)Math.Ceiling(conLai.TotalSeconds);
        lblDongHo.Text = $"{giay / 60:00}:{giay % 60:00}";
    }
}
