using System.Numerics;
using System.Reflection;
using TH5C;

internal static class TH5CChecks
{
    private static int passed;
    public static int LayoutChecks;
    public static int FunctionalChecks => passed - LayoutChecks;
    private static readonly string imageFolder = TestPaths.Images;
    private static void Assert(bool value, string description)
    {
        if (!value) throw new InvalidOperationException(description);
        passed++;
    }
    private static T Find<T>(Control form, string name) where T : Control
        => form.Controls.Find(name, true).OfType<T>().Single();
    private static void Click(Control form, string name)
        => typeof(Button).GetMethod("OnClick", BindingFlags.Instance | BindingFlags.NonPublic)!
            .Invoke(Find<Button>(form, name), new object[] { EventArgs.Empty });
    private static void Text(Control form, string name, string text) => Find<TextBox>(form, name).Text = text;
    private static void Open(Form form)
    {
        // Khởi tạo cửa sổ trong suốt, không đưa vào taskbar.
        form.ShowInTaskbar = false; form.Opacity = 0; form.Show();
        Application.DoEvents();
    }
    private static void Render(Form form, string name)
    {
        CheckBounds(form);
        using var bitmap = new Bitmap(form.Width, form.Height);
        form.DrawToBitmap(bitmap, new Rectangle(Point.Empty, bitmap.Size));
        bitmap.Save(Path.Combine(imageFolder, name + ".png"));
    }
    private static void CheckBounds(Control parent)
    {
        Control[] children = parent.Controls.Cast<Control>().Where(c => c.Visible).ToArray();
        if (parent is not TabControl)
            for (int i = 0; i < children.Length; i++)
                for (int j = i + 1; j < children.Length; j++)
                {
                    LayoutChecks++;
                    Assert(!children[i].Bounds.IntersectsWith(children[j].Bounds),
                        $"Overlapping controls: {parent.Name}/{children[i].Name} {children[i].Bounds} and {children[j].Name} {children[j].Bounds}");
                }
        foreach (Control child in children) CheckBounds(child);
    }
    private static IEnumerable<T> Items<T>(ListBox list) => list.Items.Cast<T>();

    [STAThread]
    public static int Run()
    {

        Directory.CreateDirectory(imageFolder);
        TestUocSo(); TestPhongBan(); TestSinhVien(); TestChuoi(); TestTuDien(); TestListSo(); TestDanhBa();
        using (var menu = new fmChonBai())
        {
            Open(menu);
            Assert(menu.Controls.OfType<GroupBox>().Sum(g => g.Controls.OfType<Button>().Count()) == 9, "Menu must contain 9 exercise buttons.");
            Render(menu, "fmChonBai");
        }
        TestSample1(); TestSample2();
        Console.WriteLine($"TH5C PASS: {FunctionalChecks} functional and {LayoutChecks} layout checks.");
        return passed;
    }

    private static void TestUocSo()
    {
        using var f = new Uoc(); Open(f); Render(f, "fmUocSo");
        Click(f, "btnTong"); Assert(f.Info.Contains("chọn"), "Must guard missing selection.");
        Text(f, "txtSo", "12"); Click(f, "btnCapNhat");
        var list = Find<ListBox>(f, "lstUocSo"); var combo = Find<ComboBox>(f, "cboSo");
        Assert(Items<int>(list).SequenceEqual(new[] { 1, 2, 3, 4, 6, 12 }), "Divisors of 12.");
        Click(f, "btnTong"); Assert(f.Info.EndsWith("28"), "Divisor sum 28.");
        Click(f, "btnDemChan"); Assert(f.Info.EndsWith("4"), "Even divisor count 4.");
        Click(f, "btnDemNguyenTo"); Assert(f.Info.EndsWith("2"), "Prime divisor count 2.");
        Text(f, "txtSo", "12"); Click(f, "btnCapNhat"); Assert(combo.Items.Count == 1, "Duplicate rejected.");
        foreach (string bad in new[] { "abc", "0", "-1", "2147483648" })
        { Text(f, "txtSo", bad); Click(f, "btnCapNhat"); Assert(combo.Items.Count == 1, "Invalid integer rejected."); }
        Assert(fmUocSo.TimUoc(36).Count(x => x == 6) == 1, "Square root divisor not duplicated.");
        Assert(fmUocSo.TimUoc(1).SequenceEqual(new[] { 1 }) && !fmUocSo.LaNguyenTo(1), "One is not prime.");
        Assert(fmUocSo.LaNguyenTo(int.MaxValue), "Prime test must not overflow.");
        var closing = new FormClosingEventArgs(CloseReason.UserClosing, false);
        f.Yes = false; typeof(Form).GetMethod("OnFormClosing", BindingFlags.Instance | BindingFlags.NonPublic)!.Invoke(f, new object[] { closing });
        Assert(closing.Cancel, "No must cancel closing.");
    }

