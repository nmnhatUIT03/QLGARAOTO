using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;
        public static TaiKhoanDAO Instance {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private TaiKhoanDAO() { }
        public DataTable DangNhap(string TaiKhoan, string MatKhau)
        {
            string query = "USP_Dangnhap @TenDangNhap , @MatKhau";

            return DataProvider.Instance.ExecuteQuery(query, new object[] { TaiKhoan, MatKhau });
        }
        public string LayQuyenHan(string User, string Pass)
        {
            string query = "USP_Dangnhap @TenDangNhap , @MatKhau";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { User, Pass });

            string qh = result.Rows[0][4].ToString();
            return qh ;
        }

        public string LayHoTen(string User, string Pass)
        {
            string query = "USP_Dangnhap @TenDangNhap , @MatKhau";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { User, Pass });

            string qh = result.Rows[0][1].ToString();
            return qh;
        }

        public int LayMaTaiKhoan(string User, string Pass)
        {
            string query = "USP_Dangnhap @TenDangNhap , @MatKhau";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { User, Pass });

            int ma = int.Parse(result.Rows[0][0].ToString());
            return ma;
        }

        public void CapNhatMatKhau(string matkhau, int id) 
        {
            string query = "DoiMK @MaTK , @MatKhauMoi";
            DataProvider.Instance.UpdateDatabase(query, new object[] { id, matkhau });
        }
    }
}
