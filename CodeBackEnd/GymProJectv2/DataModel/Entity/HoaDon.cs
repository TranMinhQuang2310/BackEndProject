using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
namespace GymProJectv2.DataModel.Entity
{
    public class HoaDon
    {
        [Key]
        public int ID { get; set; }
        public int IDNhanVien { get; set; }
        [ForeignKey("IDNhanVien")]
        public virtual NhanVien NhanVien { get; set; }
        public int IDKhachHang { get; set; }
        [ForeignKey("IDKhachHang")]
        public virtual KhachHang KhachHang { get; set; }
        [StringLength(50)]
        public string MaHD { get; set; }
        [StringLength(50)]
        public string MaChiNhanh { get; set; }
        [StringLength(50)]
        public string MaSoThue { get; set; }
        [StringLength(1000)]
        public string TenDoanhNghiep { get; set; }
        [StringLength(1000)]
        public string DiaChiChiNhanh { get; set; }
        [StringLength(50)]
        public string SoThue { get; set; }
        [StringLength(50)]
        public string HinhThucThanhToan { get; set; }
        public bool DaDuyet { get; set; }
        public DateTime NgayLapHD { get; set; }
        [StringLength(100)]
        public string TenNVBanHang { get; set; }
        [StringLength(100)]
        public string TenNVLapPhieu { get; set; }
        [StringLength(50)]
        public string ChucVu { get; set; }
        [StringLength(50)]
        public string MaKHLienQuan { get; set; }
        [StringLength(50)]
        public string MaNVBanHang { get; set; }
        [StringLength(50)]
        public string MaNVLapPhieu { get; set; }

        public ICollection<HoaDonSanPham> HoaDonSanPhams { get; set; }

    }
}