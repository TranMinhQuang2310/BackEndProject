using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace GymProJectv2.DataModel.Entity
{
    public class PhieuDanhGiaHLV
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50)]
        public string MaPhieu { get; set; }
        public int? IDHuanLuyenVien { get; set; }
        [ForeignKey("IDHuanLuyenVien")]
        [InverseProperty("PhieuDanhGiaHLV_IDHuanLuyenViens")]
        public virtual NhanVien NhanVien_IDHuanLuyenVien { get; set; }
        public int? IDNhanVienDanhGia { get; set; }
        [ForeignKey("IDNhanVienDanhGia")]
        [InverseProperty("PhieuDanhGiaHLV_IDNhanVienDanhGias")]
        public virtual NhanVien NhanVien_IDNhanVienDanhGia { get; set; }
        public int Diem { get; set; }
        public int IDTieuChiDanhGia { get; set; }
        [ForeignKey("IDTieuChiDanhGia")]
        public virtual TieuChiDanhGia TieuChiDanhGia { get; set; }
        public DateTime NgayDanhGia { get; set; }
        [StringLength(2000)]
        public string GhiChu { get; set; }
    }
}