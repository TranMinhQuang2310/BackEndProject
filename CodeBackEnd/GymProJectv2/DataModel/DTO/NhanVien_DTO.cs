using System;
namespace GymProJectv2.DataModel.DTO
{
    public class NhanVien_DTO
    {
        public int ID { get; set; }
        public string MaNV { get; set; }
        public string HoVaTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string ChucVu { get; set; }
        public string GioiTinh { get; set; }       
        public string SoDienThoai { get; set; }
        public string CMND { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string ChuyenMon { get; set; }
        public string GhiChu { get; set; }    
    }
}