using Buoi1.Respoitories;
using Buoi1.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Buoi1
{
    public partial class Form1 : Form
    {

        private DrinkServices _drinkServices;
        private DrinksRepos _drinksRepos;
        public Form1()
        {

            InitializeComponent();
            _drinkServices = new DrinkServices();
            _drinksRepos = new DrinksRepos();
            LoadData();
        }

        public void LoadData()
        {
            dgrid_drinks.ColumnCount = 6;
            //
            dgrid_drinks.Columns[0].Name = "ID";
            dgrid_drinks.Columns[0].Visible = false;
            //
            dgrid_drinks.Columns[1].Name = "Mã Đồ Uống";
            dgrid_drinks.Columns[2].Name = "Tên Đồ Uống";
            dgrid_drinks.Columns[3].Name = "Giá Đồ Uống";
            dgrid_drinks.Columns[4].Name = "Dung Tích";
            dgrid_drinks.Columns[5].Name = "Trạng Thái";
            dgrid_drinks.Rows.Clear();
            //thêm dữ liệu
            foreach (var x in _drinkServices.GetDataFromList().Where(c => c.TrangThai == true))
            {
                dgrid_drinks.Rows.Add(x.Id, x.MaDoUong, x.TenDoUong, x.GiaDoUong, x.DungTich, x.TrangThai == true ? "Còn Hàng" : "Hết Hàng");
            }

        }

        private void btn_them_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thêm hay không ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_drinkServices.ThemDoUong(new DrinksRepos
                {     //dk4
                      //"DK 0021"++++//3
                    Id = Guid.NewGuid(),
                    MaDoUong = "DK" + Convert.ToString(_drinkServices.GetDataFromList().Max(c => Convert.ToInt32(c.MaDoUong.Substring(2, c.MaDoUong.Length - 2))) + 1),
                    TenDoUong = txt_tendouong.Text,
                    GiaDoUong = Convert.ToDouble(txt_gia.Text),
                    DungTich = Convert.ToDouble(txt_dungtich.Text),
                    TrangThai = rbt_conhang.Checked
                }));
                LoadData();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }

        private void txt_timkiemdouong_Enter(object sender, EventArgs e)
        {

        }

        private void txt_timkiemdouong_Leave(object sender, EventArgs e)
        {

        }

        private void txt_timkiemdouong_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void dgrid_drinks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            int col = e.ColumnIndex;
            //
            if (rd == -1) return;
            if (Convert.ToString(dgrid_drinks.Rows[rd].Cells[col].Value) == "")
            {
                return;
            }
            _drinksRepos.Id = Guid.Parse(Convert.ToString(dgrid_drinks.Rows[rd].Cells[0].Value));
            txt_madouong.Text = Convert.ToString(dgrid_drinks.Rows[rd].Cells[1].Value);
            txt_tendouong.Text = Convert.ToString(dgrid_drinks.Rows[rd].Cells[2].Value);
            txt_gia.Text = Convert.ToString(dgrid_drinks.Rows[rd].Cells[3].Value);
            txt_dungtich.Text = Convert.ToString(dgrid_drinks.Rows[rd].Cells[4].Value);
            rbt_conhang.Checked = Convert.ToString(dgrid_drinks.Rows[rd].Cells[5].Value) == "Còn Hàng";


        }

        private void cbo_loc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
