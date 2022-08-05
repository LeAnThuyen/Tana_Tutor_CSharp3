namespace CuaHangTrangSuc.Utilities
{
    public class CheckRongf
    {



        public bool CheckRong(string txt)
        {
            if (string.IsNullOrEmpty(txt))
            {
                return false;
            }
            return true;
        }
    }
}
