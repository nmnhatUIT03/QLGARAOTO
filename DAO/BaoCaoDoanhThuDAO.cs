using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class BaoCaoDoanhThuDAO
    {
        private static BaoCaoDoanhThuDAO instance;
        public static BaoCaoDoanhThuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BaoCaoDoanhThuDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private BaoCaoDoanhThuDAO() { }

        public DataTable BaoCaoDoanhThu(int Thang, int Nam)
        {
            string query = "BaoCaoDoanhThu @Thang , @Nam";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { Thang, Nam });
        }

        public DataTable TongTienDoanhThu(int Thang, int Nam)
        {
            string query = "TongTienDoanhThu @Thang , @Nam";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { Thang, Nam });
        }
    }
}