    private static void TestPhongBan()
    {
        using var f = new PhongBan(); Open(f); Render(f, "fmMauPhongBan");
        var tree=Find<TreeView>(f,"trvPhongBan"); var combo=Find<ComboBox>(f,"cboPhongBan");
        Assert(tree.Nodes.Count==4 && combo.Items.Count==4, "Four initial departments.");
        Text(f,"txtPhongBan","Nghiên cứu"); Click(f,"btnThemPB");
        Assert(tree.Nodes.Count==5 && combo.Items.Count==5, "Add synchronizes department controls.");
        Text(f,"txtPhongBan"," NGHIÊN CỨU "); Click(f,"btnThemPB"); Assert(tree.Nodes.Count==5,"Duplicate department ignored case/space.");
        Click(f,"btnThemNV"); Assert(tree.Nodes[4].Nodes.Count==0,"Empty employee rejected.");
        Text(f,"txtMaSo","NV01"); Text(f,"txtHoTen","Nguyễn Bình"); Text(f,"txtDiaChi","TP HCM"); Click(f,"btnThemNV");
        Assert(tree.Nodes[4].Nodes.Count==1,"Employee added to selected department.");
        var employee=tree.Nodes[4].Nodes[0]; tree.SelectedNode=employee; Click(f,"btnXoaPB"); Assert(tree.Nodes.Count==5,"Do not delete employee as department.");
        tree.SelectedNode=tree.Nodes[4]; f.Yes=false; Click(f,"btnXoaPB"); Assert(tree.Nodes.Count==5,"Delete confirmation cancelled.");
        f.Yes=true; Click(f,"btnXoaPB"); Assert(tree.Nodes.Count==4 && combo.Items.Count==4,"Department deletion synchronizes combo.");
        while(tree.Nodes.Count>0) { tree.SelectedNode=tree.Nodes[0]; Click(f,"btnXoaPB"); }
        Assert(combo.SelectedIndex==-1 && combo.Items.Count==0,"Deleting final department is safe.");
    }

    private static void TestSinhVien()
    {
        using var f=new SinhVien(); Open(f); Render(f,"fmSinhVien");
        var tree=Find<TreeView>(f,"trvLop"); var combo=Find<ComboBox>(f,"cboLop");
        var group=Find<GroupBox>(f,"grpThongTinLop"); var check=Find<CheckBox>(f,"chkThemLop");
        Assert(tree.Nodes[0].Nodes.Count==4 && !group.Visible,"Initial classes and hidden group.");
        check.Checked=true; Assert(group.Visible,"Check shows class group."); check.Checked=false; Assert(!group.Visible,"Uncheck hides group.");
        Text(f,"txtTenLop","05DHTH5"); Click(f,"btnThemLop"); Assert(combo.Items.Count==5,"Add class.");
        Text(f,"txtTenLop","05dhth5"); Click(f,"btnThemLop"); Assert(combo.Items.Count==5,"Duplicate class rejected.");
        Click(f,"btnCapNhat"); Assert(tree.Nodes[0].Nodes[4].Nodes.Count==0,"Empty student rejected.");
        Text(f,"txtMaSV","SV01"); Text(f,"txtHoTen","Nguyễn Văn A"); Text(f,"txtDiaChi","TP HCM"); Click(f,"btnCapNhat");
        var node=tree.Nodes[0].Nodes[4].Nodes[0];
        Assert(node.Text=="SV01, Nguyễn Văn A" && node.Nodes[0].Text=="TP HCM","Student hierarchy matches PDF.");
        tree.SelectedNode=node; Assert(Find<TextBox>(f,"txtMaSV").Text=="SV01" && combo.SelectedIndex==4,"Select fills student info.");
        combo.SelectedIndex=0; Click(f,"btnCapNhat"); Assert(tree.Nodes[0].Nodes[0].Nodes.Count==0,"Student ID unique across classes.");
        tree.SelectedNode=node.Nodes[0]; Click(f,"btnXoa"); Assert(node.Parent!=null,"Address node cannot be deleted.");
        tree.SelectedNode=node; f.Yes=false; Click(f,"btnXoa"); Assert(node.Parent!=null,"Student delete can be cancelled.");
        f.Yes=true; Click(f,"btnXoa"); Assert(tree.Nodes[0].Nodes[4].Nodes.Count==0,"Student removed after confirmation.");
    }

