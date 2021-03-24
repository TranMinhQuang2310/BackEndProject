using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GymProJectv2.DataModel.Entity
{
    public class GiaoAnHLV
    {
        [Key]
        public int ID {get;set;}
        public int IDGiaoAn {get;set;}
        [ForeignKey("IDGiaoAn")]
        public GiaoAn GiaoAn {get;set;}
        public int IDHuanLuyenVien {get;set;}
        [ForeignKey("IDHuanLuyenVien")]
        public NhanVien NhanVien {get;set;}
    }
}