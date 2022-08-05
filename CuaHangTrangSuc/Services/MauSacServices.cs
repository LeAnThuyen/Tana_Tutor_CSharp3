using CuaHangTrangSuc.DomainClass;
using CuaHangTrangSuc.Repositories;
using System.Collections.Generic;

namespace CuaHangTrangSuc.Services
{
    public class MauSacServices
    {

        private MauSacRepositories _mauSacRepositories;
        public MauSacServices()
        {
            _mauSacRepositories = new MauSacRepositories();
            GetListMauSac();
        }
        public List<MauSacChuDao> GetListMauSac()
        {
            return _mauSacRepositories.GetListMau();
        }
    }
}
