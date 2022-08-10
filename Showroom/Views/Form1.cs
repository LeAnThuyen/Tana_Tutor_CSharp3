using Showroom.DomainClass;
using Showroom.Services;
using Showroom.Utilities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Showroom
{
    public partial class Form1 : Form
    {


        private int _getId;
        private CarServices _carServices;
        private HangXeServices _hangXeServices;
        private HangXe _hangxe;
        private Check _check;
        public Form1()
        {
            InitializeComponent();
            _carServices = new CarServices();
            _hangXeServices = new HangXeServices();
            _hangxe = new HangXe();
            LoadCboHangXe();
            _check = new Check();

        }
        public void LoadCboHangXe()
        {
            foreach (var x in _hangXeServices.GetListHangXe())
            {
                cbo_hangxe.Items.Add(x.Name);
            }
        }
        void loadData()
        {


            dgrid_xe.ColumnCount = 5;
            dgrid_xe.Columns[0].Name = "IdXe";
            dgrid_xe.Columns[0].Visible = false;
            dgrid_xe.Columns[1].Name = "Tên Xe";
            dgrid_xe.Columns[2].Name = "Tên Hãng Xe";
            dgrid_xe.Columns[3].Name = "Giá Xe";
            dgrid_xe.Columns[4].Name = "Thuế";
            dgrid_xe.Rows.Clear();
            foreach (var x in _carServices.GetListXe())
            {
                _hangxe = _hangXeServices.GetListHangXe().Find(c => c.Id == x.IdHangXe);
                dgrid_xe.Rows.Add(x.Id, x.Name, _hangxe.Name, x.Giaxe, x.Thue);
            }
        }

        private void btn_them_Click(object sender, System.EventArgs e)
        {
            //Check thêm cả các checkbox đã được checked hay
            if (chk_10.Checked == false && chk_20.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn mức thuế");
                return;
            }
            //gọi phương thức check số từ bên Class Check 
            // nếu truyền dữ liệu vào và trả về kết quả khác OK tức là đang bị lỗi và phải thông báo cho người dùng
            if (_check.CheckSo(txt_giaxe.Text) == false)
            {
                MessageBox.Show("Giá tiền không được phép chứa chữ cái");
                return;
            }
            //  Check các trường khi thực hiện chức năng
            if (_check.CheckRong(txt_tenxe.Text, cbo_hangxe.Text, txt_giaxe.Text) == false)
            {
                MessageBox.Show("Các trường tên xe, hãng xe, giá xe không được phép để trống");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm xe này không ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                MessageBox.Show(_carServices.AddXe(new Xe()
                {
                    Name = txt_tenxe.Text,
                    IdHangXe = _hangXeServices.GetListHangXe().Where(c => c.Name == cbo_hangxe.Text).Select(c => c.Id).FirstOrDefault(),
                    Giaxe = Convert.ToInt32(txt_giaxe.Text),
                    Thue = Convert.ToDouble(chk_10.Checked == true ? 10 : 20)
                }));
                loadData();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
        void TimKiem(string name)
        {


            dgrid_xe.ColumnCount = 5;
            dgrid_xe.Columns[0].Name = "IdXe";
            dgrid_xe.Columns[0].Visible = false;
            dgrid_xe.Columns[1].Name = "Tên Xe";
            dgrid_xe.Columns[2].Name = "Tên Hãng Xe";
            dgrid_xe.Columns[3].Name = "Giá Xe";
            dgrid_xe.Columns[4].Name = "Thuế";
            dgrid_xe.Rows.Clear();
            foreach (var x in _carServices.GetListXe().Where(c => c.Name.Contains(name)))
            {
                _hangxe = _hangXeServices.GetListHangXe().Find(c => c.Id == x.IdHangXe);
                dgrid_xe.Rows.Add(x.Id, x.Name, _hangxe.Name, x.Giaxe, x.Thue);
            }
        }
        private void btn_sua_Click(object sender, System.EventArgs e)
        {
            //Check thêm cả các checkbox đã được checked hay
            if (chk_10.Checked == false && chk_20.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn mức thuế");
                return;
            }
            //gọi phương thức check số từ bên Class Check 
            // nếu truyền dữ liệu vào và trả về kết quả khác OK tức là đang bị lỗi và phải thông báo cho người dùng
            if (_check.CheckSo(txt_giaxe.Text) == false)
            {
                MessageBox.Show("Giá tiền không được phép chứa chữ cái");
                return;
            }
            //  Check các trường khi thực hiện chức năng
            if (_check.CheckRong(txt_tenxe.Text, cbo_hangxe.Text, txt_giaxe.Text) == false)
            {
                MessageBox.Show("Các trường tên xe, hãng xe, giá xe không được phép để trống");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn sửa xe này không ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_carServices.UpdateXe(_getId, new Xe()
                {
                    Name = txt_tenxe.Text,
                    IdHangXe = _hangXeServices.GetListHangXe().Where(c => c.Name == cbo_hangxe.Text).Select(c => c.Id).FirstOrDefault(),
                    Giaxe = Convert.ToInt32(txt_giaxe.Text),
                    Thue = Convert.ToDouble(chk_10.Checked == true ? 10 : 20)
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
            //Check thêm cả các checkbox đã được checked hay
            if (chk_10.Checked == false && chk_20.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn mức thuế");
                return;
            }
            //gọi phương thức check số từ bên Class Check 
            // nếu truyền dữ liệu vào và trả về kết quả khác OK tức là đang bị lỗi và phải thông báo cho người dùng
            if (_check.CheckSo(txt_giaxe.Text) == false)
            {
                MessageBox.Show("Giá tiền không được phép chứa chữ cái");
                return;
            }
            //  Check các trường khi thực hiện chức năng
            if (_check.CheckRong(txt_tenxe.Text, cbo_hangxe.Text, txt_giaxe.Text) == false)
            {
                MessageBox.Show("Các trường tên xe, hãng xe, giá xe không được phép để trống");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa xe này không ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_carServices.DeleteXe(_getId));
                loadData();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            TimKiem(txt_search.Text);
        }



        private void btn_hienthi_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgrid_xe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1 || rd >= _carServices.GetListXe().Count)
            {
                return;
            }


            _getId = Convert.ToInt32(Convert.ToString(dgrid_xe.Rows[rd].Cells[0].Value));
            txt_tenxe.Text = Convert.ToString(dgrid_xe.Rows[rd].Cells[1].Value);
            cbo_hangxe.Text = Convert.ToString(dgrid_xe.Rows[rd].Cells[2].Value);
            txt_giaxe.Text = Convert.ToString(dgrid_xe.Rows[rd].Cells[3].Value);

            // chỗ này anh cho thêm "%" vì khi lấy dữ liệu ra chỉ là (10,20) để có thể bằng với giá trị măc định của check box à 10%, 20%
            chk_10.Checked = Convert.ToString(dgrid_xe.Rows[rd].Cells[4].Value + "%") == "10%";
            chk_20.Checked = Convert.ToString(dgrid_xe.Rows[rd].Cells[4].Value + "%") == "20%";
        }

        private void chk_10_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_10.Checked)
            {
                chk_20.Checked = false;
            }
        }

        private void chk_20_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_20.Checked)
            {
                chk_10.Checked = false;
            }
        }

        private void txt_tenxe_Enter(object sender, EventArgs e)
        {
            if (txt_tenxe.Text == "Tên Xe")
            {
                txt_tenxe.Text = "";
            }
        }

        private void txt_giaxe_Enter(object sender, EventArgs e)
        {
            if (txt_giaxe.Text == "Giá Xe")
            {
                txt_giaxe.Text = "";
            }
        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            if (txt_search.Text == "Mời Bạn Nhập Tên Xe Muốn Tìm Kiếm")
            {
                txt_search.Text = "";
            }
        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                txt_search.Text = "Mời Bạn Nhập Tên Xe Muốn Tìm Kiếm";
            }
        }
    }
}
