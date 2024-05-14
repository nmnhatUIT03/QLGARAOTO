using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class PhieuThuTienDAO
    {
        private static PhieuThuTienDAO instance;
        public static PhieuThuTienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuThuTienDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private PhieuThuTienDAO() { }

        public DataTable LayTienNoKH(string BienSo)
        {
            string query = "SELECT TienNo from KHACHHANG as KH, XE WHERE XE.BienSo = '" + BienSo + "' and XE.MaKH = KH.MaKH";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int ThemPhieuThuTien(string BienSo, int SoTienThu, DateTime now)
        {
            string query = " ThemPhieuThuTien @BienSo , @TienThu , @NgayThuTien";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { BienSo, SoTienThu, now });
        }

        public DataTable LayThongTinKH(string BienSo)
        {
            string query = "SELECT TenKH, DienThoai, DiaChi FROM KHACHHANG as KH, XE WHERE KH.MaKH = XE.MaKH and XE.BienSo = '" + BienSo + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
