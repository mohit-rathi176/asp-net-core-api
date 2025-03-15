using Core.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.Repository.Context
{
    public class AppDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<League> Leagues { get; set; }
    }
}
