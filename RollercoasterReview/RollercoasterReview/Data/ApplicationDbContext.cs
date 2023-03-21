using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RollercoasterReview.Models;

namespace RollercoasterReview.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<RollercoasterReview.Models.Park> Park { get; set; } = default!;
        public DbSet<RollercoasterReview.Models.Rollercoaster> Rollercoaster { get; set; } = default!;
        public DbSet<RollercoasterReview.Models.Review> Review { get; set; } = default!;
        public DbSet<RollercoasterReview.Models.Rating> Rating { get; set; } = default!;
    }
}