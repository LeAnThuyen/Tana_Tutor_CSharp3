using System;
using System.Collections.Generic;
using System.Linq;
using Tana_Tutor_CSharp3.Repositoties;

namespace Tana_Tutor_CSharp3.Services
{
    public class DrinkServices
    {
        private DrinksRepos _drinksRepos;
        private List<DrinksRepos> _lstDrinks;
        public DrinkServices()
        {
            _drinksRepos = new DrinksRepos();
            _lstDrinks = new List<DrinksRepos>();
            GetListDrinks();
        }


        public List<DrinksRepos> GetListDrinks()
        {
            return _lstDrinks;
        }
        public string AddDrink(DrinksRepos drinksRepos)
        {
            if (drinksRepos == null)
            {
                return "Thêm Thất Bại";
            }
            _lstDrinks.Add(drinksRepos);
            return "Thêm Thành Công";
        }
        public string UpdateDrink(Guid? Id, DrinksRepos drinksRepos)
        {
            if (drinksRepos == null || Id == null)
            {
                return "Cập Nhật Thất Bại";
            }
            if (_lstDrinks.Any(c => c.Id == Id) == false)
            {
                return "Cập Nhật Thất Bại";
            }

            foreach (var x in _lstDrinks.Where(c => c.Id == Id))
            {
                x.MaDoUong = drinksRepos.MaDoUong;
                x.TenDoUong = drinksRepos.TenDoUong;
                x.GiaDoUong = drinksRepos.GiaDoUong;
                x.TrangThai = drinksRepos.TrangThai;
                x.DungTich = drinksRepos.DungTich;

            }
            return "Cập Nhật Thành Công";
        }
        public string RemoveDrink(Guid? Id)
        {

            if (_lstDrinks.Any(c => c.Id == Id) == false)
            {
                return "Xóa Thất Bại";
            }

            foreach (DrinksRepos x in _lstDrinks.Where(c => c.Id == Id).ToList())
            {

                _lstDrinks.Remove(x);
            }
            return "Xóa Thành Công";
        }
    }
}