    private static void TestChuoi()
    {
        using var f=new Chuoi(); Open(f); Click(f,"btnNgauNhien"); Render(f,"fmChuoi");
        var list=Find<ListBox>(f,"lstTen"); Assert(list.Items.Count==50,"Generate 50 names.");
        Click(f,"btnXoaTatCa"); list.Items.AddRange(new object[]{"Lê Quang Sơn","Trần Sơn Mai","Nguyễn Anh Sơn","Lê Thị Hà","Hồ Ngọc Tâm"});
        Click(f,"btnXoaSon"); Assert(list.Items.Count==3 && list.Items.Contains("Trần Sơn Mai"),"Only final token Sơn removed.");
        Click(f,"btnXoaLe"); Assert(list.Items.Count==2,"Only surname Lê removed.");
        list.SetSelected(0,true); list.SetSelected(1,true); Click(f,"btnHoa"); Assert((string)list.Items[1]=="HỒ NGỌC TÂM","Uppercase selection.");
        Click(f,"btnThuong"); Assert((string)list.Items[0]=="trần sơn mai","Lowercase selection preserved.");
        Click(f,"btnHoaDau"); Assert((string)list.Items[0]=="Trần Sơn Mai","Title case words.");
        f.Input="  Tên Mới  "; var rect = list.GetItemRectangle(0);
        typeof(ListBox).GetMethod("OnMouseDoubleClick",BindingFlags.Instance|BindingFlags.NonPublic)!.Invoke(list,
            new object[]{new MouseEventArgs(MouseButtons.Left,2,rect.X+5,rect.Y+5,0)});
        Assert((string)list.Items[0]=="Tên Mới","Edit replaces same index.");
        f.Input=""; typeof(fmChuoi).GetMethod("SuaTen",BindingFlags.Instance|BindingFlags.NonPublic)!.Invoke(f,new object[]{0});
        Assert((string)list.Items[0]=="Tên Mới","Cancel edit preserves name.");
        list.SetSelected(0,true); list.SetSelected(1,true); Click(f,"btnXoaChon"); Assert(list.Items.Count==0,"Delete multiple names safely.");
    }

