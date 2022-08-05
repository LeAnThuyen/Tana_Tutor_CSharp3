using CuaHangTrangSuc.DomainClass;
using System.Collections.Generic;
using System.Linq;

namespace CuaHangTrangSuc.Repositories
{
    public class NhaSanXuatRepositories
    {
        private CSharpContext _cSharpContext;
        private List<NhaSanXuat> _lstNhaSanXuat;
        public NhaSanXuatRepositories()
        {
            _cSharpContext = new CSharpContext();
            _lstNhaSanXuat = new List<NhaSanXuat>();
            GetListNhaSanXuat();
        }
        public List<NhaSanXuat> GetListNhaSanXuat()
        {
            return _lstNhaSanXuat = _cSharpContext.NhaSanXuats.ToList();
        }
    }
}
