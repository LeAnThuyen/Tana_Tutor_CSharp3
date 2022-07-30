using EF_DatabaseFirst.DomainClass;
using EF_DatabaseFirst.Repositories;
using System;
using System.Collections.Generic;

namespace EF_DatabaseFirst.Services
{
    public class FastFoodServices
    {

        //folder service này sẽ được tầng view gọi xuống trực tiếp để sử dụng các phương thức
        //đồng thời folder service này sẽ gọi tiếp xuống tầng Repostories để thực thi các phương thức đã thi triển

        private FoodTourRepositories _foodTourRepositories;
        private List<FoodTour> _lstFoods;
        public FastFoodServices()
        {
            _foodTourRepositories = new FoodTourRepositories();
            _lstFoods = new List<FoodTour>();
        }
        public List<FoodTour> GetListFood()
        {
            return _lstFoods = _foodTourRepositories.GetListFoodFromDB();
        }
        public string AddFood(FoodTour foodTour)
        {
            return _foodTourRepositories.AddFood(foodTour);
        }
        public string UpdateFood(Guid id, FoodTour foodTour)
        {

            return _foodTourRepositories.UpdateFood(id, foodTour);
        }
        public string DeleteFood(Guid? id)
        {
            return _foodTourRepositories.DeleteFood(id);
        }

    }
}
