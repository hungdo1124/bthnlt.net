using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlysp
{
    public partial class frmSanPham : Form
    {
        List<SanPham> danhSachSanPham = new List<SanPham>();

        public frmSanPham()
        {
            InitializeComponent();
            cbLoaiSP.Items.Add("Loại 1");
            cbLoaiSP.Items.Add("Loại 2");
            cbLoaiSP.SelectedIndex = -1;
        }

        private void CapNhatDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = danhSachSanPham;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtDonGia.Clear();
            txtHinhAnh.Clear();
            txtMoTaNgan.Clear();
            txtMoTaChiTiet.Clear();
            cbLoaiSP.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham()
            {
                MaSP = txtMaSP.Text,
                TenSP = txtTenSP.Text,
                DonGia = decimal.Parse(txtDonGia.Text),
                HinhAnh = txtHinhAnh.Text,
                MoTaNgan = txtMoTaNgan.Text,
                MoTaChiTiet = txtMoTaChiTiet.Text,
                LoaiSP = cbLoaiSP.SelectedItem.ToString()
            };

            danhSachSanPham.Add(sp);
            CapNhatDataGridView();
            btnLamMoi_Click(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                danhSachSanPham[index].MaSP = txtMaSP.Text;
                danhSachSanPham[index].TenSP = txtTenSP.Text;
                danhSachSanPham[index].DonGia = decimal.Parse(txtDonGia.Text);
                danhSachSanPham[index].HinhAnh = txtHinhAnh.Text;
                danhSachSanPham[index].MoTaNgan = txtMoTaNgan.Text;
                danhSachSanPham[index].MoTaChiTiet = txtMoTaChiTiet.Text;
                danhSachSanPham[index].LoaiSP = cbLoaiSP.SelectedItem.ToString();

                CapNhatDataGridView();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                danhSachSanPham.RemoveAt(index);
                CapNhatDataGridView();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMaSP.Text = row.Cells["MaSP"].Value.ToString();
                txtTenSP.Text = row.Cells["TenSP"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
                txtHinhAnh.Text = row.Cells["HinhAnh"].Value.ToString();
                txtMoTaNgan.Text = row.Cells["MoTaNgan"].Value.ToString();
                txtMoTaChiTiet.Text = row.Cells["MoTaChiTiet"].Value.ToString();
                cbLoaiSP.SelectedItem = row.Cells["LoaiSP"].Value.ToString();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string timKiem = txtTimKiem.Text.ToLower();
            var ketQua = danhSachSanPham.Where(sp => sp.MaSP.ToLower().Contains(timKiem)
                                                  || sp.TenSP.ToLower().Contains(timKiem)).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ketQua;
        }
    }
}
