using System;
namespace GymProJectv2.DataModel.DTO
{
    public class KhachHang_DTO
    {
         public int ID { get; set; }
        public int MaKH { get; set; }
        public string HoVaTen { get; set; }
        public string LoaiKH { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public string GhiChu { get; set; }
        public string SoTKNganHang { get; set; }
        public string TenNganHang { get; set; }
        public bool TrangThai { get; set; } 
    }
}