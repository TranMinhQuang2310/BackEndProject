using System;
using System.Collections.Generic;
using GymProJectv2.DataModel.DTO;
using GymProJectv2.DataModel.Entity;
using System.Linq;

namespace GymProJectv2.Business
{
    public class QuanLyKhoBS : BaseBusiness
    {
        public SanPham_DTO LayHangHoa(int idHangHoa){
            var sp = _models.SanPhams.Where(s => s.ID == idHangHoa).Select(s => new SanPham_DTO{
                ID = s.ID,
                TenSP = s.TenSP,
                MaSP = s.MaSP,
                DonGia = s.DonGia,
                NgayNhap = s.NgayNhap,
                SoLuong = s.SoLuong,
                MoTa = s.MoTa,
                HinhAnh = s.HinhAnh,
                IDNhomHangHoa = s.IDNhomHangHoa,
                DaDuyet = s.DaDuyet
            }).FirstOrDefault();
            sp.TenNhomHangHoa = P_TenNhomHangHoa(sp.IDNhomHangHoa);
            return sp;
        }
        public List<SanPham_DTO> LayDSHangHoa()
        {
            var lstSanPham = _models.SanPhams.Select(s => new SanPham_DTO()
            {
                ID = s.ID,
                TenSP = s.TenSP,
                MaSP = s.MaSP,
                DonGia = s.DonGia,
                NgayNhap = s.NgayNhap,
                SoLuong = s.SoLuong,
                MoTa = s.MoTa,
                HinhAnh = s.HinhAnh,
                IDNhomHangHoa = s.IDNhomHangHoa,
                DaDuyet = s.DaDuyet
            }).ToList();
            foreach (var item in lstSanPham)
            {
                item.TenNhomHangHoa = P_TenNhomHangHoa(item.IDNhomHangHoa);
            }
            return lstSanPham;
        }
        public bool ThemMoiHangHoa(SanPham_DTO sanpham)
        {

            try
            {
                SanPham sp = new SanPham();
                sp.MaSP = sanpham.MaSP;
                sp.TenSP = sanpham.TenSP;
                sp.DonGia = sanpham.DonGia;
                sp.NgayNhap = sanpham.NgayNhap;
                sp.SoLuong = sanpham.SoLuong;
                sp.MoTa = sanpham.MoTa;
                sp.HinhAnh = sanpham.HinhAnh;
                sp.IDNhomHangHoa = sanpham.IDNhomHangHoa;
                sp.DaDuyet = false;
                _models.SanPhams.Add(sp);
                _models.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public bool SuaHangHoa(SanPham_DTO sanpham)
        {
            try
            {
                var sp = _models.SanPhams.Where(s => s.ID == sanpham.ID).FirstOrDefault();
                if (sp != null)
                {
                    sp.MaSP = sanpham.MaSP;
                    sp.TenSP = sanpham.TenSP;
                    sp.DonGia = sanpham.DonGia;
                    sp.NgayNhap = sanpham.NgayNhap;
                    sp.SoLuong = sanpham.SoLuong;
                    sp.MoTa = sanpham.MoTa;
                    sp.HinhAnh = sanpham.HinhAnh;
                    sp.IDNhomHangHoa = sanpham.IDNhomHangHoa;
                    sp.DaDuyet = sanpham.DaDuyet;
                    _models.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            catch (System.Exception)
            {

                throw;
            }

        }
        public bool XoaHangHoa(int idSanPham)
        {
            try
            {
                var sanpham = _models.SanPhams.Where(s => s.ID == idSanPham).FirstOrDefault();
                if(sanpham != null){
                    _models.SanPhams.Remove(sanpham);
                    _models.SaveChanges();
                    return true;
                }else
                    return false;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public bool ThemMoiDichVu(DichVu_DTO dichvu)
        {
            try
            {
                DichVu dv = new DichVu();
                dv.ID = dichvu.ID;
                dv.TenDV = dichvu.TenDV;
                dv.DonGia = dichvu.DonGia;
                dv.GhiChu = dichvu.GhiChu;
                _models.DichVus.Add(dv);
                _models.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {

                throw;
            }

        }
        public List<DichVu_DTO> LayDSDichVu()
        {
            var result = _models.DichVus.Select(s => new DichVu_DTO()
            {
                ID = s.ID,
                TenDV = s.TenDV,
                DonGia = s.DonGia,
                GhiChu = s.GhiChu
            }).ToList();
            return result;
        }
        public DichVu_DTO LayDichVu(int iddichvu){
            try
            {
                var dv = _models.DichVus.Where(s => s.ID == iddichvu).Select(s => new DichVu_DTO{
                ID = s.ID,
                TenDV = s.TenDV,
                DonGia = s.DonGia,
                GhiChu = s.GhiChu
                }).FirstOrDefault();
                return dv;
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
        public bool SuaDichVu(DichVu_DTO dichvu)
        {
            try
            {
                var dv = _models.DichVus.Where(s => s.ID == dichvu.ID).FirstOrDefault();
                if (dv != null)
                {
                    dv.TenDV = dichvu.TenDV;
                    dv.DonGia = dichvu.DonGia;
                    dv.GhiChu = dichvu.GhiChu;
                    _models.SaveChanges();
                    return true;
                }
                else
                    return false;

            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public bool XoaDichVu(int idDichVu)
        {
            try
            {
                var dichvu = _models.DichVus.Where(s => s.ID == idDichVu).FirstOrDefault();
                if(dichvu != null){
                    _models.DichVus.Remove(dichvu);
                    _models.SaveChanges();
                    return true;
                }else
                    return false;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        
        public List<NhomHangHoa_DTO> LayDSNhomHangHoa()
        {
            var result = _models.NhomHangHoas.Select(s => new NhomHangHoa_DTO()
            {
                ID = s.ID,
                TenNhomHangHoa = s.TenNhomHangHoa,
                MaNhomHangHoa = s.MaNhomHangHoa
            }).ToList();
            return result;
        }
        public bool ThemMoiNhomHangHoa(NhomHangHoa_DTO nhomHangHoa){
            try
            {
                NhomHangHoa nhh = new NhomHangHoa();
                nhh.TenNhomHangHoa = nhomHangHoa.TenNhomHangHoa;
                nhh.MaNhomHangHoa = nhomHangHoa.MaNhomHangHoa;
                _models.NhomHangHoas.Add(nhh);
                _models.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public bool XoaNhomHangHoa(int idNhomHangHoa){
            try
            {
                var nhh = _models.NhomHangHoas.Where(s => s.ID == idNhomHangHoa).FirstOrDefault();
                if(nhh != null){
                    _models.NhomHangHoas.Remove(nhh);
                    _models.SaveChanges();
                    return true;
                }else
                    return false;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public string XuatHangHoa(int idHangHoa, int soLuong){
            try
            {
                var sp = _models.SanPhams.Where(s => s.ID == idHangHoa).FirstOrDefault();
                if(sp != null){
                    if(sp.SoLuong < soLuong)
                        return "Error: So luong xuat lon hon so lượng tồn kho";
                    else{
                        sp.SoLuong = sp.SoLuong - soLuong;
                        _models.SaveChanges();
                        return "ok";
                    }
                }else
                    return "Khong tim thay san pham";
            }
            catch (System.Exception)
            {
                return "Loi truy xuat database";
            }
        }

        private string P_TenNhomHangHoa(int idNhomHangHoa){
            return _models.NhomHangHoas.Where(s => s.ID == idNhomHangHoa).Select(s => s.TenNhomHangHoa).FirstOrDefault();
        }
    }
}