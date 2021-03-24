using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace GymProJectv2.DataModel.Entity
{
    public class SanPham
    {
        [Key]
        public int ID { get; set; }
        [StringLength(200)]
        public string TenSP { get; set; }
        [StringLength(50)]
        public string MaSP { get; set; }
        public int IDNhomHangHoa { get; set; }
        [ForeignKey("IDNhomHangHoa")]
        public NhomHangHoa  NhomHangHoa { get; set;}
        public double DonGia { get; set; }
        public DateTime NgayNhap { get; set; }
        public int SoLuong { get; set; }
        public string HinhAnh { get; set;}
        public string MoTa { get; set;}
        public bool DaDuyet { get; set;}
        public ICollection<HoaDonSanPham> HoaDonSanPhams { get; set; }
        public ICollection<LapPhieuChi> LapPhieuChis { get; set; }
        public ICollection<LapPhieuThu> LapPhieuThus { get; set; }
    }
}