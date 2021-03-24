using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GymProJectv2.DataModel.Entity
{
    public class HocVienDKLopHoc
    {
        [Key]
        public int ID { get; set; }
        public int IDLopHoc { get; set; }
        [ForeignKey("IDLopHoc")]
        public virtual LopHoc LopHoc { get; set; }
        public int IDKhachHang { get; set; }
        [ForeignKey("IDKhachHang")]
        public virtual KhachHang KhachHang { get; set; }
        public DateTime NgayDangKy { get; set; }
        public int IDDichVu { get; set; }
        [ForeignKey("IDDichVu")]
        public DichVu DichVu { get; set; }
        [StringLength(2000)]
        public string ChiNhanh { get; set; }
    }
}