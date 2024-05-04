using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class QuyDinhDAO
    {
        private static QuyDinhDAO instance;
        public static QuyDinhDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new QuyDinhDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private QuyDinhDAO() { }
        public DataTable LayTatCaQuyDinh()
        {
            DataTable dt = new DataTable();
            String query = "Select * from THAMSO";
            dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public int CapNhatSoHieuXe(int GiaTriMoi)
        {
            int result = 0;
            string query = "UPDATE THAMSO SET GiaTri =" + GiaTriMoi + " WHERE MaThamSo = 'TS1'";
            result = DataProvider.Instance.ExecuteNonQuery(query);
            return result;
        }
        public DataTable LaySoHieuXe()
        {
            string query = "SELECT GiaTri FROM THAMSO WHERE MaThamSo = 'TS1'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int CapNhatSoXeSuaToiDa(int GiaTriMoi)
        {
            int result = 0;
            string query = "UPDATE THAMSO SET GiaTri =" + GiaTriMoi + " WHERE MaThamSo = 'TS2'";
            result = DataProvider.Instance.ExecuteNonQuery(query);
            return result;
        }
        public DataTable LaySoXeSuaToiDa()
        {
            string query = "SELECT GiaTri FROM THAMSO WHERE MaThamSo = 'TS2'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int CapNhatSoLoaiVatTu(int GiaTriMoi)
        {
            int result = 0;
            string query = "UPDATE THAMSO SET GiaTri =" + GiaTriMoi + " WHERE MaThamSo = 'TS3'";
            result = DataProvider.Instance.ExecuteNonQuery(query);
            return result;
        }
        public DataTable LaySoLoaiVatTu()
        {
            string query = "SELECT GiaTri FROM THAMSO WHERE MaThamSo = 'TS3'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int CapNhatSoLoaiTienCong(int GiaTriMoi)
        {
            int result = 0;
            string query = "UPDATE THAMSO SET GiaTri =" + GiaTriMoi + " WHERE MaThamSo = 'TS4'";
            result = DataProvider.Instance.ExecuteNonQuery(query);
            return result;
        }
        public DataTable LaySoLoaiTienCong()
        {
            string query = "SELECT GiaTri FROM THAMSO WHERE MaThamSo = 'TS4'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
