using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
namespace GymProJectv2.DataModel.Entity
{
    public class NhanVien
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50)]
        public string MaNV { get; set; }
        [StringLength(200)]
        public string HoVaTen { get; set; }
        public DateTime NgaySinh { get; set; }
        [StringLength(50)]
        public string ChucVu { get; set; }
        [StringLength(50)]
        public string GioiTinh { get; set; }    
        [StringLength(50)]    
        public string SoDienThoai { get; set; }
        [StringLength(50)]
        public string CMND { get; set; }
        [StringLength(200)]
        public string DiaChi { get; set; }
        [StringLength(200)]
        public string Email { get; set; }
        [StringLength(200)]
        public string ChuyenMon { get; set; }
        [StringLength(2000)]
        public string GhiChu { get; set; }    

        public virtual ICollection<HoaDon> HoaDons { get; set;}
        public virtual ICollection<LopHoc> LopHocs {get;set;}
        public virtual ICollection<GiaoAnHLV> GiaoAnHLVs {get;set;}
        public virtual ICollection<PhieuChi> PhieuChi_IDNhanVienLapPhieus { get; set;}
        public virtual ICollection<PhieuChi> PhieuChi_IDNhanVienBanHangs { get; set;}
        public virtual ICollection<PhieuThu> PhieuThu_IDNhanVienLapPhieus { get; set; }
        public virtual ICollection<PhieuThu> PhieuThu_IDNhanVienBanHangs { get; set; }
        public virtual ICollection<PhieuDanhGiaHLV> PhieuDanhGiaHLV_IDNhanVienDanhGias { get; set; }
        public virtual ICollection<PhieuDanhGiaHLV> PhieuDanhGiaHLV_IDHuanLuyenViens { get; set; }
    }
}