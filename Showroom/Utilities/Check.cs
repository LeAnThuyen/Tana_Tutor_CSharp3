using System.Text.RegularExpressions;

namespace Showroom.Utilities
{
    public class Check
    {


        public bool CheckSo(string txt)
        {
            //đây là đoạn mã để check xem có chứa số hay không, \d là chấp nhận các số từ 0 cho đến 9 , + là có thể có nhiều số phía sau
            //tránh trường hợp bỏ dấu + thì sẽ bị sai ví dụ khi nhập như này 9asaaaa
            if (Regex.IsMatch(txt, @"^\d+$") == false)
            {
                return false;
            }
            return true;
        }
        public bool CheckRong(string tenxe, string hangxe, string giaxe)
        {
            // hàm string.IsNullOrEmpty giúp các em kiểm tra 1 xem 1 chuỗi kí tự em truyền vào có bị null hoặc rỗng hay không 
            //nếu dữ liệu truyền vào là rỗng hoặc bị null thì lập tức sẽ trả về true và ngược lại
            if (string.IsNullOrEmpty(tenxe))
            {
                return false;
            }
            if (string.IsNullOrEmpty(hangxe))
            {
                return false;
            }
            if (string.IsNullOrEmpty(giaxe))
            {
                return false;
            }
            return true;
        }
    }
}