    private static void TestTuDien()
    {
        using var f=new fmTuDien(); Open(f); Render(f,"fmTuDien");
        var combo=Find<ComboBox>(f,"cboAnh"); var list=Find<ListBox>(f,"lstAnh");
        Assert(combo.Items.Count==17,"Dictionary loaded from List.");
        combo.Text="stu"; Assert((string?)list.SelectedItem=="student","Prefix search selects student.");
        Click(f,"btnTraAnh"); Assert(Find<TextBox>(f,"txtNghiaViet").Text=="sinh viên","Prefix lookup.");
        combo.Text="unknownword"; Click(f,"btnTraAnh"); Assert(Find<TextBox>(f,"txtNghiaViet").Text=="Không tìm thấy từ.","Unknown word.");
        Find<TabControl>(f,"tabTuDien").SelectedIndex=1;
        var viet=Find<ComboBox>(f,"cboViet"); viet.Text="nhà"; Click(f,"btnTraViet");
        Assert(Find<TextBox>(f,"txtNghiaAnh").Text=="house; home","Reverse lookup includes multiple meanings.");
        viet.Text="giáo"; var key=new KeyEventArgs(Keys.Enter);
        typeof(ComboBox).GetMethod("OnKeyDown",BindingFlags.Instance|BindingFlags.NonPublic)!.Invoke(viet,new object[]{key});
        Assert(Find<TextBox>(f,"txtNghiaAnh").Text=="teacher" && key.SuppressKeyPress,"Keyboard Enter lookup.");
        Find<TabControl>(f,"tabTuDien").SelectedIndex=0;
        int index=list.Items.IndexOf("cat"); var rect=list.GetItemRectangle(index); list.TopIndex=index;
        rect=list.GetItemRectangle(index);
        typeof(ListBox).GetMethod("OnMouseDoubleClick",BindingFlags.Instance|BindingFlags.NonPublic)!.Invoke(list,
            new object[]{new MouseEventArgs(MouseButtons.Left,2,rect.X+5,rect.Y+5,0)});
        Assert(Find<TextBox>(f,"txtNghiaViet").Text=="mèo","Double click lookup.");
    }

    private static void TestListSo()
    {
        using var f=new ListSo(); Open(f); Render(f,"fmListSo"); var list=Find<ListBox>(f,"lstSo");
        Click(f,"btnXoaDauCuoi"); Click(f,"btnTong"); Assert(f.Info.EndsWith("0"),"Empty list safe.");
        Text(f,"txtSo","-1"); Click(f,"btnNhap"); Assert(list.Items.Count==0,"Reject negative number.");
        foreach(string s in new[]{"0","1","2","3"}) { Text(f,"txtSo",s); Click(f,"btnNhap"); }
        Click(f,"btnTong"); Assert(f.Info.EndsWith("6"),"Natural number sum.");
        Click(f,"btnChan"); Assert(list.SelectedItems.Cast<BigInteger>().SequenceEqual(new BigInteger[]{0,2}),"Select even including zero.");
        Click(f,"btnLe"); Assert(list.SelectedItems.Cast<BigInteger>().SequenceEqual(new BigInteger[]{1,3}),"Select odd clears old selection.");
        Click(f,"btnXoaDauCuoi"); Assert(Items<BigInteger>(list).SequenceEqual(new BigInteger[]{1,2}),"Delete first and last.");
        Click(f,"btnTang"); Click(f,"btnBinhPhuong"); Assert(Items<BigInteger>(list).SequenceEqual(new BigInteger[]{9,16}),"Increase then square.");
        list.SetSelected(0,true); list.SetSelected(1,true); Click(f,"btnXoaChon"); Assert(list.Items.Count==0,"Delete selected numbers.");
        Text(f,"txtSo","100000000000000000000"); Click(f,"btnNhap"); Click(f,"btnBinhPhuong");
        Assert((BigInteger)list.Items[0]==BigInteger.Pow(10,40),"Squaring large values does not overflow.");
        Click(f,"btnXoaDauCuoi"); Assert(list.Items.Count==0,"Delete first and last with one item.");
    }

    private static void TestDanhBa()
    {
        using var f=new DanhBa(); Open(f); Render(f,"fmDanhBa"); var tree=Find<TreeView>(f,"trvDanhBa");
        Assert(tree.Nodes.Count==26,"26 letter groups.");
        foreach(var pair in new[]{("Bình","B"),("Ánh","A"),("Đức","D")})
        {
            Text(f,"txtFirstName",pair.Item1); Text(f,"txtLastName","Ngô Thanh"); Click(f,"btnAdd");
            Assert(tree.Nodes[pair.Item2]!.Nodes.Count==1,"Vietnamese name grouping.");
        }
        Text(f,"txtFirstName","123"); Text(f,"txtLastName","A"); Click(f,"btnAdd"); Assert(f.Info.Contains("A-Z"),"Reject initial outside A-Z.");
        Text(f,"txtFirstName",""); Click(f,"btnAdd"); Assert(f.Info.Contains("đủ"),"Reject missing name.");
    }


