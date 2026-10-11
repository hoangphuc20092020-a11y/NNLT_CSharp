using System.Data;
using System.Globalization;
using System.Reflection;
using System.Text.Json;
using Microsoft.Data.SqlClient;
using TH5D;

internal static class Program
{
    private static int functional, layout;
    private static string imageFolder=TestPaths.Images;
    private static bool? sqlAvailable;
    private static int? sqlProbeError;
    private static void Assert(bool b,string text) { if(!b) throw new InvalidOperationException(text); functional++; }
    private static T Find<T>(Control f,string n) where T:Control => f.Controls.Find(n,true).OfType<T>().Single();
    private static T Field<T>(object o,string n)
    {
        Type? t=o.GetType();
        while(t!=null) { var p=t.GetField(n,BindingFlags.NonPublic|BindingFlags.Instance); if(p!=null)return (T)p.GetValue(o)!; t=t.BaseType; }
        throw new MissingFieldException(n);
    }
    private static void Click(Form f,string n)=>typeof(Button).GetMethod("OnClick",BindingFlags.NonPublic|BindingFlags.Instance)!.Invoke(Find<Button>(f,n),new object[]{EventArgs.Empty});
    private static void Text(Form f,string n,string value)=>Find<TextBox>(f,n).Text=value;
    private static void Menu(Form f,string n)=>Field<ToolStripMenuItem>(f,n).PerformClick();
    private static void Open(Form f) { f.ShowInTaskbar=false; f.Opacity=0; f.Show(); Application.DoEvents(); }
    private static void Render(Form f,string n,bool verifyBounds=true)
    {
        if(verifyBounds) Bounds(f);
        using var b=new Bitmap(f.Width,f.Height); f.DrawToBitmap(b,new Rectangle(Point.Empty,b.Size)); b.Save(Path.Combine(imageFolder,n+".png"));
    }
    private static void Bounds(Control parent)
    {
        var controls=parent.Controls.Cast<Control>().Where(x=>x.Visible).ToArray();
        for(int i=0;i<controls.Length;i++)for(int j=i+1;j<controls.Length;j++)
        {
            if(controls[i] is MenuStrip || controls[j] is MenuStrip)continue;
            if(controls[i].Bounds.IntersectsWith(controls[j].Bounds))throw new InvalidOperationException($"Overlap: {parent.Name}/{controls[i].Name} and {controls[j].Name}"); layout++;
        }
        foreach(var c in controls)Bounds(c);
    }
    [STAThread]
    private static void Main(string[] args)
    {
        ApplicationConfiguration.Initialize(); Directory.CreateDirectory(imageFolder);
        int c=TH5CChecks.Run();
        TestHoSo(); TestTaiKhoan(); TestChuyenLop(); TestDemNguoc(); TestSql(); TestMain();
        if(args.Contains("--probe-sql")) ProbeSql();
        var result=new { th5cFunctional=TH5CChecks.FunctionalChecks,th5cLayout=TH5CChecks.LayoutChecks,th5dFunctional=functional,th5dLayout=layout,total=c+functional+layout,sqlDatabaseExecuted=false,sqlConnectionAvailable=sqlAvailable,sqlConnectionError=sqlProbeError };
        File.WriteAllText(TestPaths.Results,JsonSerializer.Serialize(result,new JsonSerializerOptions{WriteIndented=true}));
        Console.WriteLine($"TH5D PASS: {functional} functional and {layout} layout checks.");
        Console.WriteLine($"TOTAL PASS: {c+functional+layout}. SQL commands inspected with a fake executor; no database writes.");
    }

    private static void ProbeSql()
    {
        try
        {
            string? cs=Environment.GetEnvironmentVariable("TH5D_SQL_CONNECTION");
            if(string.IsNullOrWhiteSpace(cs))
            {
                using var json=JsonDocument.Parse(File.ReadAllText(Path.Combine(AppContext.BaseDirectory,"database.config.json")));
                cs=json.RootElement.GetProperty("ConnectionString").GetString();
            }
            using var connection=new SqlConnection(cs); connection.Open();
            using var cmd=new SqlCommand("SELECT DB_NAME()",connection);
            _=cmd.ExecuteScalar(); sqlAvailable=true;
            Console.WriteLine("SQL read-only connection probe succeeded; CRUD still not executed.");
        }
        catch(SqlException e) { sqlAvailable=false;sqlProbeError=e.Number;Console.WriteLine($"SQL read-only probe unavailable, SQL error {e.Number}; no database writes."); }
    }

