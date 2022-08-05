using CuaHangTrangSuc.DomainClass;
using CuaHangTrangSuc.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CuaHangTrangSuc.Services
{
    public class TrangSucService
    {

        private TrangSucRepositories _trangSucRepositories;
        private NhaSanXuatRepositories _nhaSanXuatRepositories;
        private MauSacRepositories _mauSacRepositories;
        public TrangSucService()
        {
            _trangSucRepositories = new TrangSucRepositories();
            _nhaSanXuatRepositories = new NhaSanXuatRepositories();
            _mauSacRepositories = new MauSacRepositories();
        }
        public List<TrangSuc> GetListTrangSuc()
        {
            return _trangSucRepositories.GetListTrangSuc();
        }
        public string AddTrangSuc(TrangSuc trangSuc)
        {
            return _trangSucRepositories.AddTrangSuc(trangSuc);
        }
        public string UpdateTrangSuc(Guid? Id, TrangSuc trangSuc)
        {

            return _trangSucRepositories.UpdateTrangSuc(Id, trangSuc);

        }
        public string DeleteTrangSuc(Guid? id)
        {


            return _trangSucRepositories.DeleteTrangSuc(id);
        }
        // đây là cách thứ 2 giúp các em hiển thị đầy đủ thông tin của Trang Sức
        // cách này sẽ khó hơn vì mình không dùng 1 view model để làm đối tượng trung gian chứa đầy đủ dữ liệu mà mình sẽ dùng dynamic để nhận
        public IEnumerable<dynamic> MixedList()
        {
            var finalList = (from a in GetListTrangSuc()
                             join b in _nhaSanXuatRepositories.GetListNhaSanXuat() on a.IdNhaSanXuat equals b.IdNhaSanXuat
                             join c in _mauSacRepositories.GetListMau() on a.IdMauChuDao equals c.IdMauSac
                             select new { a.Id, a.MaTrangSuc, a.TenTrangSuc, a.Gia, b.TenNhaSanXuat, c.TenMauSac, a.TrangThai }).ToList();
            return finalList;
        }
    }
}
