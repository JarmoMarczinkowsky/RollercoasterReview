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

            modelBuilder.Entity<Park>().HasData(
                new Park { ParkId = 1, Name = "Efteling", City = "Kaatsheuvel", Country = "The Netherlands" },
                new Park { ParkId = 2, Name = "Bobbejaanland", City = "Kasterlee", Country = "Belgium" },
                new Park { ParkId = 3, Name = "Disney", City = "Paris", Country = "France" }
                );

            modelBuilder.Entity<Rollercoaster>().HasData(
                new Rollercoaster { RollercoasterId = 1, ParkId = 1, Name = "Python", Build = DateTime.Now, Description = "Epic rollercoaster", RollercoasterImage = "https://www.efteling.com/nl/-/media/images/nieuw-park/park/attractions/python/1024x576-python-loopings.jpg" },
                new Rollercoaster { RollercoasterId = 2, ParkId = 2, Name = "Typhoon", Build = DateTime.Now, Description = "Whirlwind", RollercoasterImage = "https://upload.wikimedia.org/wikipedia/commons/6/65/Typhoon.JPG" },
                new Rollercoaster { RollercoasterId = 3, ParkId = 3, Name = "Space Mountain", Build = DateTime.Now, Description = "To infinity and beyond", RollercoasterImage = "https://cdn1.parksmedia.wdprapps.disney.com/resize/mwImage/1/1600/900/75/dam/wdpro-assets/parks-and-tickets/attractions/magic-kingdom/space-mountain/space-mountain-00.jpg?1658978220420" }
                );

            modelBuilder.Entity<Review>().HasData(
                new Review { ReviewId = 1, RollercoasterId = 1, UserId = 1, Partner = "Henk Henkerson", ReviewDate = DateTime.Now.AddDays(Global.Random(0, 10)) },
                new Review { ReviewId = 2, RollercoasterId = 1, UserId = 1, Partner = "Jan Jansen", ReviewDate = DateTime.Now.AddDays(-1 * Global.Random(45, 200)) },
                new Review { ReviewId = 3, RollercoasterId = 1, UserId = 2, Partner = "John Johnson", ReviewDate = DateTime.Now.AddDays(Global.Random(19, 200)) },
                new Review { ReviewId = 4, RollercoasterId = 2, UserId = 1, Partner = "Piet Pieterson", ReviewDate = DateTime.Now.AddDays(-1) }
                );
        }

        
    }
}
