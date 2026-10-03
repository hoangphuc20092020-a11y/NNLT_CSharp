using System;
using System.Collections.Generic;
using System.Linq;

namespace TH04d
{
    public class MangSoNguyen
    {
        private List<int> mang;

        public MangSoNguyen()
        {
            mang = new List<int>();
        }

        // Nhập mảng
        public void NhapMang(string chuoi)
        {
            string[] phanTu = chuoi.Split(
                new char[] { ' ', ',', ';' },
                StringSplitOptions.RemoveEmptyEntries);

            mang.Clear();

            foreach (string s in phanTu)
            {
                if (!int.TryParse(s, out int x))
                {
                    throw new Exception(
                        "Mảng chỉ được chứa số nguyên.");
                }

                mang.Add(x);
            }

            if (mang.Count == 0)
            {
                throw new Exception(
                    "Mảng không được rỗng.");
            }
        }

        // Xuất mảng
        public string XuatMang()
        {
            return string.Join(" ", mang);
        }

        // Sắp xếp tăng
        public void SapXepTang()
        {
            mang.Sort();
        }

        // Sắp xếp giảm
        public void SapXepGiam()
        {
            mang.Sort();
            mang.Reverse();
        }

        // Tìm giá trị
        public int TimGiaTri(int giaTri)
        {
            return mang.IndexOf(giaTri);
        }

        // Tìm vị trí
        public int TimViTri(int viTri)
        {
            if (viTri < 0 || viTri >= mang.Count)
            {
                throw new Exception("Vị trí không hợp lệ.");
            }

            return mang[viTri];
        }

        // Xóa theo giá trị
        public bool XoaGiaTri(int giaTri)
        {
            return mang.Remove(giaTri);
        }

        // Xóa theo vị trí
        public void XoaViTri(int viTri)
        {
            KiemTraViTri(viTri);
            mang.RemoveAt(viTri);
        }

        // Thêm giá trị vào vị trí
        public void Them(int giaTri, int viTri)
        {
            if (viTri < 0 || viTri > mang.Count)
            {
                throw new Exception("Vị trí thêm không hợp lệ.");
            }

            mang.Insert(viTri, giaTri);
        }

        // Tổng mảng
        public int TongMang()
        {
            return mang.Sum();
        }

        // Tổng chẵn
        public int TongChan()
        {
            return mang
                .Where(x => x % 2 == 0)
                .Sum();
        }

        // Tổng lẻ
        public int TongLe()
        {
            return mang
                .Where(x => x % 2 != 0)
                .Sum();
        }

        // Giá trị lớn nhất
        public int GiaTriLonNhat()
        {
            KiemTraMang();
            return mang.Max();
        }

        // Giá trị nhỏ nhất
        public int GiaTriNhoNhat()
        {
            KiemTraMang();
            return mang.Min();
        }

        // Thay thế theo giá trị
        public bool ThayTheGiaTri(int giaTriCu, int giaTriMoi)
        {
            int viTri = mang.IndexOf(giaTriCu);

            if (viTri == -1)
            {
                return false;
            }

            mang[viTri] = giaTriMoi;

            return true;
        }

        // Thay thế theo vị trí
        public void ThayTheViTri(int viTri, int giaTriMoi)
        {
            KiemTraViTri(viTri);

            mang[viTri] = giaTriMoi;
        }

        // Kiểm tra vị trí
        private void KiemTraViTri(int viTri)
        {
            if (viTri < 0 || viTri >= mang.Count)
            {
                throw new Exception("Vị trí không hợp lệ.");
            }
        }

        // Kiểm tra mảng
        private void KiemTraMang()
        {
            if (mang.Count == 0)
            {
                throw new Exception("Mảng đang rỗng.");
            }
        }
    }
}