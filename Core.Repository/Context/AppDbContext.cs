using Core.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.Repository.Context
{
    public class AppDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<League> Leagues { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<League>()
                .HasMany(l => l.Teams)
                .WithOne(t => t.League)
                .HasForeignKey(t => t.LeagueId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<League>()
                .Property(l => l.Name)
                .HasMaxLength(255)
                .IsRequired();

            modelBuilder.Entity<Team>()
                .Property(t => t.Name)
                .HasMaxLength(255)
                .IsRequired();
        }
    }
}
