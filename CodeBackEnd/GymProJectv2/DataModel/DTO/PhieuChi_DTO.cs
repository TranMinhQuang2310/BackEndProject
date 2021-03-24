using System;
using System.Collections.Generic;
namespace GymProJectv2.DataModel.DTO
{
    public class PhieuChi_DTO
    {
        public int ID {get;set;}
        public string MaPhieuChi {get;set;}
        public string SoPhieuChi {get;set;}
        public DateTime NgayLapPhieu {get;set;}
        public string TenNVLapPhieu {get;set;}
        public string HinhThucChi {get;set;}
        public string MaNguoiNhan {get;set;}
        public string HoTenNguoiNhan {get;set;}
        public string LoaiPhieuChi {get;set;} 
        public bool DaDuyet {get;set;}
        public string TTLienLac {get;set;}
        public string LyDoChi {get;set;}
        public string TenKH {get;set;}
        public string TenNVBanHang {get;set;}
        public string TenNhanVienChiuTrachNhiem {get;set;}
        public string ChucVu {get;set;}
        public int? IDNhanVienLapPhieu {get;set;}
        public int? IDNhanVienBanHang {get;set;}
        public List<SanPham_DTO> DSSanPham {get;set;}
    }
}