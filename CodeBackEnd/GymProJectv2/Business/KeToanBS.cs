using GymProJectv2.DataModel.DTO;
using GymProJectv2.DataModel.Entity;
using System.Linq;
using System.Collections.Generic;
using System;
namespace GymProJectv2.Business
{
    public class KeToanBS : BaseBusiness
    {
        public bool Lap_PhieuChi(PhieuChi_DTO phieuchi) {
            try
            {
                PhieuChi pc = new PhieuChi();
                pc.MaPhieuChi = phieuchi.MaPhieuChi;
                pc.SoPhieuChi = phieuchi.SoPhieuChi;
                pc.NgayLapPhieu = phieuchi.NgayLapPhieu;
                pc.TenNVLapPhieu = phieuchi.TenNVLapPhieu;
                pc.HinhThucChi = phieuchi.HinhThucChi;
                pc.MaNguoiNhan = phieuchi.MaNguoiNhan;
                pc.HoTenNguoiNhan = phieuchi.HoTenNguoiNhan;
                pc.LoaiPhieuChi = phieuchi.LoaiPhieuChi;
                pc.DaDuyet = phieuchi.DaDuyet;
                pc.TTLienLac = phieuchi.TTLienLac;
                pc.LyDoChi = phieuchi.LyDoChi;
                pc.TenKH = phieuchi.TenKH;
                pc.TenNVBanHang = phieuchi.TenNVBanHang;
                pc.TenNhanVienChiuTrachNhiem = phieuchi.TenNhanVienChiuTrachNhiem;
                pc.ChucVu = phieuchi.ChucVu;
                pc.IDNhanVienLapPhieu = phieuchi.IDNhanVienLapPhieu;
                pc.IDNhanVienBanHang = phieuchi.IDNhanVienBanHang;
                _models.PhieuChis.Add(pc);
                _models.SaveChanges();
                var idphieuchi = pc.ID;
                foreach (var item in phieuchi.DSSanPham)
                {
                    LapPhieuChi lpc = new LapPhieuChi();
                    lpc.IDSanPham = item.ID;
                    lpc.IDPhieuChi = idphieuchi;
                    lpc.DonGia = item.DonGia;
                    lpc.SoLuong = item.SoLuong;
                    _models.LapPhieuChis.Add(lpc);
                }
                _models.SaveChanges(); 
                return true;
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public List<PhieuChi_DTO> Lay_DSPhieuChi(){
            var lstPhieuChi = _models.PhieuChis.Select(s => new PhieuChi_DTO{
                ID = s.ID,
                MaPhieuChi = s.MaPhieuChi,
                SoPhieuChi = s.SoPhieuChi,
                NgayLapPhieu = s.NgayLapPhieu,
                TenNVLapPhieu = s.TenNVLapPhieu,
                HinhThucChi = s.HinhThucChi,
                MaNguoiNhan = s.MaNguoiNhan,
                HoTenNguoiNhan = s.HoTenNguoiNhan,
                LoaiPhieuChi = s.LoaiPhieuChi,
                DaDuyet = s.DaDuyet,
                TTLienLac = s.TTLienLac,
                LyDoChi = s.LyDoChi,
                TenKH = s.TenKH,
                TenNVBanHang = s.TenNVBanHang,
                TenNhanVienChiuTrachNhiem = s.TenNhanVienChiuTrachNhiem,
                ChucVu = s.ChucVu,
                IDNhanVienBanHang = s.IDNhanVienBanHang,
                IDNhanVienLapPhieu = s.IDNhanVienLapPhieu
            }).ToList();
            return lstPhieuChi;
        }

        public PhieuChi_DTO Lay_PhieuChi(int idphieuchi){
            var pc = _models.PhieuChis.Where(s => s.ID == idphieuchi).Select(s => new PhieuChi_DTO{
                ID = s.ID,
                MaPhieuChi = s.MaPhieuChi,
                SoPhieuChi = s.SoPhieuChi,
                NgayLapPhieu = s.NgayLapPhieu,
                TenNVLapPhieu = s.TenNVLapPhieu,
                HinhThucChi = s.HinhThucChi,
                MaNguoiNhan = s.MaNguoiNhan,
                HoTenNguoiNhan = s.HoTenNguoiNhan,
                LoaiPhieuChi = s.LoaiPhieuChi,
                DaDuyet = s.DaDuyet,
                TTLienLac = s.TTLienLac,
                LyDoChi = s.LyDoChi,
                TenKH = s.TenKH,
                TenNVBanHang = s.TenNVBanHang,
                TenNhanVienChiuTrachNhiem = s.TenNhanVienChiuTrachNhiem,
                ChucVu = s.ChucVu,
                IDNhanVienBanHang = s.IDNhanVienBanHang,
                IDNhanVienLapPhieu = s.IDNhanVienLapPhieu
            }).FirstOrDefault();
            if(pc != null){
                pc.DSSanPham = P_Lay_DSSanPhamTheoPhieuChi(idphieuchi);
                return pc;
            }else
                return null;
                
        }

        private List<SanPham_DTO> P_Lay_DSSanPhamTheoPhieuChi(int idphieuchi){
            var lstIDSanPham = _models.LapPhieuChis.Where(s => s.IDPhieuChi == idphieuchi).Select(s => s.IDSanPham).ToList();
            List<SanPham_DTO> lstSanPham = new List<SanPham_DTO>();
            foreach (var item in lstIDSanPham)
            {
                var sp = _models.SanPhams.Where(s => s.ID == item).Select(s => new SanPham_DTO{
                    ID = s.ID,
                    TenSP = s.TenSP,
                    MaSP = s.MaSP,
                    DonGia = s.DonGia,
                    NgayNhap = s.NgayNhap,
                    SoLuong = s.SoLuong,
                    MoTa = s.MoTa,
                    DaDuyet = s.DaDuyet,
                    HinhAnh = s.HinhAnh
                }).FirstOrDefault();
                if(sp != null)
                    lstSanPham.Add(sp);
            }
            return lstSanPham;
        }

        public bool Luu_PhieuChi (PhieuChi_DTO phieuchi) {
            try {
                var pc = _models.PhieuChis.Where(s => s.ID == phieuchi.ID).FirstOrDefault();
                pc.MaPhieuChi = phieuchi.MaPhieuChi;
                pc.SoPhieuChi = phieuchi.SoPhieuChi;
                pc.NgayLapPhieu = phieuchi.NgayLapPhieu;
                pc.TenNVLapPhieu = phieuchi.TenNVLapPhieu;
                pc.HinhThucChi = phieuchi.HinhThucChi;
                pc.MaNguoiNhan = phieuchi.MaNguoiNhan;
                pc.HoTenNguoiNhan = phieuchi.HoTenNguoiNhan;
                pc.LoaiPhieuChi = phieuchi.LoaiPhieuChi;
                pc.DaDuyet = phieuchi.DaDuyet;
                pc.TTLienLac = phieuchi.TTLienLac;
                pc.LyDoChi = phieuchi.LyDoChi;
                pc.TenKH = phieuchi.TenKH;
                pc.TenNVBanHang = phieuchi.TenNVBanHang;
                pc.TenNhanVienChiuTrachNhiem = phieuchi.TenNhanVienChiuTrachNhiem;
                pc.ChucVu = phieuchi.ChucVu;
                pc.IDNhanVienLapPhieu = phieuchi.IDNhanVienLapPhieu;
                pc.IDNhanVienBanHang = phieuchi.IDNhanVienBanHang;
                var idphieuchi = pc.ID;
                var lstLapPhieuChi = _models.LapPhieuChis.Where(s => s.IDPhieuChi == idphieuchi).ToList();
                foreach(var item in lstLapPhieuChi)
                {
                    if(!phieuchi.DSSanPham.Exists(s => s.ID == item.IDSanPham)){
                        _models.LapPhieuChis.Remove(item);
                    }
                }
                _models.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public bool Duyet_PhieuChi(int idphieuchi){
            try {
                var pc = _models.PhieuChis.FirstOrDefault(s => s.ID == idphieuchi);
                pc.DaDuyet = true;
                _models.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public bool Xoa_PhieuChi(int idphieuchi){
            try {
                var phieuchi = _models.PhieuChis.FirstOrDefault(s => s.ID == idphieuchi);
                _models.PhieuChis.Remove(phieuchi);
                _models.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        
        public bool Lap_PhieuThu(PhieuThu_DTO phieuthu){
            try
            {
                PhieuThu pt = new PhieuThu();
                pt.MaPhieuThu = phieuthu.MaPhieuThu;
                pt.SoPhieuThu = phieuthu.SoPhieuThu;
                pt.LoaiThue = phieuthu.LoaiThue;
                pt.LyDoNop = phieuthu.LyDoNop;
                pt.DaDuyet = phieuthu.DaDuyet;
                pt.NgayLapPhieu = phieuthu.NgayLapPhieu;
                pt.LoaiPhieuThu = phieuthu.LoaiPhieuThu;
                pt.IDKhachHang = phieuthu.IDKhachHang;
                pt.IDNhanVienBanHang = phieuthu.IDNhanVienBanHang;
                pt.IDNhanVienLapPhieu = phieuthu.IDNhanVienLapPhieu;
                _models.PhieuThus.Add(pt);
                _models.SaveChanges();
                var idphieuthu = pt.ID;               
                foreach (var item in phieuthu.DSSanPham)
                {
                    LapPhieuThu lpt = new LapPhieuThu();
                    lpt.IDSanPham = item.ID;
                    lpt.IDPhieuThu = idphieuthu;
                    lpt.DonGia = item.DonGia;
                    lpt.SoLuong = item.SoLuong;
                    _models.LapPhieuThus.Add(lpt);
                }
                _models.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
               throw;
            }
        }

        public List<PhieuThu_DTO> Lay_DSPhieuThu(){
            var lstPhieuThu = _models.PhieuThus.Select(s => new PhieuThu_DTO{
                ID = s.ID,
                MaPhieuThu = s.MaPhieuThu,
                SoPhieuThu = s.SoPhieuThu,
                LoaiThue = s.LoaiThue,
                LoaiPhieuThu = s.LoaiPhieuThu,
                LyDoNop = s.LyDoNop,
                NgayLapPhieu = s.NgayLapPhieu,
                DaDuyet = s.DaDuyet,
                IDKhachHang = s.IDKhachHang.Value,
                IDNhanVienBanHang = s.IDNhanVienBanHang,
                IDNhanVienLapPhieu = s.IDNhanVienLapPhieu
            }).ToList();
            return lstPhieuThu;
        }

        public PhieuThu_DTO Lay_PhieuThu(int id){
            var phieuthu = _models.PhieuThus.Where(s => s.ID == id).Select(s => new PhieuThu_DTO{
                ID = s.ID,
                MaPhieuThu = s.MaPhieuThu,
                SoPhieuThu = s.SoPhieuThu,
                LoaiThue = s.LoaiThue,
                LoaiPhieuThu = s.LoaiPhieuThu,
                LyDoNop = s.LyDoNop,
                NgayLapPhieu = s.NgayLapPhieu,
                DaDuyet = s.DaDuyet
            }).FirstOrDefault();
            phieuthu.DSSanPham = P_Lay_DSSanPhamTheoPhieuThu(id);
            return phieuthu;
        }

        public List<SanPham_DTO> P_Lay_DSSanPhamTheoPhieuThu(int idphieuthu){
            var lstIDSanPham = _models.LapPhieuThus.Where(s => s.IDPhieuThu == idphieuthu).Select(s => s.IDSanPham).ToList();
            List<SanPham_DTO> lstSanPham = new List<SanPham_DTO>();
            foreach(var item in lstIDSanPham){
                var sp = _models.SanPhams.Where(s => s.ID == item).Select(s => new SanPham_DTO{
                    ID = s.ID,
                    TenSP = s.TenSP,
                    MaSP = s.MaSP,
                    DonGia = s.DonGia,
                    NgayNhap = s.NgayNhap,
                    SoLuong = s.SoLuong,
                    MoTa = s.MoTa,
                    DaDuyet = s.DaDuyet,
                    HinhAnh = s.HinhAnh
                }).FirstOrDefault();
                if(sp != null)
                    lstSanPham.Add(sp);
            }
            return lstSanPham;
        }

        public bool Luu_PhieuThu(PhieuThu_DTO phieuthu){
            try {
                var pt = _models.PhieuThus.Where(s => s.ID == phieuthu.ID).FirstOrDefault();
                if(pt != null){
                    pt.MaPhieuThu = phieuthu.MaPhieuThu;
                    pt.SoPhieuThu = phieuthu.SoPhieuThu;
                    pt.LoaiThue = phieuthu.LoaiThue;
                    pt.LoaiPhieuThu = phieuthu.LoaiPhieuThu;
                    pt.LyDoNop = phieuthu.LyDoNop;
                    pt.NgayLapPhieu = phieuthu.NgayLapPhieu;
                    pt.DaDuyet = phieuthu.DaDuyet;
                    pt.IDKhachHang = phieuthu.IDKhachHang;
                    pt.IDNhanVienBanHang = phieuthu.IDNhanVienBanHang;
                    pt.IDNhanVienLapPhieu = phieuthu.IDNhanVienLapPhieu;

                    var idphieuthu = pt.ID;
                    var lstLapPhieuThu = _models.LapPhieuThus.Where(s => s.IDPhieuThu == idphieuthu).ToList();
                    foreach(var item in lstLapPhieuThu)
                    {
                        if(!phieuthu.DSSanPham.Exists(s => s.ID == item.IDSanPham)){
                            _models.LapPhieuThus.Remove(item);
                        }
                    }
                    _models.SaveChanges();
                    return true;
                }else
                return false;
            }
            catch(System.Exception)
            {
                return false;
            }
        }

        public bool Duyet_PhieuThu(int idphieuthu){
            try{
                var pt = _models.PhieuThus.Where(s => s.ID == idphieuthu).FirstOrDefault();
                pt.DaDuyet = true;
                _models.SaveChanges();
                return true;
            }
            catch(System.Exception)
            {
                return false;
            }
        }

        public bool Xoa_PhieuThu(int idphieuthu){
            try{
                var phieuthu = _models.PhieuThus.FirstOrDefault(s => s.ID == idphieuthu);
                _models.PhieuThus.Remove(phieuthu);
                _models.SaveChanges();
                return true;
            }
            catch(System.Exception)
            {
                throw;
            }
        }

        public bool Lap_HoaDon(HoaDon_DTO hoadon){
            try
            {
                HoaDon hd = new HoaDon();
                hd.MaHD = hoadon.MaHD;
                hd.MaChiNhanh = hoadon.MaChiNhanh;
                hd.MaSoThue = hoadon.MaSoThue;
                hd.TenDoanhNghiep = hoadon.TenDoanhNghiep;
                hd.DiaChiChiNhanh = hoadon.DiaChiChiNhanh;
                hd.SoThue = hoadon.SoThue;
                hd.HinhThucThanhToan = hoadon.HinhThucThanhToan;
                hd.DaDuyet = hoadon.DaDuyet;
                hd.NgayLapHD = hoadon.NgayLapHD;
                hd.TenNVBanHang = hoadon.TenNVBanHang;
                hd.TenNVLapPhieu = hoadon.TenNVLapPhieu;
                hd.ChucVu = hoadon.ChucVu;
                hd.MaKHLienQuan = hoadon.MaKHLienQuan;
                hd.MaNVBanHang = hoadon.MaNVBanHang;
                hd.MaNVLapPhieu = hoadon.MaNVLapPhieu;
                hd.IDNhanVien = hoadon.IDNhanVien;
                hd.IDKhachHang = hoadon.IDKhachHang;
                _models.HoaDons.Add(hd);
                _models.SaveChanges();
                var idhoadon = hd.ID;
                foreach (var item in hoadon.DSSanPham)
                {
                    HoaDonSanPham hdsp = new HoaDonSanPham();
                    hdsp.IDHoaDon = idhoadon;
                    hdsp.IDSanPham = item.ID;
                    hdsp.SoLuong = item.SoLuong;
                    hdsp.DonGia = item.DonGia;
                    _models.HoaDonSanPhams.Add(hdsp);
                }
                _models.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public List<HoaDon_DTO> Lay_DSHoaDon(){
            var lstHoaDon = _models.HoaDons.Select(s => new HoaDon_DTO{
                ID = s.ID,
                MaHD = s.MaHD,
                MaChiNhanh = s.MaChiNhanh,
                MaSoThue = s.MaSoThue,
                TenDoanhNghiep = s.TenDoanhNghiep,
                DiaChiChiNhanh = s.DiaChiChiNhanh,
                SoThue = s.SoThue,
                HinhThucThanhToan = s.HinhThucThanhToan,
                DaDuyet = s.DaDuyet,
                NgayLapHD = s.NgayLapHD,
                TenNVBanHang = s.TenNVBanHang,
                TenNVLapPhieu = s.TenNVLapPhieu,
                ChucVu = s.ChucVu,
                MaKHLienQuan = s.MaKHLienQuan,
                MaNVBanHang = s.MaNVBanHang,
                MaNVLapPhieu = s.MaNVLapPhieu,
                IDKhachHang = s.IDKhachHang,
                IDNhanVien = s.IDNhanVien
            }).ToList();
            return lstHoaDon;
        }

        public HoaDon_DTO Lay_HoaDon(int id){
            var hd = _models.HoaDons.Where(s => s.ID == id).Select(s => new HoaDon_DTO{
                ID = s.ID,
                MaHD = s.MaHD,
                MaChiNhanh = s.MaChiNhanh,
                MaSoThue = s.MaSoThue,
                TenDoanhNghiep = s.TenDoanhNghiep,
                DiaChiChiNhanh = s.DiaChiChiNhanh,
                SoThue = s.SoThue,
                HinhThucThanhToan = s.HinhThucThanhToan,
                DaDuyet = s.DaDuyet,
                NgayLapHD = s.NgayLapHD,
                TenNVBanHang = s.TenNVBanHang,
                TenNVLapPhieu = s.TenNVLapPhieu,
                ChucVu = s.ChucVu,
                MaKHLienQuan = s.MaKHLienQuan,
                MaNVBanHang = s.MaNVBanHang,
                MaNVLapPhieu = s.MaNVLapPhieu,
                IDKhachHang = s.IDKhachHang,
                IDNhanVien = s.IDNhanVien
            }).FirstOrDefault();
            hd.DSSanPham = P_Lay_DSSanPhamTheoHoaDon(hd.ID);
            return hd;
        }

         private List<SanPham_DTO> P_Lay_DSSanPhamTheoHoaDon(int idHoaDon){
            var lstIDSanPham = _models.HoaDonSanPhams.Where(s => s.IDHoaDon == idHoaDon).Select(s => s.IDSanPham).ToList();
            List<SanPham_DTO> lstSanPham = new List<SanPham_DTO>();
            foreach (var item in lstIDSanPham)
            {
                var sp = _models.SanPhams.Where(s => s.ID == item).Select(s => new SanPham_DTO{
                    ID = s.ID,
                    TenSP = s.TenSP,
                    MaSP = s.MaSP,
                    DonGia = s.DonGia,
                    NgayNhap = s.NgayNhap,
                    SoLuong = s.SoLuong,
                    MoTa = s.MoTa,
                    DaDuyet = s.DaDuyet,
                    HinhAnh = s.HinhAnh
                }).FirstOrDefault();
                if(sp != null)
                    lstSanPham.Add(sp);
            }
            return lstSanPham;
        }

        public bool Luu_HoaDon(HoaDon_DTO hoadon){
            try
            {
                var hd = _models.HoaDons.Where(s => s.ID == hoadon.ID).FirstOrDefault();
                hd.MaHD = hoadon.MaHD;
                hd.MaChiNhanh = hoadon.MaChiNhanh;
                hd.MaSoThue = hoadon.MaSoThue;
                hd.TenDoanhNghiep = hoadon.TenDoanhNghiep;
                hd.DiaChiChiNhanh = hoadon.DiaChiChiNhanh;
                hd.SoThue = hoadon.SoThue;
                hd.HinhThucThanhToan = hoadon.HinhThucThanhToan;
                hd.DaDuyet = hoadon.DaDuyet;
                hd.NgayLapHD = hoadon.NgayLapHD;
                hd.TenNVBanHang = hoadon.TenNVBanHang;
                hd.TenNVLapPhieu = hoadon.TenNVLapPhieu;
                hd.ChucVu = hoadon.ChucVu;
                hd.MaKHLienQuan = hoadon.MaKHLienQuan;
                hd.MaNVBanHang = hoadon.MaNVBanHang;
                hd.MaNVLapPhieu = hoadon.MaNVLapPhieu;
                hd.IDNhanVien = hoadon.IDNhanVien;
                hd.IDKhachHang = hoadon.IDKhachHang;
                var idhoadon = hd.ID;
                var lsthdsp = _models.HoaDonSanPhams.Where(s => s.IDHoaDon == idhoadon).ToList();
                foreach (var item in lsthdsp)
                {
                    if(!hoadon.DSSanPham.Exists(s => s.ID == item.IDSanPham)){
                        _models.HoaDonSanPhams.Remove(item);
                    }
                }
                _models.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public bool Duyet_HoaDon(int idhoadon){
            try{
                var hd = _models.HoaDons.Where(s => s.ID == idhoadon).FirstOrDefault();
                hd.DaDuyet = true;
                _models.SaveChanges();
                return true;
            }
            catch(System.Exception)
            {
                throw;
            }
        }

        public bool Xoa_HoaDon(int idHoaDon){
            try
            {
                var lstHoaDonSanPham = _models.HoaDonSanPhams.Where(s => s.IDHoaDon == idHoaDon).ToList();
                if(lstHoaDonSanPham != null)
                    foreach (var item in lstHoaDonSanPham)
                        _models.HoaDonSanPhams.Remove(item);
                var hoadon = _models.HoaDons.Where(s => s.ID == idHoaDon).FirstOrDefault();
                if(hoadon != null)
                    _models.HoaDons.Remove(hoadon);
                _models.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public List<SanPham_DTO> Lay_DSSanPham(){
            var lstSP = _models.SanPhams.Select(s => new SanPham_DTO{
                ID = s.ID,
                TenSP = s.TenSP,
                MaSP = s.MaSP,
                DonGia = s.DonGia,
                NgayNhap = s.NgayNhap,
                SoLuong = s.SoLuong,
                MoTa = s.MoTa,
                DaDuyet = s.DaDuyet,
                HinhAnh = s.HinhAnh
            }).ToList();
            return lstSP;
        }    


        
    }
}