    private static void TestHoSo()
    {
        using var f=new HoSo(); Open(f); Render(f,"fmHoSoSinhVien"); var list=Find<ListView>(f,"lstv1");
        Assert(list.ContextMenuStrip!=null && list.FullRowSelect && !list.MultiSelect,"ListView context menu and selection configured.");
        Assert(Find<ComboBox>(f,"comboBoxEth").Items.Count==6,"Ethnic values loaded.");
        Click(f,"btnAdd"); Assert(list.Items.Count==0 && f.Info.Contains("đầy đủ"),"Empty student rejected.");
        Text(f,"textBoxId","SV01"); Text(f,"textBoxName","Nguyễn An"); Find<CheckBox>(f,"checkBoxEng").Checked=true;
        Click(f,"btnAdd"); Assert(list.Items.Count==1 && list.Items[0].SubItems[3].Text=="Anh","Add student and languages.");
        Text(f,"textBoxId","sv01"); Text(f,"textBoxName","Trần Bình"); Click(f,"btnAdd"); Assert(list.Items.Count==1 && f.Info.Contains("tồn tại"),"Duplicate ID rejected ignoring case.");
        list.Items[0].Selected=true; Application.DoEvents();
        Assert(Find<TextBox>(f,"textBoxId").ReadOnly && Find<TextBox>(f,"textBoxName").Text=="Nguyễn An","Selected student locks ID and fills controls.");
        Text(f,"textBoxName","Nguyễn Ánh"); Click(f,"btnEdit");
        Assert(list.Items[0].SubItems[0].Text=="Nguyễn Ánh" && list.Items[0].SubItems[1].Text=="SV01","Edit keeps immutable ID.");
        list.Items[0].Selected=true; f.Yes=false; Click(f,"btnDelete"); Assert(list.Items.Count==1,"Delete No preserves row.");
        f.Yes=true; var rect=list.Items[0].Bounds;
        typeof(Control).GetMethod("OnMouseDown",BindingFlags.NonPublic|BindingFlags.Instance)!.Invoke(list,new object[]{new MouseEventArgs(MouseButtons.Right,1,rect.X+5,rect.Y+5,0)});
        list.ContextMenuStrip!.Items[0].PerformClick(); Assert(list.Items.Count==0,"Right click delete wired.");
        Click(f,"btnEdit"); Assert(f.Info.Contains("chọn"),"Edit without selection guarded.");
        f.Yes=false; var close=new FormClosingEventArgs(CloseReason.UserClosing,false);
        typeof(Form).GetMethod("OnFormClosing",BindingFlags.NonPublic|BindingFlags.Instance)!.Invoke(f,new object[]{close}); Assert(close.Cancel,"Student form closing No.");
    }

    private static void TestTaiKhoan()
    {
        using var f=new TaiKhoan(); Open(f); Render(f,"fmTaiKhoan"); var list=Find<ListView>(f,"listViewAccounts");
        Assert(!Find<Button>(f,"buttonSave").Enabled && !Find<Button>(f,"buttonDelete").Enabled,"Initial bank states.");
        Click(f,"buttonAdd"); Assert(Find<Button>(f,"buttonAdd").Text=="Hủy" && Find<Button>(f,"buttonSave").Enabled && !list.Enabled,"Adding state.");
        Click(f,"buttonSave"); Assert(list.Items.Count==0 && f.Info.Contains("đủ"),"Required bank fields.");
        Text(f,"textBoxAccount","001"); Text(f,"textBoxCustomer","An"); Text(f,"textBoxAddress","TP HCM"); Text(f,"textBoxAmount","-1"); Click(f,"buttonSave"); Assert(list.Items.Count==0,"Reject negative amount.");
        Text(f,"textBoxAmount","1,001"); Click(f,"buttonSave"); Assert(list.Items.Count==0,"Reject excess money decimal digits.");
        Text(f,"textBoxAmount","10,50"); Click(f,"buttonSave"); Assert(list.Items.Count==1 && (decimal)list.Items[0].Tag! == 10.50m,"Amount stored exactly as decimal.");
        Assert(Find<Button>(f,"buttonAdd").Text=="Thêm" && !Find<Button>(f,"buttonSave").Enabled,"After save exits adding state.");
        Click(f,"buttonAdd"); Text(f,"textBoxAccount","001"); Text(f,"textBoxCustomer","Bình"); Text(f,"textBoxAddress","Hà Nội"); Text(f,"textBoxAmount","2,25"); Click(f,"buttonSave"); Assert(list.Items.Count==1 && f.Info.Contains("tồn tại"),"Duplicate account guarded.");
        Text(f,"textBoxAccount","002"); Click(f,"buttonSave"); Assert(list.Items.Count==2 && Find<TextBox>(f,"textBoxTotal").Text==12.75m.ToString("N2",CultureInfo.GetCultureInfo("vi-VN")),"Exact decimal total.");
        Render(f,"fmTaiKhoan-filled",false);
        list.Items[0].Selected=true; Application.DoEvents(); Assert(Find<TextBox>(f,"textBoxAccount").Text=="001" && Find<Button>(f,"buttonDelete").Enabled,"Select bank row fills inputs and enables delete.");
        Click(f,"buttonAdd"); Click(f,"buttonAdd"); Assert(list.Items.Count==2 && Find<TextBox>(f,"textBoxAccount").Text=="001","Cancel preserves selected account.");
        Click(f,"buttonDelete"); Assert(list.Items.Count==1 && list.Items[0].Text=="1" && (decimal)list.Items[0].Tag! == 2.25m,"Delete renumbers and recalculates.");
        Click(f,"buttonAdd"); Text(f,"textBoxAccount","003"); Text(f,"textBoxCustomer","Chi"); Text(f,"textBoxAddress","Huế"); Text(f,"textBoxAmount",decimal.MaxValue.ToString(CultureInfo.GetCultureInfo("vi-VN"))); Click(f,"buttonSave"); Assert(list.Items.Count==1 && f.Info.Contains("vượt"),"Guard total decimal overflow.");
    }

