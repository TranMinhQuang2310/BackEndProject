using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace GymProJectv2.DataModel.Entity
{
    public class TieuChiDanhGia
    {
        [Key]
        public int ID { get; set; }
        [StringLength(200)]
        public string TenTieuChi { get; set; }
        [StringLength(200)]
        public string LoaiTieuChi { get; set; }
        public int DiemToiDa { get; set; }

        public ICollection<PhieuDanhGiaHLV> PhieuDanhGiaHLVs { get; set; }
    }
}