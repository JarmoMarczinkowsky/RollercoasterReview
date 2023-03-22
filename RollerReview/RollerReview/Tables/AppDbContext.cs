using Microsoft.EntityFrameworkCore;
using RollerReview.MyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollerReview.Tables
{
    internal class AppDbContext : DbContext 
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleUser> RoleUsers { get; set; }
        public DbSet<Rollercoaster> Rollercoasters { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Park> Parks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySql(
                "server=localhost;database=RollerReview;user=root;password=;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<RoleUser>()
                .HasKey(ru => new { ru.UserId, ru.RoleId });

            modelBuilder.Entity<RoleUser>()
                .HasOne(ru => ru.User)
                .WithMany(u => u.RoleUsers)
                .HasForeignKey(ru => ru.UserId);

            modelBuilder.Entity<RoleUser>()
                .HasOne(ru => ru.Role)
                .WithMany(r => r.RoleUsers)
                .HasForeignKey(ru => ru.RoleId);

            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, RoleId = 1, Username = "admin", Password = Global.HashPassword("a"), Email = "admin@admin.com" },
                new User { UserId = 2, RoleId = 2, Username = "Jarmo", Password = Global.HashPassword("jarmo123"), Email = "jarmo@jarmo.com" }



                );

            modelBuilder.Entity<Role>().HasData(
                new Role { RoleId = 1, Name = "Admin" },
                new Role { RoleId = 2, Name = "User" }
                
                );
        }

        
    }
}