    private static void TestChuyenLop()
    {
        using var f=new ChuyenLop(); Open(f); Render(f,"fmChuyenLop"); var a=Find<ListBox>(f,"lstLopA"); var b=Find<ListBox>(f,"lstLopB");
        Assert(a.Items.Count==3 && b.Items.Count==4,"Initial classes match example.");
        Menu(f,"mnuSangA"); Assert(f.Info.Contains("chọn"),"Moving without selection guarded.");
        b.SetSelected(1,true); b.SetSelected(2,true); var names=b.SelectedItems.Cast<string>().ToArray(); Menu(f,"mnuSangA"); Assert(a.Items.Count==5 && b.Items.Count==2 && a.Items.Cast<string>().TakeLast(2).SequenceEqual(names),"Multi move preserves order.");
        a.ClearSelected(); a.SetSelected(0,true); a.SetSelected(4,true); b.SetSelected(0,true); Menu(f,"mnuXoa"); Assert(a.Items.Count==3 && b.Items.Count==1,"Delete selections in both classes.");
        f.ThemHocVien("  Võ Nam  ","Lớp B"); Assert((string)b.Items[^1]=="Võ Nam","Add student to B.");
        using var entry=new Nhap(); Open(entry); Render(entry,"fmNhapHocVien"); entry.HocVienDaNhap+=f.ThemHocVien;
        Click(entry,"btnCapNhat"); Assert(entry.Info.Contains("họ tên") && a.Items.Count==3,"Blank entry guarded.");
        Text(entry,"txtHoTen","Lê Lan"); Click(entry,"btnCapNhat"); Assert((string)a.Items[^1]=="Lê Lan" && Find<TextBox>(entry,"txtHoTen").Text=="","Entry event updates owner class.");
    }

    private static void TestDemNguoc()
    {
        using var f=new DemNguoc(); Open(f); Render(f,"fmDemNguoc"); var clock=Find<Label>(f,"lblDongHo");
        Assert(clock.Text=="30:00","Countdown initial 30 minutes.");
        Click(f,"btnBatDau"); var timer=Field<System.Windows.Forms.Timer>(f,"timer1");
        Assert(timer.Enabled && !Find<Button>(f,"btnBatDau").Enabled,"Start timer and prevent double start.");
        f.Elapsed=TimeSpan.FromSeconds(61); typeof(System.Windows.Forms.Timer).GetMethod("OnTick",BindingFlags.NonPublic|BindingFlags.Instance)!.Invoke(timer,new object[]{EventArgs.Empty}); Assert(clock.Text=="28:59","Timer displays elapsed-based countdown.");
        f.Elapsed=TimeSpan.FromMinutes(30); typeof(System.Windows.Forms.Timer).GetMethod("OnTick",BindingFlags.NonPublic|BindingFlags.Instance)!.Invoke(timer,new object[]{EventArgs.Empty}); Assert(clock.Text=="00:00" && !timer.Enabled && f.Info.Contains("hết"),"Countdown ends at zero and stops.");
        Find<NumericUpDown>(f,"nudPhut").Value=1; f.Elapsed=TimeSpan.Zero; Click(f,"btnBatDau"); Assert(clock.Text=="01:00","Restart uses selected duration.");
        Click(f,"btnDung"); Assert(!timer.Enabled && Find<Button>(f,"btnBatDau").Enabled,"Stop enables restart.");
    }

