using Microsoft.EntityFrameworkCore;
using GymProJectv2.DataModel.Entity;
namespace GymProJectv2.DataModel
{
    public class GymDbContext : DbContext
    {
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-OCQB3QFO;Database=GymProJectv2;User Id=sa;Password=123456;Trusted_Connection=True;integrated security=false;trustServerCertificate=true;");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public DbSet<DichVu> DichVus {get;set;}
        public DbSet<HocVienDKLopHoc> HocVienDKLopHocs {get;set;}
        public DbSet<NhanVien> NhanViens {get; set;}
        public DbSet<PhieuDanhGiaHLV> PhieuDanhGiaHLVs {get; set;}
        public DbSet<LapPhieuChi> LapPhieuChis {get;set;}
        public DbSet<LapPhieuThu> LapPhieuThus {get;set;}
        public DbSet<HoaDon> HoaDons {get;set;}
        public DbSet<LopHoc> LopHocs {get;set;}
        public DbSet<GiaoAn> GiaoAns {get;set;}
        public DbSet<GiaoAnHLV> GiaoAnHLVs {get;set;}
        public DbSet<NhomHangHoa> NhomHangHoas {get;set;}
        public DbSet<SanPham> SanPhams {get;set;}
        public DbSet<HoaDonSanPham> HoaDonSanPhams {get;set;}
        public DbSet<KhachHang> KhachHangs {get;set;}
        public DbSet<PhieuThu> PhieuThus {get;set;}
        public DbSet<PhieuChi> PhieuChis {get;set;}
        public DbSet<TieuChiDanhGia> TieuChiDanhGias {get;set;}
        
    }
}