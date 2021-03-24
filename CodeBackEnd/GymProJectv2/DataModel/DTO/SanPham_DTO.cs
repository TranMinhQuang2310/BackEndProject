using System;
namespace GymProJectv2.DataModel.DTO
{
    public class SanPham_DTO
    {
        public int ID { get; set; }
        public string TenSP { get; set; }
        public string MaSP { get; set; }
        public double DonGia { get; set; }
        public DateTime NgayNhap { get; set; }
        public int SoLuong { get; set; }
        public string MoTa { get; set; }
        public bool DaDuyet { get; set; }
        public string HinhAnh { get; set; }
        public string TenNhomHangHoa { get; set; }
        public int IDNhomHangHoa { get; set; }
        
    }
}