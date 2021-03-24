using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GymProJectv2.DataModel.Entity
{
    public class LapPhieuChi
    {
        [Key]
        public int ID { get; set; }
        public int IDPhieuChi { get; set; }
        [ForeignKey("IDPhieuChi")]
        public virtual PhieuChi PhieuChi { get; set; }
        public int IDSanPham { get; set; }
        [ForeignKey("IDSanPham")]
        public virtual SanPham SanPham { get; set; }

        public double DonGia { get; set; }
        public int SoLuong { get; set; }
    }
}