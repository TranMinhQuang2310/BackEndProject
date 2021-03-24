using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using GymProJectv2.DataModel.DTO;
using GymProJectv2.Business;
namespace GymProJectv2.Controllers.GiaoVu
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GiaoVuController : ControllerBase
    {
        [HttpPost]
        public IActionResult Lap_GiaoAn(dynamic request){
            GiaoAn_DTO giaoan = JsonConvert.DeserializeObject<GiaoAn_DTO>(request.ToString());
            using(GiaoVuBS gv = new GiaoVuBS()){
                var result = gv.Lap_GiaoAn(giaoan);
                return Ok(result);
            }
        }
        [HttpGet]
        public IActionResult Lay_DSGiaoAn(){
            using(GiaoVuBS gv = new GiaoVuBS()){
                var result = gv.Lay_DSGiaoAn();
                return Ok(result);
            }
        }
        [HttpPost]
        public IActionResult Lay_GiaoAn(dynamic request){
            var giaoan = JsonConvert.DeserializeObject<GiaoAn_DTO>(request.ToString());
            using(GiaoVuBS gv = new GiaoVuBS()){
                var result = gv.Lay_GiaoAn(giaoan.ID);
                return Ok(result);
            }
        }
        [HttpPost]
        public IActionResult Luu_GiaoAn(dynamic request)
        {
            var giaoan = JsonConvert.DeserializeObject<GiaoAn_DTO>(request.ToString());
            using(GiaoVuBS gv = new GiaoVuBS()){
                var result = gv.Luu_GiaoAn(giaoan);
                return Ok(result);
            }
        }
        [HttpPost]
        public IActionResult Xoa_GiaoAn(dynamic request){
            var giaoan = JsonConvert.DeserializeObject<GiaoAn_DTO>(request.ToString());
            using(GiaoVuBS gv = new GiaoVuBS()){
                var result = gv.Xoa_GiaoAn(giaoan.ID);
                return Ok(result);
            }
        }
        [HttpPost]
        public IActionResult PhanCong_GiaoAnHLV(dynamic request){
            var giaoanhlv = JsonConvert.DeserializeObject<GiaoAnHLV_DTO>(request.ToString());
            using(GiaoVuBS gv = new GiaoVuBS()){
                var result = gv.PhanCong_GiaoAnHLV(giaoanhlv);
                return Ok(result);
            }
        }
        
    }
}