    private static void TestSql()
    {
        using(var f=new MonHoc())
        {
            Open(f); Render(f,"fmMonHoc"); Click(f,"btnThem"); Assert(f.Calls==0,"Missing subject guarded before SQL.");
            Text(f,"txtMaMonHoc","MH10"); Text(f,"txtTenMonHoc","O'Brien C#"); Click(f,"btnThem"); Assert(f.Sql.Contains("dbo.MonHoc") && !f.Sql.Contains("O'Brien") && (string)f.Parameters.Single(p=>p.ParameterName=="@TenMonHoc").Value=="O'Brien C#","Parameterized subject insert.");
            Text(f,"txtMaMonHoc","MH10"); Text(f,"txtTenMonHoc","Mới"); Click(f,"btnSua"); Assert(f.Sql.StartsWith("UPDATE"),"Subject update.");
            Text(f,"txtMaMonHoc","MH10"); Text(f,"txtTenMonHoc","Còn tên"); int n=f.Calls; Click(f,"btnXoa"); Assert(f.Calls==n,"Delete subject rejects name field.");
            Text(f,"txtTenMonHoc",""); f.Rows=0; Click(f,"btnXoa"); Assert(f.Info.Contains("Không tìm thấy") && Find<TextBox>(f,"txtMaMonHoc").Text=="MH10","Zero affected rows preserves input and reports missing.");
            f.Fail=true; Click(f,"btnXoa"); Assert(f.Info.Contains("cấu hình"),"Database configuration error handled.");
        }
        using(var f=new SinhVienSql())
        {
            Open(f); Render(f,"fmSinhVienSql"); Text(f,"txtMaSinhVien","SV10"); Text(f,"txtMaLop","L01"); Text(f,"txtHoTen","Nguyễn An"); Click(f,"btnThem"); Assert(f.Calls==0,"Add requires checked birthday.");
            var date=Find<DateTimePicker>(f,"dtpNgaySinh"); date.Checked=true; Click(f,"btnThem"); Assert(f.Sql.Contains("MaSinhVien") && f.Parameters.Single(p=>p.ParameterName=="@NgaySinh").SqlDbType==SqlDbType.Date,"Student date is typed SQL Date.");
            Text(f,"txtMaSinhVien","SV10"); Click(f,"btnSua"); int n=f.Calls; Assert(n==1,"Student edit requires one new field.");
            Text(f,"txtHoTen","Đổi tên"); Click(f,"btnSua"); Assert(f.Sql.Contains("CASE") && !(bool)f.Parameters.Single(p=>p.ParameterName=="@CoNgay").Value,"Partial update leaves unchecked birthday unchanged.");
            Text(f,"txtMaSinhVien","SV10"); Text(f,"txtHoTen","Đổi tên"); Text(f,"txtMaLop","L01"); Click(f,"btnXoa"); Assert(f.Calls==2,"Student deletion rejects class field.");
            Text(f,"txtMaLop",""); Click(f,"btnXoa"); Assert(f.Sql.StartsWith("DELETE") && f.Sql.Contains("AND HoTen=@HoTen"),"Student deletion matches ID and name.");
        }
        using(var f=new Diem())
        {
            Open(f); Render(f,"fmDiem"); Text(f,"txtMaSinhVien","SV01"); Text(f,"txtMaMonHoc","MH01");
            foreach(var bad in new[]{"","abc","-1","11","8,555","8.5"}) { Text(f,"txtDiem",bad); Click(f,"btnThem"); Assert(f.Calls==0,"Invalid score rejected before database."); }
            Text(f,"txtDiem","8,5"); Click(f,"btnThem"); var p=f.Parameters.Single(p=>p.ParameterName=="@Diem"); Assert(p.SqlDbType==SqlDbType.Decimal && p.Precision==4 && p.Scale==2 && (decimal)p.Value==8.5m,"Score is typed decimal.");
            Text(f,"txtMaSinhVien","SV01"); Text(f,"txtMaMonHoc","MH01"); Text(f,"txtDiem","9"); Click(f,"btnSua"); Assert(f.Sql.StartsWith("UPDATE") && f.Sql.Contains("AND MaMonHoc"),"Score update uses composite key.");
            Text(f,"txtMaSinhVien","SV01"); Text(f,"txtMaMonHoc","MH01"); Text(f,"txtDiem","2"); Click(f,"btnXoa"); Assert(f.Calls==2,"Delete score rejects filled score.");
            Text(f,"txtDiem",""); Click(f,"btnXoa"); Assert(f.Sql.StartsWith("DELETE") && f.Parameters.Length==2,"Delete score uses only keys.");
        }
        using(var f=new Lop())
        {
            Open(f); Render(f,"fmLop"); Click(f,"btnThem"); Assert(f.Calls==0,"Blank class guarded.");
            Text(f,"txtMaLop","L10"); Text(f,"txtMaKhoa","K01"); Text(f,"txtTenLop","Lớp mới"); Click(f,"btnThem"); Assert(f.Sql.Contains("dbo.Lop") && f.Parameters.Length==3,"Class insert typed keys.");
            Text(f,"txtMaLop","L10"); Click(f,"btnSua"); Assert(f.Calls==1,"Class edit requires data.");
            Text(f,"txtTenLop","Tên mới"); Click(f,"btnSua"); Assert(f.Sql.Contains("CASE") && f.Parameters.Single(p=>p.ParameterName=="@MaKhoa").Value.ToString()=="","Partial class update preserves faculty.");
            Text(f,"txtMaLop","L10"); Text(f,"txtMaKhoa","K01"); Click(f,"btnXoa"); Assert(f.Calls==2,"Class delete restricts inputs.");
            Text(f,"txtMaKhoa",""); Click(f,"btnXoa"); Assert(f.Sql.StartsWith("DELETE") && f.Parameters.Length==1,"Class delete by key.");
        }
    }

