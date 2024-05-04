using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class XeDAO
    {
        private static XeDAO instance;
        public static XeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new XeDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private XeDAO() { }

        public DataTable CacXeDaTiepNhan()
        {
            string query = "SELECT BienSo, TenHieuXe, TenKH, DienThoai, DiaChi FROM XE, HIEUXE as HX, KHACHHANG as KH WHERE XE.MaKH = KH.MaKH and XE.MaHX = HX.MaHX and XE.TrangThai = 1";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SoXeTiepNhanTrongNgay(DateTime now)
        {
            string query = "SELECT COUNT(BienSo) FROM XE WHERE day(NgayTiepNhan) = " + now.Day + " and month(NgayTiepNhan) = " + now.Month + " and year(NgayTiepNhan) = " + now.Year;
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LamMoiDanhSachXe()
        {
            string query = "SELECT TenHieuXe, BienSo, TenKH, DienThoai, DiaChi FROM XE, HIEUXE as HX, KHACHHANG as KH WHERE Xe.MaKH = KH.MaKH and Xe.MaHX = HX.MaHX and XE.TrangThai = 1";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable TimKiemTuongDoi(string DL)
        {
            string query = "TimKiemTuongDoi @DuLieu";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { DL });
        }

        public DataTable TimKiemChinhXac(string BienSo, string HieuXe)
        {
            string query = "TimKiemChinhXac @BienSo , @HieuXe";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { BienSo, HieuXe });
        }
        public int ThemXe(string BienSo, string HieuXe, int MaKH, DateTime now)
        {
            string query = "ThemXe @BienSo , @HieuXe , @MaKH , @NgayTiepNhan";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { BienSo, HieuXe, MaKH, now });
        }
    }
}
