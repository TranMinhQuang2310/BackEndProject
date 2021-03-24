using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace GymProJectv2.DataModel.Entity
{
    public class LopHoc
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50)]
        public string MaLop { get; set; }
        [StringLength(200)]
        public string TenLop { get; set; }
        [StringLength(200)]
        public string SoPhong {get;set;}
        public int IDNhanVien {get;set;}
        [ForeignKey("IDNhanVien")]
        public NhanVien NhanVien {get;set;}
        public int IDGiaoAn {get;set;}
        [ForeignKey("IDGiaoAn")]
        public GiaoAn GiaoAn {get;set;}
        public DateTime NgayBatDau {get;set;}
        public DateTime NgayKetThuc {get;set;}
        public ICollection<HocVienDKLopHoc> HocVienDKLopHocs { get; set; }
        
    }
}