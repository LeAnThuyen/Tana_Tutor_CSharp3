using Buoi1.Respoitories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Buoi1.Services
{
    public class DrinkServices
    {
        private DrinksRepos _drinksRepos;
        private List<DrinksRepos> _lstDrinks;
        public DrinkServices()
        {
            _lstDrinks = new List<DrinksRepos>();
            _drinksRepos = new DrinksRepos();
            FakeData();
            GetDataFromList();
        }

        //phương thức fake data
        public void FakeData()
        {
            DrinksRepos drinksRepos1 = new DrinksRepos();
            drinksRepos1.Id = System.Guid.NewGuid();
            // DK001
            drinksRepos1.MaDoUong = "DK0";
            drinksRepos1.TenDoUong = "Matchito";
            drinksRepos1.GiaDoUong = 12671;
            drinksRepos1.TrangThai = true;
            drinksRepos1.DungTich = 50;
            _lstDrinks.Add(drinksRepos1);
            //
            DrinksRepos drinksRepos2 = new DrinksRepos();
            drinksRepos2.Id = System.Guid.NewGuid();
            // DK001
            drinksRepos2.MaDoUong = "DK1";
            drinksRepos2.TenDoUong = "Coffe";
            drinksRepos2.GiaDoUong = 10000;
            drinksRepos2.TrangThai = true;
            drinksRepos2.DungTich = 100;
            _lstDrinks.Add(drinksRepos2);

        }
        //phương thức thêm
        public string ThemDoUong(DrinksRepos drinksRepos)
        {
            if (drinksRepos == null)
            {
                return "Thêm thất bại ";
            }
            _lstDrinks.Add(drinksRepos);
            return "Thêm Thành Công ";
        }
        //phương thức sửa
        public string SuaDoUong(Guid? Id, DrinksRepos drinksRepos)
        {
            if (drinksRepos == null || Id == null)
            {
                return "Sửa thất bại ";
            }
            if (_lstDrinks.Any(c => c.Id == Id) == false)
            {
                return "Đồ Uống của bạn không tồn tại";
            }

            foreach (DrinksRepos x in _lstDrinks.Where(c => c.Id == Id))
            {
                x.TenDoUong = drinksRepos.TenDoUong;
                x.GiaDoUong = drinksRepos.GiaDoUong;
                x.TrangThai = drinksRepos.TrangThai;
                x.DungTich = drinksRepos.DungTich;
            }

            return "Cập Nhật Thành Công ";
        }
        //phương thức xóa
        public string XoaDoUong(Guid? Id)
        {

            if (_lstDrinks.Any(c => c.Id == Id) == false)
            {
                return "Đồ Uống của bạn không tồn tại";
            }

            foreach (DrinksRepos x in _lstDrinks.Where(c => c.Id == Id))
            {
                x.TrangThai = false;

            }

            return "Xóa Thành Công ";
        }
        //phương getdata
        public List<DrinksRepos> GetDataFromList()
        {

            return _lstDrinks;
        }
    }
}
