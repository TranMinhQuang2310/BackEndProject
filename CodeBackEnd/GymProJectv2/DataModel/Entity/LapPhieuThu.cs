using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GymProJectv2.DataModel.Entity
{
    public class LapPhieuThu
    {
        [Key]
        public int ID { get; set; }
        public int IDPhieuThu { get; set; }
        [ForeignKey("IDPhieuThu")]
        public virtual PhieuThu PhieuThu { get; set; }
        public int IDKhachHang { get; set; }
        public int IDSanPham { get; set; }
        [ForeignKey("IDSanPham")]
        public virtual SanPham SanPham { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }


    }
}