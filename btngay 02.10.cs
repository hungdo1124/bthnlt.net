using System;

public abstract class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public Product(string name, decimal price, int stock)
    {
        Name = name;
        Price = price;
        Stock = stock;
    }
    public abstract void DisplayProductInfo();
    public abstract void ApplyDiscount(decimal percentage);
}

public interface ISellable
{
    void Sell(int quantity); 
    bool IsInStock();      
}

public class MobilePhone : Product, ISellable
{
    public string Brand { get; set; }
    public string Model { get; set; }

    public MobilePhone(string name, decimal price, int stock, string brand, string model)
        : base(name, price, stock)
    {
        Brand = brand;
        Model = model;
    }

    public override void DisplayProductInfo()
    {
        Console.WriteLine($"Dien thoai di dong: {Name}, Hang: {Brand}, Mau: {Model}, Gia: {Price:C}, Ton kho: {Stock}");
    }

    public override void ApplyDiscount(decimal percentage)
    {
        Price -= Price * (percentage / 100);
    }

    public void Sell(int quantity)
    {
        if (quantity <= Stock)
        {
            Stock -= quantity;
            Console.WriteLine($"Da ban {quantity} {Name}. So luong con lai: {Stock}");
        }
        else
        {
            Console.WriteLine("Khong du hang trong kho.");
        }
    }

    public bool IsInStock()
    {
        return Stock > 0;
    }
}
public class Laptop : Product, ISellable
{
    public string Brand { get; set; }
    public string Processor { get; set; }

    public Laptop(string name, decimal price, int stock, string brand, string processor)
        : base(name, price, stock)
    {
        Brand = brand;
        Processor = processor;
    }

    public override void DisplayProductInfo()
    {
        Console.WriteLine($"May tinh xach tay: {Name}, Hang: {Brand}, Bo xu ly: {Processor}, Gia: {Price:C}, Ton kho: {Stock}");
    }

    public override void ApplyDiscount(decimal percentage)
    {
        Price -= Price * (percentage / 100);
    }

    public void Sell(int quantity)
    {
        if (quantity <= Stock)
        {
            Stock -= quantity;
            Console.WriteLine($"Da ban {quantity} {Name}. So luong con lai: {Stock}");
        }
        else
        {
            Console.WriteLine("Khong du hang trong kho.");
        }
    }

    public bool IsInStock()
    {
        return Stock > 0;
    }
}
public class Accessory : Product, ISellable
{
    public string Type { get; set; }

    public Accessory(string name, decimal price, int stock, string type)
        : base(name, price, stock)
    {
        Type = type;
    }

    public override void DisplayProductInfo()
    {
        Console.WriteLine($"Phu kien: {Name}, Loai: {Type}, Gia: {Price:C}, Ton kho: {Stock}");
    }

    public override void ApplyDiscount(decimal percentage)
    {
        Price -= Price * (percentage / 100);
    }

    public void Sell(int quantity)
    {
        if (quantity <= Stock)
        {
            Stock -= quantity;
            Console.WriteLine($"Da ban {quantity} {Name}. So luong con lai: {Stock}");
        }
        else
        {
            Console.WriteLine("Khong du hang trong kho.");
        }
    }

    public bool IsInStock()
    {
        return Stock > 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MobilePhone phone = new MobilePhone("iPhone 14", 999.99m, 10, "Apple", "14");
        Laptop laptop = new Laptop("Dell XPS 15", 1500.00m, 5, "Dell", "Intel Core i7");
        Accessory accessory = new Accessory("Op lung dien thoai", 19.99m, 100, "Op lung");
        phone.DisplayProductInfo();
        laptop.DisplayProductInfo();
        Console.Write("Nhap so luong dien thoai da ban: ");
        int phoneQuantity = Convert.ToInt32(Console.ReadLine());
        phone.Sell(phoneQuantity);
        Console.Write("Nhap so luong may tinh xach tay da ban: ");
        int laptopQuantity = Convert.ToInt32(Console.ReadLine());
        laptop.Sell(laptopQuantity);
        Console.Write("Nhap so luong phu kien da ban: ");
        int accessoryQuantity = Convert.ToInt32(Console.ReadLine());
        accessory.Sell(accessoryQuantity);
        Console.WriteLine("\n--- Thong tin san pham sau khi ban ---");
        phone.DisplayProductInfo();
        laptop.DisplayProductInfo();
        accessory.DisplayProductInfo();
        Console.Write("\nNhap phan tram giam gia cho dien thoai: ");
        decimal discountPhone = Convert.ToDecimal(Console.ReadLine());
        phone.ApplyDiscount(discountPhone);
        Console.Write("Nhap phan tram giam gia cho may tinh xach tay: ");
        decimal discountLaptop = Convert.ToDecimal(Console.ReadLine());
        laptop.ApplyDiscount(discountLaptop);
        Console.Write("Nhap phan tram giam gia cho phu kien: ");
        decimal discountAccessory = Convert.ToDecimal(Console.ReadLine());
        accessory.ApplyDiscount(discountAccessory);
        Console.WriteLine("\n--- Thong tin san pham sau khi giam gia ---");
        phone.DisplayProductInfo();
        laptop.DisplayProductInfo();
        accessory.DisplayProductInfo();
    }
}
