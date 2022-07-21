using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tana_Tutor_CSharp3.Repositoties;
using Tana_Tutor_CSharp3.Services;

namespace Tana_Tutor_CSharp3
{
    public partial class Form1 : Form
    {
        private DrinkServices _drinkServices;
        private DrinksRepos _drinkrepos;
        public Form1()
        {

            InitializeComponent();
            _drinkServices = new DrinkServices();
            _drinkrepos = new DrinksRepos();
            LoadDataFormList();
            loadcboloc();
        }
        public void LoadDataFormList()
        {

            if (_drinkServices.GetListDrinks().Count == 0)
            {
                txt_soluong.Text = "Giỏ Hàng Đồ Uống Đang Trống Vui Lòng Thêm Đồ Uống";

            }
            dgrid_drinks.ColumnCount = 6;
            dgrid_drinks.Columns[0].Name = "IdDrink";
            dgrid_drinks.Columns[0].Visible = false;
            dgrid_drinks.Columns[1].Name = "Mã Đồ Uống";
            dgrid_drinks.Columns[1].ReadOnly = true;
            dgrid_drinks.Columns[2].Name = "Tên Đồ Uống";
            dgrid_drinks.Columns[3].Name = "Giá Đồ Uống";
            dgrid_drinks.Columns[4].Name = "Dung Tích Đồ Uống";
            dgrid_drinks.Columns[5].Name = "Trạng Thái Đồ Uống";
            dgrid_drinks.Rows.Clear();
            foreach (var x in _drinkServices.GetListDrinks())
            {
                dgrid_drinks.Rows.Add(x.Id, x.MaDoUong, x.TenDoUong, x.GiaDoUong, x.DungTich, x.TrangThai == true ? "Còn Hàng" : "Hết Hàng");
            }

        }
        private void dgrid_drinks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            int col = e.ColumnIndex;
            if (rd == -1)
                return;
            if (Convert.ToString(dgrid_drinks.Rows[rd].Cells[col].Value) == "")
            {
                return;
            }
            _drinkrepos.Id = Guid.Parse(Convert.ToString(dgrid_drinks.Rows[rd].Cells[0].Value));
            txt_madouong.Text = Convert.ToString(dgrid_drinks.Rows[rd].Cells[1].Value);
            txt_tendouong.Text = Convert.ToString(dgrid_drinks.Rows[rd].Cells[2].Value);
            txt_gia.Text = Convert.ToString(dgrid_drinks.Rows[rd].Cells[3].Value);
            txt_dungtich.Text = Convert.ToString(dgrid_drinks.Rows[rd].Cells[4].Value);
            rbt_conhang.Checked = Convert.ToString(dgrid_drinks.Rows[rd].Cells[5].Value) == "Còn Hàng";
            rbt_hethang.Checked = Convert.ToString(dgrid_drinks.Rows[rd].Cells[5].Value) == "Hết Hàng";

        }

        private void btn_them_Click(object sender, System.EventArgs e)
        {
            if (_drinkServices.GetListDrinks().Count == 0)
            {
                if (txt_tendouong.Text == "")
                {
                    MessageBox.Show("bạn chưa điềm thông tin đồ uống");
                    return;
                }
                MessageBox.Show(_drinkServices.AddDrink(new DrinksRepos
                {
                    Id = Guid.NewGuid(),
                    MaDoUong = "DK0",
                    TenDoUong = txt_tendouong.Text,
                    GiaDoUong = Convert.ToDouble(txt_gia.Text),
                    TrangThai = rbt_conhang.Checked,
                    DungTich = Convert.ToDouble(txt_dungtich.Text)
                }));
                LoadDataFormList();
                return;
            }

            if (_drinkServices.GetListDrinks().Count > 0)
            {
                MessageBox.Show(_drinkServices.AddDrink(new DrinksRepos
                {
                    Id = Guid.NewGuid(),
                    MaDoUong = "DK" + (_drinkServices.GetListDrinks().Max(c => int.Parse(c.MaDoUong.Substring(2, c.MaDoUong.Length - 2))) + 1),
                    TenDoUong = txt_tendouong.Text,
                    GiaDoUong = Convert.ToDouble(txt_gia.Text),
                    TrangThai = rbt_conhang.Checked,
                    DungTich = Convert.ToDouble(txt_dungtich.Text)
                }));
                LoadDataFormList();
                return;
            }
        }

        private void btn_sua_Click(object sender, System.EventArgs e)
        {
            if (_drinkServices.GetListDrinks().Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào để sửa");
                return;
            }


            MessageBox.Show(_drinkServices.UpdateDrink(_drinkrepos.Id, new DrinksRepos
            {
                Id = _drinkrepos.Id,
                MaDoUong = txt_madouong.Text,
                TenDoUong = txt_tendouong.Text,
                GiaDoUong = Convert.ToDouble(txt_gia.Text),
                TrangThai = rbt_conhang.Checked,
                DungTich = Convert.ToDouble(txt_dungtich.Text)
            }));
            LoadDataFormList();
            return;

        }

        private void btn_xoa_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(_drinkServices.RemoveDrink(_drinkrepos.Id));
            LoadDataFormList();
            return;
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void label4_Click(object sender, System.EventArgs e)
        {

        }
        void loadcboloc()
        {
            ArrayList row = new ArrayList();

            row = new ArrayList();
            row.Add("Giá");
            row.Add("Số Lượng");
            row.Add("Số Dung Tích");
            row.Add("Hạn Sử Dụng");
            cbo_loc.Items.AddRange(row.ToArray());
            cbo_loc.SelectedIndex = 0;
        }
        private void cbo_loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_loc.Text == "Số Lượng")
            {
                MessageBox.Show("anh thuyen dep trai");
            }
        }

        private void txt_timkiemdouong_Enter(object sender, EventArgs e)
        {
            if (txt_timkiemdouong.Text == "Mời bạn tìm kiếm đồ uống")
            {
                txt_timkiemdouong.Text = "";
            }
        }

        private void txt_timkiemdouong_Leave(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("bạn có muốn acb", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {

            }
            if (txt_timkiemdouong.Text == "")
            {
                txt_timkiemdouong.Text = "Mời bạn tìm kiếm đồ uống";
                txt_timkiemdouong.ForeColor = Color.RosyBrown;
            }
        }
    }
}

