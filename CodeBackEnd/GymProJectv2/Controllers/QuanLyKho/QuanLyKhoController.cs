using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using GymProJectv2.Business;
using GymProJectv2.DataModel.DTO;
namespace GymProJectv2.Controllers.QuanLyKho
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QuanLyKhoController : ControllerBase
    {
       
        [HttpPost]
        public IActionResult ThemMoiDichVu(dynamic request){
            DichVu_DTO dichvu = JsonConvert.DeserializeObject<DichVu_DTO>(request.ToString());
            using(QuanLyKhoBS ql = new QuanLyKhoBS()){
                var result = ql.ThemMoiDichVu(dichvu);
                return Ok(result);
            }
        }
        [HttpGet]
        public IActionResult LayDSDichVu() {
            using(QuanLyKhoBS ql = new QuanLyKhoBS()){ 
                var result = ql.LayDSDichVu();
                return Ok(result);
            }
        }
        [HttpPost]
        public IActionResult SuaDichVu(dynamic request){
            DichVu_DTO dichvu = JsonConvert.DeserializeObject<DichVu_DTO>(request.ToString());
            using(QuanLyKhoBS ql = new QuanLyKhoBS()){
                var result = ql.SuaDichVu(dichvu);
                return Ok(result);
            }
        }
         [HttpPost]
        public IActionResult Xoa_DichVu(dynamic request){
            var dichvu = JsonConvert.DeserializeObject<DichVu_DTO>(request.ToString());
            using(QuanLyKhoBS ql = new QuanLyKhoBS()){
                var result = ql.XoaDichVu(dichvu.ID);
                return Ok(result);
            }
        }
        [HttpPost]
        public IActionResult LayDichVu(dynamic request){
            var idDichVu = JsonConvert.DeserializeObject<DichVu_DTO>(request.ToString());
            using(QuanLyKhoBS ql = new QuanLyKhoBS()){
                return Ok(ql.LayDichVu(idDichVu.ID));
            }
           
        }

        [HttpPost]
        public IActionResult ThemMoiHangHoa(dynamic request){
            SanPham_DTO sanpham = JsonConvert.DeserializeObject<SanPham_DTO>(request.ToString());
            using(QuanLyKhoBS ql = new QuanLyKhoBS()){
                var result = ql.ThemMoiHangHoa(sanpham);
                if(result)
                    return Ok(result);
                else
                    return BadRequest(result);
            }
        }
        [HttpGet]
        public IActionResult LayDSHangHoa(){
            using(QuanLyKhoBS ql = new QuanLyKhoBS()){
                var result = ql.LayDSHangHoa();
                return Ok(result);
            }
        }
        [HttpPost]
        public IActionResult SuaHangHoa(dynamic request){
            SanPham_DTO sanpham = JsonConvert.DeserializeObject<SanPham_DTO>(request.ToString());
            using(QuanLyKhoBS ql = new QuanLyKhoBS()){
                var result = ql.SuaHangHoa(sanpham);
                return Ok(result);
            }
        }
        [HttpPost]
        public IActionResult XoaHangHoa(dynamic request){
            var sanpham = JsonConvert.DeserializeObject<SanPham_DTO>(request.ToString());
            using(QuanLyKhoBS ql = new QuanLyKhoBS()){
                var result = ql.XoaHangHoa(sanpham.ID);
                return Ok(result);
            }
        }
        [HttpPost]
        public IActionResult LayHangHoa(dynamic request){
            var idHangHoa = JsonConvert.DeserializeObject<SanPham_DTO>(request.ToString());
            using(QuanLyKhoBS ql = new QuanLyKhoBS()){
                return Ok(ql.LayHangHoa(idHangHoa.ID));
            }
        }
        [HttpPost]
        public IActionResult ThemMoiNhomHangHoa(dynamic request){
            var nhomHangHoa = JsonConvert.DeserializeObject<NhomHangHoa_DTO>(request.ToString());
            using(QuanLyKhoBS ql = new QuanLyKhoBS()){
                var result = ql.ThemMoiNhomHangHoa(nhomHangHoa);
                return Ok(result);
            }
        }
        [HttpGet]
        public IActionResult LayDSNhomHangHoa(){
            using(QuanLyKhoBS ql = new QuanLyKhoBS()){
                var result = ql.LayDSNhomHangHoa();
                return Ok(result);
            }
        }
        [HttpPost]
       public IActionResult XoaNhomHangHoa(dynamic request){
            var nhh = JsonConvert.DeserializeObject<NhomHangHoa_DTO>(request.ToString());
            using(QuanLyKhoBS ql = new QuanLyKhoBS()){
                var result = ql.XoaNhomHangHoa(nhh.ID);
                return Ok(result);
            }
        }
            [HttpPost]
        public IActionResult XuatHangHoa(dynamic request){
            var xuatHangHoa = JsonConvert.DeserializeObject<XuatHangHoa_DTO>(request.ToString());
            using(QuanLyKhoBS ql = new QuanLyKhoBS()){
                var result = ql.XuatHangHoa(xuatHangHoa.ID,xuatHangHoa.SoLuong);
                if(result.Equals("ok"))
                    return Ok(result);
                else
                    return BadRequest(result);
            }
        }
        
    }
}