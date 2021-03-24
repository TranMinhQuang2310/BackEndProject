using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace GymProJectv2.DataModel.Entity
{
    public class NhomHangHoa
    {
        [Key]
        public int ID { get; set; }
        public string TenNhomHangHoa { get; set; }
        public string MaNhomHangHoa { get; set; }

        public ICollection<SanPham> SanPhams { get; set; }
    }
}