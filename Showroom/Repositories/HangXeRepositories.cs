using Showroom.DomainClass;
using System.Collections.Generic;
using System.Linq;

namespace Showroom.Repositories
{
    public class HangXeRepositories
    {
        private QuanLyXeContext _quanLyXeContext;
        private List<HangXe> _lstHangXe;
        public HangXeRepositories()
        {
            _quanLyXeContext = new QuanLyXeContext();
            _lstHangXe = new List<HangXe>();
            GetListHangXe();
        }
        public List<HangXe> GetListHangXe()
        {
            return _lstHangXe = _quanLyXeContext.HangXes.ToList();
        }
    }
}
