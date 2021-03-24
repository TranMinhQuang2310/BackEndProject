using System;
namespace GymProJectv2.DataModel.DTO
{
    public class GiaoAn_DTO
    {
        public int ID {get;set;}
        public string MaGiaoAn {get;set;}
        public string TenGiaoAn {get;set;}
        public bool TrangThai {get;set;}
        public DateTime NgayLap {get;set;}
        public string GhiChu {get;set;}
        public string NhomGiaoAn {get;set;}
        public int SoLuongHocVien {get;set;}
        public int SoLuongTietHoc {get;set;}
    }
}