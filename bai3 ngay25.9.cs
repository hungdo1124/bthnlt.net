using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> students = new Dictionary<string, int>();
        Console.Write("Nhap so luong hoc sinh: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap ten hoc sinh thu " + (i + 1) + ": ");
            string name = Console.ReadLine();
            Console.Write("Nhap diem cua " + name + ": ");
            int score = int.Parse(Console.ReadLine());
            students.Add(name, score);
        }
        Console.WriteLine("\nDanh sach hoc sinh và diem:");
        foreach (KeyValuePair<string, int> student in students)
        {
            Console.WriteLine("Ten: " + student.Key + ", Diem: " + student.Value);
        }
    }
}
