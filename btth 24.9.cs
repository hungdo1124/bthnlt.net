using System;
using System.Collections.Generic;
using System.Linq;

class Sinhvien
{
    // thuoc tinh
    public string hoten { get; set; }
    public string mssv { get; set; }
    public double diemtrungbinh { get; set; }

    // phuong thuc nhap thong tin sinh vien
    public void nhapthongtin()
    {
        Console.Write("Nhap ho ten sinh vien: ");
        hoten = Console.ReadLine();
        Console.Write("Nhap MSSV: ");
        mssv = Console.ReadLine();
        Console.Write("Nhap diem trung binh: ");
        diemtrungbinh = double.Parse(Console.ReadLine());
    }

    // phuong thuc hien thi thong tin sinh vien
    public void hienthithongtin()
    {
        Console.WriteLine($"Ho ten: {hoten}, MSSV: {mssv}, Diem trung binh: {diemtrungbinh}");
    }
}

class Danhsachsinhvien
{
    // thuoc tinh: danh sach sinh vien
    private List<Sinhvien> danhsach;

    public Danhsachsinhvien()
    {
        danhsach = new List<Sinhvien>();
    }

    // phuong thuc them sinh vien vao danh sach
    public void themsinhvien(Sinhvien sv)
    {
        danhsach.Add(sv);
    }

    // phuong thuc hien thi danh sach sinh vien
    public void hienthidanhsach()
    {
        foreach (var sv in danhsach)
        {
            sv.hienthithongtin();
        }
    }

    // phuong thuc tim sinh vien theo MSSV
    public Sinhvien timsinhvientheomssv(string mssv)
    {
        return danhsach.FirstOrDefault(sv => sv.mssv == mssv);
    }

    // phuong thuc tinh va tra ve sinh vien co diem trung binh cao nhat
    public Sinhvien tinhdiemtrungbinhcaonhat()
    {
        return danhsach.OrderByDescending(sv => sv.diemtrungbinh).FirstOrDefault();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // tao danh sach sinh vien
        Danhsachsinhvien dsSinhvien = new Danhsachsinhvien();

        // yeu cau nguoi dung nhap vao so sinh vien, it nhat la 3
        int n;
        do
        {
            Console.Write("Nhap so luong sinh vien (it nhat 3): ");
            n = int.Parse(Console.ReadLine());
            if (n < 3)
            {
                Console.WriteLine("So luong sinh vien phai it nhat la 3. Vui long nhap lai.");
            }
        } while (n < 3);

        // nhap thong tin sinh vien
        for (int i = 0; i < n; i++)
        {
            Sinhvien sv = new Sinhvien();
            sv.nhapthongtin();
            dsSinhvien.themsinhvien(sv);
        }

        // hien thi danh sach sinh vien da nhap
        Console.WriteLine("\nDanh sach sinh vien:");
        dsSinhvien.hienthidanhsach();

        // tim va hien thi sinh vien co diem trung binh cao nhat
        Sinhvien svDiemcaoNhat = dsSinhvien.tinhdiemtrungbinhcaonhat();
        if (svDiemcaoNhat != null)
        {
            Console.WriteLine("\nSinh vien co diem trung binh cao nhat:");
            svDiemcaoNhat.hienthithongtin();
        }

        // tim kiem sinh vien theo MSSV
        Console.Write("\nNhap MSSV de tim sinh vien: ");
        string mssv = Console.ReadLine();
        Sinhvien svTimthay = dsSinhvien.timsinhvientheomssv(mssv);
        if (svTimthay != null)
        {
            Console.WriteLine("\nThong tin sinh vien tim thay:");
            svTimthay.hienthithongtin();
        }
        else
        {
            Console.WriteLine("Khong tim thay sinh vien voi MSSV da nhap.");
        }
    }
}
