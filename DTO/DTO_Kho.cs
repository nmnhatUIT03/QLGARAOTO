using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_Kho
    {
        public string sMaPhuTung;
        public string sTenVatTuPhuTung;
        public int iSoLuong;
        public int iDonGia;

        public string MaPhuTung
        {
            get { return MaPhuTung; }
            set { MaPhuTung = value; }
        }

        public string TenVatTuPhuTung
        {
            get { return TenVatTuPhuTung; }
            set { TenVatTuPhuTung = value; }
        }

        public int SoLuong
        {
            get { return SoLuong; }
            set { SoLuong = value; }
        }

        public int DonGia
        {
            get { return DonGia; }
            set { DonGia = value; }
        }

    }
}
