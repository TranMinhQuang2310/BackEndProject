using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace GymProJectv2.DataModel.Entity
{
    public class DichVu
    {
        [Key]
        public int ID { get; set;}
        [StringLength(200)]
        public string TenDV {get; set;}
        public double DonGia {get; set;}
        [StringLength(1000)]
        public string GhiChu {get; set;}

        public ICollection<HocVienDKLopHoc> HocVienDKLopHocs {get;set;}

    }
}