    private static void TestMain()
    {
        using var f=new MainForm(); Open(f); Render(f,"fmMain");
        foreach(var (name,type) in new[]{("mnuHoSo",typeof(fmHoSoSinhVien)),("mnuTaiKhoan",typeof(fmTaiKhoan)),("mnuChuyenLop",typeof(fmChuyenLop)),("mnuDemNguoc",typeof(fmDemNguoc)),("mnuMonHoc",typeof(fmMonHoc)),("mnuSinhVienSql",typeof(fmSinhVienSql)),("mnuDiem",typeof(fmDiem)),("mnuLop",typeof(fmLop)),("mnuTH5C",typeof(TH5C.fmChonBai))})
        { Menu(f,name); Assert(f.Last==type,"Main menu maps to "+type.Name); }
    }

    private class HoSo:fmHoSoSinhVien { public string Info="";public bool Yes=true;protected override void ThongBao(string s)=>Info=s;protected override bool XacNhan(string s)=>Yes; }
    private class TaiKhoan:fmTaiKhoan { public string Info="";protected override void ThongBao(string s)=>Info=s;protected override bool XacNhan(string s)=>true; }
    private class ChuyenLop:fmChuyenLop { public string Info="";protected override void ThongBao(string s)=>Info=s;protected override bool XacNhan(string s)=>true; }
    private class Nhap:fmNhapHocVien { public string Info="";protected override void ThongBao(string s)=>Info=s; }
    private class DemNguoc:fmDemNguoc { public TimeSpan Elapsed;public string Info="";protected override TimeSpan ThoiGianDaQua()=>Elapsed;protected override void ThongBao(string s)=>Info=s; }
    private class MainForm:fmMain { public Type? Last;protected override void MoBai(Form f) { Last=f.GetType();f.Dispose(); }protected override bool XacNhan(string s)=>true; }
    private class MonHoc:fmMonHoc { public string Info="",Sql="";public SqlParameter[] Parameters=[];public int Calls,Rows=1;public bool Fail;protected override void ThongBao(string s)=>Info=s;protected override int ThucThi(string s,params SqlParameter[] p){Calls++;Sql=s;Parameters=p;if(Fail)throw new InvalidOperationException("test config failure");return Rows;} }
    private class SinhVienSql:fmSinhVienSql { public string Info="",Sql="";public SqlParameter[] Parameters=[];public int Calls;protected override void ThongBao(string s)=>Info=s;protected override int ThucThi(string s,params SqlParameter[] p){Calls++;Sql=s;Parameters=p;return 1;} }
    private class Diem:fmDiem { public string Info="",Sql="";public SqlParameter[] Parameters=[];public int Calls;protected override void ThongBao(string s)=>Info=s;protected override int ThucThi(string s,params SqlParameter[] p){Calls++;Sql=s;Parameters=p;return 1;} }
    private class Lop:fmLop { public string Info="",Sql="";public SqlParameter[] Parameters=[];public int Calls;protected override void ThongBao(string s)=>Info=s;protected override int ThucThi(string s,params SqlParameter[] p){Calls++;Sql=s;Parameters=p;return 1;} }
}
