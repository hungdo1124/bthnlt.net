using System;
using System.Collections;
class Program
{
    static void Main()
    {
        ArrayList numbers = new ArrayList();
        Console.Write("Nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap so nguyen thu " + (i + 1) + ": ");
            int number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }
        numbers.Sort();
        Console.WriteLine("Danh sach cac so nguyen sau khi sap xep tang dan:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}