    private static void TestSample1()
    {
        using var f = new Sample1(); Open(f); Render(f, "fmMauListBox");
        var a=Find<ListBox>(f,"lstTrai"); var b=Find<ListBox>(f,"lstPhai");
        Assert(a.Items.Count==6 && b.Items.Count==0,"Sample1 initial fruit list.");
        Click(f,"btnPhai"); Assert(f.Info.Contains("chưa chọn"),"Sample1 missing selection guarded.");
        a.SelectedIndex=0; Click(f,"btnPhai"); Assert(a.Items.Count==5 && (string)b.Items[0]=="Cóc","Move one to right.");
        b.SelectedIndex=0; Click(f,"btnTrai"); Assert(a.Items.Count==6 && b.Items.Count==0,"Move one to left.");
        a.ClearSelected(); a.SetSelected(0,true); a.SetSelected(2,true);
        string[] selected=a.SelectedItems.Cast<string>().ToArray(); Click(f,"btnTuyY");
        Assert(b.Items.Cast<string>().SequenceEqual(selected) && a.Items.Count==4,"Move selected preserving order.");
        Click(f,"btnPhaiAll"); Assert(b.Items.Count==6 && a.Items.Count==0,"Move all right exactly once.");
        Click(f,"btnTraiAll"); Assert(a.Items.Count==6 && b.Items.Count==0,"Move all left exactly once.");
        f.Yes=false; var close=new FormClosingEventArgs(CloseReason.UserClosing,false);
        typeof(Form).GetMethod("OnFormClosing",BindingFlags.NonPublic|BindingFlags.Instance)!.Invoke(f,new object[]{close});
        Assert(close.Cancel,"Sample1 rejects closing on No.");
    }
    private static void TestSample2()
    {
        using var f = new Sample2(); Open(f); Render(f,"fmMauDantoc");
        var c=Find<ComboBox>(f,"cboDanToc"); var l=Find<Label>(f,"lblKetQua");
        Click(f,"btnHienThi"); Assert(l.Text.Contains("chưa chọn"),"Sample2 empty selection.");
        Click(f,"btnLoad"); Click(f,"btnLoad"); Assert(c.Items.Count==5,"Sample2 repeated load no duplicates.");
        c.SelectedIndex=1; Assert(f.Info.Contains("Hoa"),"Sample2 immediate choice notification.");
        Click(f,"btnHienThi"); Assert(l.Text.EndsWith("Hoa"),"Sample2 label shows choice.");
        Click(f,"btnLoad"); Assert(c.SelectedIndex==-1 && l.Text.Contains("Chưa chọn"),"Sample2 reload resets.");
    }
    private class Sample1 : fmMauListBox { public string Info=""; public bool Yes=true; protected override void ThongBao(string s)=>Info=s; protected override bool XacNhan(string s)=>Yes; }
    private class Sample2 : fmMauDantoc { public string Info=""; protected override void ThongBao(string s)=>Info=s; }

    private class Uoc : fmUocSo { public string Info=""; public bool Yes=true; protected override void ThongBao(string s)=>Info=s; protected override bool XacNhan(string s)=>Yes; }
    private class PhongBan : fmMauPhongBan { public string Info=""; public bool Yes=true; protected override void ThongBao(string s)=>Info=s; protected override bool XacNhan(string s)=>Yes; }
    private class SinhVien : fmSinhVien { public string Info=""; public bool Yes=true; protected override void ThongBao(string s)=>Info=s; protected override bool XacNhan(string s)=>Yes; }
    private class Chuoi : fmChuoi { public string Input=""; protected override string NhapChuoi(string s,string old)=>Input; }
    private class ListSo : fmListSo { public string Info=""; protected override void ThongBao(string s)=>Info=s; }
    private class DanhBa : fmDanhBa { public string Info=""; protected override void ThongBao(string s)=>Info=s; }
}
