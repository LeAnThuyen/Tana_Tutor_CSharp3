using CuaHangTrangSuc.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CuaHangTrangSuc.Repositories
{
    public class TrangSucRepositories
    {
        private CSharpContext _cSharpContext;
        private List<TrangSuc> _lstTrangSuc;
        public TrangSucRepositories()
        {
            _cSharpContext = new CSharpContext();
            _lstTrangSuc = new List<TrangSuc>();
            GetListTrangSuc();
        }
        public List<TrangSuc> GetListTrangSuc()
        {
            return _lstTrangSuc = _cSharpContext.TrangSucs.ToList();
        }
        public string AddTrangSuc(TrangSuc trangSuc)
        {
            if (trangSuc == null)
            {
                return "Thêm Thất Bại";
            }
            _cSharpContext.TrangSucs.Add(trangSuc);
            _cSharpContext.SaveChanges();
            return "Thêm Thành Công";
        }
        public string UpdateTrangSuc(Guid? Id, TrangSuc trangSuc)
        {
            if (trangSuc == null || Id == null)
            {
                return "Cập Nhật Thất bại";
            }
            if (GetListTrangSuc().Any(c => c.Id == Id) == false)
            {
                return "Không Tìm Thấy Trang Sức Muốn Cập Nhật";
            }
            //
            foreach (TrangSuc x in GetListTrangSuc().Where(c => c.Id == Id))
            {


                x.TenTrangSuc = trangSuc.TenTrangSuc;
                x.Gia = trangSuc.Gia;
                x.TrangThai = trangSuc.TrangThai;
                //
                x.IdMauChuDao = trangSuc.IdMauChuDao;
                x.IdNhaSanXuat = trangSuc.IdNhaSanXuat;
                _cSharpContext.TrangSucs.Update(x);
                _cSharpContext.SaveChanges();
            }

            return "Cập Nhật Thành Công";

        }
        public string DeleteTrangSuc(Guid? id)
        {

            if (GetListTrangSuc().Any(c => c.Id == id) == false)
            {
                return "Không Tìm Thấy Trang Sức Muốn Xóa";
            }
            //
            _cSharpContext.TrangSucs.Remove(GetListTrangSuc().Find(c => c.Id == id));
            _cSharpContext.SaveChanges();
            //
            //foreach (var x in GetListTrangSuc().Where(c => c.Id == id))
            //{
            //    _cSharpContext.TrangSucs.Remove(x);
            //    _cSharpContext.SaveChanges();
            //}
            return "Xóa Thành Công";
        }


    }
}
