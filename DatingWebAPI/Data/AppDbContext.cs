using DatingWebAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatingWebAPI.Data
{
    public class AppDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<AppUser> Users { get; set; }
    }
}