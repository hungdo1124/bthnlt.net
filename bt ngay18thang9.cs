using System;
using System.Collections.Generic;
class product
{
    public string ten { get; set; }
    public double gia { get; set; }
    public string mota { get; set; }
    public int soluong { get; set; }

    public product(string ten, double gia, string mota, int soluong)
    {
        this.ten = ten;
        this.gia = gia;
        this.mota = mota;
        this.soluong = soluong;
    }

    public virtual void hienthiThongtin()
    {
        Console.WriteLine($"Ten san pham: {ten}");
        Console.WriteLine($"Gia: {gia}");
        Console.WriteLine($"Mo ta: {mota}");
        Console.WriteLine($"So luong: {soluong}");
    }
}

class electronic : product
{
    public int baohanh { get; set; }

    public electronic(string ten, double gia, string mota, int soluong, int baohanh)
        : base(ten, gia, mota, soluong)
    {
        this.baohanh = baohanh;
    }

    public override void hienthiThongtin()
    {
        base.hienthiThongtin();
        Console.WriteLine($"Bao hanh: {baohanh} thang");
    }
}

class clothing : product
{
    public string kichthuoc { get; set; }
    public string mausac { get; set; }

    public clothing(string ten, double gia, string mota, int soluong, string kichthuoc, string mausac)
        : base(ten, gia, mota, soluong)
    {
        this.kichthuoc = kichthuoc;
        this.mausac = mausac;
    }

    public override void hienthiThongtin()
    {
        base.hienthiThongtin();
        Console.WriteLine($"Kich thuoc: {kichthuoc}");
        Console.WriteLine($"Mau sac: {mausac}");
    }
}

class food : product
{
    public DateTime ngayhethan { get; set; }

    public food(string ten, double gia, string mota, int soluong, DateTime ngayhethan)
        : base(ten, gia, mota, soluong)
    {
        this.ngayhethan = ngayhethan;
    }

    public override void hienthiThongtin()
    {
        base.hienthiThongtin();
        Console.WriteLine($"Ngay het han: {ngayhethan.ToShortDateString()}");
    }
}

class shoppingcart
{
    public List<product> products { get; set; }

    public shoppingcart()
    {
        products = new List<product>();
    }

    public void themSanpham(product sanpham)
    {
        products.Add(sanpham);
        Console.WriteLine($"{sanpham.ten} da duoc them vao gio hang.");
    }

    public void xoaSanpham(product sanpham)
    {
        if (products.Contains(sanpham))
        {
            products.Remove(sanpham);
            Console.WriteLine($"{sanpham.ten} da duoc xoa khoi gio hang.");
        }
        else
        {
            Console.WriteLine($"{sanpham.ten} khong co trong gio hang.");
        }
    }

    public void hienthiGiohang()
    {
        Console.WriteLine("San pham trong gio hang:");
        foreach (var sanpham in products)
        {
            sanpham.hienthiThongtin();
            Console.WriteLine("-----------------------------");
        }
    }

    public double tinhTonggia()
    {
        double tong = 0;
        foreach (var sanpham in products)
        {
            tong += sanpham.gia * sanpham.soluong;
        }
        return tong;
    }
}

class Program
{
    static void Main(string[] args)
    {
        electronic laptop = new electronic("Laptop", 15000000, "Laptop cao cap", 1, 24);
        clothing tshirt = new clothing("T-Shirt", 200000, "Ao thun cotton", 2, "L", "Trang");
        food apple = new food("Tao", 30000, "Tao do", 10, DateTime.Now.AddDays(7));
        shoppingcart cart = new shoppingcart();
        cart.themSanpham(laptop);
        cart.themSanpham(tshirt);
        cart.themSanpham(apple);
        cart.hienthiGiohang();
        double tong = cart.tinhTonggia();
        Console.WriteLine($"Tong gia tri don hang: {tong} USD");
    }
}
