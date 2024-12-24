using _8937_NguyenHuynhPhiVu.Models.Entities;
using Microsoft.EntityFrameworkCore;
using static NuGet.Packaging.PackagingConstants;

namespace _8937_NguyenHuynhPhiVu.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<NganhHoc> NganhHoc { get; set; }
        public DbSet<SinhVien> SinhVien { get; set; }
        public DbSet<HocPhan> HocPhan { get; set; }
        public DbSet<DangKy> DangKy { get; set; }
        public DbSet<ChiTietDangKy> ChiTietDangKy { get; set; }
    }
}
