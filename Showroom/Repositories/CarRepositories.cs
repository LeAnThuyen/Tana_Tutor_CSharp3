using Showroom.DomainClass;
using System.Collections.Generic;
using System.Linq;

namespace Showroom.Repositories
{
    public class CarRepositories
    {
        private QuanLyXeContext _quanLyXeContext;
        private List<Xe> _lstXe;
        public CarRepositories()
        {
            _quanLyXeContext = new QuanLyXeContext();
            _lstXe = new List<Xe>();
            GetListXe();
        }

        public List<Xe> GetListXe()
        {
            return _lstXe = _quanLyXeContext.Xes.ToList();
        }
        public string AddXe(Xe xe)
        {
            if (xe == null)
            {
                return "Thêm Thất Bại";
            }

            _quanLyXeContext.Xes.Add(xe);
            _quanLyXeContext.SaveChanges();
            return "Thêm Thành Công";
        }
        public string UpdateXe(int? Id, Xe xe)
        {
            if (xe == null || Id == null)
            {
                return "Cập Nhật Thất bại";
            }
            if (GetListXe().Any(c => c.Id == Id) == false)
            {
                return "Không Tìm Thấy Xe Muốn Cập Nhật";
            }
            //
            foreach (Xe x in GetListXe().Where(c => c.Id == Id))
            {

                x.Name = xe.Name;
                x.IdHangXe = xe.IdHangXe;
                x.Giaxe = xe.Giaxe;
                //
                x.Thue = xe.Thue;

                _quanLyXeContext.Xes.Update(x);
                _quanLyXeContext.SaveChanges();
            }

            return "Cập Nhật Thành Công";

        }
        public string DeleteXe(int? id)
        {

            if (GetListXe().Any(c => c.Id == id) == false)
            {
                return "Không Tìm Thấy Xe Muốn Xóa";
            }
            //
            _quanLyXeContext.Xes.Remove(GetListXe().Find(c => c.Id == id));
            _quanLyXeContext.SaveChanges();
            //

            //foreach (var x in GetListXe().Where(c => c.Id == id))
            //{
            //    _quanLyXeContext.Xes.Remove(x);
            //    _quanLyXeContext.SaveChanges();
            //    return "Xóa Thành Công";
            //}
            return "Xóa Thành Công";
        }
    }
}
