using System;
using System.Collections.Generic;
namespace GymProJectv2.DataModel.DTO
{
    public class PhieuThu_DTO
    {
        public int ID {get;set;}
        public string MaPhieuThu {get;set;}
        public string SoPhieuThu {get;set;}
        public string LoaiThue {get;set;}
        public string LoaiPhieuThu {get;set;}
        public string LyDoNop {get;set;}
        public bool DaDuyet {get;set;}
        public DateTime NgayLapPhieu {get;set;}
        public int IDKhachHang {get;set;}
        public int? IDNhanVienLapPhieu {get;set;}
        public int? IDNhanVienBanHang {get;set;}
        public List<SanPham_DTO> DSSanPham {get;set;}
        
    }
}