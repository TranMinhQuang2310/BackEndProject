using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace GymProJectv2.DataModel.Entity
{
    public class PhieuThu
    {
        [Key]
        public int ID { get; set; }
        public int? IDKhachHang { get; set; }
        [ForeignKey("IDKhachHang")]
        public virtual KhachHang KhachHang { get; set; }
        [StringLength(50)]
        public string MaPhieuThu { get; set; }
        [StringLength(50)]
        public string SoPhieuThu { get; set; }
        [StringLength(50)]

        public string LoaiThue { get; set; }
        [StringLength(50)]

        public string LoaiPhieuThu { get; set; }
        [StringLength(2000)]

        public string LyDoNop { get; set; }
        public bool DaDuyet { get; set; }//
        public DateTime NgayLapPhieu { get; set; }
        public int? IDNhanVienLapPhieu { get; set; }
        public int? IDNhanVienBanHang { get; set; }
        [ForeignKey("IDNhanVienLapPhieu")]
        [InverseProperty("PhieuThu_IDNhanVienLapPhieus")]
        public virtual NhanVien NhanVien_IDNhanVienLapPhieu { get; set; }
        [ForeignKey("IDNhanVienBanHang")]
        [InverseProperty("PhieuThu_IDNhanVienBanHangs")]
        public virtual NhanVien NhanVien_IDNhanVienBanHang { get; set; }

        public ICollection<LapPhieuThu> LapPhieuThus { get; set; }
    }
}