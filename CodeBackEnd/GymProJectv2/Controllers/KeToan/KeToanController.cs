using Microsoft.AspNetCore.Mvc;
using GymProJectv2.DataModel.DTO;
using GymProJectv2.Business;
using Newtonsoft.Json;
namespace GymProJectv2.Controllers.KeToan
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class KeToanController : ControllerBase
    {
        [HttpPost]
       public IActionResult Lap_PhieuChi(dynamic request){
            var phieuchi = JsonConvert.DeserializeObject<PhieuChi_DTO>(request.ToString());
            using(KeToanBS kt = new KeToanBS()){
                var result = kt.Lap_PhieuChi(phieuchi);
                return Ok(result);
            }
        }

        [HttpGet]
        public IActionResult Lay_DSPhieuChi(){
            using(KeToanBS kt = new KeToanBS()){
                var result = Ok(kt.Lay_DSPhieuChi());
                return result;
            }
        }
        [HttpPost]
        public IActionResult Lay_PhieuChi(dynamic request){
            var idphieuchi = JsonConvert.DeserializeObject<PhieuChi_DTO>(request.ToString());
            using(KeToanBS kt = new KeToanBS()){
                return Ok(kt.Lay_PhieuChi(idphieuchi.ID));
            }
        }
        [HttpPost]
        public IActionResult Luu_PhieuChi(dynamic request){
            var phieuchi = JsonConvert.DeserializeObject<PhieuChi_DTO>(request.ToString());
            using(KeToanBS kt = new KeToanBS()) {
                var result = kt.Luu_PhieuChi(phieuchi);
                return Ok(result);
            }

        }
        [HttpPost]
        public IActionResult Duyet_PhieuChi(dynamic request){
            var idphieuchi = JsonConvert.DeserializeObject<PhieuChi_DTO>(request.ToString());
            using(KeToanBS kt = new KeToanBS()) {
                var result = kt.Duyet_PhieuChi(idphieuchi.ID);
                return Ok(result);
            }
        }
        [HttpPost]
        public IActionResult Xoa_PhieuChi(dynamic request){
            var idphieuchi = JsonConvert.DeserializeObject<PhieuChi_DTO>(request.ToString());
            using(KeToanBS kt = new KeToanBS()){
                var result = kt.Xoa_PhieuChi(idphieuchi.ID);
                return Ok(result);
            }
        }

        [HttpPost]
        public IActionResult Lap_PhieuThu(dynamic request){
            var phieuthu = JsonConvert.DeserializeObject<PhieuThu_DTO>(request.ToString());
            using(KeToanBS kt = new KeToanBS()){
                var result = kt.Lap_PhieuThu(phieuthu);
                return Ok(result);
            }
        }
        [HttpGet]
        public IActionResult Lay_DSPhieuThu(){
            using(KeToanBS kt = new KeToanBS()){
                return Ok(kt.Lay_DSPhieuThu());
            }
        }
        [HttpPost]
        public IActionResult Lay_PhieuThu(dynamic request){
            var idphieuthu = JsonConvert.DeserializeObject<PhieuThu_DTO>(request.ToString());
            using(KeToanBS kt = new KeToanBS()){
                return Ok(kt.Lay_PhieuThu(idphieuthu.ID));
            }
        }
        [HttpPost]
        public IActionResult Luu_PhieuThu(dynamic request){
            PhieuThu_DTO phieuthu = JsonConvert.DeserializeObject<PhieuThu_DTO>(request.ToString());
            using(KeToanBS kt = new KeToanBS()){
                var result = kt.Luu_PhieuThu(phieuthu);
                return Ok(result);
            }
        }

        [HttpPost]
        public IActionResult Duyet_PhieuThu(dynamic request){
            var idphieuthu = JsonConvert.DeserializeObject<PhieuThu_DTO>(request.ToString());
            using(KeToanBS kt = new KeToanBS()){
                var result = kt.Duyet_PhieuThu(idphieuthu.ID);
                return Ok(result);
            }
        }
        [HttpPost]
        public IActionResult Xoa_PhieuThu(dynamic request){
            var idphieuthu = JsonConvert.DeserializeObject<PhieuThu_DTO>(request.ToString());
            using(KeToanBS kt = new KeToanBS()){
                var result = kt.Xoa_PhieuThu(idphieuthu.ID);
                return Ok(result);
            }
        }
        [HttpPost]
        public IActionResult Lap_HoaDon(dynamic request){
            var hoadon = JsonConvert.DeserializeObject<HoaDon_DTO>(request.ToString());
            using(KeToanBS kt = new KeToanBS()){
                var result = kt.Lap_HoaDon(hoadon);
                return Ok(result);
            }
        }
        [HttpGet]
        public IActionResult Lay_DSHoaDon(){
            using(KeToanBS kt = new KeToanBS()){
                return Ok(kt.Lay_DSHoaDon());
            }
        }
        [HttpPost]
        public IActionResult Lay_HoaDon(dynamic request){
            var idhoadon = JsonConvert.DeserializeObject<HoaDon_DTO>(request.ToString());
            using(KeToanBS kt = new KeToanBS()){
                var result = kt.Lay_HoaDon(idhoadon.ID);
                return Ok(result);
            }
        }
        [HttpPost]
        public IActionResult Luu_HoaDon(dynamic request){
            var hoadon = JsonConvert.DeserializeObject<HoaDon_DTO>(request.ToString());
            using(KeToanBS kt = new KeToanBS()){
                var result = kt.Luu_HoaDon(hoadon);
                return Ok(result);
            }
        }
        [HttpPost]
        public IActionResult Duyet_HoaDon(dynamic request){
            var idhoadon = JsonConvert.DeserializeObject<HoaDon_DTO>(request.ToString());
            using(KeToanBS kt = new KeToanBS()){
                var result = kt.Duyet_HoaDon(idhoadon.ID);
                return Ok(result);
            }
        }
        [HttpPost]
        public IActionResult Xoa_HoaDon(dynamic request){
            var idhoadon = JsonConvert.DeserializeObject<HoaDon_DTO>(request.ToString());
            using(KeToanBS kt = new KeToanBS()){
                var result = kt.Xoa_HoaDon(idhoadon.ID);
                return Ok(result);
            }
        }
        [HttpGet]
        public IActionResult Lay_DSSanPham(){
            using(KeToanBS kt = new KeToanBS()){
                var result = kt.Lay_DSSanPham();
                return Ok(result);
            }
        }


        
    }
}