using CuaHangTrangSuc.DomainClass;
using CuaHangTrangSuc.Repositories;
using System.Collections.Generic;

namespace CuaHangTrangSuc.Services
{
    public class NhaSanXuatServices
    {
        private NhaSanXuatRepositories _nhaSanXuatRepositories;
        public NhaSanXuatServices()
        {
            _nhaSanXuatRepositories = new NhaSanXuatRepositories();
            GetListNhaSanXuat();
        }
        public List<NhaSanXuat> GetListNhaSanXuat()
        {
            return _nhaSanXuatRepositories.GetListNhaSanXuat();
        }
    }
}
