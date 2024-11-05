﻿//Lop Khach Hang và Dich Vụ
using System.Collections.Generic;
using System.Windows.Forms;
using System;

public class KhachHang
{
    public int MaKH { get; set; }
    public string TenKH { get; set; }
    public string SoDienThoai { get; set; }
    public string DiaChi { get; set; }
}
public class DichVu
{
    public int MaDV { get; set; }
    public string TenDV { get; set; }
    public decimal Gia { get; set; }
}
//List
List<KhachHang> danhSachKhachHang = new List<KhachHang>();
List<DichVu> danhSachDichVu = new List<DichVu>();
private void LoadDuLieuMau()
{
    danhSachKhachHang.Add(new KhachHang { MaKH = 1, TenKH = "Nguyen Van A", SoDienThoai = "0123456789", DiaChi = "Hanoi" });
    danhSachDichVu.Add(new DichVu { MaDV = 1, TenDV = "Giat say", Gia = 50000 });
    danhSachDichVu.Add(new DichVu { MaDV = 2, TenDV = "Ve sinh may lanh", Gia = 100000 });
}
//Cac Button
private void button_ThemKhachHang_Click(object sender, EventArgs e)
{
    int maKH = danhSachKhachHang.Count > 0 ? danhSachKhachHang.Max(kh => kh.MaKH) + 1 : 1;
    KhachHang khachHangMoi = new KhachHang
    {
        MaKH = maKH,
        TenKH = textBox_TenKH.Text,
        SoDienThoai = textBox_SoDienThoai.Text,
        DiaChi = textBox_DiaChi.Text
    };
    danhSachKhachHang.Add(khachHangMoi);
    HienThiKhachHang();
}
private void button_ChinhSuaKhachHang_Click(object sender, EventArgs e)
{
    if (dataGridView_KhachHang.SelectedRows.Count > 0)
    {
        int maKH = int.Parse(dataGridView_KhachHang.SelectedRows[0].Cells["MaKH"].Value.ToString());
        KhachHang khachHang = danhSachKhachHang.FirstOrDefault(kh => kh.MaKH == maKH);
        if (khachHang != null)
        {
            khachHang.TenKH = textBox_TenKH.Text;
            khachHang.SoDienThoai = textBox_SoDienThoai.Text;
            khachHang.DiaChi = textBox_DiaChi.Text;
            HienThiKhachHang();
        }
    }
}
private void button_XoaKhachHang_Click(object sender, EventArgs e)
{
    if (dataGridView_KhachHang.SelectedRows.Count > 0)
    {
        int maKH = int.Parse(dataGridView_KhachHang.SelectedRows[0].Cells["MaKH"].Value.ToString());
        KhachHang khachHang = danhSachKhachHang.FirstOrDefault(kh => kh.MaKH == maKH);
        if (khachHang != null)
        {
            danhSachKhachHang.Remove(khachHang);
            HienThiKhachHang();
        }
    }
}
private void button_TaoHoaDon_Click(object sender, EventArgs e)
{
    if (dataGridView_KhachHang.SelectedRows.Count > 0 && dataGridView_DichVu.SelectedRows.Count > 0)
    {
        int maKH = int.Parse(dataGridView_KhachHang.SelectedRows[0].Cells["MaKH"].Value.ToString());
        KhachHang khachHang = danhSachKhachHang.FirstOrDefault(kh => kh.MaKH == maKH);

        decimal tongTien = 0;
        foreach (DataGridViewRow row in dataGridView_DichVu.SelectedRows)
        {
            int maDV = int.Parse(row.Cells["MaDV"].Value.ToString());
            DichVu dichVu = danhSachDichVu.FirstOrDefault(dv => dv.MaDV == maDV);
            if (dichVu != null)
            {
                listBox_HoaDon.Items.Add($"{dichVu.TenDV} - {dichVu.Gia} VND");
                tongTien += dichVu.Gia;
            }
        }
        textBox_TongTien.Text = $"{tongTien} VND";
    }
}
//Hien thi du lieu
private void HienThiKhachHang()
{
    dataGridView_KhachHang.DataSource = null;
    dataGridView_KhachHang.DataSource = danhSachKhachHang;
}

private void HienThiDichVu()
{
    dataGridView_DichVu.DataSource = null;
    dataGridView_DichVu.DataSource = danhSachDichVu;
}