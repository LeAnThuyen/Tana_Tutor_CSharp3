using EF_DatabaseFirst.Context;
using EF_DatabaseFirst.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EF_DatabaseFirst.Services
{
    public class DoAnServices
    {
        private FastFoodContext _dbContext;
        private List<FoodTour> _lstFood;
        public DoAnServices()
        {
            _dbContext = new FastFoodContext();
            _lstFood = new List<FoodTour>();
            GetDataFromDb();
        }

        public List<FoodTour> GetDataFromDb()
        {
            return _lstFood = _dbContext.FoodTours.ToList();
        }
        public string AddFood(FoodTour foodTour)
        {
            if (foodTour == null)
            {
                return "Thêm Thất Bại";
            }

            _dbContext.FoodTours.Add(foodTour);
            _dbContext.SaveChanges();

            return "Thêm Thành Công";
        }
        public string UpdateFood(Guid id, FoodTour foodTour)
        {
            if (foodTour == null)
            {
                return "Cập Nhật Thất Bại";
            }
            if (GetDataFromDb().Any(c => c.Id == id) == false)
            {
                return "Dồ ăn bạn muốn cập nhật không tồn tại";
            }


            foreach (FoodTour x in GetDataFromDb().Where(c => c.Id == id))
            {
                x.TenMonAn = foodTour.TenMonAn;
                x.TrangThai = foodTour.TrangThai;


                _dbContext.FoodTours.Update(x);
                _dbContext.SaveChanges();
            }

            return "Cập Nhật Thành Công";
        }
        public string DeleteFood(Guid id)
        {

            if (GetDataFromDb().Any(c => c.Id == id) == false)
            {
                return "Dồ ăn bạn muốn xóa không tồn tại";
            }

            foreach (FoodTour x in GetDataFromDb().Where(c => c.Id == id))
            {

                _dbContext.FoodTours.Remove(x);
                _dbContext.SaveChanges();
            }

            return "Xóa Thành Công";
        }






    }
}
