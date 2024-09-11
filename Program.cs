using System;
using System.Linq;

class bt119
{
    // Bai 1:
    public void tinhtongmang()
    {
        Console.Write("Nhap so luong phan tu trong mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int sum = array.Sum();
        Console.WriteLine("Tong cac phan tu trong mang la: " + sum);
    }

    // Bai 2:
    public void demkytutrongchuoi()
    {
        Console.Write("Nhap chuoi: ");
        string input = Console.ReadLine();
        int count = input.Count(c => char.IsLetterOrDigit(c));

        Console.WriteLine("So luong ky tu trong chuoi (khong tinh khoang trang va dau cau): " + count);
    }

    // Bai 3:
    public void timphantulonnhat()
    {
        Console.Write("Nhap so luong phan tu trong mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int max = array.Max();
        Console.WriteLine("Phan tu lon nhat trong mang la: " + max);
    }

    // Bai 4:
    public void daonguocchuoi()
    {
        Console.Write("Nhap chuoi: ");
        string input = Console.ReadLine();
        char[] reversedArray = input.Reverse().ToArray();

        Console.WriteLine("Chuoi dao nguoc la: " + new string(reversedArray));
    }

    // Bai 5:
    public void kiemtramangdoixung()
    {
        Console.Write("Nhap so luong phan tu trong mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        bool isPalindrome = array.SequenceEqual(array.Reverse()); 

        Console.WriteLine("Mang " + (isPalindrome ? "la mang doi xung." : "khong phai la mang doi xung."));
    }

    // Bai 6:
    public void demsolanxuathienkytu()
    {
        Console.Write("Nhap chuoi: ");
        string input = Console.ReadLine();

        Console.Write("Nhap ky tu can dem: ");
        char character = Console.ReadKey().KeyChar;
        Console.WriteLine();

        int count = input.Count(c => c == character); 

        Console.WriteLine($"So lan xuat hien cua ky tu '{character}' trong chuoi: {count}");
    }

    static void Main(string[] args)
    {
        bt119 exercises = new bt119();

        exercises.tinhtongmang();
        exercises.demkytutrongchuoi();
        exercises.timphantulonnhat();
        exercises.daonguocchuoi();
        exercises.kiemtramangdoixung();
        exercises.demsolanxuathienkytu();
    }
}
