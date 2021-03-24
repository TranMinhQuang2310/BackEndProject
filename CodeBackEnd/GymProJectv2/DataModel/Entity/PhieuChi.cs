using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace GymProJectv2.DataModel.Entity
{
    public class PhieuChi
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50)]
        public string MaPhieuChi { get; set; }
        [StringLength(50)]
        public string SoPhieuChi { get; set; }
        public DateTime NgayLapPhieu { get; set; }
        [StringLength(100)]
        public string TenNVLapPhieu { get; set; }
        [StringLength(50)]
        public string HinhThucChi { get; set; }
        [StringLength(50)]
        public string MaNguoiNhan { get; set; }
        [StringLength(100)]
        public string HoTenNguoiNhan { get; set; }
        [StringLength(50)]
        public string LoaiPhieuChi { get; set; }
        public bool DaDuyet { get; set; }
        [StringLength(200)]
        public string TTLienLac { get; set; }
        [StringLength(1000)]
        public string LyDoChi { get; set; }
        [StringLength(100)]
        public string TenKH { get; set; }
        [StringLength(100)]
        public string TenNVBanHang { get; set; }
        [StringLength(100)]
        public string TenNhanVienChiuTrachNhiem { get; set; }  
        [StringLength(50)]
        public string ChucVu { get; set; }
        public int? IDNhanVienLapPhieu { get; set; }
        public int? IDNhanVienBanHang { get; set; }
        [ForeignKey("IDNhanVienLapPhieu")]
        [InverseProperty("PhieuChi_IDNhanVienLapPhieus")]
        public virtual NhanVien NhanVien_IDNhanVienLapPhieu { get; set; }
        [ForeignKey("IDNhanVienBanHang")]
        [InverseProperty("PhieuChi_IDNhanVienBanHangs")]
        public virtual NhanVien NhanVien_IDNhanVienBanHang { get; set; }

        public ICollection<LapPhieuChi> LapPhieuChis { get; set; }
        
    }
}