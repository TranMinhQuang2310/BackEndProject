using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
namespace GymProJectv2.DataModel.Entity
{
    public class KhachHang
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50)]
        public string MaKH { get; set; }
        [StringLength(200)]
        public string HoVaTen { get; set; }
        [StringLength(50)]
        public string LoaiKH { get; set; }
        public DateTime NgaySinh { get; set; }
        [StringLength(50)]
        public string SoDienThoai { get; set; }
        [StringLength(200)]
        public string Email { get; set; }
        [StringLength(2000)]
        public string DiaChi { get; set; }
        [StringLength(50)]
        public string GioiTinh { get; set; }
        [StringLength(2000)]
        public string GhiChu { get; set; }
        [StringLength(50)]
        public string SoTKNganHang { get; set; }
        [StringLength(200)]
        public string TenNganHang { get; set; }
        [Required]
        public bool TrangThai { get; set; } 

        public ICollection<HoaDon> HoaDons { get; set; }
        public ICollection<HocVienDKLopHoc> HocVienDKLopHocs { get; set; }
        public ICollection<PhieuChi> PhieuChis { get; set; }
        public ICollection<PhieuThu> PhieuThus { get; set; }
    }
}