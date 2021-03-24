using System.Linq;
using System.Collections.Generic;
using GymProJectv2.DataModel.DTO;
using GymProJectv2.DataModel.Entity;
namespace GymProJectv2.Business
{
    public class GiaoVuBS :BaseBusiness 
    {
        public bool Lap_GiaoAn(GiaoAn_DTO giaoan){
            try{
                GiaoAn ga = new GiaoAn();
                ga.MaGiaoAn = giaoan.MaGiaoAn;
                ga.TenGiaoAn = giaoan.TenGiaoAn;
                ga.TrangThai = giaoan.TrangThai;
                ga.NgayLap = giaoan.NgayLap;
                ga.GhiChu = giaoan.GhiChu;
                ga.NhomGiaoAn = giaoan.NhomGiaoAn;
                ga.SoLuongTietHoc = giaoan.SoLuongTietHoc;
                ga.SoLuongHocVien = giaoan.SoLuongHocVien;
                _models.GiaoAns.Add(ga);
                _models.SaveChanges();
                return true;
            }
            catch(System.Exception)
            {
                throw;
            }
        }

        public List<GiaoAn_DTO> Lay_DSGiaoAn(){
            try{
                var lstGiaoAn = _models.GiaoAns.Select(s => new GiaoAn_DTO{
                    ID = s.ID,
                    MaGiaoAn = s.MaGiaoAn,
                    TenGiaoAn = s.TenGiaoAn,
                    TrangThai = s.TrangThai,
                    NgayLap = s.NgayLap,
                    GhiChu = s.GhiChu,
                    NhomGiaoAn = s.NhomGiaoAn,
                    SoLuongHocVien = s.SoLuongHocVien,
                    SoLuongTietHoc = s.SoLuongTietHoc
                }).ToList();
                return lstGiaoAn;
            }
            catch(System.Exception)
            {
                throw;
            }
        }

        public GiaoAn_DTO Lay_GiaoAn(int idgiaoan){
            try{
                var ga = _models.GiaoAns.Where(s => s.ID == idgiaoan).Select(s => new GiaoAn_DTO{
                    ID = s.ID,
                    MaGiaoAn = s.MaGiaoAn,
                    TenGiaoAn = s.TenGiaoAn,
                    TrangThai = s.TrangThai,
                    NgayLap = s.NgayLap,
                    GhiChu = s.GhiChu,
                    NhomGiaoAn = s.NhomGiaoAn,
                    SoLuongHocVien = s.SoLuongHocVien,
                    SoLuongTietHoc = s.SoLuongTietHoc
                }).FirstOrDefault();
                return ga;
            }
            catch(System.Exception){
                throw;
            }
        }

        public bool Luu_GiaoAn(GiaoAn_DTO giaoan){
            try{
                var ga = _models.GiaoAns.Where(s => s.ID == giaoan.ID).FirstOrDefault();
                ga.MaGiaoAn = giaoan.MaGiaoAn;
                ga.TenGiaoAn = giaoan.TenGiaoAn;
                ga.TrangThai = giaoan.TrangThai;
                ga.GhiChu = giaoan.GhiChu;
                ga.NhomGiaoAn = giaoan.NhomGiaoAn;
                ga.SoLuongTietHoc = giaoan.SoLuongTietHoc;
                ga.SoLuongHocVien = giaoan.SoLuongHocVien;
                _models.SaveChanges();
                return true;
            }
            catch(System.Exception){
                throw;
            }
        }

        public bool Xoa_GiaoAn(int idgiaoan){
            try{
                var ga = _models.GiaoAns.Where(s => s.ID == idgiaoan).FirstOrDefault();
                _models.GiaoAns.Remove(ga);
                _models.SaveChanges();
                return true;
            }
            catch(System.Exception){
                throw;
            }
        }

        public bool PhanCong_GiaoAnHLV(GiaoAnHLV_DTO giaoanhlv){
            try{
                GiaoAnHLV phancong = new GiaoAnHLV();
                phancong.IDGiaoAn = giaoanhlv.IDGiaoAn;
                phancong.IDHuanLuyenVien = giaoanhlv.IDHuanLuyenVien;
                _models.GiaoAnHLVs.Add(phancong);
                _models.SaveChanges();
                return true;
            }
            catch(System.Exception){
                throw;
            }
        }
        
    }
}