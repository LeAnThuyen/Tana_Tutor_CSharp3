using CuaHangTrangSuc.DomainClass;
using CuaHangTrangSuc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CuaHangTrangSuc
{
    public partial class Form1 : Form
    {


        private MauSacServices _mauSacServices;
        private TrangSucService _trangSucService;
        private NhaSanXuatServices _nhaSanXuatServices;
        //khai báo ra 2 đối tượng
        private NhaSanXuat _nsx;
        private MauSacChuDao _mausac;
        private Guid _getId;
        public Form1()
        {
            InitializeComponent();
            _mauSacServices = new MauSacServices();
            _trangSucService = new TrangSucService();
            _nhaSanXuatServices = new NhaSanXuatServices();
            //
            LoadMauSac();
            LoadNhaSanXuat();
            loadData();
            LoadLoc();
            //
            _nsx = new NhaSanXuat();
            _mausac = new MauSacChuDao();
        }

        public void LoadMauSac()
        {
            foreach (var x in _mauSacServices.GetListMauSac())
            {
                cbo_mausac.Items.Add(x.TenMauSac);
            }
            //cbo_mausac.SelectedIndex = 0;
        }
        public void LoadNhaSanXuat()
        {
            foreach (var x in _nhaSanXuatServices.GetListNhaSanXuat())
            {
                cbo_nsx.Items.Add(x.TenNhaSanXuat);
            }
        }
        public void LoadLoc()
        {
            List<string> _lst = new List<string>() { "Lọc Theo Tên", "Lọc Theo Giá" };
            foreach (var x in _lst)
            {
                comboBox1.Items.Add(x);
            }
        }
        void loadData()
        {
            dgrid_trangsuc.ColumnCount = 7;
            //
            dgrid_trangsuc.Columns[0].Name = "IDTrangSuc";
            dgrid_trangsuc.Columns[0].Visible = false;

            dgrid_trangsuc.Columns[1].Name = "Mã Trang Sức";
            dgrid_trangsuc.Columns[2].Name = "Tên Trang Sức";
            dgrid_trangsuc.Columns[3].Name = "Giá";
            dgrid_trangsuc.Columns[4].Name = "Trạng Thái";
            //
            dgrid_trangsuc.Columns[5].Name = "Tên Màu Sắc";
            dgrid_trangsuc.Columns[6].Name = "Tên Nhà Sản Xuất";
            dgrid_trangsuc.Rows.Clear();
            ///
            //ở phần hiển thị này các em có thể dùng list dynamic mà mình làm ở TrangSucService load ra data
            //lưu ý vì là dynamic lên khi các em . các thuộc tính nó sẽ không hiển thị gợi ý, các em phải gõ chuẩn
            //Cách 1 Dynamic(Khó Hơn)
            //foreach (var x in _trangSucService.MixedList())
            //{




            //    dgrid_trangsuc.Rows.Add(x.Id, x.MaTrangSuc, x.TenTrangSuc,
            //        x.Gia, x.TrangThai == true ? "Còn Hàng" : "Hết Hàng", x.TenMauSac, x.TenNhaSanXuat);
            //}
            //Cách 2 dễ hơn dùng linq truy vấn dữ liệu bằng cách khai báo 1 đối tượng để nhận

            foreach (var x in _trangSucService.GetListTrangSuc())
            {
                _nsx = _nhaSanXuatServices.GetListNhaSanXuat().Find(c => c.IdNhaSanXuat == x.IdNhaSanXuat);

                _mausac = _mauSacServices.GetListMauSac().Find(c => c.IdMauSac == x.IdMauChuDao);



                dgrid_trangsuc.Rows.Add(x.Id, x.MaTrangSuc, x.TenTrangSuc,
                    x.Gia, x.TrangThai == true ? "Còn Hàng" : "Hết Hàng", _mausac.TenMauSac, _nsx.TenNhaSanXuat);
            }

        }





        private void dgrid_foods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1 || rd >= _trangSucService.GetListTrangSuc().Count)
            {
                return;
            }

            _getId = Guid.Parse(Convert.ToString(dgrid_trangsuc.Rows[rd].Cells[0].Value));
            txt_matrangsuc.Text = Convert.ToString(dgrid_trangsuc.Rows[rd].Cells[1].Value);
            txt_ten.Text = Convert.ToString(dgrid_trangsuc.Rows[rd].Cells[2].Value);
            txt_gia.Text = Convert.ToString(dgrid_trangsuc.Rows[rd].Cells[3].Value);
            rbt_conhang.Checked = Convert.ToString(dgrid_trangsuc.Rows[rd].Cells[4].Value) == "Còn Hàng";
            rbt_hethang.Checked = Convert.ToString(dgrid_trangsuc.Rows[rd].Cells[4].Value) == "Hết Hàng";

            cbo_mausac.Text = Convert.ToString(dgrid_trangsuc.Rows[rd].Cells[5].Value);
            cbo_nsx.Text = Convert.ToString(dgrid_trangsuc.Rows[rd].Cells[6].Value);
        }
        private void btn_them_Click(object sender, System.EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm trang sức này không ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_trangSucService.AddTrangSuc(new TrangSuc()
                {

                    Id = Guid.NewGuid(),
                    MaTrangSuc = "ACC" + Convert.ToString(_trangSucService.GetListTrangSuc()
                      .Max(c => Convert.ToInt32(c.MaTrangSuc.Substring(3, c.MaTrangSuc.Length - 3)) + 1)),

                    TenTrangSuc = txt_ten.Text,
                    Gia = Convert.ToDouble(txt_gia.Text),
                    TrangThai = rbt_conhang.Checked,


                    IdMauChuDao = _mauSacServices.GetListMauSac()
                      .Where(c => c.TenMauSac == Convert.ToString(cbo_mausac.Text)).Select(c => c.IdMauSac).FirstOrDefault(),
                    //
                    IdNhaSanXuat = _nhaSanXuatServices.GetListNhaSanXuat()
                      .Where(c => c.TenNhaSanXuat == Convert.ToString(cbo_nsx.Text)).Select(c => c.IdNhaSanXuat).FirstOrDefault(),
                }));
                loadData();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_sua_Click(object sender, System.EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn sửa trang sức này không ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_trangSucService.UpdateTrangSuc(_getId, new TrangSuc()
                {


                    TenTrangSuc = txt_ten.Text,
                    Gia = Convert.ToDouble(txt_gia.Text),
                    TrangThai = rbt_conhang.Checked,


                    IdMauChuDao = _mauSacServices.GetListMauSac()
                     .Where(c => c.TenMauSac == Convert.ToString(cbo_mausac.Text)).Select(c => c.IdMauSac).FirstOrDefault(),
                    //
                    IdNhaSanXuat = _nhaSanXuatServices.GetListNhaSanXuat()
                     .Where(c => c.TenNhaSanXuat == Convert.ToString(cbo_nsx.Text)).Select(c => c.IdNhaSanXuat).FirstOrDefault(),
                }));
                loadData();

            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_xoa_Click(object sender, System.EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa Trang Sức  này không ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_trangSucService.DeleteTrangSuc(_getId));
                loadData();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }





        private void label6_Click(object sender, EventArgs e)
        {

        }
        public void LoadDataLocTheoTen()
        {
            dgrid_trangsuc.ColumnCount = 7;
            //
            dgrid_trangsuc.Columns[0].Name = "IDTrangSuc";
            dgrid_trangsuc.Columns[0].Visible = false;

            dgrid_trangsuc.Columns[1].Name = "Mã Trang Sức";
            dgrid_trangsuc.Columns[2].Name = "Tên Trang Sức";
            dgrid_trangsuc.Columns[3].Name = "Giá";
            dgrid_trangsuc.Columns[4].Name = "Trạng Thái";
            //
            dgrid_trangsuc.Columns[5].Name = "Tên Màu Sắc";
            dgrid_trangsuc.Columns[6].Name = "Tên Nhà Sản Xuất";
            dgrid_trangsuc.Rows.Clear();
            ///
            foreach (var x in _trangSucService.GetListTrangSuc().OrderBy(c => c.TenTrangSuc))
            {
                _nsx = _nhaSanXuatServices.GetListNhaSanXuat().Find(c => c.IdNhaSanXuat == x.IdNhaSanXuat);

                _mausac = _mauSacServices.GetListMauSac().Find(c => c.IdMauSac == x.IdMauChuDao);



                dgrid_trangsuc.Rows.Add(x.Id, x.MaTrangSuc, x.TenTrangSuc,
                    x.Gia, x.TrangThai == true ? "Còn Hàng" : "Hết Hàng", _mausac.TenMauSac, _nsx.TenNhaSanXuat);
            }
        }
        public void LoadDataLocTheoGia()
        {
            dgrid_trangsuc.ColumnCount = 7;
            //
            dgrid_trangsuc.Columns[0].Name = "IDTrangSuc";
            dgrid_trangsuc.Columns[0].Visible = false;

            dgrid_trangsuc.Columns[1].Name = "Mã Trang Sức";
            dgrid_trangsuc.Columns[2].Name = "Tên Trang Sức";
            dgrid_trangsuc.Columns[3].Name = "Giá";
            dgrid_trangsuc.Columns[4].Name = "Trạng Thái";
            //
            dgrid_trangsuc.Columns[5].Name = "Tên Màu Sắc";
            dgrid_trangsuc.Columns[6].Name = "Tên Nhà Sản Xuất";
            dgrid_trangsuc.Rows.Clear();
            ///
            foreach (var x in _trangSucService.GetListTrangSuc().OrderBy(c => c.Gia))
            {
                _nsx = _nhaSanXuatServices.GetListNhaSanXuat().Find(c => c.IdNhaSanXuat == x.IdNhaSanXuat);

                _mausac = _mauSacServices.GetListMauSac().Find(c => c.IdMauSac == x.IdMauChuDao);



                dgrid_trangsuc.Rows.Add(x.Id, x.MaTrangSuc, x.TenTrangSuc,
                    x.Gia, x.TrangThai == true ? "Còn Hàng" : "Hết Hàng", _mausac.TenMauSac, _nsx.TenNhaSanXuat);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Lọc Theo Tên")
            {
                LoadDataLocTheoTen();
            }
            if (comboBox1.Text == "Lọc Theo Giá")
            {
                LoadDataLocTheoGia();
            }
        }
    }
}

