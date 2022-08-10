using Showroom.DomainClass;
using Showroom.Repositories;
using System.Collections.Generic;

namespace Showroom.Services
{
    public class CarServices
    {
        private CarRepositories _carRepositories;
        private HangXeRepositories _hangXeRepositories;
        public CarServices()
        {
            _carRepositories = new CarRepositories();
            _hangXeRepositories = new HangXeRepositories();
            GetListXe();

        }
        public List<Xe> GetListXe()
        {
            return _carRepositories.GetListXe();
        }
        public string AddXe(Xe xe)
        {
            return _carRepositories.AddXe(xe);
        }
        public string UpdateXe(int? Id, Xe xe)
        {

            return _carRepositories.UpdateXe(Id, xe);

        }
        public string DeleteXe(int? id)
        {


            return _carRepositories.DeleteXe(id);
        }
    }
}
