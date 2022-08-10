using Showroom.DomainClass;
using Showroom.Repositories;
using System.Collections.Generic;

namespace Showroom.Services
{
    public class HangXeServices
    {
        private HangXeRepositories _hangXeRepositories;
        public HangXeServices()
        {
            _hangXeRepositories = new HangXeRepositories();
            GetListHangXe();
        }
        public List<HangXe> GetListHangXe()
        {
            return _hangXeRepositories.GetListHangXe();
        }
    }
}
