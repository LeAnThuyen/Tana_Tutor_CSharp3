using CuaHangTrangSuc.DomainClass;
using System.Collections.Generic;
using System.Linq;

namespace CuaHangTrangSuc.Repositories
{
    public class MauSacRepositories
    {
        private CSharpContext _cSharpContext;
        private List<MauSacChuDao> _lstMauSacChuDao;
        public MauSacRepositories()
        {
            _cSharpContext = new CSharpContext();
            _lstMauSacChuDao = new List<MauSacChuDao>();
            GetListMau();
        }
        public List<MauSacChuDao> GetListMau()
        {
            return _lstMauSacChuDao = _cSharpContext.MauSacChuDaos.ToList();
        }
    }
}
