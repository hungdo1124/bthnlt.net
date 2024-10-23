namespace quanlysp {
partial class frmSanPham
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.TextBox txtMaSP;
    private System.Windows.Forms.TextBox txtTenSP;
    private System.Windows.Forms.TextBox txtDonGia;
    private System.Windows.Forms.TextBox txtHinhAnh;
    private System.Windows.Forms.TextBox txtMoTaNgan;
    private System.Windows.Forms.TextBox txtMoTaChiTiet;
    private System.Windows.Forms.ComboBox cbLoaiSP;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.Button btnTimKiem;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.TextBox txtTimKiem;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.txtMaSP = new System.Windows.Forms.TextBox();
        this.txtTenSP = new System.Windows.Forms.TextBox();
        this.txtDonGia = new System.Windows.Forms.TextBox();
        this.txtHinhAnh = new System.Windows.Forms.TextBox();
        this.txtMoTaNgan = new System.Windows.Forms.TextBox();
        this.txtMoTaChiTiet = new System.Windows.Forms.TextBox();
        this.cbLoaiSP = new System.Windows.Forms.ComboBox();
        this.btnThem = new System.Windows.Forms.Button();
        this.btnSua = new System.Windows.Forms.Button();
        this.btnXoa = new System.Windows.Forms.Button();
        this.btnLamMoi = new System.Windows.Forms.Button();
        this.btnTimKiem = new System.Windows.Forms.Button();
        this.dataGridView1 = new System.Windows.Forms.DataGridView();
        this.txtTimKiem = new System.Windows.Forms.TextBox();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        this.SuspendLayout();
        // 
        // txtMaSP
        // 
        this.txtMaSP.Location = new System.Drawing.Point(12, 12);
        this.txtMaSP.Name = "txtMaSP";
        this.txtMaSP.Size = new System.Drawing.Size(200, 20);
        this.txtMaSP.TabIndex = 0;
        // 
        // txtTenSP
        // 
        this.txtTenSP.Location = new System.Drawing.Point(12, 38);
        this.txtTenSP.Name = "txtTenSP";
        this.txtTenSP.Size = new System.Drawing.Size(200, 20);
        this.txtTenSP.TabIndex = 1;
        // 
        // txtDonGia
        // 
        this.txtDonGia.Location = new System.Drawing.Point(12, 64);
        this.txtDonGia.Name = "txtDonGia";
        this.txtDonGia.Size = new System.Drawing.Size(200, 20);
        this.txtDonGia.TabIndex = 2;
        // 
        // txtHinhAnh
        // 
        this.txtHinhAnh.Location = new System.Drawing.Point(12, 90);
        this.txtHinhAnh.Name = "txtHinhAnh";
        this.txtHinhAnh.Size = new System.Drawing.Size(200, 20);
        this.txtHinhAnh.TabIndex = 3;
        // 
        // txtMoTaNgan
        // 
        this.txtMoTaNgan.Location = new System.Drawing.Point(12, 116);
        this.txtMoTaNgan.Name = "txtMoTaNgan";
        this.txtMoTaNgan.Size = new System.Drawing.Size(200, 20);
        this.txtMoTaNgan.TabIndex = 4;
        // 
        // txtMoTaChiTiet
        // 
        this.txtMoTaChiTiet.Location = new System.Drawing.Point(12, 142);
        this.txtMoTaChiTiet.Name = "txtMoTaChiTiet";
        this.txtMoTaChiTiet.Size = new System.Drawing.Size(200, 20);
        this.txtMoTaChiTiet.TabIndex = 5;
        // 
        // cbLoaiSP
        // 
        this.cbLoaiSP.FormattingEnabled = true;
        this.cbLoaiSP.Location = new System.Drawing.Point(12, 168);
        this.cbLoaiSP.Name = "cbLoaiSP";
        this.cbLoaiSP.Size = new System.Drawing.Size(200, 21);
        this.cbLoaiSP.TabIndex = 6;
        // 
        // btnThem
        // 
        this.btnThem.Location = new System.Drawing.Point(12, 195);
        this.btnThem.Name = "btnThem";
        this.btnThem.Size = new System.Drawing.Size(75, 23);
        this.btnThem.TabIndex = 7;
        this.btnThem.Text = "Thêm";
        this.btnThem.UseVisualStyleBackColor = true;
        this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
        // 
        // btnSua
        // 
        this.btnSua.Location = new System.Drawing.Point(93, 195);
        this.btnSua.Name = "btnSua";
        this.btnSua.Size = new System.Drawing.Size(75, 23);
        this.btnSua.TabIndex = 8;
        this.btnSua.Text = "Sửa";
        this.btnSua.UseVisualStyleBackColor = true;
        this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
        // 
        // btnXoa
        // 
        this.btnXoa.Location = new System.Drawing.Point(174, 195);
        this.btnXoa.Name = "btnXoa";
        this.btnXoa.Size = new System.Drawing.Size(75, 23);
        this.btnXoa.TabIndex = 9;
        this.btnXoa.Text = "Xóa";
        this.btnXoa.UseVisualStyleBackColor = true;
        this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
        // 
        // btnLamMoi
        // 
        this.btnLamMoi.Location = new System.Drawing.Point(255, 195);
        this.btnLamMoi.Name = "btnLamMoi";
        this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
        this.btnLamMoi.TabIndex = 10;
        this.btnLamMoi.Text = "Làm Mới";
        this.btnLamMoi.UseVisualStyleBackColor = true;
        this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
        // 
        // btnTimKiem
        // 
        this.btnTimKiem.Location = new System.Drawing.Point(336, 195);
        this.btnTimKiem.Name = "btnTimKiem";
        this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
        this.btnTimKiem.TabIndex = 11;
        this.btnTimKiem.Text = "Tìm Kiếm";
        this.btnTimKiem.UseVisualStyleBackColor = true;
        this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
        // 
        // dataGridView1
        // 
        this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView1.Location = new System.Drawing.Point(12, 224);
        this.dataGridView1.Name = "dataGridView1";
        this.dataGridView1.Size = new System.Drawing.Size(400, 150);
        this.dataGridView1.TabIndex = 12;
        this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
        // 
        // txtTimKiem
        // 
        this.txtTimKiem.Location = new System.Drawing.Point(12, 380);
        this.txtTimKiem.Name = "txtTimKiem";
        this.txtTimKiem.Size = new System.Drawing.Size(200, 20);
        this.txtTimKiem.TabIndex = 13;
        // 
        // frmSanPham
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(424, 411);
        this.Controls.Add(this.txtTimKiem);
        this.Controls.Add(this.dataGridView1);
        this.Controls.Add(this.btnTimKiem);
        this.Controls.Add(this.btnLamMoi);
        this.Controls.Add(this.btnXoa);
        this.Controls.Add(this.btnSua);
        this.Controls.Add(this.btnThem);
        this.Controls.Add(this.cbLoaiSP);
        this.Controls.Add(this.txtMoTaChiTiet);
        this.Controls.Add(this.txtMoTaNgan);
        this.Controls.Add(this.txtHinhAnh);
        this.Controls.Add(this.txtDonGia);
        this.Controls.Add(this.txtTenSP);
        this.Controls.Add(this.txtMaSP);
        this.Name = "frmSanPham";
        this.Text = "Quản Lý Sản Phẩm";
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
}