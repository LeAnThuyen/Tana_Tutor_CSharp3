using EF_DatabaseFirst.DomainClass;
using EF_DatabaseFirst.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EF_DatabaseFirst
{
    public partial class Form1 : Form
    {

        //folder views này chứa các form có trong bài của em
        private DoAnServices _doAnServices;
        private Guid _getId;
        public Form1()
        {
            InitializeComponent();
            _doAnServices = new DoAnServices();

            loadData();
            rbt_conhang.Checked = true;
        }

        void loadData()
        {
            dgrid_foods.ColumnCount = 4;
            dgrid_foods.Columns[0].Name = "IdMonAn";
            dgrid_foods.Columns[0].Visible = false;
            dgrid_foods.Columns[1].Name = "Mã Món Ăn";
            dgrid_foods.Columns[2].Name = "Tên Món Ăn";
            dgrid_foods.Columns[3].Name = "Trạng Thái";
            dgrid_foods.Rows.Clear();
            foreach (var x in _doAnServices.GetDataFromDb())
            {
                dgrid_foods.Rows.Add(x.Id, x.MaMonAn, x.TenMonAn, x.TrangThai == true ? "Còn Hàng" : "Hết Hàng");
            }
        }
        private void dgrid_foods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1) return;
            // mục đích để lấy ra id để thao tác với chwusc năng cập nhật cà xóa
            _getId = Guid.Parse(Convert.ToString(dgrid_foods.Rows[rd].Cells[0].Value));
            txt_mamonan.Text = Convert.ToString(dgrid_foods.Rows[rd].Cells[1].Value);
            txt_tenmonan.Text = Convert.ToString(dgrid_foods.Rows[rd].Cells[2].Value);
            rbt_conhang.Checked = Convert.ToString(dgrid_foods.Rows[rd].Cells[3].Value) == "Còn Hàng";
            rbt_hethang.Checked = Convert.ToString(dgrid_foods.Rows[rd].Cells[3].Value) == "Hết Hàng";
        }
        private void btn_them_Click(object sender, System.EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm đồ ăn này không ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_doAnServices.AddFood(new FoodTour()
                {
                    Id = System.Guid.NewGuid(),
                    MaMonAn = "MA" + Convert.ToString(_doAnServices.GetDataFromDb().Max(c => Convert.ToInt32(c.MaMonAn.Substring(2, c.MaMonAn.Length - 2))) + 1),
                    TenMonAn = txt_tenmonan.Text,
                    TrangThai = rbt_conhang.Checked,
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
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn sửa đồ ăn này không ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_doAnServices.UpdateFood(_getId, new FoodTour()
                {

                    TenMonAn = txt_tenmonan.Text,
                    TrangThai = rbt_conhang.Checked,
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
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa đồ ăn này không ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_doAnServices.DeleteFood(_getId));
                loadData();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }


    }
}
