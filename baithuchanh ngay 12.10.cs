using System;
using System.Collections.Generic;

public abstract class PhuongTien
{
    public string TenPhuongTien { get; set; }
    public string LoaiNhienLieu { get; set; }

    public PhuongTien(string tenPhuongTien, string loaiNhienLieu)
    {
        TenPhuongTien = tenPhuongTien;
        LoaiNhienLieu = loaiNhienLieu;
    }

    public abstract void DiChuyen();
}

public interface IThongTinThem
{
    double TocDoToiDa();
    double MucTieuThuNhienLieu();
}

public class XeHoi : PhuongTien, IThongTinThem
{
    public XeHoi(string tenPhuongTien, string loaiNhienLieu) : base(tenPhuongTien, loaiNhienLieu) { }

    public override void DiChuyen()
    {
        Console.WriteLine($"{TenPhuongTien} di chuyen bang dong co.");
    }

    public double TocDoToiDa()
    {
        return 180; 
    }

    public double MucTieuThuNhienLieu()
    {
        return 7.5; 
    }
}

public class XeDap : PhuongTien, IThongTinThem
{
    public XeDap(string tenPhuongTien) : base(tenPhuongTien, "Khong su dung nhien lieu") { }

    public override void DiChuyen()
    {
        Console.WriteLine($"{TenPhuongTien} di chuyen bang suc dap.");
    }
    public double TocDoToiDa()
    {
        return 25;
    }
    public double MucTieuThuNhienLieu()
    {
        return 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tao danh sach cac phuong tien
        List<PhuongTien> danhSachPhuongTien = new List<PhuongTien>
        {
            new XeHoi("Xe Hoi Toyota", "Xang"),
            new XeDap("Xe Dap The Thao")
        };

        foreach (PhuongTien phuongTien in danhSachPhuongTien)
        {
            Console.WriteLine($"Phuong tien: {phuongTien.TenPhuongTien}");
            Console.WriteLine($"Loai nhien lieu: {phuongTien.LoaiNhienLieu}");
            phuongTien.DiChuyen();
            if (phuongTien is IThongTinThem thongTinThem)
            {
                Console.WriteLine($"Toc do toi da: {thongTinThem.TocDoToiDa()} km/h");
                if (phuongTien.LoaiNhienLieu != "Khong su dung nhien lieu")
                {
                    Console.WriteLine($"Muc tieu thu nhien lieu: {thongTinThem.MucTieuThuNhienLieu()} lit/100km");
                }
            }
            Console.WriteLine();
        }
    }
}
