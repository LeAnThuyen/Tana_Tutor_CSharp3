using EF_DatabaseFirst.Context;
using EF_DatabaseFirst.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EF_DatabaseFirst.Repositories
{
    public class FoodTourRepositories
    {
        //folder Repositories chính là nơi chứa các chức năng nghiệp vụ của các em,
        //khai báo khởi tạo Context để giúp khai triển các phương thức

        private FastFoodContext _dbContext;
        private List<FoodTour> _lstFoods;
        public FoodTourRepositories()
        {
            _dbContext = new FastFoodContext();
            _lstFoods = new List<FoodTour>();
        }
        public List<FoodTour> GetListFoodFromDB()
        {
            return _lstFoods = _dbContext.FoodTours.ToList();
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
                return "Cập nhật thất bại";
            }
            if (GetListFoodFromDB().Any(c => c.Id == id) == false)
            {
                return " Không tìm thấy đồ ăn mà bạn muốn cập nhật";
            }
            foreach (FoodTour x in GetListFoodFromDB().Where(c => c.Id == id))
            {
                x.TenMonAn = foodTour.TenMonAn;
                x.TrangThai = foodTour.TrangThai;
                _dbContext.FoodTours.Update(x);
                _dbContext.SaveChanges();
            }


            return "Cập nhật Thành Công";
        }
        public string DeleteFood(Guid? id)
        {
            if (GetListFoodFromDB().Any(c => c.Id == id) == false)
            {
                return " Không tìm thấy đồ ăn mà bạn muốn xóa";
            }
            var food = GetListFoodFromDB().Find(c => c.Id == id);
            _dbContext.FoodTours.Remove(food);
            _dbContext.SaveChanges();

            return "Xóa Thành Công";
        }
    }
}
