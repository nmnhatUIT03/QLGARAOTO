using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuNhapVTPTDAO
    {
        private static PhieuNhapVTPTDAO instance;
        private PhieuNhapVTPTDAO() { }
        public static PhieuNhapVTPTDAO Instance
        {
            get { if (instance == null) instance = new PhieuNhapVTPTDAO(); return instance; }
            private set { PhieuNhapVTPTDAO.instance = value; }
        }
        public int NhapVTPT(string ten, int soluong, DateTime now)
        {
            string query = "NhapVTPT @MaPhuTung , @SoLuong , @ThoiDiem";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, soluong, now });
        }

        public int NhapMoiVTPT(string ten, int soluong, int gia, DateTime now)
        {
            string query = "NhapMoiVTPT @TenPhuTung , @SoLuong , @DonGia , @ThoiDiem";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, soluong, gia, now });
        }
    }
}
