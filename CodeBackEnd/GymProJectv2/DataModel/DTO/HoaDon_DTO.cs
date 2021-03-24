using System;
using System.Collections.Generic;
namespace GymProJectv2.DataModel.DTO
{
    public class HoaDon_DTO
    {
        public int ID { get; set; }
        public int IDKhachHang { get; set; }
        public int IDNhanVien { get; set; }
        public string MaHD { get; set; }
        public string MaChiNhanh { get; set; }
        public string MaSoThue { get; set; }
        public string TenDoanhNghiep { get; set; }
        public string DiaChiChiNhanh { get; set; }
        public string SoThue { get; set; }
        public string HinhThucThanhToan { get; set; }
        public bool DaDuyet { get; set; }
        public DateTime NgayLapHD { get; set; }
        public string TenNVBanHang { get; set; }
        public string TenNVLapPhieu { get; set; }
        public string ChucVu { get; set; }
        public string MaKHLienQuan { get; set; }
        public string MaNVBanHang { get; set; }
        public string MaNVLapPhieu { get; set; }
        public List<SanPham_DTO> DSSanPham { get; set;}

    }
}