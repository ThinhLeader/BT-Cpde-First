using Microsoft.EntityFrameworkCore;
using LVT_2415053122340.Models; // Gọi đến thư mục Models của bạn

namespace LVT_2415053122340.Data
{
    // Kế thừa từ DbContext của Entity Framework
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Khai báo bảng Products sẽ được tạo trong Database
        public DbSet<Product> Products { get; set; }
    }
}