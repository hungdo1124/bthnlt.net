using System;
using System.Collections;
class Program
{
    static void Main()
    {
        Hashtable people = new Hashtable();
        Console.Write("Nhap so luong nguoi: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap ten nguoi thu " + (i + 1) + ": ");
            string name = Console.ReadLine();
            Console.Write("Nhap tuoi cua " + name + ": ");
            int age = int.Parse(Console.ReadLine());
            people.Add(name, age);
        }
        Console.WriteLine("Danh sach ten va tuoi da nhap:");
        foreach (DictionaryEntry person in people)
        {
            Console.WriteLine("Ten: " + person.Key + ", Tuoi: " + person.Value);
        }
    }
}
