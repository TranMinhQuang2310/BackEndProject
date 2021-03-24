using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
namespace GymProJectv2.DataModel.Entity
{
    public class GiaoAn
    {
        public int ID { get; set; }
        [StringLength(50)]
        public string MaGiaoAn { get; set; }
        [StringLength(100)]
        public string TenGiaoAn { get; set; }
        public bool TrangThai { get; set; }
        public DateTime NgayLap { get; set; }
        [StringLength(1000)]
        public string GhiChu { get; set; }
        public int SoLuongTietHoc{get;set;}
        [StringLength(50)]
        public string NhomGiaoAn { get; set; }
        public int SoLuongHocVien {get;set;}

        public ICollection<LopHoc> LopHocs {get;set;}
        public ICollection<GiaoAnHLV> GiaoAnHLVs {get;set;}
    }
}